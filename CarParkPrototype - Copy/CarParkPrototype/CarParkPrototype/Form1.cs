using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParkPrototype
{
    public partial class Form1 : Form
    {

        private bool enterLeave;
        private int parkingSpace;
        private bool[] floor1 = { true, true, true, true, true, true, true, true };
        private bool[] floor2 = { true, true, true, true, true, true, true, true };

        //ADDED VARIABLES TO MAKE THE KEYPAD WORK!!!!!!!
        private int passPark1, passPark2, passPark3, passPark4;
        private bool s1 = false, s2 = false, s3 = false, s4 = false;
        //

        public Form1()
        {
            InitializeComponent();
            Reset();
            enterLeave = true;
            parkingSpace = 0;

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            btnArriveAtCarPark.Visible = true;
            btnEnter.Visible = false;
            btnLeave.Visible = false;
        }

        private void btnArriveAtCarPark_Click(object sender, EventArgs e)
        {
            btnArriveAtCarPark.Visible = false;
            btnSelectSpace.Visible = true;
        }

        private void btnCoinReceived_Click(object sender, EventArgs e)
        {
            btnPark.Visible = true;
            btnCoinReceived.Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFloor1Parking_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (floor1[i])
                {
                    switch (i + 1)
                    {
                        case 1:
                            btnFloor1.Enabled = true;
                            btnFloor1.BackColor = Color.Lime;
                            break;
                        case 2:
                            btnFloor2.Enabled = true;
                            btnFloor2.BackColor = Color.Lime;
                            break;
                        case 3:
                            btnFloor3.Enabled = true;
                            btnFloor3.BackColor = Color.Lime;
                            break;
                        case 4:
                            btnFloor4.Enabled = true;
                            btnFloor4.BackColor = Color.Lime;
                            break;
                    }
                }

                grbxFloor1.Visible = true;
                btnSelectSpace.Enabled = false;
                grbxFloor2.Visible = false;
                grbxParking.Enabled = false;

            }


        }

        private void btnFloor2Parking_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (floor2[i])
                {
                    switch (i + 1)
                    {
                        case 1:
                            btnFloor5.Enabled = true;
                            btnFloor5.BackColor = Color.Lime;
                            break;
                        case 2:
                            btnFloor6.Enabled = true;
                            btnFloor6.BackColor = Color.Lime;
                            break;
                        case 3:
                            btnFloor7.Enabled = true;
                            btnFloor7.BackColor = Color.Lime;
                            break;
                        case 4:
                            btnFloor8.Enabled = true;
                            btnFloor8.BackColor = Color.Lime;
                            break;
                    }
                }

                grbxFloor1.Visible = false;
                grbxFloor2.Visible = true;
                btnSelectSpace.Visible = false;
                grbxParking.Enabled = false;

            }

        }


        private void selectSpaceFloor1()
        {

            for (int i = 0; i < 4; i++)
            {
                if (floor1[i])
                {
                    switch (i + 1)
                    {
                        case 1:
                            btnFloor4.Enabled = true;
                            btnFloor4.BackColor = Color.Lime;
                            break;
                        case 2:
                            btnFloor4.Enabled = true;
                            btnFloor4.BackColor = Color.Lime;
                            break;
                        case 3:
                            btnFloor1.Enabled = true;
                            btnFloor1.BackColor = Color.Lime;
                            break;
                        case 4:
                            btnFloor4.Enabled = true;
                            btnFloor4.BackColor = Color.Lime;
                            break;

                    }
                }
            }

        }

        private void btnFloor1Confirm_Click(object sender, EventArgs e)
        {

            btnFloor1.Enabled = false;
            btnFloor1.BackColor = Color.Red;
            btnFloor2.Enabled = false;
            btnFloor2.BackColor = Color.Red;
            btnFloor3.Enabled = false;
            btnFloor3.BackColor = Color.Red;
            btnFloor4.Enabled = false;
            btnFloor4.BackColor = Color.Red;

            grbxFloor1.Visible = false;
            if (!enterLeave)
            {
                if (parkingSpace > 0)
                {
                    MessageBox.Show("Enter you passcode to leave", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grbxPin.Visible = true;
                    btnFindCar.Enabled = false;
                    grbxLeaving.Enabled = false;
                }

            }
            else
            {
                if (parkingSpace > 0)
                {
                    MessageBox.Show("Select a passcode, or fingerprint scanner to secure your car", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grbxSecurity.Visible = true;
                    grbxLeaving.Enabled = true;
                }

            }
        }
        private void btnConfirmSpace_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter floor 1 for secure parking or \nEnter floor 2 for standard parking", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnSelectSpace.Enabled = false;
            grbxParking.Visible = true;
        }
        private void btnPark_Click(object sender, EventArgs e)
        {
            if ((parkingSpace > 0) && (parkingSpace <= 4))
            {
                floor1[parkingSpace - 1] = false;
            }
            else if ((parkingSpace >= 5) && (parkingSpace <= 8))
            {
                floor2[parkingSpace - 9] = false;
            }

            btnPark.Visible = false;
            parkingSpace = 0;
            Reset();
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            btnFindCar.Visible = true;
            btnLeave.Visible = false;
            enterLeave = false;
            btnEnter.Visible = false;
        }

        private void btnPayForParking_Click(object sender, EventArgs e)
        {
            btnLeaveSpace.Visible = true;
            btnPayForParking.Visible = false;
        }

        private void btnFindCar_Click(object sender, EventArgs e)
        {
            btnFindCar.Enabled = false;
            grbxLeaving.Visible = true;
        }
        private void selectLeavingFloor1()
        {
            for (int i = 0; i < 4; i++)
            {
                if (!floor1[i])
                {
                    switch (i + 1)
                    {
                        case 1:
                            btnFloor1.Enabled = true;
                            btnFloor1.BackColor = Color.Gold;
                            break;
                        case 2:
                            btnFloor2.Enabled = true;
                            btnFloor2.BackColor = Color.Gold;
                            break;
                        case 3:
                            btnFloor3.Enabled = true;
                            btnFloor3.BackColor = Color.Gold;
                            break;
                        case 4:
                            btnFloor4.Enabled = true;
                            btnFloor4.BackColor = Color.Gold;
                            break;

                    }
                }
            }
        }
        private void selectLeavingFloor2()
        {
            for (int i = 0; i < 4; i++)
            {
                if (!floor1[i])
                {
                    switch (i + 1)
                    {
                        case 1:
                            btnFloor5.Enabled = true;
                            btnFloor5.BackColor = Color.Gold;
                            break;
                        case 2:
                            btnFloor6.Enabled = true;
                            btnFloor6.BackColor = Color.Gold;
                            break;
                        case 3:
                            btnFloor7.Enabled = true;
                            btnFloor7.BackColor = Color.Gold;
                            break;
                        case 4:
                            btnFloor8.Enabled = true;
                            btnFloor8.BackColor = Color.Gold;
                            break;

                    }
                }
            }
        }
        private void btnFloor1Leaving_Click(object sender, EventArgs e)
        {
            selectLeavingFloor1();
            grbxFloor1.Visible = true;
            grbxLeaving.Enabled = false;
        }
        private void btnFloor2Leaving_Click(object sender, EventArgs e)
        {
            selectLeavingFloor2();
            grbxFloor2.Visible = true;
            grbxLeaving.Enabled = false;
        }


        private void btnLeaveSpace_Click(object sender, EventArgs e)
        {

            if ((parkingSpace > 0) && (parkingSpace <= 4))
            {
                floor1[parkingSpace - 1] = true;

            }
            else if ((parkingSpace >= 5) && (parkingSpace <= 8))
            {
                floor2[parkingSpace - 5] = true;

            }
            btnLeaveCarPark.Visible = true;
            btnLeaveSpace.Visible = false;
        }

        private void btnLeaveCarPark_Click(object sender, EventArgs e)
        {
            btnLeaveCarPark.Visible = false;
            if ((parkingSpace > 0) && (parkingSpace <= 8))
            {
                floor1[parkingSpace - 1] = true;

            }
            else if ((parkingSpace >= 9) && (parkingSpace <= 20))
            {
                floor2[parkingSpace - 9] = true;

            }
            enterLeave = true;
            parkingSpace = 0;
            Reset();

        }

        private void Reset()
        {

            btnEnter.Visible = true;
            btnLeave.Visible = true;

            btnArriveAtCarPark.Enabled = true;
            btnArriveAtCarPark.Visible = false;
            btnCoinReceived.Enabled = true;
            btnCoinReceived.Visible = false;
            btnSelectSpace.Enabled = true;
            btnSelectSpace.Visible = false;
            grbxParking.Visible = false;
            grbxParking.Enabled = true;
            grbxLeaving.Visible = false;
            grbxLeaving.Enabled = true;
            btnPark.Visible = false;
            btnPark.Enabled = true;
            btnPayForParking.Enabled = true;
            btnPayForParking.Visible = false;
            btnFindCar.Enabled = true;
            btnFindCar.Visible = false;
            btnLeaveSpace.Enabled = true;
            btnLeaveSpace.Visible = false;
            btnLeaveCarPark.Enabled = true;
            btnLeaveCarPark.Visible = false;
        }

        private void btnPasscode_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter A Pin Number To Secure Your Car", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            grbxPin.Visible = true;
        }

        private void btnSelectSpace_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select Floor 1 for secure parking, or floor 2 for regular parking", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            grbxParking.Visible = true;
            btnSelectSpace.Enabled = false;
        }

        //NEW KEYPAD NOW WORKING
        private void btnPin1_Click_1(object sender, EventArgs e)
        {
            lblPin.Text += "1";
        }

        private void btnPin2_Click_1(object sender, EventArgs e)
        {
            lblPin.Text += "2";
        }

        private void btnPin3_Click_1(object sender, EventArgs e)
        {
            lblPin.Text += "3";
        }

        private void btnPin4_Click_1(object sender, EventArgs e)
        {
            lblPin.Text += "4";
        }

        private void btnPin5_Click_1(object sender, EventArgs e)
        {
            lblPin.Text += "5";
        }

        private void btnPin6_Click_1(object sender, EventArgs e)
        {
            lblPin.Text += "6";
        }

        private void btnPin7_Click_1(object sender, EventArgs e)
        {
            lblPin.Text += "7";
        }

        private void btnPin8_Click_1(object sender, EventArgs e)
        {
            lblPin.Text += "8";
        }

        private void btnPin9_Click_1(object sender, EventArgs e)
        {
            lblPin.Text += "9";
        }

        private void btnPin0_Click_1(object sender, EventArgs e)
        {
            lblPin.Text += "0";
        }



        //CLEAR BUTTON
        private void btnPinBack_Click_1(object sender, EventArgs e)
        {
            lblPin.Text = ("");
        }

        //NEW ENTER BUTTON
        private void btnPinEnter_Click_1(object sender, EventArgs e)
        {
            if (s1)
            {
                if (!enterLeave)
                {
                    if (passPark1 == Convert.ToInt32(lblPin.Text))
                    {
                        if (lblPin.Text == "")
                        {
                            MessageBox.Show("Please enter a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Pin Correct", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnFindCar.Visible = false;
                            btnPayForParking.Visible = true;
                            lblPin.Text = "";
                            passPark1 = 0;
                            s1 = false;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Incorrect Pin, Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblPin.Text = "";
                    }
                }
                else
                {
                    if (lblPin.Text == "")
                    {
                        MessageBox.Show("Please enter a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        passPark1 = Convert.ToInt32(lblPin.Text);
                        lblTest.Text = Convert.ToString(passPark1); // Just for testing purposes can be deleted later.
                        lblPin.Text = "";
                        btnCoinReceived.Visible = true;
                        s1 = false;
                    }

                }
            }

            if (s2)
            {
                if (!enterLeave)
                {
                    if (passPark2 == Convert.ToInt32(lblPin.Text))
                    {
                        MessageBox.Show("Pin Correct", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnFindCar.Visible = false;
                        btnPayForParking.Visible = true;
                        lblPin.Text = "";
                        passPark2 = 0;
                        s2 = false;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Pin, Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblPin.Text = "";
                    }
                }
                else
                {
                    passPark2 = Convert.ToInt32(lblPin.Text);
                    lblTest2.Text = Convert.ToString(passPark2); // Just for testing purposes can be deleted later.
                    lblPin.Text = "";
                    btnCoinReceived.Visible = true;
                    s2 = false;

                }
            }

            if (s3)
            {
                if (!enterLeave)
                {
                    if (passPark3 == Convert.ToInt32(lblPin.Text))
                    {
                        MessageBox.Show("Pin Correct", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnFindCar.Visible = false;
                        btnPayForParking.Visible = true;
                        lblPin.Text = "";
                        passPark3 = 0;
                        s3 = false;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Pin, Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblPin.Text = "";
                    }
                }
                else
                {
                    passPark3 = Convert.ToInt32(lblPin.Text);
                    lblTest3.Text = Convert.ToString(passPark3); // Just for testing purposes can be deleted later.
                    lblPin.Text = "";
                    btnCoinReceived.Visible = true;
                    s3 = false;

                }
            }

            if (s4)
            {
                if (!enterLeave)
                {
                    if (passPark4 == Convert.ToInt32(lblPin.Text))
                    {
                        MessageBox.Show("Pin Correct", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnFindCar.Visible = false;
                        btnPayForParking.Visible = true;
                        lblPin.Text = "";
                        passPark4 = 0;
                        s4 = false;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Pin, Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblPin.Text = "";
                    }
                }
                else
                {
                    passPark4 = Convert.ToInt32(lblPin.Text);
                    lblTest4.Text = Convert.ToString(passPark4); // Just for testing purposes can be deleted later.
                    lblPin.Text = "";
                    btnCoinReceived.Visible = true;
                    s4 = false;

                }
            }

            btnSelectSpace.Visible = false;
            //grbxPin.Visible = false;
            grbxSecurity.Visible = false;
            grbxParking.Visible = false;
        }


        //DIFFERENT PARKING SPACES#
        private void btnFloor1_Click(object sender, EventArgs e)
        {
            s1 = true;
            s2 = false;
            s3 = false;
            s4 = false;
            // Prevents multiple parking selection
            parkingSpace = 1;
            if (!enterLeave)
            {
                selectLeavingFloor1();
            }
            else
            {
                selectSpaceFloor1();
            }
            btnFloor1.BackColor = Color.RoyalBlue;
        }

        private void btnFloor2_Click_1(object sender, EventArgs e)
        {
            s2 = true;
            s1 = false;
            s3 = false;
            s4 = false;
            //stops multiple park selection
            parkingSpace = 2;
            if (!enterLeave)
            {
                selectLeavingFloor1();
            }
            else
            {
                selectSpaceFloor1();
            }
            btnFloor2.BackColor = Color.RoyalBlue;
        }

        private void btnFloor3_Click_1(object sender, EventArgs e)


        {
            s3 = true;
            s2 = false;
            s1 = false;
            s4 = false;
            //stops multiple park selection
            parkingSpace = 3;
            if (!enterLeave)
            {
                selectLeavingFloor1();
            }
            else
            {
                selectSpaceFloor1();
            }
            btnFloor3.BackColor = Color.RoyalBlue;
        }

        private void btnFloor4_Click_1(object sender, EventArgs e)
        {
            s4 = true;
            s2 = false;
            s1 = false;
            s3 = false;
            //stops multiple park selection
            parkingSpace = 4;
            if (!enterLeave)
            {
                selectLeavingFloor1();
            }
            else
            {
                selectSpaceFloor1();
            }
            btnFloor4.BackColor = Color.RoyalBlue;
        }

    }
}

