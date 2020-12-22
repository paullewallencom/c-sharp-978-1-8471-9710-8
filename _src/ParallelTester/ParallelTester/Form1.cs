using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ParallelTester
{
    public partial class frmParallelPerformance : Form
    {
        // The number in which the iteration begins
        private long priBegin;
        // The number in which the iteration ends
        private long priEnd;
        // The total number of times the code in the loop will run
        private long priTotalIterations;

        public frmParallelPerformance()
        {
            InitializeComponent();
        }

        public frmParallelPerformance(long pariBegin, long pariEnd)
        {
            InitializeComponent();
            priBegin = pariBegin;
            priEnd = pariEnd;
            priTotalIterations = pariEnd - pariBegin + 1;
        }

        private void butStart_Click(object sender, EventArgs e)
        {
            // Save the start time
            DateTime loStartTime = DateTime.Now;
            /* This code will not generate a result.
             * Its main purpose is to consume processing power and also to update the progress bar */
            // This variable will hold a number to iterate from 1 to 36,000,000
            long liNumber;
            // This variable will hold a char generated from the number in i
            char lcChar;
            // This variable will hold the conversion from the char type to string
            String lsConverted;
            // This loop will run priTotalIteration times
            for (liNumber = priBegin; liNumber <= priEnd; liNumber++)
            {
                // lcChar holds a char as a result of modulus applied to liNumber
                lcChar = (char)(liNumber % 255);
                // The char is converted to a string and stored in s
                lsConverted = lcChar.ToString();
                // The progress is communicated to the progressbar
                pgbLoopProgress.Value = (int)((liNumber - priBegin) * 100 / priTotalIterations);
                // Allow Windows process events and display the advances in the progressbar
                Application.DoEvents();
            }
            // Save the ending time
            DateTime loEndTime = DateTime.Now;
            TimeSpan loDifference = (loEndTime - loStartTime);
            // Show the time to complete the loop in seconds
            lblSeconds.Text = string.Format("{0} seconds to complete", loDifference.Seconds);
    }

        private void frmParallelPerformance_Load(object sender, EventArgs e)
        {

        }
    }
}