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
    public partial class frmMain : Form
    {
        // The thumbnails size
        private Size poThumbnailSize = new  Size(200, 200);
        // The image file name
        private string psImageFileName;
        // The beginning brightness adjustment
        double piBeginningBrightness = -1;
        // The ending brightness adjustment
        double piEndingBrightness = 1;
        // The step
        double piBrightnessStep = 0.01F;
        // The total number of thumbnails with brightness adjustments that are going to be shown
        int piTotalThumbnails;
        // The thumbnails already shown in the form
        int piThumbnailsShown;

        private delegate void ChangeOpacityCaller(double pariOpacity);
        public void ChangeOpacity(double pariOpacity)
        {
            // InvokeRequired compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If they are different, it will return true.
            if (this.InvokeRequired)
            {
                // The calling thread is different than the UI thread
                // Create the delegate
                ChangeOpacityCaller ldChangeOpacity = new ChangeOpacityCaller(ChangeOpacity);
                // Invoke the delegate
                // the current thread will block until the delegate has been executed
                this.Invoke(ldChangeOpacity, new object[] { pariOpacity });
            }
            else
            {
                // The calling thread is the same than the UI thread
                // Change the form's opacity value
                this.Opacity = pariOpacity;
            }
        }

        private delegate void AddThumbnailCaller(System.Drawing.Image paroThumbnailImage, double pariBrightnessDelta);
        public void AddThumbnail(System.Drawing.Image paroThumbnailImage, double pariBrightnessDelta)
        {
            // InvokeRequired compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If they are different, it will return true.
            if (this.InvokeRequired)
            {
                // The calling thread is different than the UI thread
                // Create the delegate
                AddThumbnailCaller ldAddThumbnail = new AddThumbnailCaller(AddThumbnail);
                // Invoke the delegate
                // the current thread will block until the delegate has been executed
                this.Invoke(ldAddThumbnail, new object[] { paroThumbnailImage, pariBrightnessDelta });
            }
            else
            {
                // The calling thread is the same than the UI thread
                // Add a new picture box showing the thumbnail in a layout panel
                AddThumbnailInLayoutPanel(paroThumbnailImage, pariBrightnessDelta);
            }
        }

        private void AddThumbnailInLayoutPanel(System.Drawing.Image paroThumbnailImage, double pariBrightnessDelta)
        {
            PictureBox loPictureBox = new PictureBox();

            loPictureBox.Size = poThumbnailSize;
            loPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            pnlFlowLayoutPanel.Controls.Add(loPictureBox);
            loPictureBox.Image = paroThumbnailImage;
            // A safe counter to track the total number of thumbnails shown
            piThumbnailsShown++;
            // Update the toolstrip progress bar
            tstThumbnailsProgress.Value = (int)((piThumbnailsShown * 100) / piTotalThumbnails);
            // Store the brightness delta in the picture box Tag property
            loPictureBox.Tag = pariBrightnessDelta;
            
            // ADD LATER

            // Attach an event handler making reference to the procedure that contains the code that will be triggered by the Click event
            loPictureBox.Click += new System.EventHandler(PictureBoxClickProcedure);
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpacityEffect loOpacityEffect = new OpacityEffect(this);
            loOpacityEffect.RunAsync();

            // Set the maximum number of requests to the thread pool that can be active concurrently equal to the number of available cores
            // All requests above that number remain queued until thread pool threads become available
            ThreadPool.SetMaxThreads(Environment.ProcessorCount, Environment.ProcessorCount * 2);

            // Specify the image file name
            //psImageFileName = @"C:\MYPHOTOS\DSC01470.JPG";
            psImageFileName = @"C:\MYPHOTOS\DSC01566.JPG";

            // Initialize the safe counter
            piThumbnailsShown = 0;
            piTotalThumbnails = (int)((piEndingBrightness - piBeginningBrightness) / piBrightnessStep);
            double liBrightnessAdjustment = piBeginningBrightness;
            while (liBrightnessAdjustment <= piEndingBrightness)
            {
                QueueBrightnessThumbnail(liBrightnessAdjustment);
                liBrightnessAdjustment += piBrightnessStep;
                liBrightnessAdjustment = Math.Round(liBrightnessAdjustment, 3);
            }
        }

        private void QueueBrightnessThumbnailThreadProc(Object stateInfo)
        {
            // An instance of ThumbnailBrightnessAdjuster is passed in stateInfo
            ThumbnailBrightnessAdjuster loThumbnailBrightnessAdjuster = (ThumbnailBrightnessAdjuster)stateInfo;

            loThumbnailBrightnessAdjuster.GenerateThumbnailImage();
            AddThumbnail(loThumbnailBrightnessAdjuster.poThumbnailImage, loThumbnailBrightnessAdjuster.piBrightnessDelta);
        }

        private void QueueBrightnessThumbnail(double pariBrightnessAdjustment)
        {
            ThumbnailBrightnessAdjuster loThumbnailBrightnessAdjuster;
            loThumbnailBrightnessAdjuster = new ThumbnailBrightnessAdjuster(psImageFileName, poThumbnailSize, pariBrightnessAdjustment);
            //this);
            // Queue the work passing a ThumbnailBrightnessAdjuster instance as a parameter
            ThreadPool.QueueUserWorkItem(new WaitCallback(QueueBrightnessThumbnailThreadProc), loThumbnailBrightnessAdjuster);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //PictureBox loPictureBox = new PictureBox();

            //loPictureBox.Width = 200;
            //loPictureBox.Height = 200;
            //loPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            //pnlFlowLayoutPanel.Controls.Add(loPictureBox);
            //Bitmap loBitmap = new Bitmap(@"C:\gaston_libros\redes_WIFI\figuras\5-4.emf");
            //loPictureBox.Image = loBitmap;

            psImageFileName = @"E:\Fotos_OK\DSC01656.JPG";

            ////BEGIN
            //System.Drawing.Image loImage = new Bitmap(psImageFileName);

            //// Create a new rectangle for displaying the original image
            //Rectangle loDestinationRectangle = new Rectangle(new Point(0, 0), poThumbnailSize);

            //// Create a new bitmap with the thumbnail width and height
            //Bitmap loBitmap = new Bitmap(poThumbnailSize.Width, poThumbnailSize.Height);
            //Graphics g = Graphics.FromImage((System.Drawing.Image)loBitmap);
            //g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            //// Draw the image resized to the thumbnail width and height using a high quality bicubic interpolation
            //g.DrawImage(loImage, loDestinationRectangle, 0, 0, loImage.Width, loImage.Height, GraphicsUnit.Pixel);

            //g.Dispose();

            ////pictureBox1.Image = loBitmap;

            //// Assign the thumbnail image
            //poThumbnailImage = loBitmap;

            //poStream = new MemoryStream();
            //poThumbnailImage.Save(poStream, System.Drawing.Imaging.ImageFormat.Bmp);

            //loImage = System.Drawing.Image.FromStream(poStream);
            ////END

            piThumbnailsShown = 0;
            piTotalThumbnails = (int)((piEndingBrightness - piBeginningBrightness) / piBrightnessStep);
            double liBrightnessAdjustment = piBeginningBrightness;
            while (liBrightnessAdjustment <= piEndingBrightness)
            {
                QueueBrightnessThumbnail(liBrightnessAdjustment);
                liBrightnessAdjustment += piBrightnessStep;
                liBrightnessAdjustment = Math.Round(liBrightnessAdjustment, 3);
            }

            //for (liBrightnessAdjustment = -1F; liBrightnessAdjustment <= 1F; liBrightnessAdjustment += 0.025F) 
            //{
                
            //}
        }

        private void pnlFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBoxClickProcedure(object sender, System.EventArgs e)
        {
            // SEE PAGE 112 (private void DoWorkProcedure(object sender, DoWorkEventArgs e))
            PictureBox loPictureBox = (PictureBox)(sender);
            frmShowFullImage loForm = new frmShowFullImage();
            loForm.psImageFileName = psImageFileName;
            //loForm.piBrightnessDelta =  Double.Parse((string) loPictureBox.Tag);
            loForm.piBrightnessDelta = (double)loPictureBox.Tag;
            loForm.Show(this);
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }

    class ThumbnailBrightnessAdjuster
    {
        // The brightness delta
        private double priBrightnessDelta;
        // The thumbnail image size to generate
        private Size proThumbnailSize;
        // The original image file name
        private string prsImageFileName;
        // The thumbnail image generated
        private System.Drawing.Image proThumbnailImage;

        public double piBrightnessDelta
        {
            get
            {
                return priBrightnessDelta;
            }
        }
        public string psImageFileName
        {
            get
            {
                return prsImageFileName;
            }
        }
        public System.Drawing.Image poThumbnailImage
        {
            get
            {
                return proThumbnailImage;
            }
        }

        public ThumbnailBrightnessAdjuster(string parsImageFileName, Size paroThumbnailSize, double pariBrightnessAdjustment)
        {
            prsImageFileName = parsImageFileName;
            priBrightnessDelta = pariBrightnessAdjustment;
            proThumbnailSize = paroThumbnailSize;
        }
        
        private Bitmap CreateThumbnail()
        {
            // Read the original image
            System.Drawing.Image loImage = new Bitmap(prsImageFileName);

            // Create a new rectangle for displaying the original image
            Rectangle loDestinationRectangle = new Rectangle(new Point(0, 0), proThumbnailSize);

            // Create a new bitmap with the thumbnail width and height
            Bitmap loBitmap = new Bitmap(proThumbnailSize.Width, proThumbnailSize.Height);
            Graphics g = Graphics.FromImage((System.Drawing.Image)loBitmap);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            // Draw the image resized to the thumbnail width and height using a high quality bicubic interpolation
            g.DrawImage(loImage, loDestinationRectangle, 0, 0, loImage.Width, loImage.Height, GraphicsUnit.Pixel);

            g.Dispose();

            return loBitmap;
        }

        private void AdjustThumbnailBrightness(Bitmap loBitmap)
        {
            //Format the image according to AForge.NET needs to apply the filter
            AForge.Imaging.Image.FormatImage(ref loBitmap);
            // Create an instance of the brightness correction filter
            AForge.Imaging.Filters.BrightnessCorrection loBrightnessCorrection = new AForge.Imaging.Filters.BrightnessCorrection(priBrightnessDelta);
            // Process the image (correct the brightness)
            proThumbnailImage = loBrightnessCorrection.Apply(loBitmap);

            Graphics g = Graphics.FromImage((System.Drawing.Image)proThumbnailImage);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            // Create the string to draw
            string loString = string.Format("Brightness value: {0}", priBrightnessDelta);
            // Create the font and the brush
            Font loFont = new Font("Arial", 12);
            SolidBrush loBrush = new SolidBrush(Color.CornflowerBlue);
            // Create the point for the upper-left corner of drawing
            PointF loPoint = new PointF(10.0F, (proThumbnailSize.Height - 50.0F));
            // Draw string to the thumbnail
            g.DrawString(loString, loFont, loBrush, loPoint);
            // Draw a rectangle around the thumbnail
            g.DrawRectangle(new Pen(loBrush, 10), new Rectangle(0, 0, proThumbnailImage.Width, proThumbnailImage.Height));

            g.Dispose();
        }

        public void GenerateThumbnailImage()
        {
            // Create the high quality thumbnail
            Bitmap loBitmap = CreateThumbnail();
            // Run the brightness adjustment
            AdjustThumbnailBrightness(loBitmap);
        }
    }
}
