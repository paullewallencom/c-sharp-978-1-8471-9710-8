using System;
using System.Collections.Generic;
using System.Text;
//NEW CHANGE
using System.Drawing;

namespace SunspotsAnalyzer
{
    class SunspotAnalyzerPiece : ParallelAlgorithmPiece
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

        public SunspotAnalyzerPiece(int priThreadNumberToAssign)
            : base(priThreadNumberToAssign)
        {
            // Add any necessary additional instructions

        }

        public override void ThreadMethod(object poThreadParameter)
        {
            // This is the code that is going to be run by the thread
            // It has access to all the instance variable of this class
            // It receives the instance as a parameter
            // We must typecast poThreadParameter to SunSpotAnalyzerPiece (inherited from ParallelAlgorithmPiece)
            // to gain access to its members
            SunspotAnalyzerPiece loPiece;
            loPiece = (SunspotAnalyzerPiece)poThreadParameter;

            // Retrieve the thread number received in object poThreadParameter, in piThreadNumber property
            long liPieceNumber = loPiece.piThreadNumber;
            // The pixel matrix (bitmap) row number (Y)
            int liRow;
            // The pixel matrix (bitmap) col number (X)
            int liCol;
            // The pixel color
            Color loPixelColor;

        //            // Reset my old stars counter
        //            prliOldStarsCount[liPieceNumber] = 0;
            // Iterate through each pixel matrix (bitmap) rows
            for (liRow = 0; liRow < proBitmap.Height; liRow++)
            {
                // Iterate through each pixel matrix (bitmap) cols
                for (liCol = 0; liCol < proBitmap.Width; liCol++)
                {
                    // Get the pixel Color for liCol and liRow
                    loPixelColor = proBitmap.GetPixel(liCol, liRow);
                    // Change the pixel color (inver the color)
                    proBitmap.SetPixel(liCol, liRow, Color.FromArgb((Int32.MaxValue - loPixelColor.ToArgb())));
                }
            }
            // Code added in the WaitHandle.WaitAll version
            poAutoResetEvent.Set();
        }
    }

    class SunspotAnalyzer : ParallelAlgorithm
    {
        // The Bitmap
        private Bitmap proOriginalBitmap;
        // The resulting bitmap
        private Bitmap proBitmap;
        public Bitmap poBitmap
        {
            get
            {
                return proBitmap;
            }
        }
        // The bitmaps list
        private List<Bitmap> prloBitmapList;
        // The total number of pieces
        private int priTotalPieces;
        public int piTotalPieces
        {
            get
            {
                return priTotalPieces;
            }
        }
        
        public SunspotAnalyzer(Bitmap proBitmap)
        {
            proOriginalBitmap = proBitmap;
            // Create threads taking into account the number of lines in the bitmap
            // And the number of available cores
            priTotalPieces = Environment.ProcessorCount;
            CreateThreads(proOriginalBitmap.Height, priTotalPieces);
            CreateBitmapParts();
        }

        private void CreateBitmapParts()
        {
            // Create the bitmap list
            prloBitmapList = new List<Bitmap>(priTotalPieces);
            int liPieceNumber;

            Bitmap loBitmap;
            for (liPieceNumber = 0; liPieceNumber < priTotalPieces; liPieceNumber++)
            {
                loBitmap = CropBitmap(proOriginalBitmap, new Rectangle(0, (int) prloPieces[liPieceNumber].piBegin, proOriginalBitmap.Width, (int) (prloPieces[liPieceNumber].piEnd - prloPieces[liPieceNumber].piBegin + 1)));
                prloBitmapList.Add(loBitmap);

                // TO ADD IN THE SECOND PHASE
                // Assign the bitmap part corresponding to the piece
                ((SunspotAnalyzerPiece)prloPieces[liPieceNumber]).poBitmap = loBitmap;
            }
        }

        private Bitmap CropBitmap(Bitmap proBitmap, Rectangle proRectangle)
        {
            // Create a new bitmap copying the portion of the original defined by proRectangle
            // and keeping its PixelFormat
            Bitmap loCroppedBitmap = proBitmap.Clone(proRectangle, proBitmap.PixelFormat);
            // Return the cropped bitmap
            return loCroppedBitmap;
        }

        //CHANGE
        // NEW 
        public override void CollectResults()
        {
            // Enter the results collection iteration through the results left in each ParallelAlgorithmPiece
            int liPieceNumber;
            // Each bitmap portion
            Bitmap loBitmap;

            // Create a new bitmap with the whole width and height
            loBitmap = new Bitmap(proOriginalBitmap.Width, proOriginalBitmap.Height);
            Graphics g = Graphics.FromImage((Image)loBitmap);
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

        //CHANGE
        // NEW 
        public override void StartThreadsAsync()
        {
            // Call the garbage collector before starting each thread
            ForceGarbageCollection();
            // Run the base code
            base.StartThreadsAsync();
        }

        //CHANGE
        // NEW 
        public override ParallelAlgorithmPiece CreateParallelAlgorithmPiece(int priThreadNumber)
        {
            return (new SunspotAnalyzerPiece(priThreadNumber));
        }
    }
}
