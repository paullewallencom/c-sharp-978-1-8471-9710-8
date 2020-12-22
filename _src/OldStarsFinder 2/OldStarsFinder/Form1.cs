using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Imaging;
using System.IO;


namespace OldStarsFinder
{
    public partial class frmStarsFinder : Form
    {
        // The number of processors or cores available in the computer for this application
        private int priProcessorCount = Environment.ProcessorCount;
        // The bitmaps list
        private List<Bitmap> prloBitmapList;
        // The long list with the old stars count
        private List<long> prliOldStarsCount;
        // The threads list
        private List<Thread> prloThreadList;
        // The original huge infrared bitmap portrait
        Bitmap proOriginalBitmap;
        // Code added in the WaitHandle.WaitAll version
        // The AutoResetEvent instances array
        private AutoResetEvent[] praoAutoResetEventArray;

        public frmStarsFinder()
        {
            InitializeComponent();
        }

        private Bitmap CropBitmap(Bitmap proBitmap, Rectangle proRectangle)
        {
            // Create a new bitmap copying the portion of the original defined by proRectangle
            // and keeping its PixelFormat
            Bitmap loCroppedBitmap = proBitmap.Clone(proRectangle, proBitmap.PixelFormat);
            // Return the cropped bitmap
            return loCroppedBitmap;
        }

        public bool IsOldStar(Color poPixelColor)
        {
            // Hue between 150 and 258
            // Saturation more than 0.10
            // Brightness more than 0.90
            return ((poPixelColor.GetHue() >= 150) && (poPixelColor.GetHue() <= 258) && (poPixelColor.GetSaturation() >= 0.10) && (poPixelColor.GetBrightness() <= 0.90));
        }

        private void ThreadOldStarsFinder(object poThreadParameter)
        {
            // Retrieve the thread number received in object poThreadParameter
            int liThreadNumber = (int)poThreadParameter;
            // The pixel matrix (bitmap) row number (Y)
            int liRow;
            // The pixel matrix (bitmap) col number (X)
            int liCol;
            // The pixel color
            Color loPixelColor;
            // Get my bitmap part from the bitmap list
            Bitmap loBitmap = prloBitmapList[liThreadNumber];

            // Reset my old stars counter
            prliOldStarsCount[liThreadNumber] = 0;
            // Iterate through each pixel matrix (bitmap) rows
            for (liRow = 0; liRow < loBitmap.Height; liRow++)
            {
                // Iterate through each pixel matrix (bitmap) cols
                for (liCol = 0; liCol < loBitmap.Width; liCol++)
                {
                    // Get the pixel Color for liCol and liRow
                    loPixelColor = loBitmap.GetPixel(liCol, liRow);
                    if (IsOldStar(loPixelColor))
                    {
                        // The color range corresponds to an old star
                        // Change its color to a pure blue
                        loBitmap.SetPixel(liCol, liRow, Color.Blue);
                        // Increase the old stars counter
                        prliOldStarsCount[liThreadNumber]++;
                    }
                }
            }

            // Code added in the WaitHandleVersion
            // The thread finished its work. Signal that the work item has finished.
            praoAutoResetEventArray[liThreadNumber].Set();
        }

        private void frmStarsFinder_Load(object sender, EventArgs e)
        {

        }

        private void WaitForThreadsToDie()
        {
            // Previous version - without using WaitAll
            //// A bool flag
            //bool lbContinue = true;
            //int liDeadThreads = 0;
            //int liThreadNumber;
            //while (lbContinue)
            //{
            //    for (liThreadNumber = 0; liThreadNumber < priProcessorCount; liThreadNumber++)
            //    {
            //        if (prloThreadList[liThreadNumber].IsAlive)
            //        {
            //            // One of the threads is still alive, exit the for loop and sleep 100 milliseconds
            //            break;
            //        }
            //        else
            //        {
            //            // Increase the dead threads count
            //            liDeadThreads++;
            //        }
            //    }
            //    if (liDeadThreads == priProcessorCount)
            //    {
            //        // All the threads are dead, exit the while loop
            //        break;
            //    }
            //    Thread.Sleep(100);
            //    liDeadThreads = 0;
            //}
            // End of previous version - without using WaitAll
            // Code added in the WaitHandle.WaitAll version
            // Just wait for the threads to signal that every work item has finished
            WaitHandle.WaitAll(praoAutoResetEventArray);
        }

        private void ShowBitmapWithOldStars()
        {
            int liThreadNumber;
            // Each bitmap portion
            Bitmap loBitmap;
            // The starting row in each iteration
            int liStartRow = 0;

            // Calculate each bitmap's height
            int liEachBitmapHeight = ((int)(proOriginalBitmap.Height / priProcessorCount)) + 1;

            // Create a new bitmap with the whole width and height
            loBitmap = new Bitmap(proOriginalBitmap.Width, proOriginalBitmap.Height);
            Graphics g = Graphics.FromImage((Image)loBitmap);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            for (liThreadNumber = 0; liThreadNumber < priProcessorCount; liThreadNumber++)
            {
                // Draw each portion in its corresponding absolute starting row
                g.DrawImage(prloBitmapList[liThreadNumber], 0, liStartRow);
                // Increase the starting row
                liStartRow += liEachBitmapHeight;
            }
            // Show the bitmap in the PictureBox picStarsBitmap
            picStarsBitmap.Image = loBitmap;
            //picStarsBitmap.Image.Save("c:\\packt\\resulting_image.png", ImageFormat.Png);

            g.Dispose();
        }

