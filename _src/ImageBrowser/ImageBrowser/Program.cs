using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ImageBrowser
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        // Code added in the WaitHandle.WaitAll version
        [MTAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
