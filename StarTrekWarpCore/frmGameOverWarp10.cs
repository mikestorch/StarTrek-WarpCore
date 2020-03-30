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
    public partial class frmGameOverWarp10 : Form
    {

        String strPrevious = "previous.text";
        String strName = "Michael Storch";

        StreamReader previousRead;

        public frmGameOverWarp10()
        {
            InitializeComponent();
        }

        private void btnExitFail_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGameOverWarp10_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(strPrevious))
                previousRead = File.OpenText(strPrevious);
            else
                MessageBox.Show("Missing Previous Attempt File.");

            strName = previousRead.ReadLine();

            previousRead.Close();

            lblWarp10.Text = "Chief Engineer " + strName + " has achieved Warp 10!";
        }
    }
}