        private void FindOldStarsAndShowResult()
        {
            // Thread number
            int liThreadNumber;
            // Create the thread list; the long list and the bitmap list
            prloThreadList = new List<Thread>(priProcessorCount);
            prliOldStarsCount = new List<long>(priProcessorCount);
            prloBitmapList = new List<Bitmap>(priProcessorCount);
            // Code added in the WaitHandle.WaitAll version
            // Create the AutoResetEvent array with the number of cores available
            praoAutoResetEventArray = new AutoResetEvent[priProcessorCount];
            // End of the code added in the WaitHandle.WaitAll version

            int liStartRow = 0;

            int liEachBitmapHeight = ((int)(proOriginalBitmap.Height / priProcessorCount)) + 1;

            int liHeightToAdd = proOriginalBitmap.Height;
            Bitmap loBitmap;

            // Initialize the threads
            for (liThreadNumber = 0; liThreadNumber < priProcessorCount; liThreadNumber++)
            {
                // Just to occupy the number
                prliOldStarsCount.Add(0);

                if (liEachBitmapHeight > liHeightToAdd)
                {
                    // The last bitmap height perhaps is less than the other bitmaps height
                    liEachBitmapHeight = liHeightToAdd;
                }

                loBitmap = CropBitmap(proOriginalBitmap, new Rectangle(0, liStartRow, proOriginalBitmap.Width, liEachBitmapHeight));
                liHeightToAdd -= liEachBitmapHeight;
                liStartRow += liEachBitmapHeight;
                prloBitmapList.Add(loBitmap);

                // Code added in the WaitHandle.WaitAll version
                // Create a new AutoResetEvent instance for that thread with its initial state set to false
                praoAutoResetEventArray[liThreadNumber] = new AutoResetEvent(false);
                // End of the code added in the WaitHandle.WaitAll version

                // Add the new thread, with a parameterized start (to allow parameters)
                prloThreadList.Add(new Thread(new ParameterizedThreadStart(ThreadOldStarsFinder)));
            }

            // Call the garbage collector before starting each thread
            GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced);

            // Now, start the threads
            for (liThreadNumber = 0; liThreadNumber < priProcessorCount; liThreadNumber++)
            {
                prloThreadList[liThreadNumber].Start(liThreadNumber);
            }

            WaitForThreadsToDie();

            ShowBitmapWithOldStars();
        }

        private void butFindOldStars_Click(object sender, EventArgs e)
        {
            proOriginalBitmap = new Bitmap(picStarsBitmap.Image);

            // Thread number
            int liThreadNumber;
            // Create the thread list; the long list and the bitmap list
            prloThreadList = new List<Thread>(priProcessorCount);
            prliOldStarsCount = new List<long>(priProcessorCount);
            prloBitmapList = new List<Bitmap>(priProcessorCount);
            // Create the AutoResetEvent array with the number of cores available
            praoAutoResetEventArray = new AutoResetEvent[priProcessorCount];

            int liStartRow = 0;

            int liEachBitmapHeight = ((int)(proOriginalBitmap.Height / priProcessorCount)) + 1;

            int liHeightToAdd = proOriginalBitmap.Height;
            Bitmap loBitmap;

            // Initialize the threads
            for (liThreadNumber = 0; liThreadNumber < priProcessorCount; liThreadNumber++)
            {
                // Just to occupy the number
                prliOldStarsCount.Add(0);

                if (liEachBitmapHeight > liHeightToAdd)
                {
                    // The last bitmap height perhaps is less than the other bitmaps height
                    liEachBitmapHeight = liHeightToAdd;
                }

                loBitmap = CropBitmap(proOriginalBitmap, new Rectangle(0, liStartRow, proOriginalBitmap.Width, liEachBitmapHeight));
                liHeightToAdd -= liEachBitmapHeight;
                liStartRow += liEachBitmapHeight;
                prloBitmapList.Add(loBitmap);

                // Create a new AutoResetEvent instance for that thread with its initial state set to false
                praoAutoResetEventArray[liThreadNumber] = new AutoResetEvent(false);

                // Add the new thread, with a parameterized start (to allow parameters)
                prloThreadList.Add(new Thread(new ParameterizedThreadStart(ThreadOldStarsFinder)));
            }

            // Now, start the threads
            for (liThreadNumber = 0; liThreadNumber < priProcessorCount; liThreadNumber++)
            {
                prloThreadList[liThreadNumber].Start(liThreadNumber);
            }

            WaitForThreadsToDie();

            ShowBitmapWithOldStars();
    }

        private void butRunBatch_Click(object sender, EventArgs e)
        {
            DirectoryInfo loDirectory;
            FileInfo[] loImageFiles;

            loDirectory = new DirectoryInfo("C:\\NASA");
            // Get the JPG files stored in the path
            loImageFiles = loDirectory.GetFiles("*.JPG");

            // Process each JPG image file found
            foreach (FileInfo loNextImageFile in loImageFiles)
            {
                // Store the Bitmap to be processed in the proOriginalBitmap private variable
                proOriginalBitmap = new Bitmap(Image.FromFile(loNextImageFile.FullName));

                FindOldStarsAndShowResult();

                // Let the PictureBox control update the image
                Application.DoEvents();
            }
        }
    }
}