using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SunspotsAnalyzer
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
            Application.Run(new frmSunspotsAnalyzer());
        }
    }
}