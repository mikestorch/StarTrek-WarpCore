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
    public partial class frmMainMenu : Form
    {

        //Variables and Declarations

        String strPrevious = "previous.text";
        String strName = "Geordi La Forge";

        StreamWriter previousWrite;

        public frmMainMenu()
        {
            InitializeComponent();
        }

        //Write Name to File and Start Game

        private void btnPlay_Click(object sender, EventArgs e)
        {
            strName = txtName.Text;

            previousWrite = File.CreateText(strPrevious);

            previousWrite.WriteLine(strName);

            previousWrite.Close();

            //Load frmGame and Begin Game
            frmGame gamestate = new frmGame();
            gamestate.ShowDialog();
        }


        //Exit the Program

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Load the About Page

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }


        //Menu Strip and Context Menu Buttons

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startGame();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startGame();
        }


        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cxtAbout_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }

        //Method to Start Game

        private void startGame()
        {
            strName = txtName.Text;

            previousWrite = File.CreateText(strPrevious);

            previousWrite.WriteLine(strName);

            previousWrite.Close();

            //Load frmGame and Begin Game
            frmGame gamestate = new frmGame();
            gamestate.ShowDialog();
        }

    }
}
