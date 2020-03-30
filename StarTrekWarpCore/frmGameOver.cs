using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StarTrekWarpCore
{
    public partial class frmGameOver : Form
    {

        String strPrevious = "previous.text";
        String strName = "Michael Storch";

        StreamReader previousRead;

        public frmGameOver()
        {
            InitializeComponent();
        }

        private void btnExitFail_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmGameOver_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(strPrevious))
                previousRead = File.OpenText(strPrevious);
            else
                MessageBox.Show("Missing Previous Attempt File.");

            strName = previousRead.ReadLine();

            previousRead.Close();

            lblDestroyed.Text = "Chief Engineer " + strName + " Destroyed the Enterprise!";


        }
    }
}
