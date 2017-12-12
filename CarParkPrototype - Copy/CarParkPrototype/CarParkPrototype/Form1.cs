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

        public Form1()
        {
            InitializeComponent();
            Reset();
            enterLeave = false;
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
            btnCoinReceived.Visible = true;
            btnArriveAtCarPark.Visible = false;
        }

        private void btnCoinReceived_Click(object sender, EventArgs e)
        {
            btnEnterCarPark.Visible= true;
            btnCoinReceived.Visible= false;
        }

        private void btnEnterCarPark_Click(object sender, EventArgs e)
        {

            btnEnterCarPark.Enabled = false;
            grbxParking.Visible = true;

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
                grbxFloor2.Visible = false;
                btnConfirmSpace.Visible = false;
                grbxParking.Enabled = false;

            }


        }

        private void btnFloor2Parking_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 4; i++)
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
                btnConfirmSpace.Visible = false;
                grbxParking.Enabled = false;

            }

        }


        private void btnFloor1_Click(object sender, EventArgs e)
        {

            parkingSpace = 1;
            if (enterLeave)
            {
                selectSpaceFloor1();
            }
            else
            {
                selectLeavingFloor1();
            }
            btnFloor1.BackColor = Color.RoyalBlue;

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
                    btnConfirmSpace.Visible = true;
                grbxParking.Enabled = true;
            }
            else
            {
                if (parkingSpace > 0)
                    btnConfirmLeave.Visible = true;
                grbxLeaving.Enabled = true;
            }
        }
        private void btnConfirmSpace_Click(object sender, EventArgs e)
        {
            btnConfirmSpace.Enabled = false;
            grbxParking.Enabled = false;
            btnPark.Visible = true;
            grbxSecurity.Visible = true;
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
            btnPayForParking.Visible = true;
            btnLeave.Visible = false;
            enterLeave = false;
            btnEnter.Visible = false;
        }

        private void btnPayForParking_Click(object sender, EventArgs e)
        {
            btnFindCar.Visible = true;
            btnPayForParking.Enabled = false;
        }

        private void btnFindCar_Click(object sender, EventArgs e)
        {
            btnFindCar.Enabled = false;
            grbxLeaving.Visible = true;
            btnPayForParking.Enabled = false;
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

        private void btnConfirmLeave_Click(object sender, EventArgs e)
        {
            btnConfirmLeave.Enabled = false;
            btnLeaveSpace.Visible = true;
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
                btnLeaveSpace.Enabled = false;
            
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
            btnEnterCarPark.Enabled = true;
            btnEnterCarPark.Visible = false;
            btnConfirmSpace.Enabled = true;
            btnConfirmSpace.Visible = false;
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
            btnConfirmLeave.Enabled = true;
            btnConfirmLeave.Visible = false;
            btnLeaveSpace.Enabled = true;
            btnLeaveSpace.Visible = false;
            btnLeaveCarPark.Enabled = true;
            btnLeaveCarPark.Visible = false;
        }

        private void btnPasscode_Click(object sender, EventArgs e)
        {
            grbxPin.Visible = true;
        }
    }
}

