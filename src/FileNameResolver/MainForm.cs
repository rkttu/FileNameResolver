/*
Rename icon by Icons8 (https://icons8.com/icon/oJQSZNne5Rp0/rename)
*/

using FileNameResolver.Models;
using FileNameResolver.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FileNameResolver
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.ApplyLocalization(Strings.ResourceManager);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            const int Padding = 10;
            foreach (var eachScreen in Screen.AllScreens)
            {
                if (eachScreen.Bounds.Contains(Location))
                {
                    Location = new Point(eachScreen.Bounds.Right - Width - Padding, eachScreen.Bounds.Top + Padding);
                    break;
                }
            }
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (BackgroundWorker.IsBusy)
            {
                e.Effect = DragDropEffects.None;
                return;
            }

            if (!e.Data.GetDataPresent(DataFormats.FileDrop, true))
            {
                e.Effect = DragDropEffects.None;
                return;
            }

            e.Effect = DragDropEffects.Move;
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            NormalizationForm targetForm;

            if (ToFormCRadioButton.Checked)
                targetForm = NormalizationForm.FormC;
            else if (ToFormDRadioButton.Checked)
                targetForm = NormalizationForm.FormD;
            else
            {
                e.Effect = DragDropEffects.None;
                return;
            }

            ProgressBar.Visible = true;

            BackgroundWorker.RunWorkerAsync(
                new FileNameResolverRequest(e.Data.GetData(DataFormats.FileDrop) as string[], targetForm, UnblockFiles.Checked));
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            const string WildCardExpression = "*.*";

            var args = e.Argument as FileNameResolverRequest;
            var directories = new List<string>();
            var files = new List<string>();

            // Collect all files and directory names
            foreach (var eachObject in args.TargetPathList)
            {
                if (Directory.Exists(eachObject))
                {
                    directories.Add(eachObject);
                    directories.AddRange(Directory.GetDirectories(eachObject, WildCardExpression, SearchOption.AllDirectories));
                    files.AddRange(Directory.GetFiles(eachObject, WildCardExpression, SearchOption.AllDirectories));
                }
                else if (File.Exists(eachObject))
                    files.Add(eachObject);
                else
                    continue;
            }

            var results = new FileNameResolverResultCollection();
            var totalCount = files.Count + directories.Count;
            var acc = 0;

            foreach (var eachFile in files.Select((x, i) => new { FullPath = x, Progress = (double)(acc + i + 1) / totalCount * 100d }))
            {
                if (File.Exists(eachFile.FullPath))
                {
                    try
                    {
                        if (args.RemoveZoneIdentifier)
                            NativeMethods.DeleteFileW($"{eachFile.FullPath}:Zone.Identifier");

                        if (!eachFile.FullPath.IsNormalized(args.TargetForm))
                        {
                            File.Move(eachFile.FullPath, eachFile.FullPath.Normalize(args.TargetForm));
                            results.Add(new FileNameResolverResult(eachFile.FullPath, true, false, FileNameResolverResultCategory.Renamed, null));
                        }
                        else
                            results.Add(new FileNameResolverResult(eachFile.FullPath, true, false, FileNameResolverResultCategory.Skipped, null));
                    }
                    catch (Exception thrown)
                    {
                        results.Add(new FileNameResolverResult(eachFile.FullPath, true, false, FileNameResolverResultCategory.Failed, thrown));
                    }
                }
                else
                    results.Add(new FileNameResolverResult(eachFile.FullPath, true, false, FileNameResolverResultCategory.Failed, new FileNotFoundException(string.Format(Strings.FileNotFoundException_Message, eachFile.FullPath))));

                BackgroundWorker.ReportProgress((int)eachFile.Progress);
            }

            acc += files.Count;

            foreach (var eachDirectory in directories.Select((x, i) => new { FullPath = x, Progress = (double)(acc + i + 1) / totalCount * 100d }))
            {
                if (Directory.Exists(eachDirectory.FullPath))
                {
                    try
                    {
                        if (!eachDirectory.FullPath.IsNormalized(args.TargetForm))
                        {
                            Directory.Move(eachDirectory.FullPath, eachDirectory.FullPath.Normalize(args.TargetForm));
                            results.Add(new FileNameResolverResult(eachDirectory.FullPath, false, true, FileNameResolverResultCategory.Renamed, null));
                        }
                        else
                            results.Add(new FileNameResolverResult(eachDirectory.FullPath, false, true, FileNameResolverResultCategory.Skipped, null));
                    }
                    catch (Exception thrown)
                    {
                        results.Add(new FileNameResolverResult(eachDirectory.FullPath, false, true, FileNameResolverResultCategory.Failed, thrown));
                    }
                }
                else
                    results.Add(new FileNameResolverResult(eachDirectory.FullPath, false, true, FileNameResolverResultCategory.Failed, new DirectoryNotFoundException(string.Format(Strings.DirectoryNotFoundException_Message, eachDirectory.FullPath))));

                BackgroundWorker.ReportProgress((int)eachDirectory.Progress);
            }

            acc += directories.Count;
            e.Result = results;
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressBar.Value = e.ProgressPercentage;
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ProgressBar.Value = ProgressBar.Maximum;
            ProgressBar.Visible = false;

            if (e.Cancelled)
            {
                MessageBox.Show(this, Strings.BackgroundWorker_Cancelled, Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }

            if (e.Error != null)
            {
                MessageBox.Show(this, string.Format(Strings.BackgroundWorker_Error, e.Error.Message), Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            var result = e.Result as FileNameResolverResultCollection;
            var icon = MessageBoxIcon.Information;

            var succeedCount = result.Where(x => x.Category == FileNameResolverResultCategory.Renamed).Count();
            var failedCount = result.Where(x => x.Category == FileNameResolverResultCategory.Failed).Count();

            if (failedCount > 0)
                icon = MessageBoxIcon.Warning;

            MessageBox.Show(this,
                string.Format(Strings.BackgroundWorker_Done, succeedCount, failedCount),
                Text, MessageBoxButtons.OK, icon, MessageBoxDefaultButton.Button1);
        }
    }
}
