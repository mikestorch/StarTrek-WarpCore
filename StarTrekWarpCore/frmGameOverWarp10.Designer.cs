namespace StarTrekWarpCore
{
    partial class frmGameOverWarp10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameOverWarp10));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblWarp10 = new System.Windows.Forms.Label();
            this.btnExitFail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(586, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblWarp10
            // 
            this.lblWarp10.AutoSize = true;
            this.lblWarp10.BackColor = System.Drawing.Color.Black;
            this.lblWarp10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarp10.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblWarp10.Location = new System.Drawing.Point(23, 272);
            this.lblWarp10.Name = "lblWarp10";
            this.lblWarp10.Size = new System.Drawing.Size(397, 20);
            this.lblWarp10.TabIndex = 4;
            this.lblWarp10.Text = "Chief Engineer Storch Destroyed the Enterprise!";
            // 
            // btnExitFail
            // 
            this.btnExitFail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnExitFail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitFail.Location = new System.Drawing.Point(27, 23);
            this.btnExitFail.Name = "btnExitFail";
            this.btnExitFail.Size = new System.Drawing.Size(75, 23);
            this.btnExitFail.TabIndex = 3;
            this.btnExitFail.Text = "CLOSE";
            this.btnExitFail.UseVisualStyleBackColor = false;
            this.btnExitFail.Click += new System.EventHandler(this.btnExitFail_Click);
            // 
            // frmGameOverWarp10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 312);
            this.Controls.Add(this.lblWarp10);
            this.Controls.Add(this.btnExitFail);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmGameOverWarp10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "You Reached Warp 10!";
            this.Load += new System.EventHandler(this.frmGameOverWarp10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblWarp10;
        private System.Windows.Forms.Button btnExitFail;

    }
}