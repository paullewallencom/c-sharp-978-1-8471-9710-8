using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// NEW
using System.Threading;
using System.Threading.Collections;
using System.IO;
using AForge.Imaging;
// NEW
using System.Threading.Tasks;

namespace BlobCounter
{
    public partial class frmNebulaFinder : Form
    {
        private TaskManager proParallelTaskManager = new TaskManager(new TaskManagerPolicy(Environment.ProcessorCount, Environment.ProcessorCount, 1));

        // NEW NEW
        private ConcurrentQueue<NebulaFinder> praoNebulaFinders;

        public frmNebulaFinder()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private delegate void ShowImageCaller(Bitmap poBitmap);

        public void ShowImage(Bitmap poBitmap)
        {
            // InvokeRequired compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If they are different, it will return true.
            if (picResultingBitmap.InvokeRequired)
            {
                // The calling thread is different than the UI thread
                // Create the delegate
                ShowImageCaller ldShowImage = new ShowImageCaller(ShowImage);
                // Invoke the delegate with an asynchronous execution
                // the current thread will not block until the delegate has been executed
                this.BeginInvoke(ldShowImage, new object[] { poBitmap });
            }
            else
            {
                // The calling thread is the same than the UI thread
                // Add the string received as a parameter to the ListBox control
                picResultingBitmap.Image = poBitmap;
            }
        }

        private void butRunBatch_Click(object sender, EventArgs e)
        {
            DirectoryInfo loDirectory;
            FileInfo[] loImageFiles;

            // Replace "C:\\NASA" with your images folder path
            loDirectory = new DirectoryInfo("C:\\NASABLOB");
            // Get the JPG files stored in the path
            loImageFiles = loDirectory.GetFiles("*.GIF");

            // Call the garbage collector before starting each thread
            NebulaFinder.ForceGarbageCollection();
            // Create a concurrent queue
            praoNebulaFinders = new ConcurrentQueue<NebulaFinder>();

            // Start the BackgroundWorker (the consumer)
            //bakDisplayImages.RunWorkerAsync();

                System.Threading.Tasks.Task.Create(poObject =>
                {
                    try
                    {
                        Parallel.For(0, loImageFiles.Count(), i =>
                        //Parallel.ForEach<FileInfo>(loImageFiles, loNextImageFile =>
                        {
                        // Create a new instance of the nebula finder
                        NebulaFinder loNebulaFinder = new NebulaFinder();
                        // Count the blobs for the image file
                        //loNebulaFinder.CountBlobs(loNextImageFile.FullName);
                        loNebulaFinder.CountBlobs(loImageFiles[i].FullName);
                        // Add the nebula finder instance to the safe concurrent queue
                        praoNebulaFinders.Enqueue(loNebulaFinder);

                        // Call the form's method to update the UI using a safe delegate
                        ShowImage(loNebulaFinder.poBitmap);
                    });
                }
                catch (System.Threading.AggregateException loAggregateException)
                {
                    foreach (Exception loInnerException in loAggregateException.InnerExceptions)
                    {
                        // Something went wrong
                        System.Diagnostics.Debug.Print(loInnerException.ToString());
                    }
                }
            });
            // Call the garbage collector to remove unused memory
            NebulaFinder.ForceGarbageCollection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap loBitmap;
            loBitmap = (Bitmap)System.Drawing.Bitmap.FromFile("C:\\NASABLOB\\221562main_print.gif");
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void bakDisplayImages_DoWork(object sender, DoWorkEventArgs e)
        {
            // Assign a name to the BackgroundWorker thread to identify it in the Threads Window
            Thread.CurrentThread.Name = ((BackgroundWorker)sender).ToString();
            NebulaFinder loNebulaFinder;
            while (!((BackgroundWorker)sender).CancellationPending)
            {
                while (praoNebulaFinders.TryDequeue(out loNebulaFinder))
                {
                    // A NebulaFinder instance could be dequeued from the praoNebulaFinders thread-safe queue
                    ShowImage(loNebulaFinder.poBitmap);
                    Thread.Sleep(1000);
                }
                Thread.Sleep(1000);
            }
        }

        public static int CountPotentialNebulasSequential(IEnumerable<Blob> paoSource)
        {
            return paoSource.Where(s => IsPotentialNebula(s)).Count();
        }

        public static int CountPotentialNebulasParallel(IEnumerable<Blob> paoSource)
        {
            return paoSource.AsParallel(Environment.ProcessorCount - 1).Where(s => IsPotentialNebula(s)).Count();
        }

        public static bool IsPotentialNebula(Blob poBlob)
        {
            return ((poBlob.Rectangle.Size.Width * poBlob.Rectangle.Size.Height) > 150);
        }

        private void butShowResults_Click(object sender, EventArgs e)
        {
            List<Blob> laoNebulaFinderList = new List<Blob>();
            // First, collect the blobs in a single unified list
            foreach (NebulaFinder loNebulaFinder in praoNebulaFinders)
            {
                laoNebulaFinderList.AddRange(loNebulaFinder.paoBlobs);
            }
            // Count the potential nebulas
            int liCount = CountPotentialNebulasParallel(laoNebulaFinderList);
            // Show a message box with the potential nebulas count
            System.Windows.Forms.MessageBox.Show(string.Format("The potential nebulas are {0}", liCount));

            // Start the BackgroundWorker thread
            //bakDisplayImages.RunWorkerAsync();

            //NebulaFinder loNebulaFinder;
            //while (praoNebulaFinders.TryDequeue(out loNebulaFinder))
            //{
            //    ShowImage(loNebulaFinder.poBitmap);
            //    Thread.Sleep(5000);
            //}
        }
    }
}
