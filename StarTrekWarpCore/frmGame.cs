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
    public partial class frmGame : Form
    {
        public frmGame()
        {
            InitializeComponent();
        }

        //Variables and Declarations

        double time = 0.0;
        double dblWarpFactor = 0.0;
        double dblWarpCoreHealth = 100;

        double dblPlasmaInjector = 0;
        double dblInjectorMax = 100;
        int intCoolantLevel = 20;
        double dblContainment = 100;
        double dblDilithiumIntegrity = 100;

        double dblInjectorPercent = 0;

        double dblPercent = 0;

        double dblButtonWait;
        Boolean blnGameOver = false;
        
        bool blnStop = true;
        Boolean blnWarning01 = false;
        Boolean blnWarning02 = false;

        String strPrevious = "previous.text";
        String strName = "Geordi La Forge";

        StreamReader previousRead;


        //Form Load Defaults

        private void frmGame_Load(object sender, EventArgs e)
        {


            if (System.IO.File.Exists(strPrevious))
                previousRead = File.OpenText(strPrevious);
            else
                MessageBox.Show("Missing Previous Attempt File.");

            strName = previousRead.ReadLine();

            previousRead.Close();

            lblEngineer.Text = strName;

            //Sets Injector Max
            dblInjectorMax = 92;

            //Starts Game Clock and Begins Game
            timGameClock.Enabled = true;
        }

        //MAIN GAME LOOP / TIMER

        private void timGameClock_Tick(object sender, EventArgs e)
        {

                //Main Game Clock / Updates as Changes Made

                time += Convert.ToDouble(timGameClock.Interval) / 1000;
                lblGameClock.Text = String.Format("{0:f1}", time);
                lblGameClock.Refresh();

                //Update Warp Factor From Radio Buttons andChange Radio Button Selected if Warp Power Changes Warp

                //Warp Zero is Selected Via Radio Button

                if (blnGameOver == false)
                {
                    if (blnStop == false)
                    {
                        if (radWarp0.Checked == true)
                        {
                            if (dblWarpFactor > 0)
                            {
                                dblWarpFactor = dblWarpFactor - 0.2;
                                btnPlasmaIncrease.Enabled = false;
                                btnPlasmaDecrease.Enabled = false;
                                blnStop = false;

                                if (dblWarpFactor <= 0)
                                    dblWarpFactor = 0;
                            }
                            else if (dblWarpFactor <= 0)
                            {
                                btnPlasmaIncrease.Enabled = true;
                                btnPlasmaDecrease.Enabled = true;
                                blnStop = true;
                            }
                        }

                    //If Other Warp Factors are Selected Via Radio Button

                        else if (radWarp1.Checked == true)
                            rad_Warp(1);

                        else if (radWarp2.Checked == true)
                            rad_Warp(2);

                        else if (radWarp3.Checked == true)
                            rad_Warp(3);

                        else if (radWarp4.Checked == true)
                            rad_Warp(4);

                        else if (radWarp5.Checked == true)
                            rad_Warp(5);

                        else if (radWarp6.Checked == true)
                            rad_Warp(6);

                        else if (radWarp7.Checked == true)
                            rad_Warp(7);

                        else if (radWarp8.Checked == true)
                            rad_Warp(8);

                        else if (radWarp9.Checked == true)
                            rad_Warp(9);
                    }


                    //Warp Factor Effect on Warp Core Heatlh


                    if ((dblWarpFactor > 0) && (dblWarpFactor <= 7.0))
                        dblContainment = dblContainment - 0.0025;
                    else if ((dblWarpFactor >= 7.1) && (dblWarpFactor <= 8.0))
                        dblContainment = dblContainment - 0.005;
                    else if ((dblWarpFactor >= 8.1) && (dblWarpFactor <= 9.0))
                        dblContainment = dblContainment - 0.01;
                    else if ((dblWarpFactor >= 9.1) && (dblWarpFactor <= 9.5))
                        dblContainment = dblContainment - 0.02;
                    else if (dblWarpFactor >= 9.6)
                        dblContainment = dblContainment - 0.05;

                    //Update Labels, Graphics, and Progress Bars

                    //Update Warp Factor and Warp Power Labels

                    lblWarpFactor.Text = String.Format("{0:f1}", dblWarpFactor);
                    lblWarpFactor.Refresh();


                    //dblWarpFactor = dblPlasmaInjector / 10;

                    if ((dblWarpFactor * 10) > dblInjectorMax)
                        dblWarpFactor = dblWarpFactor - 0.01;

                    dblPlasmaInjector = dblWarpFactor * 10;

                    //Decrement Plasma if Over Injector Max

                    if (dblPlasmaInjector <= 0)
                        dblPlasmaInjector = 0;

                    dblInjectorPercent = dblPlasmaInjector;

                    dblInjectorPercent = dblInjectorPercent / 100;

                    lblInjector.Text = dblInjectorPercent.ToString("P0");

                    lblInjector.Refresh();


                    //Warning Updates

                    //Injector Warning Update

                    if (blnWarning01 == true)
                        lblWarning01.Visible = true;
                    else
                        lblWarning01.Visible = false;

                    if ((dblPlasmaInjector > 0) && (dblPlasmaInjector < dblInjectorMax))
                        prgInjector.Value = Convert.ToInt32(dblPlasmaInjector);
                    else if (dblPlasmaInjector >= dblInjectorMax)
                    {
                        prgInjector.Value = 100;
                    }
                    else
                    {
                        dblPlasmaInjector = 0;
                        prgInjector.Value = 0;
                    }

                    lblInjector.Refresh();

                    //Coolant Leak Warning / Update

                    if (intCoolantLevel == 100)
                    {
                        Random coolantleak = new Random();
                        int leak = coolantleak.Next(0,50);

                        if (leak == 5)
                            blnWarning02 = true;
                    }
                    else if (intCoolantLevel == 80)
                    {
                        Random coolantleak = new Random();
                        int leak = coolantleak.Next(0,150);

                        if (leak == 5)
                            blnWarning02 = true;
                    }

                    if (blnWarning02 == true)
                    {
                        intCoolantLevel = intCoolantLevel - 1;
                        lblWarning02.Visible = true;
                    }


                    //Update Coolant


                    if ((intCoolantLevel > 0) && (intCoolantLevel < 100))
                        prgCoolantLevel.Value = intCoolantLevel;
                    else if (intCoolantLevel >= 100)
                    {
                        intCoolantLevel = 100;
                        prgCoolantLevel.Value = 100;
                    }
                    else
                    {
                        intCoolantLevel = 0;
                        prgCoolantLevel.Value = intCoolantLevel;
                    }

                    lblCoolant.Text = intCoolantLevel.ToString();
                    lblCoolant.Refresh();


                    //Update Coolant Labels

                    dblPercent = ((Convert.ToDouble(intCoolantLevel)) / 100);


                    lblCoolant.Text = dblPercent.ToString("P0");

                    prgContainment.Value = Convert.ToInt32(dblContainment);

                    dblWarpCoreHealth = dblContainment;


                    //Update Containment


                    if ((intCoolantLevel >= 20) && (intCoolantLevel <= 39))
                        dblWarpCoreHealth = dblContainment + ((Convert.ToDouble(intCoolantLevel) / 100));
                    else if ((intCoolantLevel >= 40) && (intCoolantLevel <= 59))
                        dblWarpCoreHealth = dblContainment + ((Convert.ToDouble(intCoolantLevel) / 100) + .5);
                    else if ((intCoolantLevel >= 60) && (intCoolantLevel <= 79))
                        dblWarpCoreHealth = dblContainment + ((Convert.ToDouble(intCoolantLevel) / 100) + 1);
                    else if ((intCoolantLevel >= 80) && (intCoolantLevel < 100))
                        dblContainment = dblContainment + 0.005;
                    else if (intCoolantLevel == 100)
                        dblContainment = dblContainment + 0.01;
                    else
                        dblContainment = dblContainment - 1;


                    if (dblContainment > 100)
                        dblContainment = 100;

                    if (dblContainment <= 0)
                    {
                        blnGameOver = true;
                        dblContainment = 0;
                    }


                    //Update Containment Label

                    dblPercent = (dblContainment / 100);


                    lblContainment.Text = dblPercent.ToString("P0");

                    prgContainment.Value = Convert.ToInt32(dblContainment);

                    dblWarpCoreHealth = dblContainment;


                    //Update Warp Core Heatlh


                    dblPercent = (dblWarpCoreHealth / 100);

                    lblWarpCoreHealth.Text = dblPercent.ToString("P0");
                    lblWarpCoreHealth.Refresh();

                    //Turn Containment Failure Warning Label On and Off

                    if (dblContainment < 20)
                        lblContainmentFailure.Visible = true;
                    else
                        lblContainmentFailure.Visible = false;

                    //Update Dilithium Health


                    if (dblDilithiumIntegrity > 0)
                    {
                        dblDilithiumIntegrity = dblDilithiumIntegrity - 0.1;
                    }

                    else if (dblDilithiumIntegrity <= 0)
                    {
                        dblDilithiumIntegrity = 0;
                        blnGameOver = true;
                    }

                    //Turn Recrystalize Warning Label On and Off

                    if (dblDilithiumIntegrity < 20)
                        lblRecrystalize.Visible = true;
                    else
                        lblRecrystalize.Visible = false;

                    if (dblDilithiumIntegrity == 0)
                    {
                        blnGameOver = true;

                        endGame();

                        this.Close();
                        frmGameOver gameover = new frmGameOver();
                        gameover.ShowDialog();
                    }

                    //Dilithium Label Output

                    prgDilithium.Value = Convert.ToInt32(dblDilithiumIntegrity);

                    dblPercent = dblDilithiumIntegrity / 100;

                    lblDilithium.Text = dblPercent.ToString("P0");
                    lblDilithium.Refresh();

                    //Game Over

                    //Boolean blnExplode = false;
                    //Boolean blnWarp10 = false;
                    //Boolean blnCoolantLeaK = false;

                    if (dblWarpFactor >= 10)
                    {

                        blnGameOver = true;

                        endGame();

                        this.Close();
                        frmGameOverWarp10 warp10 = new frmGameOverWarp10();
                        warp10.ShowDialog();


                    }

                    if (dblWarpCoreHealth == 0)
                    {

                        blnGameOver = true;

                        endGame();

                        this.Close();
                        frmGameOver gameover = new frmGameOver();
                        gameover.ShowDialog();

                    }

                }

        }

        //Increases Warp Power

        private void btnPlasmaIncrease_Click(object sender, EventArgs e)
        {
            if ((dblWarpFactor * 10) >= dblInjectorMax - 1)
                blnWarning01 = true;

            
            if ((dblWarpFactor * 10) < dblInjectorMax)
            {
                dblWarpFactor = dblWarpFactor + 0.1;
                blnStop = true;

                //if ((dblWarpFactor * 10) == dblInjectorMax - 1)
                    //lblWarning01.Enabled = true;

                ///////

                if ((dblWarpFactor >= 1) && (dblWarpFactor <= 1.9))
                    radWarp1.Checked = true;
                else if ((dblWarpFactor >= 2) && (dblWarpFactor <= 2.9))
                    radWarp2.Checked = true;

                //////////

                dblButtonWait = 0.01; // number of seconds

                timButtonWait.Tick += timButtonWait_Tick;
                timButtonWait.Start();

                btnPlasmaIncrease.Enabled = false;
                btnPlasmaDecrease.Enabled = false;
            }
        }


        //Decreases Warp Power

        private void btnPlasmaDecrease_Click(object sender, EventArgs e)
        {

            if (((dblWarpFactor * 10) <= dblInjectorMax) && (dblWarpFactor > 0))
            {
                dblWarpFactor = dblWarpFactor - 0.1;
                blnStop = true;

                blnWarning01 = false;

                if ((dblWarpFactor >= 1) && (dblWarpFactor <= 1.9))
                    radWarp1.Checked = true;
                else if ((dblWarpFactor >= 2) && (dblWarpFactor <= 2.9))
                    radWarp2.Checked = true;
                else if ((dblWarpFactor >= 3) && (dblWarpFactor <= 3.9))
                    radWarp3.Checked = true;
                else if ((dblWarpFactor >= 4) && (dblWarpFactor <= 4.9))
                    radWarp4.Checked = true;
                else if ((dblWarpFactor >= 5) && (dblWarpFactor <= 5.9))
                    radWarp5.Checked = true;
                else if ((dblWarpFactor >= 6) && (dblWarpFactor <= 6.9))
                    radWarp6.Checked = true;
                else if ((dblWarpFactor >= 7) && (dblWarpFactor <= 7.9))
                    radWarp7.Checked = true;
                else if ((dblWarpFactor >= 8) && (dblWarpFactor <= 8.9))
                    radWarp8.Checked = true;
                else if (dblWarpFactor >= 9)
                    radWarp9.Checked = true;
            }
            else if ((dblWarpFactor * 10) <= 0)
            {
                dblWarpFactor = 0;
            }

            dblButtonWait = 0.01; // number of seconds

            timButtonWait.Tick += timButtonWait_Tick;
            timButtonWait.Start();

            btnPlasmaIncrease.Enabled = false;
            btnPlasmaDecrease.Enabled = false;
        }


        //Coolant Level Increase Button

        private void btnCoolantIncrease_Click(object sender, EventArgs e)
        {
            intCoolantLevel = intCoolantLevel + 20;

            dblButtonWait = 0.01; // number of seconds

            timButtonWait.Tick += timButtonWait_Tick;
            timButtonWait.Start();
            btnCoolantIncrease.Enabled = false;
            btnCoolantDecrease.Enabled = false;
        }


        //Coolant Level Decrease Button

        private void btnCoolantDecrease_Click(object sender, EventArgs e)
        {
            intCoolantLevel = intCoolantLevel - 20;

            dblButtonWait = 0.01; // number of seconds

            timButtonWait.Tick += timButtonWait_Tick;
            timButtonWait.Start();
            btnCoolantIncrease.Enabled = false;
            btnCoolantDecrease.Enabled = false;
        }

        //Containment Increase Button

        private void btnContainmentIncrease_Click(object sender, EventArgs e)
        {


            if (dblWarpFactor > 0)
            {
                dblContainment = dblContainment + 1;
                dblWarpFactor = dblWarpFactor - 0.2;

                dblButtonWait = 0.01; // number of seconds

                timButtonWait.Tick += timButtonWait_Tick;
                timButtonWait.Start();
                btnContainmentIncrease.Enabled = false;
                btnContainmentDecrease.Enabled = false;
            }
            else
                dblWarpFactor = 0;
        }

        //Containment Decrease Button

        private void btnContainmentDecrease_Click(object sender, EventArgs e)
        {

            dblContainment = dblContainment - 5;
            dblWarpFactor = dblWarpFactor + 0.5;


            dblButtonWait = 0.01; // number of seconds

            timButtonWait.Tick += timButtonWait_Tick;
            timButtonWait.Start();
            btnContainmentIncrease.Enabled = false;
            btnContainmentDecrease.Enabled = false;

        }

        //Recrystalize Button

        private void brnRecrystalize_Click(object sender, EventArgs e)
        {

            if (dblWarpFactor <= 0)
            {

                time = 0.0;
                dblWarpFactor = 0.0;
                dblWarpCoreHealth = 100;

                dblPlasmaInjector = 0;
                dblInjectorMax = 100;
                intCoolantLevel = 20;
                dblContainment = 100;
                dblDilithiumIntegrity = 100;

                dblInjectorPercent = 0;

                dblPercent = 0;

                blnGameOver = false;

                blnStop = true;
            }
            else
            {
                blnGameOver = true;

                endGame();

                this.Close();
                frmGameOver gameover = new frmGameOver();
                gameover.ShowDialog();
            }
            
        }


        //Delays Buttons from Being Pressed after just being used

        private void timButtonWait_Tick(object sender, EventArgs e)
        {
            if (--dblButtonWait <= 0)
            {
                btnPlasmaIncrease.Enabled = true;
                btnPlasmaDecrease.Enabled = true;

                btnCoolantIncrease.Enabled = true;
                btnCoolantDecrease.Enabled = true;

                btnContainmentIncrease.Enabled = true;
                btnContainmentDecrease.Enabled = true;

                timButtonWait.Stop();
                timButtonWait.Tick -= timButtonWait_Tick;
            }

        }


        //Method to Set Labels for End Game


        private void endGame()
        {

            lblDilithium.Text = "0%";
            lblCoolant.Text = "0%";
            lblContainment.Text = "0%";
            lblInjector.Text = "0%";
            lblWarpFactor.Text = "0.0";

            prgDilithium.Value = 0;
            prgCoolantLevel.Value = 0;
            prgContainment.Value = 0;
            prgInjector.Value = 0;

            picEngineering.Enabled = false;
            picLcars01.Enabled = false;
        }




        //Method to Determine Which Warp Speed is Selected Via Radio Button

        private void rad_Warp(int intWarp)
        {


                if (dblWarpFactor == intWarp)
                {
                    btnPlasmaIncrease.Enabled = true;
                    btnPlasmaDecrease.Enabled = true;
                    blnStop = true;
                }

                else if (dblWarpFactor > intWarp)
                {
                    dblWarpFactor = dblWarpFactor - 0.2;
                    btnPlasmaIncrease.Enabled = false;
                    btnPlasmaDecrease.Enabled = false;

                    if (dblWarpFactor <= intWarp)
                        dblWarpFactor = intWarp;
                }

                else if (dblWarpFactor < intWarp)
                {
                    dblWarpFactor = dblWarpFactor + 0.2;
                    btnPlasmaIncrease.Enabled = false;
                    btnPlasmaDecrease.Enabled = false;

                    if (dblWarpFactor >= intWarp)
                        dblWarpFactor = intWarp;
                }
    }


        //Changes blnStop to False if Button is Changed.

        private void radWarp0_CheckedChanged(object sender, EventArgs e)
        {
            blnStop = false;
        }

        private void radWarp1_CheckedChanged(object sender, EventArgs e)
        {
            blnStop = false;
        }

        private void radWarp2_CheckedChanged(object sender, EventArgs e)
        {
            blnStop = false;
        }

        private void radWarp3_CheckedChanged(object sender, EventArgs e)
        {
            blnStop = false;
        }

        private void radWarp4_CheckedChanged(object sender, EventArgs e)
        {
            blnStop = false;
        }

        private void radWarp5_CheckedChanged(object sender, EventArgs e)
        {
            blnStop = false;
        }

        private void radWarp6_CheckedChanged(object sender, EventArgs e)
        {
            blnStop = false;
        }

        private void radWarp7_CheckedChanged(object sender, EventArgs e)
        {
            blnStop = false;
        }

        private void radWarp8_CheckedChanged(object sender, EventArgs e)
        {
            blnStop = false;
        }

        private void radWarp9_CheckedChanged(object sender, EventArgs e)
        {
            blnStop = false;
        }

        



        

    }
}
