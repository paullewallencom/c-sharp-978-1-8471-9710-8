using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CodeBreakerApplication
{
    public partial class frmMain : Form
    {
        // The simulated code to be broken
        private string prsCode;
        // The list of Label controls that show the characters of the code being broken
        private List<Label> prloOutputCharLabels;
        // The list of ProgressBar controls that show the progress of the character being decoded
        private List<ProgressBar> prloProgressChar;

        // 4 BackgroundWorker components
        private BackgroundWorker bakCodebreaker;
        private BackgroundWorker bakCodebreaker2;
        private BackgroundWorker bakCodebreaker3;
        private BackgroundWorker bakCodebreaker4;

        public frmMain()
        {
            InitializeComponent();
            // Generate a random code to be broken
            simulateCodeGeneration();
            // Create a new list of Label controls that show the characters of the code being broken
            prloOutputCharLabels = new List<Label>(4);
            // Add the Label controls to the List
            prloOutputCharLabels.Add(lblOutputChar1);
            prloOutputCharLabels.Add(lblOutputChar2);
            prloOutputCharLabels.Add(lblOutputChar3);
            prloOutputCharLabels.Add(lblOutputChar4);
            // Create a new list of ProgressBar controls that show the progress of each character of the code being broken
            prloProgressChar = new List<ProgressBar>(4);
            // Add the ProgressBar controls to the list
            prloProgressChar.Add(pgbProgressChar1);
            prloProgressChar.Add(pgbProgressChar2);
            prloProgressChar.Add(pgbProgressChar3);
            prloProgressChar.Add(pgbProgressChar4);

            // Create 4 new BackgroundWorker component
            bakCodebreaker = new System.ComponentModel.BackgroundWorker();
            // Attach an event handler making reference to the procedure that contains the code that will be triggered by the DoWork event
            bakCodebreaker.DoWork += new DoWorkEventHandler(DoWorkProcedure);
            // Attach an event handler making reference to the procedure that contains the code that will be triggered by the ProgressChanged event
            bakCodebreaker.ProgressChanged += new ProgressChangedEventHandler(ProgressChangedProcedure);
            // Attach an event handler making reference to the procedure that contains the code that will be triggered by the RunWorkerCompleted event
            bakCodebreaker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(RunWorkerCompletedProcedure);

            // Set up its properties
            bakCodebreaker.WorkerReportsProgress = true;
            bakCodebreaker.WorkerSupportsCancellation = true;

            bakCodebreaker2= new System.ComponentModel.BackgroundWorker();
            // Attach an event handler making reference to the procedure that contains the code that will be triggered by the DoWork event
            bakCodebreaker2.DoWork += new DoWorkEventHandler(DoWorkProcedure);
            // Attach an event handler making reference to the procedure that contains the code that will be triggered by the ProgressChanged event
            bakCodebreaker2.ProgressChanged += new ProgressChangedEventHandler(ProgressChangedProcedure);
            // Attach an event handler making reference to the procedure that contains the code that will be triggered by the RunWorkerCompleted event
            bakCodebreaker2.RunWorkerCompleted += new RunWorkerCompletedEventHandler(RunWorkerCompletedProcedure);

            // Set up its properties
            bakCodebreaker2.WorkerReportsProgress = true;
            bakCodebreaker2.WorkerSupportsCancellation = true;

            bakCodebreaker3 = new System.ComponentModel.BackgroundWorker();
            // Attach an event handler making reference to the procedure that contains the code that will be triggered by the DoWork event
            bakCodebreaker3.DoWork += new DoWorkEventHandler(DoWorkProcedure);
            // Attach an event handler making reference to the procedure that contains the code that will be triggered by the ProgressChanged event
            bakCodebreaker3.ProgressChanged += new ProgressChangedEventHandler(ProgressChangedProcedure);
            // Attach an event handler making reference to the procedure that contains the code that will be triggered by the RunWorkerCompleted event
            bakCodebreaker3.RunWorkerCompleted += new RunWorkerCompletedEventHandler(RunWorkerCompletedProcedure);

            // Set up its properties
            bakCodebreaker3.WorkerReportsProgress = true;
            bakCodebreaker3.WorkerSupportsCancellation = true;

            bakCodebreaker4 = new System.ComponentModel.BackgroundWorker();
            // Attach an event handler making reference to the procedure that contains the code that will be triggered by the DoWork event
            bakCodebreaker4.DoWork += new DoWorkEventHandler(DoWorkProcedure);
            // Attach an event handler making reference to the procedure that contains the code that will be triggered by the ProgressChanged event
            bakCodebreaker4.ProgressChanged += new ProgressChangedEventHandler(ProgressChangedProcedure);
            // Attach an event handler making reference to the procedure that contains the code that will be triggered by the RunWorkerCompleted event
            bakCodebreaker4.RunWorkerCompleted += new RunWorkerCompletedEventHandler(RunWorkerCompletedProcedure);

            // Set up its properties
            bakCodebreaker4.WorkerReportsProgress = true;
            bakCodebreaker4.WorkerSupportsCancellation = true;
        }

        private void simulateCodeGeneration()
        {
            // A Random number generator
            Random loRandom = new Random();
            // The char position being generated
            int i;
            
            prsCode = "";
            for (i = 0; i <= 4; i++)
            {
                // Generate a Random Unicode char for each of the 4 positions
                prsCode += (char)(loRandom.Next(32000));
            }
            //prsCode = "³H©€";
            prsCode = "FQÑ€";
        }

        private void setFishesVisibility(bool pbValue)
        {
            // Change the visibility of the controls related to the fishes game
            picFish1.Visible = pbValue;
            picFish2.Visible = pbValue;
            picFish3.Visible = pbValue;
            lblFishesGame.Visible = pbValue;
            butGameOver.Visible = pbValue;
        }

        private void setCodeBreakerVisibility(bool pbValue)
        {
            // Change the visibility of the controls related to the code breaking procedure
            picSkull.Visible = pbValue;
            picAgent.Visible = pbValue;
            lblCodeBreaker.Visible = pbValue;
            lblLabelChar1.Visible = pbValue;
            lblLabelChar2.Visible = pbValue;
            lblLabelChar3.Visible = pbValue;
            lblLabelChar4.Visible = pbValue;
            lblOutputChar1.Visible = pbValue;
            lblOutputChar2.Visible = pbValue;
            lblOutputChar3.Visible = pbValue;
            lblOutputChar4.Visible = pbValue;
            butStart.Visible = pbValue;
            butHide.Visible = pbValue;
            // Change the visibility of the controls related to the progress of the code breaking procedure
            pgbProgressChar1.Visible = pbValue;
            pgbProgressChar2.Visible = pbValue;
            pgbProgressChar3.Visible = pbValue;
            pgbProgressChar4.Visible = pbValue;
            // Change the visibility of the new stop button
            butStop.Visible = pbValue;
        }

        private void showFishes()
        {
            // Hide all the controls related to the code breaking procedure
            setCodeBreakerVisibility(false);
            // Change the window title
            this.Text = "Fishing game for Windows 1.0";
            // Make the fishes visible
            setFishesVisibility(true);
            // Change the window height
            this.Height = 700;
        }

        private void showCodeBreaker()
        {
            // Hide all the controls related to the fishes game
            setFishesVisibility(false);
            // Change the window title
            this.Text = "CodeBreaker Application";
            // Make the code breaker controls visible
            setCodeBreakerVisibility(true);
            // Change the window height
            this.Height = 415;
        }

        private bool checkCodeChar(char pcChar, int piCharNumber)
        {
            // Returns a bool value indicating whether the piCharNumber position of the code is the pcChar received
            int j;
            for (int i = 0; i <= 6500; i++)
            {
                j = (int) (i / 2);
            }

            return (prsCode[piCharNumber] == pcChar);
        }

        private void butStart_Click(object sender, EventArgs e)
        {
            // Disable the Start button
            butStart.Enabled = false;
            // Enable the Stop button
            butStop.Enabled = true;

            // Start running the code programmed in each BackgroundWorker DoWork event handler
            // in a new independent thread and return control to the application's main thread
            // First, create the CodeBreakerParameters for each BackgroundWorker and set its parameters
            CodeBreakerParameters loParameters1 = new CodeBreakerParameters();
            CodeBreakerParameters loParameters2 = new CodeBreakerParameters();
            CodeBreakerParameters loParameters3 = new CodeBreakerParameters();
            CodeBreakerParameters loParameters4 = new CodeBreakerParameters();
            loParameters1.MaxUnicodeCharCode = 32000;
            loParameters1.FirstCharNumber = 0;
            loParameters1.LastCharNumber = 0;
            loParameters2.MaxUnicodeCharCode = 32000;
            loParameters2.FirstCharNumber = 1;
            loParameters2.LastCharNumber = 1;
            loParameters3.MaxUnicodeCharCode = 32000;
            loParameters3.FirstCharNumber = 2;
            loParameters3.LastCharNumber = 2;
            loParameters4.MaxUnicodeCharCode = 32000;
            loParameters4.FirstCharNumber = 3;
            loParameters4.LastCharNumber = 3;
            bakCodebreaker.RunWorkerAsync(loParameters1);
            bakCodebreaker2.RunWorkerAsync(loParameters2);
            bakCodebreaker3.RunWorkerAsync(loParameters3);
            bakCodebreaker4.RunWorkerAsync(loParameters4);
        }

        private void butHide_Click(object sender, EventArgs e)
        {
            // Hide the Codebreaker and show the fishes game
            showFishes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Hide the fishes game and show the Codebreaker
            showCodeBreaker();
        }

        private void butGameOver_Click(object sender, EventArgs e)
        {
            // Hide the fishes game and show the Codebreaker
            showCodeBreaker();
        }

        private void DoWorkProcedure(object sender, DoWorkEventArgs e)
        {
            CodeBreakerParameters loCodeBreakerParameters = (CodeBreakerParameters)e.Argument;

            // This variable holds the last Unicode character to be processed
            //int liTotal = (int)e.Argument;
            int liTotal = loCodeBreakerParameters.MaxUnicodeCharCode;

            // This variable will hold the broken code
            string lsBrokenCode = "";
            
            // This code will break the simulated code
            // This variable will hold a number to iterate from 0 to liTotal - Unicode character set
            int i;
            // This variable will hold a number to iterate from 0 to 3 (the characters positions in the code to be broken)            
            int liCharNumber;
            // This variable will hold a char generated from the number in i
            char lcChar;
            // This variable will hold the current Label control that shows the char position being decoded
            //Label loOutputCharCurrentLabel;

            // This variable will hold a CodeBreakerProgress instance
            CodeBreakerProgress loCodeBreakerProgress = new CodeBreakerProgress();
            // This variable will hold the last percentage of the iteration completed
            int liOldPercentageCompleted;

            liOldPercentageCompleted = 0;
            for (liCharNumber = loCodeBreakerParameters.FirstCharNumber; liCharNumber <= loCodeBreakerParameters.LastCharNumber; liCharNumber++)
            {
                // This loop will run (liTotal + 1) times
                for (i = 0; i <= liTotal; i++)
                {
                    // We must check whether the user pressed the cancellation button or not
                    if (((BackgroundWorker)sender).CancellationPending)
                    {
                        // The user requested to cancel the process
                        e.Cancel = true;
                        return;
                    }

                    // myChar holds a Unicode char
                    lcChar = (char)(i);

                    // The percentage completed is calculated and stored in the PercentageCompleted property
                    loCodeBreakerProgress.PercentageCompleted = (int)((i * 100) / liTotal);
                    loCodeBreakerProgress.CharNumber = liCharNumber;
                    loCodeBreakerProgress.CharCode = i;

                    if (loCodeBreakerProgress.PercentageCompleted > liOldPercentageCompleted)
                    {
                        // The progress is reported only when it changes with regard to the last one (liOldPercentageCompleted)
                        ((BackgroundWorker)sender).ReportProgress(loCodeBreakerProgress.PercentageCompleted, loCodeBreakerProgress);
                        //Application.DoEvents();
                        // The old percentage completed is now the percentage reported
                        liOldPercentageCompleted = loCodeBreakerProgress.PercentageCompleted;
                    }

                    if (checkCodeChar(lcChar, liCharNumber))
                    {
                        // The code position was found
                        loCodeBreakerProgress.PercentageCompleted = 100;
                        ((BackgroundWorker)sender).ReportProgress(loCodeBreakerProgress.PercentageCompleted, loCodeBreakerProgress);
                        Application.DoEvents();
                        // The broken code is concatenated in lsBrokenCode
                        lsBrokenCode += lcChar.ToString();
                        break;
                    }
                }
            }

            // Create a new instance of the CodeBreakerResult class and set its properties values
            CodeBreakerResult loResult = new CodeBreakerResult();
            loResult.FirstCharNumber = loCodeBreakerParameters.FirstCharNumber;
            loResult.LastCharNumber = loCodeBreakerParameters.LastCharNumber;
            loResult.BrokenCode = lsBrokenCode;
            
            // Return a CodeBreakerResult instance in the Result property
            e.Result = loResult;
        }
           

        private void bakCodebreaker_DoWork(object sender, DoWorkEventArgs e)
        {
            DoWorkProcedure(sender, e);
        }

        private void ProgressChangedProcedure(object sender, ProgressChangedEventArgs e)
        {
            // This variable will hold a CodeBreakerProgress instance
            CodeBreakerProgress loCodeBreakerProgress = (CodeBreakerProgress)e.UserState;

            // Update the corresponding ProgressBar with the percentage received in the as a parameter
            prloProgressChar[loCodeBreakerProgress.CharNumber].Value = loCodeBreakerProgress.PercentageCompleted;
            // Update the corresponding Label with the character being processed
            prloOutputCharLabels[loCodeBreakerProgress.CharNumber].Text = ((char)loCodeBreakerProgress.CharCode).ToString();
        }

        private void bakCodebreaker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressChangedProcedure(sender, e);
        }

        private void butStop_Click(object sender, EventArgs e)
        {
            // Disable the Stop button
            butStop.Enabled = false;
            // Enable the Start button
            butStart.Enabled = true;
            // Call the asynchronous cancellation (it will assign the true value to 
            // the BackgroundWorker bakCodebreaker CancellationPending property
            bakCodebreaker.CancelAsync();
            bakCodebreaker2.CancelAsync();
            bakCodebreaker3.CancelAsync();
            bakCodebreaker4.CancelAsync();
        }

        private void RunWorkerCompletedProcedure(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                // Obtain the CodeBreakerResult instance contained in the Result property of e parameter
                CodeBreakerResult loResult = (CodeBreakerResult) e.Result;
                int i;

                // Iterate through the parts of the result resolved by this BackgroundWorker
                for (i = loResult.FirstCharNumber; i <= loResult.LastCharNumber; i++)
                {
                    // The process has finishes, therefore the ProgressBar control must show a 100%
                    prloProgressChar[i].Value = 100;
                    // Show the part of the broken code in the label
                    prloOutputCharLabels[i].Text = loResult.BrokenCode[i - loResult.FirstCharNumber].ToString();
                }
            }
        }

        private void bakCodebreaker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            RunWorkerCompletedProcedure(sender, e);
        }

        private void bakCodebreaker2_DoWork(object sender, DoWorkEventArgs e)
        {
            DoWorkProcedure(sender, e);
        }

        private void bakCodebreaker3_DoWork(object sender, DoWorkEventArgs e)
        {
            DoWorkProcedure(sender, e);
        }

        private void bakCodebreaker4_DoWork(object sender, DoWorkEventArgs e)
        {
            DoWorkProcedure(sender, e);
        }

        private void bakCodebreaker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressChangedProcedure(sender, e);
        }

        private void bakCodebreaker3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            RunWorkerCompletedProcedure(sender, e);
        }

        private void bakCodebreaker3_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressChangedProcedure(sender, e);
        }

        private void bakCodebreaker4_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressChangedProcedure(sender, e);
        }

        private void bakCodebreaker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            RunWorkerCompletedProcedure(sender, e);
        }

        private void bakCodebreaker4_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            RunWorkerCompletedProcedure(sender, e);
        }
    }

    public class CodeBreakerProgress
    {
        // The char position in the 4 chars code
        private int priCharNumber;
        // The Unicode char code
        private int priCharCode;
        // The decoding process percentage completed
        private int priPercentageCompleted;

        public int CharNumber
        {
            get
            {
                return priCharNumber;
            }
            set
            {
                priCharNumber = value;
            }
        }

        public int CharCode
        {
            get
            {
                return priCharCode;
            }
            set
            {
                priCharCode = value;
            }
        }

        public int PercentageCompleted
        {
            get
            {
                return priPercentageCompleted;
            }
            set
            {
                priPercentageCompleted = value;
            }
        }
    }

    public class CodeBreakerParameters
    {
        // The first char position in the 4 chars code to process
        private int priFirstCharNumber;
        // The last char position in the 4 chars code to process
        private int priLastCharNumber;
        // The maximum number of the Unicode character
        private int priMaxUnicodeCharCode;

        public int FirstCharNumber
        {
            get
            {
                return priFirstCharNumber;
            }
            set
            {
                priFirstCharNumber = value;
            }
        }

        public int LastCharNumber
        {
            get
            {
                return priLastCharNumber;
            }
            set
            {
                priLastCharNumber = value;
            }
        }

        public int MaxUnicodeCharCode
        {
            get
            {
                return priMaxUnicodeCharCode;
            }
            set
            {
                priMaxUnicodeCharCode = value;
            }
        }
    }

    public class CodeBreakerResult
    {
        // The first char position in the 4 chars code to process
        private int priFirstCharNumber;
        // The last char position in the 4 chars code to process
        private int priLastCharNumber;
        // The part of the broken code 
        private string prsBrokenCode;

        public int FirstCharNumber
        {
            get
            {
                return priFirstCharNumber;
            }
            set
            {
                priFirstCharNumber = value;
            }
        }

        public int LastCharNumber
        {
            get
            {
                return priLastCharNumber;
            }
            set
            {
                priLastCharNumber = value;
            }
        }

        public string BrokenCode
        {
            get
            {
                return prsBrokenCode;
            }
            set
            {
                prsBrokenCode = value;
            }
        }
    }
}