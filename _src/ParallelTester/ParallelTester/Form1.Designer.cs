namespace ParallelTester
{
    partial class frmParallelPerformance
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
            this.lblSeconds = new System.Windows.Forms.Label();
            this.pgbLoopProgress = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSeconds
            // 
            this.lblSeconds.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeconds.Location = new System.Drawing.Point(272, 9);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(292, 27);
            this.lblSeconds.TabIndex = 5;
            this.lblSeconds.Text = "seconds to complete";
            this.lblSeconds.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pgbLoopProgress
            // 
            this.pgbLoopProgress.Location = new System.Drawing.Point(138, 111);
            this.pgbLoopProgress.Name = "pgbLoopProgress";
            this.pgbLoopProgress.Size = new System.Drawing.Size(426, 23);
            this.pgbLoopProgress.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ParallelTester.Properties.Resources.BREAKFAST__TIME_TO_GET_UP;
            this.pictureBox1.Location = new System.Drawing.Point(138, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // butStart
            // 
            this.butStart.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butStart.Image = global::ParallelTester.Properties.Resources.AQUA_ICONS_APPLICATIONS_WMP;
            this.butStart.Location = new System.Drawing.Point(7, 9);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(125, 125);
            this.butStart.TabIndex = 3;
            this.butStart.Text = "Start";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // frmParallelPerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 148);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.pgbLoopProgress);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butStart);
            this.Name = "frmParallelPerformance";
            this.Text = "Parallel performance tester";
            this.Load += new System.EventHandler(this.frmParallelPerformance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.ProgressBar pgbLoopProgress;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

