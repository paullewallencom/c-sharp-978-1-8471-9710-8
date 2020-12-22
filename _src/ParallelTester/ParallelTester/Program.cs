using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ParallelTester
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static int Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length < 2)
            {
                // The application needs two arguments. Use the default values.
                //Application.Run(new frmParallelPerformance(1, 36000000));
                Application.Run(new frmParallelPerformance(9000001, 18000000));
            }
            else
            {
                // Run the main form with the two parameters that set the iteration bounds (begin and end)
                Application.Run(new frmParallelPerformance(long.Parse(args[0]), long.Parse(args[1])));
            }
            return 0;
        }
   }
}