using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// NEW
using System.Threading;
using System.Drawing;
using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Math;

namespace ImageBrowser
{
    class BrightnessAdjustmentPiece : ParallelAlgorithmPiece
    {
        // The resulting bitmap
        private Bitmap proBitmap;

        public Bitmap poBitmap
        {
            set
            {
                proBitmap = value;
            }
            get
            {
                return proBitmap;
            }
        }

        // The brightness adjustment value
        private double priBrightnessDelta;
        public double piBrightnessDelta
        {
            set
            {
                priBrightnessDelta = value;
            }
            get
            {
                return priBrightnessDelta;
            }
        }

        public BrightnessAdjustmentPiece(int priThreadNumberToAssign)
            : base(priThreadNumberToAssign)
        {
            // Add any necessary additional instructions
        }

        public override void ThreadMethod(object poThreadParameter)
        {
            // This is the code that is going to be run by the thread
            // It has access to all the instance variable of this class
            // It receives the instance as a parameter
            // We must typecast poThreadParameter to BrightnessAdjustmentPiece (inherited from ParallelAlgorithmPiece)
            // to gain access to its members
            BrightnessAdjustmentPiece loPiece;
            loPiece = (BrightnessAdjustmentPiece)poThreadParameter;

            // Retrieve the thread number received in object poThreadParameter, in piThreadNumber property
            long liPieceNumber = loPiece.piThreadNumber;

            //Format the image according to AForge.NET needs to apply the filter
            AForge.Imaging.Image.FormatImage(ref proBitmap);
            // Create an instance of the brightness correction filter
            AForge.Imaging.Filters.BrightnessCorrection loBrightnessCorrection = new AForge.Imaging.Filters.BrightnessCorrection(priBrightnessDelta);
            // Process the image (correct the brightness)
            loBrightnessCorrection.ApplyInPlace(proBitmap);

            // Code added in the WaitHandle.WaitAll version
            // The thread finished its work. Signal that the work item has finished.
            poAutoResetEvent.Set();
        }
    }

    class BrightnessAdjustment : ParallelAlgorithm
    {
        // The Bitmap
        private Bitmap proOriginalBitmap;
        // The brightness adjustment value
        private double priBrightnessDelta;
        // The resulting bitmap
        private Bitmap proBitmap;
        // The bitmaps list
        private List<Bitmap> prloBitmapList;
        // The total number of pieces
        private int priTotalPieces;

        public Bitmap poBitmap
        {
            get
            {
                return proBitmap;
            }
        }
        public int piTotalPieces
        {
            get
            {
                return priTotalPieces;
            }
        }

        public BrightnessAdjustment(Bitmap paroBitmap, double pariBrightnessDelta)
        {
            proOriginalBitmap = paroBitmap;
            priBrightnessDelta = pariBrightnessDelta;
            // Create threads taking into account the number of lines in the bitmap
            // And the number of available cores
            priTotalPieces = Environment.ProcessorCount;
            CreateThreads(proOriginalBitmap.Height, priTotalPieces);
            CreateBitmapParts();
        }

        private Bitmap CropBitmap(Bitmap proBitmap, Rectangle proRectangle)
        {
            // Create a new bitmap copying the portion of the original defined by proRectangle
            // and keeping its PixelFormat
            Bitmap loCroppedBitmap = proBitmap.Clone(proRectangle, proBitmap.PixelFormat);
            // Return the cropped bitmap
            return loCroppedBitmap;
        }

        private void CreateBitmapParts()
        {
            // Create the bitmap list
            prloBitmapList = new List<Bitmap>(priTotalPieces);
            int liPieceNumber;

            Bitmap loBitmap;
            for (liPieceNumber = 0; liPieceNumber < priTotalPieces; liPieceNumber++)
            {
                loBitmap = CropBitmap(proOriginalBitmap, new Rectangle(0, (int)prloPieces[liPieceNumber].piBegin, proOriginalBitmap.Width, (int)(prloPieces[liPieceNumber].piEnd - prloPieces[liPieceNumber].piBegin + 1)));
                prloBitmapList.Add(loBitmap);

                // Assign the bitmap part corresponding to the piece
                ((BrightnessAdjustmentPiece)prloPieces[liPieceNumber]).poBitmap = loBitmap;
                // Assign the brightness adjustment value to the piece
                ((BrightnessAdjustmentPiece)prloPieces[liPieceNumber]).piBrightnessDelta = priBrightnessDelta;
            }
        }

        public override void StartThreadsAsync()
        {
            // Call the garbage collector before starting each thread
            ForceGarbageCollection();
            // Run the base code
            base.StartThreadsAsync();
        }

        public override ParallelAlgorithmPiece CreateParallelAlgorithmPiece(int priThreadNumber)
        {
            return (new BrightnessAdjustmentPiece(priThreadNumber));
        }

        public override void CollectResults()
        {
            // Enter the results collection iteration through the results left in each ParallelAlgorithmPiece
            int liPieceNumber;
            // Each bitmap portion
            Bitmap loBitmap;

            // Create a new bitmap with the whole width and height
            loBitmap = new Bitmap(proOriginalBitmap.Width, proOriginalBitmap.Height);
            Graphics g = Graphics.FromImage((System.Drawing.Image)loBitmap);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            for (liPieceNumber = 0; liPieceNumber < priTotalPieces; liPieceNumber++)
            {
                // Draw each portion in its corresponding absolute starting row
                g.DrawImage(prloBitmapList[liPieceNumber], 0, prloPieces[liPieceNumber].piBegin);
            }
            // Assign the generated bitmap to proBitmap
            proBitmap = loBitmap;

            g.Dispose();
        }
    }
}
