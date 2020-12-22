namespace SMSEncryption
{
    partial class frmSMSEncryptionEngine
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
            this.txtOriginalSMS = new System.Windows.Forms.TextBox();
            this.txtEncryptedSMS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butRunInThread = new System.Windows.Forms.Button();
            this.butTest = new System.Windows.Forms.Button();
            this.bakShowEncryptedStrings = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumberOfSMSEncrypted = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOriginalSMS
            // 
            this.txtOriginalSMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOriginalSMS.Location = new System.Drawing.Point(147, 135);
            this.txtOriginalSMS.MaxLength = 0;
            this.txtOriginalSMS.Multiline = true;
            this.txtOriginalSMS.Name = "txtOriginalSMS";
            this.txtOriginalSMS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOriginalSMS.Size = new System.Drawing.Size(530, 110);
            this.txtOriginalSMS.TabIndex = 1;
            // 
            // txtEncryptedSMS
            // 
            this.txtEncryptedSMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtEncryptedSMS.Location = new System.Drawing.Point(147, 280);
            this.txtEncryptedSMS.MaxLength = 0;
            this.txtEncryptedSMS.Multiline = true;
            this.txtEncryptedSMS.Name = "txtEncryptedSMS";
            this.txtEncryptedSMS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEncryptedSMS.Size = new System.Drawing.Size(530, 206);
            this.txtEncryptedSMS.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zurich BlkEx BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "SMS Encryption Engine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DicotBold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Original SMS Messages";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("DicotBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(149, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(367, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Encrypted SMS Messages (by thread 1)";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SMSEncryption.Properties.Resources.Motorola_e1000__PNG__128x128_;
            this.pictureBox3.Location = new System.Drawing.Point(549, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(128, 128);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SMSEncryption.Properties.Resources.ICON_;
            this.pictureBox2.Location = new System.Drawing.Point(13, 146);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::SMSEncryption.Properties.Resources.ScriptBlocking;
            this.pictureBox10.Location = new System.Drawing.Point(482, 52);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(49, 42);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 2;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::SMSEncryption.Properties.Resources.ScriptBlocking;
            this.pictureBox9.Location = new System.Drawing.Point(427, 52);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(49, 42);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 2;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::SMSEncryption.Properties.Resources.ScriptBlocking;
            this.pictureBox8.Location = new System.Drawing.Point(372, 52);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(49, 42);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 2;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::SMSEncryption.Properties.Resources.ScriptBlocking;
            this.pictureBox7.Location = new System.Drawing.Point(318, 52);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(49, 42);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 2;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::SMSEncryption.Properties.Resources.ScriptBlocking;
            this.pictureBox6.Location = new System.Drawing.Point(263, 52);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(49, 42);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::SMSEncryption.Properties.Resources.ScriptBlocking;
            this.pictureBox5.Location = new System.Drawing.Point(208, 52);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(49, 42);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SMSEncryption.Properties.Resources.ScriptBlocking;
            this.pictureBox4.Location = new System.Drawing.Point(153, 52);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(49, 42);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SMSEncryption.Properties.Resources.AQUA_ICONS_SYSTEM_GLOBE;
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // butRunInThread
            // 
            this.butRunInThread.Font = new System.Drawing.Font("DicotBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRunInThread.Image = global::SMSEncryption.Properties.Resources.AQUA_ICONS_APPLICATIONS_STUFFIT_EXPAN;
            this.butRunInThread.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butRunInThread.Location = new System.Drawing.Point(13, 398);
            this.butRunInThread.Name = "butRunInThread";
            this.butRunInThread.Size = new System.Drawing.Size(128, 177);
            this.butRunInThread.TabIndex = 0;
            this.butRunInThread.Text = "Run in a thread";
            this.butRunInThread.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butRunInThread.UseVisualStyleBackColor = true;
            this.butRunInThread.Click += new System.EventHandler(this.butRunInThread_Click);
            // 
            // butTest
            // 
            this.butTest.Font = new System.Drawing.Font("DicotBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTest.Image = global::SMSEncryption.Properties.Resources.CHATBUBBLES_CHAT;
            this.butTest.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butTest.Location = new System.Drawing.Point(13, 280);
            this.butTest.Name = "butTest";
            this.butTest.Size = new System.Drawing.Size(128, 112);
            this.butTest.TabIndex = 0;
            this.butTest.Text = "Test";
            this.butTest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butTest.UseVisualStyleBackColor = true;
            this.butTest.Click += new System.EventHandler(this.butTest_Click);
            // 
            // bakShowEncryptedStrings
            // 
            this.bakShowEncryptedStrings.WorkerReportsProgress = true;
            this.bakShowEncryptedStrings.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bakShowEncryptedStrings_DoWork);
            this.bakShowEncryptedStrings.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bakShowEncryptedStrings_ProgressChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("DicotBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(142, 489);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(459, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of SMS Messages encrypted  by thread 1";
            // 
            // lblNumberOfSMSEncrypted
            // 
            this.lblNumberOfSMSEncrypted.AutoSize = true;
            this.lblNumberOfSMSEncrypted.Font = new System.Drawing.Font("DicotBold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfSMSEncrypted.Location = new System.Drawing.Point(607, 489);
            this.lblNumberOfSMSEncrypted.Name = "lblNumberOfSMSEncrypted";
            this.lblNumberOfSMSEncrypted.Size = new System.Drawing.Size(25, 26);
            this.lblNumberOfSMSEncrypted.TabIndex = 3;
            this.lblNumberOfSMSEncrypted.Text = "0";
            // 
            // frmSMSEncryptionEngine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 577);
            this.Controls.Add(this.txtOriginalSMS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNumberOfSMSEncrypted);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtEncryptedSMS);
            this.Controls.Add(this.butRunInThread);
            this.Controls.Add(this.butTest);
            this.Name = "frmSMSEncryptionEngine";
            this.Text = "SMS Encryption Engine";
            this.Load += new System.EventHandler(this.frmSMSEncryptionEngine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butTest;
        private System.Windows.Forms.TextBox txtOriginalSMS;
        private System.Windows.Forms.TextBox txtEncryptedSMS;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Button butRunInThread;
        private System.ComponentModel.BackgroundWorker bakShowEncryptedStrings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNumberOfSMSEncrypted;
    }
}

