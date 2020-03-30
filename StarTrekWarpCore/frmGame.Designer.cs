namespace StarTrekWarpCore
{
    partial class frmGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.timGameClock = new System.Windows.Forms.Timer(this.components);
            this.lblGameClock = new System.Windows.Forms.Label();
            this.lblWarpFactor = new System.Windows.Forms.Label();
            this.btnPlasmaIncrease = new System.Windows.Forms.Button();
            this.btnPlasmaDecrease = new System.Windows.Forms.Button();
            this.lblWarpCoreHealth = new System.Windows.Forms.Label();
            this.timButtonWait = new System.Windows.Forms.Timer(this.components);
            this.radWarp9 = new System.Windows.Forms.RadioButton();
            this.radWarp8 = new System.Windows.Forms.RadioButton();
            this.radWarp7 = new System.Windows.Forms.RadioButton();
            this.radWarp1 = new System.Windows.Forms.RadioButton();
            this.radWarp2 = new System.Windows.Forms.RadioButton();
            this.radWarp3 = new System.Windows.Forms.RadioButton();
            this.radWarp4 = new System.Windows.Forms.RadioButton();
            this.radWarp5 = new System.Windows.Forms.RadioButton();
            this.radWarp6 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCoolantDecrease = new System.Windows.Forms.Button();
            this.btnCoolantIncrease = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnContainmentDecrease = new System.Windows.Forms.Button();
            this.btnContainmentIncrease = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.brnRecrystalize = new System.Windows.Forms.Button();
            this.lblWarning01 = new System.Windows.Forms.Label();
            this.lblWarning02 = new System.Windows.Forms.Label();
            this.prgInjector = new System.Windows.Forms.ProgressBar();
            this.lblContainmentFailure = new System.Windows.Forms.Label();
            this.lblRecrystalize = new System.Windows.Forms.Label();
            this.lblInjector = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.radWarp0 = new System.Windows.Forms.RadioButton();
            this.picEngineering = new System.Windows.Forms.PictureBox();
            this.lblCoolant = new System.Windows.Forms.Label();
            this.prgCoolantLevel = new System.Windows.Forms.ProgressBar();
            this.prgContainment = new System.Windows.Forms.ProgressBar();
            this.prgDilithium = new System.Windows.Forms.ProgressBar();
            this.lblContainment = new System.Windows.Forms.Label();
            this.lblDilithium = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.picLcars01 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblEngineer = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picEngineering)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLcars01)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timGameClock
            // 
            this.timGameClock.Tick += new System.EventHandler(this.timGameClock_Tick);
            // 
            // lblGameClock
            // 
            this.lblGameClock.AutoSize = true;
            this.lblGameClock.Location = new System.Drawing.Point(318, 640);
            this.lblGameClock.Name = "lblGameClock";
            this.lblGameClock.Size = new System.Drawing.Size(22, 13);
            this.lblGameClock.TabIndex = 0;
            this.lblGameClock.Text = "0.0";
            this.lblGameClock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWarpFactor
            // 
            this.lblWarpFactor.AutoSize = true;
            this.lblWarpFactor.BackColor = System.Drawing.Color.Bisque;
            this.lblWarpFactor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWarpFactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarpFactor.Location = new System.Drawing.Point(730, 421);
            this.lblWarpFactor.Name = "lblWarpFactor";
            this.lblWarpFactor.Size = new System.Drawing.Size(47, 28);
            this.lblWarpFactor.TabIndex = 1;
            this.lblWarpFactor.Text = "0.0";
            // 
            // btnPlasmaIncrease
            // 
            this.btnPlasmaIncrease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPlasmaIncrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlasmaIncrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlasmaIncrease.Location = new System.Drawing.Point(636, 496);
            this.btnPlasmaIncrease.Name = "btnPlasmaIncrease";
            this.btnPlasmaIncrease.Size = new System.Drawing.Size(75, 23);
            this.btnPlasmaIncrease.TabIndex = 2;
            this.btnPlasmaIncrease.Text = "Increase";
            this.toolTip1.SetToolTip(this.btnPlasmaIncrease, "Increase Warp Power.");
            this.btnPlasmaIncrease.UseVisualStyleBackColor = false;
            this.btnPlasmaIncrease.Click += new System.EventHandler(this.btnPlasmaIncrease_Click);
            // 
            // btnPlasmaDecrease
            // 
            this.btnPlasmaDecrease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPlasmaDecrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlasmaDecrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlasmaDecrease.Location = new System.Drawing.Point(717, 496);
            this.btnPlasmaDecrease.Name = "btnPlasmaDecrease";
            this.btnPlasmaDecrease.Size = new System.Drawing.Size(75, 23);
            this.btnPlasmaDecrease.TabIndex = 3;
            this.btnPlasmaDecrease.Text = "Decrease";
            this.toolTip1.SetToolTip(this.btnPlasmaDecrease, "Decrease Warp Power");
            this.btnPlasmaDecrease.UseVisualStyleBackColor = false;
            this.btnPlasmaDecrease.Click += new System.EventHandler(this.btnPlasmaDecrease_Click);
            // 
            // lblWarpCoreHealth
            // 
            this.lblWarpCoreHealth.AutoSize = true;
            this.lblWarpCoreHealth.BackColor = System.Drawing.Color.Bisque;
            this.lblWarpCoreHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarpCoreHealth.Location = new System.Drawing.Point(321, 423);
            this.lblWarpCoreHealth.Name = "lblWarpCoreHealth";
            this.lblWarpCoreHealth.Size = new System.Drawing.Size(51, 26);
            this.lblWarpCoreHealth.TabIndex = 4;
            this.lblWarpCoreHealth.Text = "100";
            // 
            // timButtonWait
            // 
            this.timButtonWait.Interval = 500;
            this.timButtonWait.Tick += new System.EventHandler(this.timButtonWait_Tick);
            // 
            // radWarp9
            // 
            this.radWarp9.AutoSize = true;
            this.radWarp9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.radWarp9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radWarp9.Location = new System.Drawing.Point(9, 14);
            this.radWarp9.Name = "radWarp9";
            this.radWarp9.Size = new System.Drawing.Size(66, 17);
            this.radWarp9.TabIndex = 5;
            this.radWarp9.Text = "Warp 9";
            this.radWarp9.UseVisualStyleBackColor = false;
            this.radWarp9.CheckedChanged += new System.EventHandler(this.radWarp9_CheckedChanged);
            // 
            // radWarp8
            // 
            this.radWarp8.AutoSize = true;
            this.radWarp8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.radWarp8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radWarp8.Location = new System.Drawing.Point(9, 48);
            this.radWarp8.Name = "radWarp8";
            this.radWarp8.Size = new System.Drawing.Size(66, 17);
            this.radWarp8.TabIndex = 6;
            this.radWarp8.Text = "Warp 8";
            this.radWarp8.UseVisualStyleBackColor = false;
            this.radWarp8.CheckedChanged += new System.EventHandler(this.radWarp8_CheckedChanged);
            // 
            // radWarp7
            // 
            this.radWarp7.AutoSize = true;
            this.radWarp7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.radWarp7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radWarp7.Location = new System.Drawing.Point(9, 82);
            this.radWarp7.Name = "radWarp7";
            this.radWarp7.Size = new System.Drawing.Size(66, 17);
            this.radWarp7.TabIndex = 7;
            this.radWarp7.Text = "Warp 7";
            this.radWarp7.UseVisualStyleBackColor = false;
            this.radWarp7.CheckedChanged += new System.EventHandler(this.radWarp7_CheckedChanged);
            // 
            // radWarp1
            // 
            this.radWarp1.AutoSize = true;
            this.radWarp1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.radWarp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radWarp1.Location = new System.Drawing.Point(9, 286);
            this.radWarp1.Name = "radWarp1";
            this.radWarp1.Size = new System.Drawing.Size(66, 17);
            this.radWarp1.TabIndex = 10;
            this.radWarp1.Text = "Warp 1";
            this.radWarp1.UseVisualStyleBackColor = false;
            this.radWarp1.CheckedChanged += new System.EventHandler(this.radWarp1_CheckedChanged);
            // 
            // radWarp2
            // 
            this.radWarp2.AutoSize = true;
            this.radWarp2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.radWarp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radWarp2.Location = new System.Drawing.Point(9, 252);
            this.radWarp2.Name = "radWarp2";
            this.radWarp2.Size = new System.Drawing.Size(66, 17);
            this.radWarp2.TabIndex = 9;
            this.radWarp2.Text = "Warp 2";
            this.radWarp2.UseVisualStyleBackColor = false;
            this.radWarp2.CheckedChanged += new System.EventHandler(this.radWarp2_CheckedChanged);
            // 
            // radWarp3
            // 
            this.radWarp3.AutoSize = true;
            this.radWarp3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.radWarp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radWarp3.Location = new System.Drawing.Point(9, 218);
            this.radWarp3.Name = "radWarp3";
            this.radWarp3.Size = new System.Drawing.Size(66, 17);
            this.radWarp3.TabIndex = 8;
            this.radWarp3.Text = "Warp 3";
            this.radWarp3.UseVisualStyleBackColor = false;
            this.radWarp3.CheckedChanged += new System.EventHandler(this.radWarp3_CheckedChanged);
            // 
            // radWarp4
            // 
            this.radWarp4.AutoSize = true;
            this.radWarp4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.radWarp4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radWarp4.Location = new System.Drawing.Point(9, 184);
            this.radWarp4.Name = "radWarp4";
            this.radWarp4.Size = new System.Drawing.Size(66, 17);
            this.radWarp4.TabIndex = 13;
            this.radWarp4.Text = "Warp 4";
            this.radWarp4.UseVisualStyleBackColor = false;
            this.radWarp4.CheckedChanged += new System.EventHandler(this.radWarp4_CheckedChanged);
            // 
            // radWarp5
            // 
            this.radWarp5.AutoSize = true;
            this.radWarp5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.radWarp5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radWarp5.Location = new System.Drawing.Point(9, 150);
            this.radWarp5.Name = "radWarp5";
            this.radWarp5.Size = new System.Drawing.Size(66, 17);
            this.radWarp5.TabIndex = 12;
            this.radWarp5.Text = "Warp 5";
            this.radWarp5.UseVisualStyleBackColor = false;
            this.radWarp5.CheckedChanged += new System.EventHandler(this.radWarp5_CheckedChanged);
            // 
            // radWarp6
            // 
            this.radWarp6.AutoSize = true;
            this.radWarp6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.radWarp6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radWarp6.Location = new System.Drawing.Point(9, 116);
            this.radWarp6.Name = "radWarp6";
            this.radWarp6.Size = new System.Drawing.Size(66, 17);
            this.radWarp6.TabIndex = 11;
            this.radWarp6.Text = "Warp 6";
            this.radWarp6.UseVisualStyleBackColor = false;
            this.radWarp6.CheckedChanged += new System.EventHandler(this.radWarp6_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(673, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Warp Power";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(275, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Coolant Level";
            // 
            // btnCoolantDecrease
            // 
            this.btnCoolantDecrease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCoolantDecrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoolantDecrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoolantDecrease.Location = new System.Drawing.Point(319, 496);
            this.btnCoolantDecrease.Name = "btnCoolantDecrease";
            this.btnCoolantDecrease.Size = new System.Drawing.Size(75, 23);
            this.btnCoolantDecrease.TabIndex = 16;
            this.btnCoolantDecrease.Text = "Decrease";
            this.toolTip1.SetToolTip(this.btnCoolantDecrease, "Decrease Coolant Level 20%. \r\nCoolant Levels at 0% will lead \r\nto Anti-Matter Con" +
                    "tainment Failure.");
            this.btnCoolantDecrease.UseVisualStyleBackColor = false;
            this.btnCoolantDecrease.Click += new System.EventHandler(this.btnCoolantDecrease_Click);
            // 
            // btnCoolantIncrease
            // 
            this.btnCoolantIncrease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCoolantIncrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoolantIncrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoolantIncrease.Location = new System.Drawing.Point(238, 496);
            this.btnCoolantIncrease.Name = "btnCoolantIncrease";
            this.btnCoolantIncrease.Size = new System.Drawing.Size(75, 23);
            this.btnCoolantIncrease.TabIndex = 15;
            this.btnCoolantIncrease.Text = "Increase";
            this.toolTip1.SetToolTip(this.btnCoolantIncrease, "Increase Coolant Level 20%.\r\nHigh Coolant Levels may \r\nresult in a Coolant Leak.");
            this.btnCoolantIncrease.UseVisualStyleBackColor = false;
            this.btnCoolantIncrease.Click += new System.EventHandler(this.btnCoolantIncrease_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(452, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Antimatter Containment";
            // 
            // btnContainmentDecrease
            // 
            this.btnContainmentDecrease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnContainmentDecrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContainmentDecrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContainmentDecrease.Location = new System.Drawing.Point(525, 496);
            this.btnContainmentDecrease.Name = "btnContainmentDecrease";
            this.btnContainmentDecrease.Size = new System.Drawing.Size(75, 23);
            this.btnContainmentDecrease.TabIndex = 19;
            this.btnContainmentDecrease.Text = "Decrease";
            this.toolTip1.SetToolTip(this.btnContainmentDecrease, "Divert Energy from Antimatter Containment\r\nto boost Warp Power.");
            this.btnContainmentDecrease.UseVisualStyleBackColor = false;
            this.btnContainmentDecrease.Click += new System.EventHandler(this.btnContainmentDecrease_Click);
            // 
            // btnContainmentIncrease
            // 
            this.btnContainmentIncrease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnContainmentIncrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContainmentIncrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContainmentIncrease.Location = new System.Drawing.Point(444, 496);
            this.btnContainmentIncrease.Name = "btnContainmentIncrease";
            this.btnContainmentIncrease.Size = new System.Drawing.Size(75, 23);
            this.btnContainmentIncrease.TabIndex = 18;
            this.btnContainmentIncrease.Text = "Increase";
            this.toolTip1.SetToolTip(this.btnContainmentIncrease, "Divert Energy from Warp Power \r\nto Increase Antimatter Containment.");
            this.btnContainmentIncrease.UseVisualStyleBackColor = false;
            this.btnContainmentIncrease.Click += new System.EventHandler(this.btnContainmentIncrease_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label4.Location = new System.Drawing.Point(30, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Dilithium Crytal Integrity";
            // 
            // brnRecrystalize
            // 
            this.brnRecrystalize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.brnRecrystalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnRecrystalize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnRecrystalize.Location = new System.Drawing.Point(13, 496);
            this.brnRecrystalize.Name = "brnRecrystalize";
            this.brnRecrystalize.Size = new System.Drawing.Size(186, 23);
            this.brnRecrystalize.TabIndex = 22;
            this.brnRecrystalize.Text = "Recrystalize";
            this.toolTip1.SetToolTip(this.brnRecrystalize, "Recrystalize Dilithium to Restore to \r\n100% Core and Crystal Integrity.\r\nDo NOT A" +
                    "TTEMPT at Warp Speed!");
            this.brnRecrystalize.UseVisualStyleBackColor = false;
            this.brnRecrystalize.Click += new System.EventHandler(this.brnRecrystalize_Click);
            // 
            // lblWarning01
            // 
            this.lblWarning01.AutoSize = true;
            this.lblWarning01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning01.ForeColor = System.Drawing.Color.Red;
            this.lblWarning01.Location = new System.Drawing.Point(642, 468);
            this.lblWarning01.Name = "lblWarning01";
            this.lblWarning01.Size = new System.Drawing.Size(147, 20);
            this.lblWarning01.TabIndex = 23;
            this.lblWarning01.Text = "LIMIT REACHED";
            this.lblWarning01.Visible = false;
            // 
            // lblWarning02
            // 
            this.lblWarning02.AutoSize = true;
            this.lblWarning02.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning02.ForeColor = System.Drawing.Color.Red;
            this.lblWarning02.Location = new System.Drawing.Point(244, 470);
            this.lblWarning02.Name = "lblWarning02";
            this.lblWarning02.Size = new System.Drawing.Size(141, 20);
            this.lblWarning02.TabIndex = 24;
            this.lblWarning02.Text = "COOLANT LEAK";
            this.lblWarning02.Visible = false;
            // 
            // prgInjector
            // 
            this.prgInjector.ForeColor = System.Drawing.Color.Red;
            this.prgInjector.Location = new System.Drawing.Point(706, 531);
            this.prgInjector.Name = "prgInjector";
            this.prgInjector.Size = new System.Drawing.Size(86, 23);
            this.prgInjector.Step = 1;
            this.prgInjector.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgInjector.TabIndex = 25;
            // 
            // lblContainmentFailure
            // 
            this.lblContainmentFailure.AutoSize = true;
            this.lblContainmentFailure.BackColor = System.Drawing.Color.Black;
            this.lblContainmentFailure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContainmentFailure.ForeColor = System.Drawing.Color.Red;
            this.lblContainmentFailure.Location = new System.Drawing.Point(411, 470);
            this.lblContainmentFailure.Name = "lblContainmentFailure";
            this.lblContainmentFailure.Size = new System.Drawing.Size(216, 20);
            this.lblContainmentFailure.TabIndex = 31;
            this.lblContainmentFailure.Text = "CONTAINMENT FAILURE\r\n";
            this.lblContainmentFailure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblContainmentFailure.Visible = false;
            // 
            // lblRecrystalize
            // 
            this.lblRecrystalize.AutoSize = true;
            this.lblRecrystalize.BackColor = System.Drawing.Color.Black;
            this.lblRecrystalize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecrystalize.ForeColor = System.Drawing.Color.Red;
            this.lblRecrystalize.Location = new System.Drawing.Point(29, 470);
            this.lblRecrystalize.Name = "lblRecrystalize";
            this.lblRecrystalize.Size = new System.Drawing.Size(144, 20);
            this.lblRecrystalize.TabIndex = 32;
            this.lblRecrystalize.Text = "RECRYSTALIZE";
            this.lblRecrystalize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRecrystalize.Visible = false;
            // 
            // lblInjector
            // 
            this.lblInjector.AutoSize = true;
            this.lblInjector.BackColor = System.Drawing.Color.SteelBlue;
            this.lblInjector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInjector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblInjector.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblInjector.Location = new System.Drawing.Point(646, 532);
            this.lblInjector.Name = "lblInjector";
            this.lblInjector.Size = new System.Drawing.Size(54, 20);
            this.lblInjector.TabIndex = 33;
            this.lblInjector.Text = "100%";
            this.lblInjector.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(238, 640);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Time Elapsed:";
            // 
            // radWarp0
            // 
            this.radWarp0.AutoSize = true;
            this.radWarp0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.radWarp0.Checked = true;
            this.radWarp0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radWarp0.Location = new System.Drawing.Point(9, 320);
            this.radWarp0.Name = "radWarp0";
            this.radWarp0.Size = new System.Drawing.Size(66, 17);
            this.radWarp0.TabIndex = 38;
            this.radWarp0.TabStop = true;
            this.radWarp0.Text = "Warp 0";
            this.radWarp0.UseVisualStyleBackColor = false;
            this.radWarp0.CheckedChanged += new System.EventHandler(this.radWarp0_CheckedChanged);
            // 
            // picEngineering
            // 
            this.picEngineering.Image = ((System.Drawing.Image)(resources.GetObject("picEngineering.Image")));
            this.picEngineering.Location = new System.Drawing.Point(133, 8);
            this.picEngineering.Name = "picEngineering";
            this.picEngineering.Size = new System.Drawing.Size(678, 449);
            this.picEngineering.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEngineering.TabIndex = 39;
            this.picEngineering.TabStop = false;
            // 
            // lblCoolant
            // 
            this.lblCoolant.AutoSize = true;
            this.lblCoolant.BackColor = System.Drawing.Color.SteelBlue;
            this.lblCoolant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoolant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblCoolant.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCoolant.Location = new System.Drawing.Point(240, 533);
            this.lblCoolant.Name = "lblCoolant";
            this.lblCoolant.Size = new System.Drawing.Size(54, 20);
            this.lblCoolant.TabIndex = 41;
            this.lblCoolant.Text = "100%";
            this.lblCoolant.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // prgCoolantLevel
            // 
            this.prgCoolantLevel.ForeColor = System.Drawing.Color.Red;
            this.prgCoolantLevel.Location = new System.Drawing.Point(300, 532);
            this.prgCoolantLevel.Name = "prgCoolantLevel";
            this.prgCoolantLevel.Size = new System.Drawing.Size(94, 23);
            this.prgCoolantLevel.Step = 20;
            this.prgCoolantLevel.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgCoolantLevel.TabIndex = 40;
            // 
            // prgContainment
            // 
            this.prgContainment.ForeColor = System.Drawing.Color.Red;
            this.prgContainment.Location = new System.Drawing.Point(507, 532);
            this.prgContainment.Name = "prgContainment";
            this.prgContainment.Size = new System.Drawing.Size(93, 23);
            this.prgContainment.Step = 1;
            this.prgContainment.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgContainment.TabIndex = 42;
            // 
            // prgDilithium
            // 
            this.prgDilithium.ForeColor = System.Drawing.Color.Red;
            this.prgDilithium.Location = new System.Drawing.Point(75, 531);
            this.prgDilithium.Name = "prgDilithium";
            this.prgDilithium.Size = new System.Drawing.Size(124, 23);
            this.prgDilithium.Step = 1;
            this.prgDilithium.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgDilithium.TabIndex = 44;
            // 
            // lblContainment
            // 
            this.lblContainment.AutoSize = true;
            this.lblContainment.BackColor = System.Drawing.Color.SteelBlue;
            this.lblContainment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContainment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblContainment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblContainment.Location = new System.Drawing.Point(447, 533);
            this.lblContainment.Name = "lblContainment";
            this.lblContainment.Size = new System.Drawing.Size(54, 20);
            this.lblContainment.TabIndex = 43;
            this.lblContainment.Text = "100%";
            this.lblContainment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDilithium
            // 
            this.lblDilithium.AutoSize = true;
            this.lblDilithium.BackColor = System.Drawing.Color.SteelBlue;
            this.lblDilithium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDilithium.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblDilithium.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblDilithium.Location = new System.Drawing.Point(16, 532);
            this.lblDilithium.Name = "lblDilithium";
            this.lblDilithium.Size = new System.Drawing.Size(54, 20);
            this.lblDilithium.TabIndex = 45;
            this.lblDilithium.Text = "100%";
            this.lblDilithium.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Linen;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(511, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "WARP SPEED FACTOR:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Linen;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(149, 427);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 20);
            this.label9.TabIndex = 47;
            this.label9.Text = "CORE INTEGRITY";
            // 
            // picLcars01
            // 
            this.picLcars01.Image = ((System.Drawing.Image)(resources.GetObject("picLcars01.Image")));
            this.picLcars01.Location = new System.Drawing.Point(3, 8);
            this.picLcars01.Name = "picLcars01";
            this.picLcars01.Size = new System.Drawing.Size(488, 449);
            this.picLcars01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLcars01.TabIndex = 48;
            this.picLcars01.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.radWarp0);
            this.groupBox1.Controls.Add(this.radWarp9);
            this.groupBox1.Controls.Add(this.radWarp4);
            this.groupBox1.Controls.Add(this.radWarp8);
            this.groupBox1.Controls.Add(this.radWarp5);
            this.groupBox1.Controls.Add(this.radWarp7);
            this.groupBox1.Controls.Add(this.radWarp6);
            this.groupBox1.Controls.Add(this.radWarp3);
            this.groupBox1.Controls.Add(this.radWarp1);
            this.groupBox1.Controls.Add(this.radWarp2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(710, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(86, 348);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox1, "Select Warp Factor.");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(724, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 33);
            this.label10.TabIndex = 50;
            this.label10.Text = "SELECT\r\nWARP\r\nFACTOR";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(150, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 14);
            this.label11.TabIndex = 51;
            this.label11.Text = "CHIEF ENGINEER: ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEngineer
            // 
            this.lblEngineer.AutoSize = true;
            this.lblEngineer.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEngineer.ForeColor = System.Drawing.Color.White;
            this.lblEngineer.Location = new System.Drawing.Point(316, 29);
            this.lblEngineer.Name = "lblEngineer";
            this.lblEngineer.Size = new System.Drawing.Size(133, 14);
            this.lblEngineer.TabIndex = 53;
            this.lblEngineer.Text = "MICHAEL STORCH";
            this.lblEngineer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(807, 566);
            this.Controls.Add(this.lblWarning01);
            this.Controls.Add(this.lblEngineer);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblInjector);
            this.Controls.Add(this.prgInjector);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPlasmaDecrease);
            this.Controls.Add(this.btnPlasmaIncrease);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblRecrystalize);
            this.Controls.Add(this.lblContainmentFailure);
            this.Controls.Add(this.lblWarning02);
            this.Controls.Add(this.lblWarpCoreHealth);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblWarpFactor);
            this.Controls.Add(this.lblDilithium);
            this.Controls.Add(this.prgDilithium);
            this.Controls.Add(this.lblContainment);
            this.Controls.Add(this.prgContainment);
            this.Controls.Add(this.lblCoolant);
            this.Controls.Add(this.prgCoolantLevel);
            this.Controls.Add(this.picEngineering);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.brnRecrystalize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnContainmentDecrease);
            this.Controls.Add(this.btnContainmentIncrease);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCoolantDecrease);
            this.Controls.Add(this.btnCoolantIncrease);
            this.Controls.Add(this.lblGameClock);
            this.Controls.Add(this.picLcars01);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Star Trek: Warp Engine Simulator";
            this.Load += new System.EventHandler(this.frmGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picEngineering)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLcars01)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timGameClock;
        private System.Windows.Forms.Label lblGameClock;
        private System.Windows.Forms.Label lblWarpFactor;
        private System.Windows.Forms.Button btnPlasmaIncrease;
        private System.Windows.Forms.Button btnPlasmaDecrease;
        private System.Windows.Forms.Label lblWarpCoreHealth;
        private System.Windows.Forms.Timer timButtonWait;
        private System.Windows.Forms.RadioButton radWarp9;
        private System.Windows.Forms.RadioButton radWarp8;
        private System.Windows.Forms.RadioButton radWarp7;
        private System.Windows.Forms.RadioButton radWarp1;
        private System.Windows.Forms.RadioButton radWarp2;
        private System.Windows.Forms.RadioButton radWarp3;
        private System.Windows.Forms.RadioButton radWarp4;
        private System.Windows.Forms.RadioButton radWarp5;
        private System.Windows.Forms.RadioButton radWarp6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCoolantDecrease;
        private System.Windows.Forms.Button btnCoolantIncrease;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnContainmentDecrease;
        private System.Windows.Forms.Button btnContainmentIncrease;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button brnRecrystalize;
        private System.Windows.Forms.Label lblWarning01;
        private System.Windows.Forms.Label lblWarning02;
        private System.Windows.Forms.ProgressBar prgInjector;
        private System.Windows.Forms.Label lblContainmentFailure;
        private System.Windows.Forms.Label lblRecrystalize;
        private System.Windows.Forms.Label lblInjector;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton radWarp0;
        private System.Windows.Forms.PictureBox picEngineering;
        private System.Windows.Forms.Label lblCoolant;
        private System.Windows.Forms.ProgressBar prgCoolantLevel;
        private System.Windows.Forms.ProgressBar prgContainment;
        private System.Windows.Forms.ProgressBar prgDilithium;
        private System.Windows.Forms.Label lblContainment;
        private System.Windows.Forms.Label lblDilithium;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox picLcars01;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblEngineer;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}