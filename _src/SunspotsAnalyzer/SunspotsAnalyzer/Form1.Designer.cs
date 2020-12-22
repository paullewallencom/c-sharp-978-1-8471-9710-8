namespace SunspotsAnalyzer
{
    partial class frmSunspotsAnalyzer
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
            this.picSunspots = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSunspots)).BeginInit();
            this.SuspendLayout();
            // 
            // butRunBatch
            // 
            this.butRunBatch.BackColor = System.Drawing.Color.Black;
            this.butRunBatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butRunBatch.Font = new System.Drawing.Font("Playbill", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRunBatch.ForeColor = System.Drawing.Color.Plum;
            this.butRunBatch.Image = global::SunspotsAnalyzer.Properties.Resources.TRITANIUM_SQUARED_ROCKET_SHIP;
            this.butRunBatch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butRunBatch.Location = new System.Drawing.Point(439, 510);
            this.butRunBatch.Name = "butRunBatch";
            this.butRunBatch.Size = new System.Drawing.Size(338, 140);
            this.butRunBatch.TabIndex = 0;
            this.butRunBatch.Text = "Run sunspots analyzer batch";
            this.butRunBatch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butRunBatch.UseVisualStyleBackColor = false;
            this.butRunBatch.Click += new System.EventHandler(this.butRunBatch_Click);
            // 
            // picSunspots
            // 
            this.picSunspots.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSunspots.Location = new System.Drawing.Point(2, 5);
            this.picSunspots.Name = "picSunspots";
            this.picSunspots.Size = new System.Drawing.Size(775, 490);
            this.picSunspots.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSunspots.TabIndex = 2;
            this.picSunspots.TabStop = false;
            // 
            // frmSunspotsAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SunspotsAnalyzer.Properties.Resources.sun_small;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(779, 653);
            this.Controls.Add(this.picSunspots);
            this.Controls.Add(this.butRunBatch);
            this.Name = "frmSunspotsAnalyzer";
            this.Text = "Sunspots analyzer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSunspots)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butRunBatch;
        private System.Windows.Forms.PictureBox picSunspots;
    }
}

