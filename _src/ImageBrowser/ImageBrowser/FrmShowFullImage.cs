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

namespace ImageBrowser
{
    public partial class frmShowFullImage : Form
    {
        private double priBrightnessDelta;
        public double piBrightnessDelta
        {
            get
            {
                return priBrightnessDelta;
            }
            set
            {
                priBrightnessDelta = value;
            }
        }
        private string prsImageFileName;
        public string psImageFileName
        {
            get
            {
                return prsImageFileName;
            }
            set
            {
                prsImageFileName = value;
            }
        }
        
        // The bitmap to show with the brightness adjustment
        private Bitmap proBitmap;

        public frmShowFullImage()
        {
            InitializeComponent();
        }

        private void picImage_Click(object sender, EventArgs e)
        {

        }

        private void FrmShowFullImage_Load(object sender, EventArgs e)
        {
            // Set the forms title
            this.Text = psImageFileName + string.Format("; Brightness value: {0}", priBrightnessDelta);
            // Run in an independent thread to avoid blocking the UI thread
            RunAsync();
        }

        public void RunAsync()
        {
            // Add a new independent thread, with a parameterized start (to allow parameters)
            Thread loThread = new Thread(new ThreadStart(ThreadProc));
            // If the user closes the form, we want the threads to be cancelled
            // Therefore, it must be a background thread
            loThread.IsBackground = true;
            // Start the thread with an asynchronous execution
            loThread.Start();
        }

        private void ThreadProc()
        {
            //// An instance of FrmShowFullImage is passed in poThreadParameter
            //FrmShowFullImage loForm = (FrmShowFullImage)poThreadParameter;

            BrightnessAdjustment loBrightnessAdjustment;

            proBitmap = new Bitmap(psImageFileName);
            loBrightnessAdjustment = new BrightnessAdjustment(proBitmap, priBrightnessDelta);
            loBrightnessAdjustment.RunInParallelSync();
            loBrightnessAdjustment.CollectResults();
            // Invoke the image assignation and resize
            ShowImage(loBrightnessAdjustment.poBitmap);
        }

        private delegate void ShowImageCaller(System.Drawing.Image paroImage);
        public void ShowImage(System.Drawing.Image paroImage)
        {
            // InvokeRequired compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If they are different, it will return true.
            if (this.InvokeRequired)
            {
                // The calling thread is different than the UI thread
                // Create the delegate
                ShowImageCaller ldAddThumbnail = new ShowImageCaller(ShowImage);
                // Invoke the delegate
                // the current thread will block until the delegate has been executed
                this.Invoke(ldAddThumbnail, new object[] { paroImage });
            }
            else
            {
                // The calling thread is the same than the UI thread
                // Show the image in the picture box and assign its size
                picImage.Size = paroImage.Size;
                picImage.Image = paroImage;
            }
        }
    }
}
