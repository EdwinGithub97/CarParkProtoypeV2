namespace CarParkPrototype
{
    partial class Form1
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
            this.btnFindCar = new System.Windows.Forms.Button();
            this.grbxLeaving = new System.Windows.Forms.GroupBox();
            this.btnFloor2Leaving = new System.Windows.Forms.Button();
            this.btnFloor1Leaving = new System.Windows.Forms.Button();
            this.btnConfirmLeave = new System.Windows.Forms.Button();
            this.btnLeaveCarPark = new System.Windows.Forms.Button();
            this.btnLeaveSpace = new System.Windows.Forms.Button();
            this.btnPayForParking = new System.Windows.Forms.Button();
            this.grpbxFingerprint = new System.Windows.Forms.GroupBox();
            this.pictbxFingerprint = new System.Windows.Forms.PictureBox();
            this.grpbxSimulator = new System.Windows.Forms.GroupBox();
            this.grbxParking = new System.Windows.Forms.GroupBox();
            this.btnFloor2Parking = new System.Windows.Forms.Button();
            this.btnFloor1Parking = new System.Windows.Forms.Button();
            this.grbxSecurity = new System.Windows.Forms.GroupBox();
            this.btnPasscode = new System.Windows.Forms.Button();
            this.btnFingerprint = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnConfirmSpace = new System.Windows.Forms.Button();
            this.btnPark = new System.Windows.Forms.Button();
            this.btnEnterCarPark = new System.Windows.Forms.Button();
            this.btnCoinReceived = new System.Windows.Forms.Button();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.btnArriveAtCarPark = new System.Windows.Forms.Button();
            this.grbxFloor1 = new System.Windows.Forms.GroupBox();
            this.btnFloor1Confirm = new System.Windows.Forms.Button();
            this.btnFloor4 = new System.Windows.Forms.Button();
            this.btnFloor3 = new System.Windows.Forms.Button();
            this.btnFloor2 = new System.Windows.Forms.Button();
            this.btnFloor1 = new System.Windows.Forms.Button();
            this.grbxFloor2 = new System.Windows.Forms.GroupBox();
            this.btnFloor2Confirm = new System.Windows.Forms.Button();
            this.btnFloor8 = new System.Windows.Forms.Button();
            this.btnFloor7 = new System.Windows.Forms.Button();
            this.btnFloor6 = new System.Windows.Forms.Button();
            this.btnFloor5 = new System.Windows.Forms.Button();
            this.grbxPin = new System.Windows.Forms.GroupBox();
            this.btnPinEnter = new System.Windows.Forms.Button();
            this.btnPin0 = new System.Windows.Forms.Button();
            this.btnPinBack = new System.Windows.Forms.Button();
            this.txtboxPin = new System.Windows.Forms.TextBox();
            this.btnPin9 = new System.Windows.Forms.Button();
            this.btnPin8 = new System.Windows.Forms.Button();
            this.btnPin7 = new System.Windows.Forms.Button();
            this.btnPin6 = new System.Windows.Forms.Button();
            this.btnPin5 = new System.Windows.Forms.Button();
            this.btnPin4 = new System.Windows.Forms.Button();
            this.btnPin3 = new System.Windows.Forms.Button();
            this.btnPin2 = new System.Windows.Forms.Button();
            this.btnPin1 = new System.Windows.Forms.Button();
            this.grbxLeaving.SuspendLayout();
            this.grpbxFingerprint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxFingerprint)).BeginInit();
            this.grpbxSimulator.SuspendLayout();
            this.grbxParking.SuspendLayout();
            this.grbxSecurity.SuspendLayout();
            this.grbxFloor1.SuspendLayout();
            this.grbxFloor2.SuspendLayout();
            this.grbxPin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFindCar
            // 
            this.btnFindCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnFindCar.Location = new System.Drawing.Point(318, 179);
            this.btnFindCar.Name = "btnFindCar";
            this.btnFindCar.Size = new System.Drawing.Size(110, 41);
            this.btnFindCar.TabIndex = 27;
            this.btnFindCar.Text = "Find Car";
            this.btnFindCar.UseVisualStyleBackColor = true;
            this.btnFindCar.Click += new System.EventHandler(this.btnFindCar_Click);
            // 
            // grbxLeaving
            // 
            this.grbxLeaving.Controls.Add(this.btnFloor2Leaving);
            this.grbxLeaving.Controls.Add(this.btnFloor1Leaving);
            this.grbxLeaving.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grbxLeaving.Location = new System.Drawing.Point(262, 426);
            this.grbxLeaving.Name = "grbxLeaving";
            this.grbxLeaving.Size = new System.Drawing.Size(139, 121);
            this.grbxLeaving.TabIndex = 3;
            this.grbxLeaving.TabStop = false;
            this.grbxLeaving.Text = "Leaving";
            this.grbxLeaving.Visible = false;
            // 
            // btnFloor2Leaving
            // 
            this.btnFloor2Leaving.Location = new System.Drawing.Point(13, 67);
            this.btnFloor2Leaving.Name = "btnFloor2Leaving";
            this.btnFloor2Leaving.Size = new System.Drawing.Size(113, 42);
            this.btnFloor2Leaving.TabIndex = 1;
            this.btnFloor2Leaving.Text = "Floor 2";
            this.btnFloor2Leaving.UseVisualStyleBackColor = true;
            this.btnFloor2Leaving.Click += new System.EventHandler(this.btnFloor2Leaving_Click);
            // 
            // btnFloor1Leaving
            // 
            this.btnFloor1Leaving.Location = new System.Drawing.Point(13, 19);
            this.btnFloor1Leaving.Name = "btnFloor1Leaving";
            this.btnFloor1Leaving.Size = new System.Drawing.Size(113, 42);
            this.btnFloor1Leaving.TabIndex = 0;
            this.btnFloor1Leaving.Text = "Floor 1";
            this.btnFloor1Leaving.UseVisualStyleBackColor = true;
            this.btnFloor1Leaving.Click += new System.EventHandler(this.btnFloor1Leaving_Click);
            // 
            // btnConfirmLeave
            // 
            this.btnConfirmLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnConfirmLeave.Location = new System.Drawing.Point(318, 228);
            this.btnConfirmLeave.Name = "btnConfirmLeave";
            this.btnConfirmLeave.Size = new System.Drawing.Size(110, 41);
            this.btnConfirmLeave.TabIndex = 31;
            this.btnConfirmLeave.Text = "Confirm Space";
            this.btnConfirmLeave.UseVisualStyleBackColor = true;
            this.btnConfirmLeave.Click += new System.EventHandler(this.btnConfirmLeave_Click);
            // 
            // btnLeaveCarPark
            // 
            this.btnLeaveCarPark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnLeaveCarPark.Location = new System.Drawing.Point(318, 335);
            this.btnLeaveCarPark.Name = "btnLeaveCarPark";
            this.btnLeaveCarPark.Size = new System.Drawing.Size(110, 41);
            this.btnLeaveCarPark.TabIndex = 30;
            this.btnLeaveCarPark.Text = "Leave Car Park";
            this.btnLeaveCarPark.UseVisualStyleBackColor = true;
            this.btnLeaveCarPark.Click += new System.EventHandler(this.btnLeaveCarPark_Click);
            // 
            // btnLeaveSpace
            // 
            this.btnLeaveSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnLeaveSpace.Location = new System.Drawing.Point(318, 275);
            this.btnLeaveSpace.Name = "btnLeaveSpace";
            this.btnLeaveSpace.Size = new System.Drawing.Size(110, 41);
            this.btnLeaveSpace.TabIndex = 29;
            this.btnLeaveSpace.Text = "Leave Space";
            this.btnLeaveSpace.UseVisualStyleBackColor = true;
            this.btnLeaveSpace.Click += new System.EventHandler(this.btnLeaveSpace_Click);
            // 
            // btnPayForParking
            // 
            this.btnPayForParking.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnPayForParking.Location = new System.Drawing.Point(318, 122);
            this.btnPayForParking.Name = "btnPayForParking";
            this.btnPayForParking.Size = new System.Drawing.Size(110, 41);
            this.btnPayForParking.TabIndex = 28;
            this.btnPayForParking.Text = "Pay for Parking";
            this.btnPayForParking.UseVisualStyleBackColor = true;
            this.btnPayForParking.Click += new System.EventHandler(this.btnPayForParking_Click);
            // 
            // grpbxFingerprint
            // 
            this.grpbxFingerprint.Controls.Add(this.pictbxFingerprint);
            this.grpbxFingerprint.Enabled = false;
            this.grpbxFingerprint.Location = new System.Drawing.Point(1129, 312);
            this.grpbxFingerprint.Name = "grpbxFingerprint";
            this.grpbxFingerprint.Size = new System.Drawing.Size(196, 263);
            this.grpbxFingerprint.TabIndex = 12;
            this.grpbxFingerprint.TabStop = false;
            this.grpbxFingerprint.Text = "Fingerprint Scanner";
            // 
            // pictbxFingerprint
            // 
            this.pictbxFingerprint.Location = new System.Drawing.Point(18, 48);
            this.pictbxFingerprint.Name = "pictbxFingerprint";
            this.pictbxFingerprint.Size = new System.Drawing.Size(155, 174);
            this.pictbxFingerprint.TabIndex = 0;
            this.pictbxFingerprint.TabStop = false;
            // 
            // grpbxSimulator
            // 
            this.grpbxSimulator.Controls.Add(this.grbxLeaving);
            this.grpbxSimulator.Controls.Add(this.grbxParking);
            this.grpbxSimulator.Controls.Add(this.grbxSecurity);
            this.grpbxSimulator.Controls.Add(this.btnConfirmLeave);
            this.grpbxSimulator.Controls.Add(this.btnLeaveCarPark);
            this.grpbxSimulator.Controls.Add(this.btnLeaveSpace);
            this.grpbxSimulator.Controls.Add(this.btnPayForParking);
            this.grpbxSimulator.Controls.Add(this.btnFindCar);
            this.grpbxSimulator.Controls.Add(this.btnLeave);
            this.grpbxSimulator.Controls.Add(this.btnEnter);
            this.grpbxSimulator.Controls.Add(this.btnConfirmSpace);
            this.grpbxSimulator.Controls.Add(this.btnPark);
            this.grpbxSimulator.Controls.Add(this.btnEnterCarPark);
            this.grpbxSimulator.Controls.Add(this.btnCoinReceived);
            this.grpbxSimulator.Controls.Add(this.txtInstructions);
            this.grpbxSimulator.Controls.Add(this.btnArriveAtCarPark);
            this.grpbxSimulator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grpbxSimulator.Location = new System.Drawing.Point(77, 37);
            this.grpbxSimulator.Name = "grpbxSimulator";
            this.grpbxSimulator.Size = new System.Drawing.Size(462, 613);
            this.grpbxSimulator.TabIndex = 18;
            this.grpbxSimulator.TabStop = false;
            this.grpbxSimulator.Text = "Simulator";
            // 
            // grbxParking
            // 
            this.grbxParking.Controls.Add(this.btnFloor2Parking);
            this.grbxParking.Controls.Add(this.btnFloor1Parking);
            this.grbxParking.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grbxParking.Location = new System.Drawing.Point(60, 426);
            this.grbxParking.Name = "grbxParking";
            this.grbxParking.Size = new System.Drawing.Size(126, 121);
            this.grbxParking.TabIndex = 0;
            this.grbxParking.TabStop = false;
            this.grbxParking.Text = "Parking";
            this.grbxParking.Visible = false;
            // 
            // btnFloor2Parking
            // 
            this.btnFloor2Parking.Location = new System.Drawing.Point(6, 67);
            this.btnFloor2Parking.Name = "btnFloor2Parking";
            this.btnFloor2Parking.Size = new System.Drawing.Size(113, 42);
            this.btnFloor2Parking.TabIndex = 1;
            this.btnFloor2Parking.Text = "Floor 2";
            this.btnFloor2Parking.UseVisualStyleBackColor = true;
            this.btnFloor2Parking.Click += new System.EventHandler(this.btnFloor2Parking_Click);
            // 
            // btnFloor1Parking
            // 
            this.btnFloor1Parking.Location = new System.Drawing.Point(6, 19);
            this.btnFloor1Parking.Name = "btnFloor1Parking";
            this.btnFloor1Parking.Size = new System.Drawing.Size(113, 42);
            this.btnFloor1Parking.TabIndex = 0;
            this.btnFloor1Parking.Text = "Floor 1";
            this.btnFloor1Parking.UseVisualStyleBackColor = true;
            this.btnFloor1Parking.Click += new System.EventHandler(this.btnFloor1Parking_Click);
            // 
            // grbxSecurity
            // 
            this.grbxSecurity.Controls.Add(this.btnPasscode);
            this.grbxSecurity.Controls.Add(this.btnFingerprint);
            this.grbxSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grbxSecurity.Location = new System.Drawing.Point(151, 187);
            this.grbxSecurity.Name = "grbxSecurity";
            this.grbxSecurity.Size = new System.Drawing.Size(142, 141);
            this.grbxSecurity.TabIndex = 19;
            this.grbxSecurity.TabStop = false;
            this.grbxSecurity.Text = "Security";
            this.grbxSecurity.Visible = false;
            // 
            // btnPasscode
            // 
            this.btnPasscode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnPasscode.Location = new System.Drawing.Point(31, 35);
            this.btnPasscode.Name = "btnPasscode";
            this.btnPasscode.Size = new System.Drawing.Size(75, 39);
            this.btnPasscode.TabIndex = 0;
            this.btnPasscode.Text = "Passcode";
            this.btnPasscode.UseVisualStyleBackColor = true;
            this.btnPasscode.Click += new System.EventHandler(this.btnPasscode_Click);
            // 
            // btnFingerprint
            // 
            this.btnFingerprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnFingerprint.Location = new System.Drawing.Point(31, 80);
            this.btnFingerprint.Name = "btnFingerprint";
            this.btnFingerprint.Size = new System.Drawing.Size(75, 39);
            this.btnFingerprint.TabIndex = 1;
            this.btnFingerprint.Text = "Fingerprint Scanner";
            this.btnFingerprint.UseVisualStyleBackColor = true;
            // 
            // btnLeave
            // 
            this.btnLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnLeave.Location = new System.Drawing.Point(318, 67);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(110, 41);
            this.btnLeave.TabIndex = 9;
            this.btnLeave.Text = "Leave";
            this.btnLeave.UseVisualStyleBackColor = true;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnEnter.Location = new System.Drawing.Point(17, 69);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(110, 41);
            this.btnEnter.TabIndex = 8;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnConfirmSpace
            // 
            this.btnConfirmSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnConfirmSpace.Location = new System.Drawing.Point(17, 288);
            this.btnConfirmSpace.Name = "btnConfirmSpace";
            this.btnConfirmSpace.Size = new System.Drawing.Size(110, 41);
            this.btnConfirmSpace.TabIndex = 7;
            this.btnConfirmSpace.Text = "Confirm Space";
            this.btnConfirmSpace.UseVisualStyleBackColor = true;
            this.btnConfirmSpace.Click += new System.EventHandler(this.btnConfirmSpace_Click);
            // 
            // btnPark
            // 
            this.btnPark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnPark.Location = new System.Drawing.Point(17, 335);
            this.btnPark.Name = "btnPark";
            this.btnPark.Size = new System.Drawing.Size(110, 41);
            this.btnPark.TabIndex = 6;
            this.btnPark.Text = "Park";
            this.btnPark.UseVisualStyleBackColor = true;
            this.btnPark.Click += new System.EventHandler(this.btnPark_Click);
            // 
            // btnEnterCarPark
            // 
            this.btnEnterCarPark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnEnterCarPark.Location = new System.Drawing.Point(19, 238);
            this.btnEnterCarPark.Name = "btnEnterCarPark";
            this.btnEnterCarPark.Size = new System.Drawing.Size(110, 41);
            this.btnEnterCarPark.TabIndex = 4;
            this.btnEnterCarPark.Text = "Enter Car Park";
            this.btnEnterCarPark.UseVisualStyleBackColor = true;
            this.btnEnterCarPark.Click += new System.EventHandler(this.btnEnterCarPark_Click);
            // 
            // btnCoinReceived
            // 
            this.btnCoinReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCoinReceived.Location = new System.Drawing.Point(16, 179);
            this.btnCoinReceived.Name = "btnCoinReceived";
            this.btnCoinReceived.Size = new System.Drawing.Size(110, 41);
            this.btnCoinReceived.TabIndex = 3;
            this.btnCoinReceived.Text = "Coin Received";
            this.btnCoinReceived.UseVisualStyleBackColor = true;
            this.btnCoinReceived.Click += new System.EventHandler(this.btnCoinReceived_Click);
            // 
            // txtInstructions
            // 
            this.txtInstructions.BackColor = System.Drawing.SystemColors.Window;
            this.txtInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstructions.Location = new System.Drawing.Point(16, 28);
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.ReadOnly = true;
            this.txtInstructions.Size = new System.Drawing.Size(428, 23);
            this.txtInstructions.TabIndex = 2;
            // 
            // btnArriveAtCarPark
            // 
            this.btnArriveAtCarPark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnArriveAtCarPark.Location = new System.Drawing.Point(17, 125);
            this.btnArriveAtCarPark.Name = "btnArriveAtCarPark";
            this.btnArriveAtCarPark.Size = new System.Drawing.Size(110, 41);
            this.btnArriveAtCarPark.TabIndex = 1;
            this.btnArriveAtCarPark.Text = "Arrive at Car Park";
            this.btnArriveAtCarPark.UseVisualStyleBackColor = true;
            this.btnArriveAtCarPark.Click += new System.EventHandler(this.btnArriveAtCarPark_Click);
            // 
            // grbxFloor1
            // 
            this.grbxFloor1.Controls.Add(this.btnFloor1Confirm);
            this.grbxFloor1.Controls.Add(this.btnFloor4);
            this.grbxFloor1.Controls.Add(this.btnFloor3);
            this.grbxFloor1.Controls.Add(this.btnFloor2);
            this.grbxFloor1.Controls.Add(this.btnFloor1);
            this.grbxFloor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grbxFloor1.Location = new System.Drawing.Point(625, 57);
            this.grbxFloor1.Name = "grbxFloor1";
            this.grbxFloor1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbxFloor1.Size = new System.Drawing.Size(313, 119);
            this.grbxFloor1.TabIndex = 19;
            this.grbxFloor1.TabStop = false;
            this.grbxFloor1.Text = "Floor1";
            this.grbxFloor1.Visible = false;
            // 
            // btnFloor1Confirm
            // 
            this.btnFloor1Confirm.Location = new System.Drawing.Point(149, 87);
            this.btnFloor1Confirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnFloor1Confirm.Name = "btnFloor1Confirm";
            this.btnFloor1Confirm.Size = new System.Drawing.Size(55, 24);
            this.btnFloor1Confirm.TabIndex = 4;
            this.btnFloor1Confirm.Text = "Confirm";
            this.btnFloor1Confirm.UseVisualStyleBackColor = true;
            this.btnFloor1Confirm.Click += new System.EventHandler(this.btnFloor1Confirm_Click);
            // 
            // btnFloor4
            // 
            this.btnFloor4.Enabled = false;
            this.btnFloor4.Location = new System.Drawing.Point(248, 52);
            this.btnFloor4.Name = "btnFloor4";
            this.btnFloor4.Size = new System.Drawing.Size(39, 29);
            this.btnFloor4.TabIndex = 3;
            this.btnFloor4.Text = "4";
            this.btnFloor4.UseVisualStyleBackColor = true;
            // 
            // btnFloor3
            // 
            this.btnFloor3.Enabled = false;
            this.btnFloor3.Location = new System.Drawing.Point(182, 52);
            this.btnFloor3.Name = "btnFloor3";
            this.btnFloor3.Size = new System.Drawing.Size(39, 29);
            this.btnFloor3.TabIndex = 2;
            this.btnFloor3.Text = "3";
            this.btnFloor3.UseVisualStyleBackColor = true;
            // 
            // btnFloor2
            // 
            this.btnFloor2.Enabled = false;
            this.btnFloor2.Location = new System.Drawing.Point(117, 51);
            this.btnFloor2.Name = "btnFloor2";
            this.btnFloor2.Size = new System.Drawing.Size(39, 29);
            this.btnFloor2.TabIndex = 1;
            this.btnFloor2.Text = "2";
            this.btnFloor2.UseVisualStyleBackColor = true;
            // 
            // btnFloor1
            // 
            this.btnFloor1.Enabled = false;
            this.btnFloor1.Location = new System.Drawing.Point(42, 50);
            this.btnFloor1.Name = "btnFloor1";
            this.btnFloor1.Size = new System.Drawing.Size(39, 29);
            this.btnFloor1.TabIndex = 0;
            this.btnFloor1.Text = "1";
            this.btnFloor1.UseVisualStyleBackColor = true;
            this.btnFloor1.Click += new System.EventHandler(this.btnFloor1_Click);
            // 
            // grbxFloor2
            // 
            this.grbxFloor2.Controls.Add(this.btnFloor2Confirm);
            this.grbxFloor2.Controls.Add(this.btnFloor8);
            this.grbxFloor2.Controls.Add(this.btnFloor7);
            this.grbxFloor2.Controls.Add(this.btnFloor6);
            this.grbxFloor2.Controls.Add(this.btnFloor5);
            this.grbxFloor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grbxFloor2.Location = new System.Drawing.Point(625, 191);
            this.grbxFloor2.Name = "grbxFloor2";
            this.grbxFloor2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbxFloor2.Size = new System.Drawing.Size(313, 125);
            this.grbxFloor2.TabIndex = 20;
            this.grbxFloor2.TabStop = false;
            this.grbxFloor2.Text = "Floor2";
            this.grbxFloor2.Visible = false;
            // 
            // btnFloor2Confirm
            // 
            this.btnFloor2Confirm.Location = new System.Drawing.Point(149, 95);
            this.btnFloor2Confirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnFloor2Confirm.Name = "btnFloor2Confirm";
            this.btnFloor2Confirm.Size = new System.Drawing.Size(55, 24);
            this.btnFloor2Confirm.TabIndex = 5;
            this.btnFloor2Confirm.Text = "Confirm";
            this.btnFloor2Confirm.UseVisualStyleBackColor = true;
            // 
            // btnFloor8
            // 
            this.btnFloor8.Location = new System.Drawing.Point(248, 52);
            this.btnFloor8.Name = "btnFloor8";
            this.btnFloor8.Size = new System.Drawing.Size(39, 29);
            this.btnFloor8.TabIndex = 3;
            this.btnFloor8.Text = "8";
            this.btnFloor8.UseVisualStyleBackColor = true;
            // 
            // btnFloor7
            // 
            this.btnFloor7.Location = new System.Drawing.Point(182, 52);
            this.btnFloor7.Name = "btnFloor7";
            this.btnFloor7.Size = new System.Drawing.Size(39, 29);
            this.btnFloor7.TabIndex = 2;
            this.btnFloor7.Text = "7";
            this.btnFloor7.UseVisualStyleBackColor = true;
            // 
            // btnFloor6
            // 
            this.btnFloor6.Location = new System.Drawing.Point(117, 51);
            this.btnFloor6.Name = "btnFloor6";
            this.btnFloor6.Size = new System.Drawing.Size(39, 29);
            this.btnFloor6.TabIndex = 1;
            this.btnFloor6.Text = "6";
            this.btnFloor6.UseVisualStyleBackColor = true;
            // 
            // btnFloor5
            // 
            this.btnFloor5.Location = new System.Drawing.Point(42, 50);
            this.btnFloor5.Name = "btnFloor5";
            this.btnFloor5.Size = new System.Drawing.Size(39, 29);
            this.btnFloor5.TabIndex = 0;
            this.btnFloor5.Text = "5";
            this.btnFloor5.UseVisualStyleBackColor = true;
            // 
            // grbxPin
            // 
            this.grbxPin.Controls.Add(this.btnPinEnter);
            this.grbxPin.Controls.Add(this.btnPin0);
            this.grbxPin.Controls.Add(this.btnPinBack);
            this.grbxPin.Controls.Add(this.txtboxPin);
            this.grbxPin.Controls.Add(this.btnPin9);
            this.grbxPin.Controls.Add(this.btnPin8);
            this.grbxPin.Controls.Add(this.btnPin7);
            this.grbxPin.Controls.Add(this.btnPin6);
            this.grbxPin.Controls.Add(this.btnPin5);
            this.grbxPin.Controls.Add(this.btnPin4);
            this.grbxPin.Controls.Add(this.btnPin3);
            this.grbxPin.Controls.Add(this.btnPin2);
            this.grbxPin.Controls.Add(this.btnPin1);
            this.grbxPin.Location = new System.Drawing.Point(1129, 73);
            this.grbxPin.Name = "grbxPin";
            this.grbxPin.Size = new System.Drawing.Size(196, 226);
            this.grbxPin.TabIndex = 21;
            this.grbxPin.TabStop = false;
            this.grbxPin.Text = "Pin";
            this.grbxPin.Visible = false;
            // 
            // btnPinEnter
            // 
            this.btnPinEnter.Location = new System.Drawing.Point(100, 179);
            this.btnPinEnter.Name = "btnPinEnter";
            this.btnPinEnter.Size = new System.Drawing.Size(73, 29);
            this.btnPinEnter.TabIndex = 22;
            this.btnPinEnter.Text = "Enter";
            this.btnPinEnter.UseVisualStyleBackColor = true;
            // 
            // btnPin0
            // 
            this.btnPin0.Location = new System.Drawing.Point(55, 179);
            this.btnPin0.Name = "btnPin0";
            this.btnPin0.Size = new System.Drawing.Size(39, 29);
            this.btnPin0.TabIndex = 26;
            this.btnPin0.Text = "0";
            this.btnPin0.UseVisualStyleBackColor = true;
            // 
            // btnPinBack
            // 
            this.btnPinBack.Location = new System.Drawing.Point(145, 74);
            this.btnPinBack.Name = "btnPinBack";
            this.btnPinBack.Size = new System.Drawing.Size(28, 99);
            this.btnPinBack.TabIndex = 25;
            this.btnPinBack.Text = "<-";
            this.btnPinBack.UseVisualStyleBackColor = true;
            // 
            // txtboxPin
            // 
            this.txtboxPin.Location = new System.Drawing.Point(9, 45);
            this.txtboxPin.Name = "txtboxPin";
            this.txtboxPin.Size = new System.Drawing.Size(164, 20);
            this.txtboxPin.TabIndex = 24;
            // 
            // btnPin9
            // 
            this.btnPin9.Location = new System.Drawing.Point(100, 74);
            this.btnPin9.Name = "btnPin9";
            this.btnPin9.Size = new System.Drawing.Size(39, 29);
            this.btnPin9.TabIndex = 23;
            this.btnPin9.Text = "9";
            this.btnPin9.UseVisualStyleBackColor = true;
            // 
            // btnPin8
            // 
            this.btnPin8.Location = new System.Drawing.Point(55, 74);
            this.btnPin8.Name = "btnPin8";
            this.btnPin8.Size = new System.Drawing.Size(39, 29);
            this.btnPin8.TabIndex = 4;
            this.btnPin8.Text = "8";
            this.btnPin8.UseVisualStyleBackColor = true;
            // 
            // btnPin7
            // 
            this.btnPin7.Location = new System.Drawing.Point(10, 74);
            this.btnPin7.Name = "btnPin7";
            this.btnPin7.Size = new System.Drawing.Size(39, 29);
            this.btnPin7.TabIndex = 4;
            this.btnPin7.Text = "7";
            this.btnPin7.UseVisualStyleBackColor = true;
            // 
            // btnPin6
            // 
            this.btnPin6.Location = new System.Drawing.Point(100, 109);
            this.btnPin6.Name = "btnPin6";
            this.btnPin6.Size = new System.Drawing.Size(39, 29);
            this.btnPin6.TabIndex = 4;
            this.btnPin6.Text = "6";
            this.btnPin6.UseVisualStyleBackColor = true;
            // 
            // btnPin5
            // 
            this.btnPin5.Location = new System.Drawing.Point(55, 109);
            this.btnPin5.Name = "btnPin5";
            this.btnPin5.Size = new System.Drawing.Size(39, 29);
            this.btnPin5.TabIndex = 4;
            this.btnPin5.Text = "5";
            this.btnPin5.UseVisualStyleBackColor = true;
            // 
            // btnPin4
            // 
            this.btnPin4.Location = new System.Drawing.Point(10, 109);
            this.btnPin4.Name = "btnPin4";
            this.btnPin4.Size = new System.Drawing.Size(39, 29);
            this.btnPin4.TabIndex = 4;
            this.btnPin4.Text = "4";
            this.btnPin4.UseVisualStyleBackColor = true;
            // 
            // btnPin3
            // 
            this.btnPin3.Location = new System.Drawing.Point(100, 144);
            this.btnPin3.Name = "btnPin3";
            this.btnPin3.Size = new System.Drawing.Size(39, 29);
            this.btnPin3.TabIndex = 4;
            this.btnPin3.Text = "3";
            this.btnPin3.UseVisualStyleBackColor = true;
            // 
            // btnPin2
            // 
            this.btnPin2.Location = new System.Drawing.Point(55, 144);
            this.btnPin2.Name = "btnPin2";
            this.btnPin2.Size = new System.Drawing.Size(39, 29);
            this.btnPin2.TabIndex = 4;
            this.btnPin2.Text = "2";
            this.btnPin2.UseVisualStyleBackColor = true;
            // 
            // btnPin1
            // 
            this.btnPin1.Location = new System.Drawing.Point(10, 144);
            this.btnPin1.Name = "btnPin1";
            this.btnPin1.Size = new System.Drawing.Size(39, 29);
            this.btnPin1.TabIndex = 22;
            this.btnPin1.Text = "1";
            this.btnPin1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 686);
            this.Controls.Add(this.grbxPin);
            this.Controls.Add(this.grbxFloor2);
            this.Controls.Add(this.grbxFloor1);
            this.Controls.Add(this.grpbxFingerprint);
            this.Controls.Add(this.grpbxSimulator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbxLeaving.ResumeLayout(false);
            this.grpbxFingerprint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictbxFingerprint)).EndInit();
            this.grpbxSimulator.ResumeLayout(false);
            this.grpbxSimulator.PerformLayout();
            this.grbxParking.ResumeLayout(false);
            this.grbxSecurity.ResumeLayout(false);
            this.grbxFloor1.ResumeLayout(false);
            this.grbxFloor2.ResumeLayout(false);
            this.grbxPin.ResumeLayout(false);
            this.grbxPin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFindCar;
        private System.Windows.Forms.GroupBox grbxLeaving;
        private System.Windows.Forms.Button btnFloor2Leaving;
        private System.Windows.Forms.Button btnFloor1Leaving;
        private System.Windows.Forms.Button btnConfirmLeave;
        private System.Windows.Forms.Button btnLeaveCarPark;
        private System.Windows.Forms.Button btnLeaveSpace;
        private System.Windows.Forms.Button btnPayForParking;
        private System.Windows.Forms.GroupBox grpbxFingerprint;
        private System.Windows.Forms.GroupBox grpbxSimulator;
        private System.Windows.Forms.GroupBox grbxSecurity;
        private System.Windows.Forms.Button btnPasscode;
        private System.Windows.Forms.Button btnFingerprint;
        private System.Windows.Forms.GroupBox grbxParking;
        private System.Windows.Forms.Button btnFloor2Parking;
        private System.Windows.Forms.Button btnFloor1Parking;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnConfirmSpace;
        private System.Windows.Forms.Button btnPark;
        private System.Windows.Forms.Button btnEnterCarPark;
        private System.Windows.Forms.Button btnCoinReceived;
        private System.Windows.Forms.TextBox txtInstructions;
        private System.Windows.Forms.Button btnArriveAtCarPark;
        private System.Windows.Forms.GroupBox grbxFloor1;
        private System.Windows.Forms.Button btnFloor4;
        private System.Windows.Forms.Button btnFloor3;
        private System.Windows.Forms.Button btnFloor2;
        private System.Windows.Forms.Button btnFloor1;
        private System.Windows.Forms.GroupBox grbxFloor2;
        private System.Windows.Forms.Button btnFloor8;
        private System.Windows.Forms.Button btnFloor7;
        private System.Windows.Forms.Button btnFloor6;
        private System.Windows.Forms.Button btnFloor5;
        private System.Windows.Forms.GroupBox grbxPin;
        private System.Windows.Forms.Button btnPinEnter;
        private System.Windows.Forms.Button btnPin0;
        private System.Windows.Forms.Button btnPinBack;
        private System.Windows.Forms.TextBox txtboxPin;
        private System.Windows.Forms.Button btnPin9;
        private System.Windows.Forms.Button btnPin8;
        private System.Windows.Forms.Button btnPin7;
        private System.Windows.Forms.Button btnPin6;
        private System.Windows.Forms.Button btnPin5;
        private System.Windows.Forms.Button btnPin4;
        private System.Windows.Forms.Button btnPin3;
        private System.Windows.Forms.Button btnPin2;
        private System.Windows.Forms.Button btnPin1;
        private System.Windows.Forms.PictureBox pictbxFingerprint;
        private System.Windows.Forms.Button btnFloor1Confirm;
        private System.Windows.Forms.Button btnFloor2Confirm;
    }
}

