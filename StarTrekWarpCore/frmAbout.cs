﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StarTrekWarpCore
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        //Close The About Form When Button is Clicked

        private void btnExitFail_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
