namespace ImageBrowser
{
    partial class frmMain
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
            this.pnlFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.staStatusStrip = new System.Windows.Forms.StatusStrip();
            this.tstThumbnailsProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.staStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFlowLayoutPanel
            // 
            this.pnlFlowLayoutPanel.AutoScroll = true;
            this.pnlFlowLayoutPanel.BackgroundImage = global::ImageBrowser.Properties.Resources.background_thumbnails;
            this.pnlFlowLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlFlowLayoutPanel.Name = "pnlFlowLayoutPanel";
            this.pnlFlowLayoutPanel.Size = new System.Drawing.Size(823, 520);
            this.pnlFlowLayoutPanel.TabIndex = 2;
            this.pnlFlowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFlowLayoutPanel_Paint);
            // 
            // staStatusStrip
            // 
            this.staStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstThumbnailsProgress});
            this.staStatusStrip.Location = new System.Drawing.Point(0, 520);
            this.staStatusStrip.Name = "staStatusStrip";
            this.staStatusStrip.Size = new System.Drawing.Size(823, 22);
            this.staStatusStrip.TabIndex = 5;
            this.staStatusStrip.Text = "statusStrip1";
            // 
            // tstThumbnailsProgress
            // 
            this.tstThumbnailsProgress.Name = "tstThumbnailsProgress";
            this.tstThumbnailsProgress.Size = new System.Drawing.Size(800, 16);
            this.tstThumbnailsProgress.Click += new System.EventHandler(this.toolStripProgressBar1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 542);
            this.Controls.Add(this.pnlFlowLayoutPanel);
            this.Controls.Add(this.staStatusStrip);
            this.DoubleBuffered = true;
            this.Name = "frmMain";
            this.Opacity = 0;
            this.Text = "Brightness Adjustment Browser for Digital Images";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.staStatusStrip.ResumeLayout(false);
            this.staStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlFlowLayoutPanel;
        private System.Windows.Forms.StatusStrip staStatusStrip;
        private System.Windows.Forms.ToolStripProgressBar tstThumbnailsProgress;

    }
}

