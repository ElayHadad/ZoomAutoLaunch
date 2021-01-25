using System;
using System.Windows.Forms;
using System.IO;

namespace ZoomOpener
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (Directory.Exists("C:\\ZoomOpener\\"))
            {
                Application.Run(new Load());
            }
            else
            {
                Application.Run(new Setup());
            }
        }
    }
}
