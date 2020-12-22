namespace MarsEncrypter
{
    partial class frmMarsEncrypter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMarsEncrypter));
            this.fswCheckForNewFiles = new System.IO.FileSystemWatcher();
            this.lblFilesProcessed = new System.Windows.Forms.Label();
            this.libFilesEncrypted = new System.Windows.Forms.ListBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picRover = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvFilesToEncryptProgress = new System.Windows.Forms.DataGridView();
            this.lblCounter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fswCheckForNewFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilesToEncryptProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // fswCheckForNewFiles
            // 
            this.fswCheckForNewFiles.EnableRaisingEvents = true;
            this.fswCheckForNewFiles.NotifyFilter = System.IO.NotifyFilters.LastAccess;
            this.fswCheckForNewFiles.Path = "C:\\MARSCOMMANDS\\INPUT";
            this.fswCheckForNewFiles.SynchronizingObject = this;
            this.fswCheckForNewFiles.Created += new System.IO.FileSystemEventHandler(this.fswCheckForNewFiles_Created);
            this.fswCheckForNewFiles.Changed += new System.IO.FileSystemEventHandler(this.fswCheckForNewFiles_Changed);
            // 
            // lblFilesProcessed
            // 
            this.lblFilesProcessed.AutoSize = true;
            this.lblFilesProcessed.Font = new System.Drawing.Font("DicotBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilesProcessed.Location = new System.Drawing.Point(569, 9);
            this.lblFilesProcessed.Name = "lblFilesProcessed";
            this.lblFilesProcessed.Size = new System.Drawing.Size(234, 26);
            this.lblFilesProcessed.TabIndex = 0;
            this.lblFilesProcessed.Text = "Files processed; Threads";
            // 
            // libFilesEncrypted
            // 
            this.libFilesEncrypted.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libFilesEncrypted.FormattingEnabled = true;
            this.libFilesEncrypted.ItemHeight = 30;
            this.libFilesEncrypted.Location = new System.Drawing.Point(12, 374);
            this.libFilesEncrypted.Name = "libFilesEncrypted";
            this.libFilesEncrypted.Size = new System.Drawing.Size(791, 64);
            this.libFilesEncrypted.TabIndex = 2;
            this.libFilesEncrypted.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::MarsEncrypter.Properties.Resources.ScriptBlocking;
            this.pictureBox4.Location = new System.Drawing.Point(16, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(49, 42);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(235, 67);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(49, 42);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 7;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(180, 67);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(49, 42);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 8;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(235, 12);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(49, 42);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 9;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(181, 12);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(49, 42);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(126, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(49, 42);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::MarsEncrypter.Properties.Resources.ScriptBlocking;
            this.pictureBox5.Location = new System.Drawing.Point(71, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(49, 42);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MarsEncrypter.Properties.Resources.Sol952B_P2389_L257atc_withNew_Rover_v008_br;
            this.pictureBox3.Location = new System.Drawing.Point(16, 168);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(500, 200);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // picRover
            // 
            this.picRover.Image = global::MarsEncrypter.Properties.Resources.rover2;
            this.picRover.Location = new System.Drawing.Point(522, 115);
            this.picRover.Name = "picRover";
            this.picRover.Size = new System.Drawing.Size(281, 253);
            this.picRover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRover.TabIndex = 5;
            this.picRover.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MarsEncrypter.Properties.Resources.World_Of_Aqua_4_The_Flying_Sub;
            this.pictureBox2.Location = new System.Drawing.Point(31, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 124);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MarsEncrypter.Properties.Resources.GLOBES_MARS;
            this.pictureBox1.Location = new System.Drawing.Point(290, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // dgvFilesToEncryptProgress
            // 
            this.dgvFilesToEncryptProgress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilesToEncryptProgress.Location = new System.Drawing.Point(12, 375);
            this.dgvFilesToEncryptProgress.Name = "dgvFilesToEncryptProgress";
            this.dgvFilesToEncryptProgress.Size = new System.Drawing.Size(787, 324);
            this.dgvFilesToEncryptProgress.TabIndex = 10;
            // 
            // lblCounter
            // 
            this.lblCounter.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter.Location = new System.Drawing.Point(508, 43);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(291, 60);
            this.lblCounter.TabIndex = 11;
            this.lblCounter.Text = "124";
            this.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmMarsEncrypter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 710);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.dgvFilesToEncryptProgress);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.picRover);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.libFilesEncrypted);
            this.Controls.Add(this.lblFilesProcessed);
            this.Name = "frmMarsEncrypter";
            this.Text = "Mars Encrypter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fswCheckForNewFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilesToEncryptProgress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fswCheckForNewFiles;
        private System.Windows.Forms.Label lblFilesProcessed;
        private System.Windows.Forms.ListBox libFilesEncrypted;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picRover;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dgvFilesToEncryptProgress;
        private System.Windows.Forms.Label lblCounter;
    }
}

