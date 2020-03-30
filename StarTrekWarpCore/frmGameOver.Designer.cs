namespace StarTrekWarpCore
{
    partial class frmGameOver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameOver));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExitFail = new System.Windows.Forms.Button();
            this.lblDestroyed = new System.Windows.Forms.Label();
            this.lblPrevious = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(583, 309);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnExitFail
            // 
            this.btnExitFail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnExitFail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitFail.Location = new System.Drawing.Point(25, 23);
            this.btnExitFail.Name = "btnExitFail";
            this.btnExitFail.Size = new System.Drawing.Size(75, 23);
            this.btnExitFail.TabIndex = 1;
            this.btnExitFail.Text = "CLOSE";
            this.btnExitFail.UseVisualStyleBackColor = false;
            this.btnExitFail.Click += new System.EventHandler(this.btnExitFail_Click);
            // 
            // lblDestroyed
            // 
            this.lblDestroyed.AutoSize = true;
            this.lblDestroyed.BackColor = System.Drawing.Color.Black;
            this.lblDestroyed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestroyed.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblDestroyed.Location = new System.Drawing.Point(21, 272);
            this.lblDestroyed.Name = "lblDestroyed";
            this.lblDestroyed.Size = new System.Drawing.Size(397, 20);
            this.lblDestroyed.TabIndex = 2;
            this.lblDestroyed.Text = "Chief Engineer Storch Destroyed the Enterprise!";
            // 
            // lblPrevious
            // 
            this.lblPrevious.AutoSize = true;
            this.lblPrevious.Location = new System.Drawing.Point(167, 81);
            this.lblPrevious.Name = "lblPrevious";
            this.lblPrevious.Size = new System.Drawing.Size(0, 13);
            this.lblPrevious.TabIndex = 3;
            // 
            // frmGameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 312);
            this.Controls.Add(this.lblPrevious);
            this.Controls.Add(this.lblDestroyed);
            this.Controls.Add(this.btnExitFail);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmGameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Over!";
            this.Load += new System.EventHandler(this.frmGameOver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExitFail;
        private System.Windows.Forms.Label lblDestroyed;
        private System.Windows.Forms.Label lblPrevious;
    }
}