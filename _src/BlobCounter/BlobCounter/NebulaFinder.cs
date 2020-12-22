using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// NEW
using System.Drawing;
using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Math;

namespace BlobCounter
{
    class NebulaFinder
    {
        // The image file name
        private string prsFileName;
        // The resulting bitmap
        private Bitmap proBitmap;
        // The resulting list of blobs
        private List<Blob> praoBlobs;
        // The resulting list of potential nebula blobs
        private List<Blob> praoNebulaBlobs;
        public string psFileName
        {
            get
            {
                return prsFileName;
            }
        }
        public Bitmap poBitmap
        {
            get
            {
                return proBitmap;
            }
        }
        public List<Blob> paoBlobs
        {
            get
            {
                return praoBlobs;
            }
        }
        public List<Blob> paoNebulaBlobs
        {
            get
            {
                return praoNebulaBlobs;
            }
        }

        public static void ForceGarbageCollection()
        {
            GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced);
        }

        public void CountBlobs(string parsFileName)
        {
            Bitmap loBitmap;

            prsFileName = parsFileName;
            // Load the binary bitmap from the file
            loBitmap = (Bitmap)System.Drawing.Bitmap.FromFile(parsFileName);
            // Format the image according to AForge.NET needs to apply the filter
            AForge.Imaging.Image.FormatImage(ref loBitmap);
            // Create an instance of the blob counter algorithm
            AForge.Imaging.BlobCounter loBlobCounter = new AForge.Imaging.BlobCounter();
            // Process the binary image (find the blobs)
            loBlobCounter.ProcessImage(loBitmap);
            // Retrieve the array of found blobs and convert it to a List of Blob instances
            praoBlobs = loBlobCounter.GetObjects(loBitmap).ToList<Blob>();

            // Create a new image with a 24 bpp pixel format
            // We use System.Drawing.Image because there is also an AForge.Imaging.Image
            System.Drawing.Image loNewBitmap = new Bitmap(loBitmap.Width, loBitmap.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            // Create the graphics from the new image
            Graphics g = Graphics.FromImage((System.Drawing.Image)loNewBitmap);
            // Draw the image
            g.DrawImage(loBitmap, 0, 0);
            // Create the a new potential nebula list
            praoNebulaBlobs = new List<Blob>();
            using (Pen loPen = new Pen(Color.CornflowerBlue, 2))
            {
                // Process the blobs found in the image
                foreach (Blob loBlob in praoBlobs)
                {
                    if ((loBlob.Rectangle.Size.Width * loBlob.Rectangle.Size.Height) > 150)
                    {
                        // If the area is greater than 150 pixels, it is a potential nebula
                        praoNebulaBlobs.Add(loBlob);
                        // Draw a rectangle using the pen in the resulting image
                        g.DrawRectangle(loPen, loBlob.Rectangle);
                    }
                }
            }
            // Assign the generated bitmap to proBitmap
            proBitmap = (Bitmap)loNewBitmap;
            g.Dispose();

            //proBitmap.Save(prsFileName + "_OUT");
        }
    }
}
