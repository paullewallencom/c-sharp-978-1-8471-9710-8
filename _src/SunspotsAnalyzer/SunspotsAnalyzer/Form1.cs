using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
// NEW 
using System.IO;

namespace SunspotsAnalyzer
{
    public partial class frmSunspotsAnalyzer : Form
    {
        public frmSunspotsAnalyzer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AnalyzeSunspotsAndShowResult(Bitmap proBitmap)
        {
            SunspotAnalyzer loSunSpotAnalyzer;

            loSunSpotAnalyzer = new SunspotAnalyzer(proBitmap);
            loSunSpotAnalyzer.RunInParallelSync();
            loSunSpotAnalyzer.CollectResults();
            picSunspots.Image = loSunSpotAnalyzer.poBitmap;
        }

        private void butRunBatch_Click(object sender, EventArgs e)
        {
            DirectoryInfo loDirectory;
            FileInfo[] loImageFiles;
            Bitmap loBitmap;

            // Replace "C:\\NASASUNSPOT" with your images folder path
            loDirectory = new DirectoryInfo("C:\\NASASUNSPOT");
            // Get the JPG files stored in the path
            loImageFiles = loDirectory.GetFiles("*.JPG");

            // Process each JPG image file found
            foreach (FileInfo loNextImageFile in loImageFiles)
            {
                // Store the Bitmap to be processed in the proOriginalBitmap private variable
                loBitmap = new Bitmap(Image.FromFile(loNextImageFile.FullName));

                AnalyzeSunspotsAndShowResult(loBitmap);

                // Let the PictureBox control update the image
                Application.DoEvents();
            }
        }
    }
}