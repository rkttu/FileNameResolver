namespace FileNameResolver
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ToFormCRadioButton = new System.Windows.Forms.RadioButton();
            this.ToFormDRadioButton = new System.Windows.Forms.RadioButton();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.UnblockFiles = new System.Windows.Forms.CheckBox();
            this.TableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.AllowDrop = true;
            this.TableLayoutPanel.SetColumnSpan(this.InstructionLabel, 2);
            this.InstructionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InstructionLabel.Location = new System.Drawing.Point(13, 10);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(294, 80);
            this.InstructionLabel.TabIndex = 0;
            this.InstructionLabel.Text = "Drag and drop individual files or folders onto this window. This tool will change" +
    " all of the filenames encoding to suit your purposes.";
            this.InstructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InstructionLabel.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.InstructionLabel.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.AllowDrop = true;
            this.TableLayoutPanel.ColumnCount = 2;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.Controls.Add(this.InstructionLabel, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.ToFormCRadioButton, 0, 1);
            this.TableLayoutPanel.Controls.Add(this.ToFormDRadioButton, 1, 1);
            this.TableLayoutPanel.Controls.Add(this.ProgressBar, 0, 3);
            this.TableLayoutPanel.Controls.Add(this.UnblockFiles, 0, 2);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.Padding = new System.Windows.Forms.Padding(10);
            this.TableLayoutPanel.RowCount = 4;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(320, 240);
            this.TableLayoutPanel.TabIndex = 1;
            this.TableLayoutPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.TableLayoutPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            // 
            // ToFormCRadioButton
            // 
            this.ToFormCRadioButton.AllowDrop = true;
            this.ToFormCRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.ToFormCRadioButton.AutoSize = true;
            this.ToFormCRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToFormCRadioButton.Location = new System.Drawing.Point(13, 93);
            this.ToFormCRadioButton.Name = "ToFormCRadioButton";
            this.ToFormCRadioButton.Size = new System.Drawing.Size(144, 74);
            this.ToFormCRadioButton.TabIndex = 1;
            this.ToFormCRadioButton.TabStop = true;
            this.ToFormCRadioButton.Text = "For Windows/OneDrive";
            this.ToFormCRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ToFormCRadioButton.UseVisualStyleBackColor = true;
            this.ToFormCRadioButton.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.ToFormCRadioButton.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            // 
            // ToFormDRadioButton
            // 
            this.ToFormDRadioButton.AllowDrop = true;
            this.ToFormDRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.ToFormDRadioButton.AutoSize = true;
            this.ToFormDRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToFormDRadioButton.Location = new System.Drawing.Point(163, 93);
            this.ToFormDRadioButton.Name = "ToFormDRadioButton";
            this.ToFormDRadioButton.Size = new System.Drawing.Size(144, 74);
            this.ToFormDRadioButton.TabIndex = 2;
            this.ToFormDRadioButton.TabStop = true;
            this.ToFormDRadioButton.Text = "For macOS/iCloud";
            this.ToFormDRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ToFormDRadioButton.UseVisualStyleBackColor = true;
            this.ToFormDRadioButton.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.ToFormDRadioButton.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            // 
            // ProgressBar
            // 
            this.TableLayoutPanel.SetColumnSpan(this.ProgressBar, 2);
            this.ProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProgressBar.Location = new System.Drawing.Point(13, 203);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(294, 24);
            this.ProgressBar.TabIndex = 3;
            this.ProgressBar.Visible = false;
            this.ProgressBar.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.ProgressBar.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            // 
            // BackgroundWorker
            // 
            this.BackgroundWorker.WorkerReportsProgress = true;
            this.BackgroundWorker.WorkerSupportsCancellation = true;
            this.BackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            this.BackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker_ProgressChanged);
            this.BackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
            // 
            // UnblockFiles
            // 
            this.UnblockFiles.Checked = true;
            this.UnblockFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TableLayoutPanel.SetColumnSpan(this.UnblockFiles, 2);
            this.UnblockFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UnblockFiles.Location = new System.Drawing.Point(13, 173);
            this.UnblockFiles.Name = "UnblockFiles";
            this.UnblockFiles.Size = new System.Drawing.Size(294, 24);
            this.UnblockFiles.TabIndex = 4;
            this.UnblockFiles.Text = "Unblock files downloaded from the Internet";
            this.UnblockFiles.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(320, 240);
            this.Controls.Add(this.TableLayoutPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(320, 240);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "File Name Resolver";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.TableLayoutPanel.ResumeLayout(false);
            this.TableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label InstructionLabel;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.RadioButton ToFormCRadioButton;
        private System.Windows.Forms.RadioButton ToFormDRadioButton;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.ComponentModel.BackgroundWorker BackgroundWorker;
        private System.Windows.Forms.CheckBox UnblockFiles;
    }
}

