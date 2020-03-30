namespace StarTrekWarpCore
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDestroyed = new System.Windows.Forms.Label();
            this.btnExitFail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(523, 293);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblDestroyed
            // 
            this.lblDestroyed.AutoSize = true;
            this.lblDestroyed.BackColor = System.Drawing.Color.Black;
            this.lblDestroyed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestroyed.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblDestroyed.Location = new System.Drawing.Point(12, 306);
            this.lblDestroyed.Name = "lblDestroyed";
            this.lblDestroyed.Size = new System.Drawing.Size(414, 72);
            this.lblDestroyed.TabIndex = 3;
            this.lblDestroyed.Text = "This Program is designed to train Star Fleet engineers\r\nin the basics of operatin" +
                "g and maintaining the \r\nAntimatter Reactors that power the Warp Engines \r\nof Sta" +
                "r Fleet\'s finest ships!\r\n";
            // 
            // btnExitFail
            // 
            this.btnExitFail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnExitFail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitFail.Location = new System.Drawing.Point(432, 379);
            this.btnExitFail.Name = "btnExitFail";
            this.btnExitFail.Size = new System.Drawing.Size(75, 23);
            this.btnExitFail.TabIndex = 4;
            this.btnExitFail.Text = "CLOSE";
            this.btnExitFail.UseVisualStyleBackColor = false;
            this.btnExitFail.Click += new System.EventHandler(this.btnExitFail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(37, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = " - Programmed by Michael Storch";
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(526, 414);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExitFail);
            this.Controls.Add(this.lblDestroyed);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDestroyed;
        private System.Windows.Forms.Button btnExitFail;
        private System.Windows.Forms.Label label1;
    }
}