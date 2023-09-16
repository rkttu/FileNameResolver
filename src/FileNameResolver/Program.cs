using System;
using System.Windows.Forms;

namespace FileNameResolver
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.OleRequired();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var mainForm = new MainForm())
            using (var appContext = new ApplicationContext(mainForm))
            {
                Application.Run(appContext);
            }
        }
    }
}
