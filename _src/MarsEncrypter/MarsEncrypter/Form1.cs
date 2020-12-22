using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
// NEW
using System.Threading;
using System.IO;

namespace MarsEncrypter
{
    public partial class frmMarsEncrypter : Form
    {
        private delegate void AddToListBoxCaller(string psText);
        // The total number of files encrypted
        private int priTotalFilesEncrypted = 0;

        // NEW DATAGRID
        // The list to hold the FileToEncryptProgress instances for each new file to encrypt
        List<FileToEncryptProgress> paoFilesToEncryptProgress = new List<FileToEncryptProgress>();
        private delegate void UpdateProgressCaller();
        // END NEW DATAGRID

        public frmMarsEncrypter()
        {
            InitializeComponent();
        }

        private void IncreaseAndShowCounter()
        {
            // Increase the number of total files encrypted
            priTotalFilesEncrypted++;
            //// Update the counter (using a nice Dundas Gauge)
            //// Replace this line by the code necessary to update your counter
            //gauCounter.NumericIndicators[0].Value = (priTotalFilesEncrypted + (Environment.ProcessorCount * 0.1));
            lblCounter.Text = string.Format("{0};{1}", priTotalFilesEncrypted, Environment.ProcessorCount);
        }

        public void AddToListBox(string psText)
        {
            // InvokeRequired compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If they are different, it will return true.
            if (libFilesEncrypted.InvokeRequired)
            {
                // The calling thread is different than the UI thread
                // Create the delegate
                AddToListBoxCaller ldAddToListBox = new AddToListBoxCaller(AddToListBox);
                // Invoke the delegate
                // the current thread will block until the delegate has been executed
                this.Invoke(ldAddToListBox, new object[] { psText });
            }
            else
            {
                // The calling thread is the same than the UI thread
                // Add the string received as a parameter to the ListBox control
                libFilesEncrypted.Items.Add(psText);
                IncreaseAndShowCounter();
            }
        }

        // NEW DATAGRID
        public void UpdateProgress()
        {
            // InvokeRequired compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If they are different, it will return true.
            if (dgvFilesToEncryptProgress.InvokeRequired)
            {
                // The calling thread is different than the UI thread
                // Create the delegate
                UpdateProgressCaller ldUpdateProgress = new UpdateProgressCaller(UpdateProgress);
                // Invoke the delegate
                // the current thread will block until the delegate has been executed
                this.BeginInvoke(ldUpdateProgress);
            }
            else
            {
                // The calling thread is the same than the UI thread
                // Invalidate the progress column of the grid control (to avoid repainting all the grid)
                dgvFilesToEncryptProgress.InvalidateColumn(1);
            }
        }
        // END NEW DATAGRID

        private void ThreadProc(Object stateInfo)
        {
            // An instance of Encrypter is passed in stateInfo
            Encrypter loEncrypter = (Encrypter) stateInfo;

            // Give the thread a name
            Thread.CurrentThread.Name = "ThreadPool: " + loEncrypter.psInputFileName;

            loEncrypter.EncryptFile();
        }

        private void QueueFileEncryption(string psFileName)
        {
            Encrypter loEncrypter;
            loEncrypter = new Encrypter();
            // Assign the input file name (received as a parameter)
            loEncrypter.psInputFileName = psFileName;
            // Generate the output file name replacing INPUT with OUTPUT in the path
            loEncrypter.psOutputFileName = psFileName.Replace("INPUT", "OUTPUT");

            // Fill the property with the reference to this form
            loEncrypter.poForm = this;

            // NEW DATAGRID
            FileToEncryptProgress loFileToEncryptProgress;
            loFileToEncryptProgress = new FileToEncryptProgress(psFileName, 0);
            paoFilesToEncryptProgress.Add(loFileToEncryptProgress);
            // Update the data grid bounding it again to the data source
            ShowFilesToEncryptProgressGrid();
            loEncrypter.poFileToEncryptProgress = loFileToEncryptProgress;
            // END NEW DATAGRID

            // Fill the property with the reference to this form
            loEncrypter.poForm = this;

            // Queue the work passing an Encrypter instance as a parameter
            ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadProc), loEncrypter);
            //System.Diagnostics.Debug.Print(psFileName);
        }

        private void fswCheckForNewFiles_Created(object sender, System.IO.FileSystemEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set the maximum number of requests to the thread pool that can be active concurrently equal to the number of available cores
            // All requests above that number remain queued until thread pool threads become available
            ThreadPool.SetMaxThreads(Environment.ProcessorCount, Environment.ProcessorCount * 2);
            // Give a name to identify the thread that creates the UI
            Thread.CurrentThread.Name = "UI Thread";
            // Initialize the counter
            // Replace this line by the code necessary to initialize your counter
            // gauCounter.NumericIndicators[0].Value = (0 + (Environment.ProcessorCount * 0.1));
            // NEW DATAGRID
            //ShowFilesToEncryptProgressGrid();
        }

        private void fswCheckForNewFiles_Changed(object sender, FileSystemEventArgs e)
        {
            // The file was last accessed, it is a new file ready to be encrypted
            // Send it to the queue
            QueueFileEncryption(e.FullPath);
            // Add its name to the ListBox
            
            // Commented
            ///////libFilesEncrypted.Items.Add(e.Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        // NEW DATAGRID
        private void ShowFilesToEncryptProgressGrid()
        {
            // Do not generate the DataGridView columns automatically
            dgvFilesToEncryptProgress.AutoGenerateColumns = false;
            // Bound the dataGridView to the list of encrypted files
            dgvFilesToEncryptProgress.DataSource = paoFilesToEncryptProgress;
            dgvFilesToEncryptProgress.Columns.Clear();
            // Add the Input file name column
            dgvFilesToEncryptProgress.Columns.Add(new DataGridViewTextBoxColumn());
            dgvFilesToEncryptProgress.Columns[0].DataPropertyName = "psInputFileName";
            dgvFilesToEncryptProgress.Columns[0].HeaderText = "File name to encrypt";
            // Add the Progress column
            dgvFilesToEncryptProgress.Columns.Add(new DataGridViewProgressColumn());
            dgvFilesToEncryptProgress.Columns[1].DataPropertyName = "piProgress";
            dgvFilesToEncryptProgress.Columns[1].HeaderText = "Encryption progress";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }
    }
}