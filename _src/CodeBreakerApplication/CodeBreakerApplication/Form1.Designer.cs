namespace CodeBreakerApplication
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
            this.lblCodeBreaker = new System.Windows.Forms.Label();
            this.lblLabelChar1 = new System.Windows.Forms.Label();
            this.lblLabelChar2 = new System.Windows.Forms.Label();
            this.lblLabelChar3 = new System.Windows.Forms.Label();
            this.lblLabelChar4 = new System.Windows.Forms.Label();
            this.lblOutputChar1 = new System.Windows.Forms.Label();
            this.lblOutputChar2 = new System.Windows.Forms.Label();
            this.lblOutputChar3 = new System.Windows.Forms.Label();
            this.lblOutputChar4 = new System.Windows.Forms.Label();
            this.lblFishesGame = new System.Windows.Forms.Label();
            this.pgbProgressChar1 = new System.Windows.Forms.ProgressBar();
            this.pgbProgressChar2 = new System.Windows.Forms.ProgressBar();
            this.pgbProgressChar3 = new System.Windows.Forms.ProgressBar();
            this.pgbProgressChar4 = new System.Windows.Forms.ProgressBar();
            this.picFish3 = new System.Windows.Forms.PictureBox();
            this.picFish2 = new System.Windows.Forms.PictureBox();
            this.picFish1 = new System.Windows.Forms.PictureBox();
            this.butGameOver = new System.Windows.Forms.Button();
            this.butStop = new System.Windows.Forms.Button();
            this.butHide = new System.Windows.Forms.Button();
            this.butStart = new System.Windows.Forms.Button();
            this.picAgent = new System.Windows.Forms.PictureBox();
            this.picSkull = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFish3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFish2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFish1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSkull)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodeBreaker
            // 
            this.lblCodeBreaker.AutoSize = true;
            this.lblCodeBreaker.Font = new System.Drawing.Font("Chiller", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeBreaker.ForeColor = System.Drawing.Color.Red;
            this.lblCodeBreaker.Location = new System.Drawing.Point(187, 9);
            this.lblCodeBreaker.Name = "lblCodeBreaker";
            this.lblCodeBreaker.Size = new System.Drawing.Size(283, 68);
            this.lblCodeBreaker.TabIndex = 1;
            this.lblCodeBreaker.Text = "CodeBreaker with run-time \r\nBackgroundWorkers";
            // 
            // lblLabelChar1
            // 
            this.lblLabelChar1.AutoSize = true;
            this.lblLabelChar1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelChar1.ForeColor = System.Drawing.Color.White;
            this.lblLabelChar1.Location = new System.Drawing.Point(175, 96);
            this.lblLabelChar1.Name = "lblLabelChar1";
            this.lblLabelChar1.Size = new System.Drawing.Size(62, 44);
            this.lblLabelChar1.TabIndex = 4;
            this.lblLabelChar1.Text = "#1";
            // 
            // lblLabelChar2
            // 
            this.lblLabelChar2.AutoSize = true;
            this.lblLabelChar2.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelChar2.ForeColor = System.Drawing.Color.White;
            this.lblLabelChar2.Location = new System.Drawing.Point(243, 96);
            this.lblLabelChar2.Name = "lblLabelChar2";
            this.lblLabelChar2.Size = new System.Drawing.Size(62, 44);
            this.lblLabelChar2.TabIndex = 4;
            this.lblLabelChar2.Text = "#2";
            // 
            // lblLabelChar3
            // 
            this.lblLabelChar3.AutoSize = true;
            this.lblLabelChar3.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelChar3.ForeColor = System.Drawing.Color.White;
            this.lblLabelChar3.Location = new System.Drawing.Point(311, 96);
            this.lblLabelChar3.Name = "lblLabelChar3";
            this.lblLabelChar3.Size = new System.Drawing.Size(62, 44);
            this.lblLabelChar3.TabIndex = 4;
            this.lblLabelChar3.Text = "#3";
            // 
            // lblLabelChar4
            // 
            this.lblLabelChar4.AutoSize = true;
            this.lblLabelChar4.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelChar4.ForeColor = System.Drawing.Color.White;
            this.lblLabelChar4.Location = new System.Drawing.Point(379, 96);
            this.lblLabelChar4.Name = "lblLabelChar4";
            this.lblLabelChar4.Size = new System.Drawing.Size(62, 44);
            this.lblLabelChar4.TabIndex = 4;
            this.lblLabelChar4.Text = "#4";
            // 
            // lblOutputChar1
            // 
            this.lblOutputChar1.AutoSize = true;
            this.lblOutputChar1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputChar1.ForeColor = System.Drawing.Color.White;
            this.lblOutputChar1.Location = new System.Drawing.Point(175, 160);
            this.lblOutputChar1.Name = "lblOutputChar1";
            this.lblOutputChar1.Size = new System.Drawing.Size(34, 44);
            this.lblOutputChar1.TabIndex = 4;
            this.lblOutputChar1.Text = "*";
            // 
            // lblOutputChar2
            // 
            this.lblOutputChar2.AutoSize = true;
            this.lblOutputChar2.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputChar2.ForeColor = System.Drawing.Color.White;
            this.lblOutputChar2.Location = new System.Drawing.Point(243, 160);
            this.lblOutputChar2.Name = "lblOutputChar2";
            this.lblOutputChar2.Size = new System.Drawing.Size(34, 44);
            this.lblOutputChar2.TabIndex = 4;
            this.lblOutputChar2.Text = "*";
            // 
            // lblOutputChar3
            // 
            this.lblOutputChar3.AutoSize = true;
            this.lblOutputChar3.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputChar3.ForeColor = System.Drawing.Color.White;
            this.lblOutputChar3.Location = new System.Drawing.Point(311, 160);
            this.lblOutputChar3.Name = "lblOutputChar3";
            this.lblOutputChar3.Size = new System.Drawing.Size(34, 44);
            this.lblOutputChar3.TabIndex = 4;
            this.lblOutputChar3.Text = "*";
            // 
            // lblOutputChar4
            // 
            this.lblOutputChar4.AutoSize = true;
            this.lblOutputChar4.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputChar4.ForeColor = System.Drawing.Color.White;
            this.lblOutputChar4.Location = new System.Drawing.Point(379, 160);
            this.lblOutputChar4.Name = "lblOutputChar4";
            this.lblOutputChar4.Size = new System.Drawing.Size(34, 44);
            this.lblOutputChar4.TabIndex = 4;
            this.lblOutputChar4.Text = "*";
            // 
            // lblFishesGame
            // 
            this.lblFishesGame.AutoSize = true;
            this.lblFishesGame.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFishesGame.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblFishesGame.Location = new System.Drawing.Point(294, 28);
            this.lblFishesGame.Name = "lblFishesGame";
            this.lblFishesGame.Size = new System.Drawing.Size(240, 49);
            this.lblFishesGame.TabIndex = 1;
            this.lblFishesGame.Text = "Fishes Game!";
            // 
            // pgbProgressChar1
            // 
            this.pgbProgressChar1.Location = new System.Drawing.Point(12, 146);
            this.pgbProgressChar1.Name = "pgbProgressChar1";
            this.pgbProgressChar1.Size = new System.Drawing.Size(128, 23);
            this.pgbProgressChar1.TabIndex = 8;
            // 
            // pgbProgressChar2
            // 
            this.pgbProgressChar2.Location = new System.Drawing.Point(12, 175);
            this.pgbProgressChar2.Name = "pgbProgressChar2";
            this.pgbProgressChar2.Size = new System.Drawing.Size(128, 23);
            this.pgbProgressChar2.TabIndex = 8;
            // 
            // pgbProgressChar3
            // 
            this.pgbProgressChar3.Location = new System.Drawing.Point(12, 204);
            this.pgbProgressChar3.Name = "pgbProgressChar3";
            this.pgbProgressChar3.Size = new System.Drawing.Size(128, 23);
            this.pgbProgressChar3.TabIndex = 8;
            // 
            // pgbProgressChar4
            // 
            this.pgbProgressChar4.Location = new System.Drawing.Point(12, 232);
            this.pgbProgressChar4.Name = "pgbProgressChar4";
            this.pgbProgressChar4.Size = new System.Drawing.Size(128, 23);
            this.pgbProgressChar4.TabIndex = 8;
            // 
            // picFish3
            // 
            this.picFish3.Image = global::CodeBreakerApplication.Properties.Resources.XFISH_OCTOPUSS;
            this.picFish3.Location = new System.Drawing.Point(387, 408);
            this.picFish3.Name = "picFish3";
            this.picFish3.Size = new System.Drawing.Size(128, 128);
            this.picFish3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picFish3.TabIndex = 7;
            this.picFish3.TabStop = false;
            // 
            // picFish2
            // 
            this.picFish2.Image = global::CodeBreakerApplication.Properties.Resources.XFISH_FISH_3;
            this.picFish2.Location = new System.Drawing.Point(34, 408);
            this.picFish2.Name = "picFish2";
            this.picFish2.Size = new System.Drawing.Size(128, 128);
            this.picFish2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picFish2.TabIndex = 6;
            this.picFish2.TabStop = false;
            // 
            // picFish1
            // 
            this.picFish1.Image = global::CodeBreakerApplication.Properties.Resources.XFISH_FISH_4;
            this.picFish1.Location = new System.Drawing.Point(205, 408);
            this.picFish1.Name = "picFish1";
            this.picFish1.Size = new System.Drawing.Size(128, 128);
            this.picFish1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picFish1.TabIndex = 5;
            this.picFish1.TabStop = false;
            // 
            // butGameOver
            // 
            this.butGameOver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butGameOver.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGameOver.ForeColor = System.Drawing.Color.White;
            this.butGameOver.Image = global::CodeBreakerApplication.Properties.Resources.CLEANER;
            this.butGameOver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butGameOver.Location = new System.Drawing.Point(278, 542);
            this.butGameOver.Name = "butGameOver";
            this.butGameOver.Size = new System.Drawing.Size(237, 138);
            this.butGameOver.TabIndex = 3;
            this.butGameOver.Text = "Game over!!!!";
            this.butGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butGameOver.UseVisualStyleBackColor = true;
            this.butGameOver.Click += new System.EventHandler(this.butGameOver_Click);
            // 
            // butStop
            // 
            this.butStop.Enabled = false;
            this.butStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butStop.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butStop.ForeColor = System.Drawing.Color.White;
            this.butStop.Image = global::CodeBreakerApplication.Properties.Resources.HEINS_HITOOLBOX_REPLACEMENTS_STOP;
            this.butStop.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butStop.Location = new System.Drawing.Point(283, 207);
            this.butStop.Name = "butStop";
            this.butStop.Size = new System.Drawing.Size(119, 173);
            this.butStop.TabIndex = 3;
            this.butStop.Text = "Stop!";
            this.butStop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butStop.UseVisualStyleBackColor = true;
            this.butStop.Click += new System.EventHandler(this.butStop_Click);
            // 
            // butHide
            // 
            this.butHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butHide.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butHide.ForeColor = System.Drawing.Color.White;
            this.butHide.Image = global::CodeBreakerApplication.Properties.Resources.SAVED_FILES;
            this.butHide.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butHide.Location = new System.Drawing.Point(146, 207);
            this.butHide.Name = "butHide";
            this.butHide.Size = new System.Drawing.Size(131, 173);
            this.butHide.TabIndex = 3;
            this.butHide.Text = "Hide!!!!!";
            this.butHide.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butHide.UseVisualStyleBackColor = true;
            this.butHide.Click += new System.EventHandler(this.butHide_Click);
            // 
            // butStart
            // 
            this.butStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butStart.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butStart.ForeColor = System.Drawing.Color.White;
            this.butStart.Image = global::CodeBreakerApplication.Properties.Resources.Lock_Open;
            this.butStart.Location = new System.Drawing.Point(408, 207);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(117, 173);
            this.butStart.TabIndex = 3;
            this.butStart.Text = "Start!";
            this.butStart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // picAgent
            // 
            this.picAgent.Image = global::CodeBreakerApplication.Properties.Resources.User;
            this.picAgent.Location = new System.Drawing.Point(12, 262);
            this.picAgent.Name = "picAgent";
            this.picAgent.Size = new System.Drawing.Size(128, 128);
            this.picAgent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picAgent.TabIndex = 2;
            this.picAgent.TabStop = false;
            // 
            // picSkull
            // 
            this.picSkull.Image = global::CodeBreakerApplication.Properties.Resources.Skul_Colorl;
            this.picSkull.Location = new System.Drawing.Point(12, 12);
            this.picSkull.Name = "picSkull";
            this.picSkull.Size = new System.Drawing.Size(128, 128);
            this.picSkull.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picSkull.TabIndex = 0;
            this.picSkull.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(537, 688);
            this.Controls.Add(this.pgbProgressChar4);
            this.Controls.Add(this.pgbProgressChar3);
            this.Controls.Add(this.pgbProgressChar2);
            this.Controls.Add(this.pgbProgressChar1);
            this.Controls.Add(this.picFish3);
            this.Controls.Add(this.picFish2);
            this.Controls.Add(this.picFish1);
            this.Controls.Add(this.lblOutputChar4);
            this.Controls.Add(this.lblLabelChar4);
            this.Controls.Add(this.lblOutputChar3);
            this.Controls.Add(this.lblLabelChar3);
            this.Controls.Add(this.lblOutputChar2);
            this.Controls.Add(this.lblLabelChar2);
            this.Controls.Add(this.lblOutputChar1);
            this.Controls.Add(this.lblLabelChar1);
            this.Controls.Add(this.butGameOver);
            this.Controls.Add(this.butStop);
            this.Controls.Add(this.butHide);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.picAgent);
            this.Controls.Add(this.lblFishesGame);
            this.Controls.Add(this.lblCodeBreaker);
            this.Controls.Add(this.picSkull);
            this.Name = "frmMain";
            this.Text = "CodeBreaker Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFish3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFish2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFish1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSkull)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSkull;
        private System.Windows.Forms.Label lblCodeBreaker;
        private System.Windows.Forms.PictureBox picAgent;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.Label lblLabelChar1;
        private System.Windows.Forms.Label lblLabelChar2;
        private System.Windows.Forms.Label lblLabelChar3;
        private System.Windows.Forms.Label lblLabelChar4;
        private System.Windows.Forms.Label lblOutputChar1;
        private System.Windows.Forms.Label lblOutputChar2;
        private System.Windows.Forms.Label lblOutputChar3;
        private System.Windows.Forms.Label lblOutputChar4;
        private System.Windows.Forms.PictureBox picFish1;
        private System.Windows.Forms.PictureBox picFish2;
        private System.Windows.Forms.PictureBox picFish3;
        private System.Windows.Forms.Button butHide;
        private System.Windows.Forms.Button butGameOver;
        private System.Windows.Forms.Label lblFishesGame;
        private System.Windows.Forms.ProgressBar pgbProgressChar1;
        private System.Windows.Forms.ProgressBar pgbProgressChar2;
        private System.Windows.Forms.ProgressBar pgbProgressChar3;
        private System.Windows.Forms.ProgressBar pgbProgressChar4;
        private System.Windows.Forms.Button butStop;
    }
}

