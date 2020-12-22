namespace OldStarsFinder
{
    partial class frmStarsFinder
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
            this.butFindOldStars = new System.Windows.Forms.Button();
            this.picStarsBitmap = new System.Windows.Forms.PictureBox();
            this.butRunBatch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picStarsBitmap)).BeginInit();
            this.SuspendLayout();
            // 
            // butFindOldStars
            // 
            this.butFindOldStars.BackColor = System.Drawing.Color.Black;
            this.butFindOldStars.Font = new System.Drawing.Font("DicotMedium", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFindOldStars.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.butFindOldStars.Image = global::OldStarsFinder.Properties.Resources.blue_Style_balls_png_favs_whtstars;
            this.butFindOldStars.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butFindOldStars.Location = new System.Drawing.Point(652, 3);
            this.butFindOldStars.Name = "butFindOldStars";
            this.butFindOldStars.Size = new System.Drawing.Size(128, 176);
            this.butFindOldStars.TabIndex = 0;
            this.butFindOldStars.Text = "Find old stars";
            this.butFindOldStars.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butFindOldStars.UseVisualStyleBackColor = false;
            this.butFindOldStars.Click += new System.EventHandler(this.butFindOldStars_Click);
            // 
            // picStarsBitmap
            // 
            this.picStarsBitmap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picStarsBitmap.Image = global::OldStarsFinder.Properties.Resources.NASA_STARTS_01;
            this.picStarsBitmap.Location = new System.Drawing.Point(4, 187);
            this.picStarsBitmap.Name = "picStarsBitmap";
            this.picStarsBitmap.Size = new System.Drawing.Size(775, 572);
            this.picStarsBitmap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStarsBitmap.TabIndex = 1;
            this.picStarsBitmap.TabStop = false;
            // 
            // butRunBatch
            // 
            this.butRunBatch.BackColor = System.Drawing.Color.Black;
            this.butRunBatch.Font = new System.Drawing.Font("DicotMedium", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRunBatch.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.butRunBatch.Image = global::OldStarsFinder.Properties.Resources.JUST_SOME_PIXELS_CLASSIC_PIXEL;
            this.butRunBatch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butRunBatch.Location = new System.Drawing.Point(4, 3);
            this.butRunBatch.Name = "butRunBatch";
            this.butRunBatch.Size = new System.Drawing.Size(128, 176);
            this.butRunBatch.TabIndex = 0;
            this.butRunBatch.Text = "Run batch old stars finder";
            this.butRunBatch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butRunBatch.UseVisualStyleBackColor = false;
            this.butRunBatch.Click += new System.EventHandler(this.butRunBatch_Click);
            // 
            // frmStarsFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OldStarsFinder.Properties.Resources.mars;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 771);
            this.Controls.Add(this.picStarsBitmap);
            this.Controls.Add(this.butRunBatch);
            this.Controls.Add(this.butFindOldStars);
            this.DoubleBuffered = true;
            this.Name = "frmStarsFinder";
            this.Text = "Old stars finder";
            this.Load += new System.EventHandler(this.frmStarsFinder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picStarsBitmap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butFindOldStars;
        private System.Windows.Forms.PictureBox picStarsBitmap;
        private System.Windows.Forms.Button butRunBatch;
    }
}

