namespace BlobCounter
{
    partial class frmNebulaFinder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.butRunBatch = new System.Windows.Forms.Button();
            this.picResultingBitmap = new System.Windows.Forms.PictureBox();
            this.butShowResults = new System.Windows.Forms.Button();
            this.bakDisplayImages = new System.ComponentModel.BackgroundWorker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picResultingBitmap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // butRunBatch
            // 
            this.butRunBatch.Font = new System.Drawing.Font("Onyx", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRunBatch.Image = global::BlobCounter.Properties.Resources.blue_Style_balls_png_konfabulator;
            this.butRunBatch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butRunBatch.Location = new System.Drawing.Point(535, 716);
            this.butRunBatch.Name = "butRunBatch";
            this.butRunBatch.Size = new System.Drawing.Size(300, 63);
            this.butRunBatch.TabIndex = 0;
            this.butRunBatch.Text = "Run batch";
            this.butRunBatch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butRunBatch.UseVisualStyleBackColor = true;
            this.butRunBatch.Click += new System.EventHandler(this.butRunBatch_Click);
            // 
            // picResultingBitmap
            // 
            this.picResultingBitmap.BackColor = System.Drawing.Color.Transparent;
            this.picResultingBitmap.Location = new System.Drawing.Point(12, 2);
            this.picResultingBitmap.Name = "picResultingBitmap";
            this.picResultingBitmap.Size = new System.Drawing.Size(823, 635);
            this.picResultingBitmap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResultingBitmap.TabIndex = 1;
            this.picResultingBitmap.TabStop = false;
            // 
            // butShowResults
            // 
            this.butShowResults.Font = new System.Drawing.Font("Onyx", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butShowResults.Image = global::BlobCounter.Properties.Resources.SNOW_E_2_TOOLBAR__áPICTURES;
            this.butShowResults.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butShowResults.Location = new System.Drawing.Point(535, 643);
            this.butShowResults.Name = "butShowResults";
            this.butShowResults.Size = new System.Drawing.Size(300, 67);
            this.butShowResults.TabIndex = 3;
            this.butShowResults.Text = "Show results";
            this.butShowResults.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butShowResults.UseVisualStyleBackColor = true;
            this.butShowResults.Click += new System.EventHandler(this.butShowResults_Click);
            // 
            // bakDisplayImages
            // 
            this.bakDisplayImages.WorkerSupportsCancellation = true;
            this.bakDisplayImages.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bakDisplayImages_DoWork);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::BlobCounter.Properties.Resources.WOA_CandyBar_Toolbar___FInd;
            this.pictureBox2.Location = new System.Drawing.Point(12, 654);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 125);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::BlobCounter.Properties.Resources.SNOW_E_2_TOOLBAR___FIND;
            this.pictureBox3.Location = new System.Drawing.Point(133, 654);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(127, 125);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::BlobCounter.Properties.Resources.SNOW_E_2_APPLICATION___IMOVIE;
            this.pictureBox4.Location = new System.Drawing.Point(257, 654);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(127, 125);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // frmNebulaFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlobCounter.Properties.Resources.NEBULA_BACKGROUND;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 788);
            this.Controls.Add(this.butRunBatch);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.butShowResults);
            this.Controls.Add(this.picResultingBitmap);
            this.DoubleBuffered = true;
            this.Name = "frmNebulaFinder";
            this.Text = "Nebula finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picResultingBitmap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butRunBatch;
        private System.Windows.Forms.PictureBox picResultingBitmap;
        private System.Windows.Forms.Button butShowResults;
        private System.ComponentModel.BackgroundWorker bakDisplayImages;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

