namespace CarCharging
{
    partial class ControlOrderCurrent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbTimeToCharge = new System.Windows.Forms.TextBox();
            this.lbTimeToCharge = new System.Windows.Forms.Label();
            this.tbCar = new System.Windows.Forms.TextBox();
            this.tbBattery = new System.Windows.Forms.TextBox();
            this.lbBattery = new System.Windows.Forms.Label();
            this.lbCar = new System.Windows.Forms.Label();
            this.lbOrderCurrent = new System.Windows.Forms.Label();
            this.lbDriverLogin = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.ExitLoginCurrentOrder = new System.Windows.Forms.Button();
            this.btnStartCharging = new System.Windows.Forms.Button();
            this.btnStopCharging = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tbSelectedCharger = new System.Windows.Forms.TextBox();
            this.lbCharger = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.tbGPS = new System.Windows.Forms.TextBox();
            this.lbGPS = new System.Windows.Forms.Label();
            this.tbOrderTime = new System.Windows.Forms.TextBox();
            this.lbTimeOfOrder = new System.Windows.Forms.Label();
            this.lbStartTime = new System.Windows.Forms.Label();
            this.lbEndTimeExpect = new System.Windows.Forms.Label();
            this.lbTimePassedMin = new System.Windows.Forms.Label();
            this.lbPercent = new System.Windows.Forms.Label();
            this.lbStartTimeVal = new System.Windows.Forms.Label();
            this.lbEndTimeExpectVal = new System.Windows.Forms.Label();
            this.lbTimePassedMinVal = new System.Windows.Forms.Label();
            this.lbCurrentTimeVal = new System.Windows.Forms.Label();
            this.lbCurrentTime = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.lbBatteryProgressVal = new System.Windows.Forms.Label();
            this.lbBatteryProgress = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbStopCharging = new System.Windows.Forms.Label();
            this.timerStepProgressBar = new System.Windows.Forms.Timer(this.components);
            this.timerBattery = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tbTimeToCharge
            // 
            this.tbTimeToCharge.BackColor = System.Drawing.Color.FloralWhite;
            this.tbTimeToCharge.Location = new System.Drawing.Point(208, 84);
            this.tbTimeToCharge.Name = "tbTimeToCharge";
            this.tbTimeToCharge.Size = new System.Drawing.Size(178, 20);
            this.tbTimeToCharge.TabIndex = 60;
            this.tbTimeToCharge.TextChanged += new System.EventHandler(this.tbTime_TextChanged);
            // 
            // lbTimeToCharge
            // 
            this.lbTimeToCharge.AutoSize = true;
            this.lbTimeToCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTimeToCharge.Location = new System.Drawing.Point(82, 85);
            this.lbTimeToCharge.Name = "lbTimeToCharge";
            this.lbTimeToCharge.Size = new System.Drawing.Size(107, 15);
            this.lbTimeToCharge.TabIndex = 59;
            this.lbTimeToCharge.Text = "Time to charge:";
            // 
            // tbCar
            // 
            this.tbCar.BackColor = System.Drawing.Color.FloralWhite;
            this.tbCar.Location = new System.Drawing.Point(208, 44);
            this.tbCar.Name = "tbCar";
            this.tbCar.Size = new System.Drawing.Size(178, 20);
            this.tbCar.TabIndex = 58;
            // 
            // tbBattery
            // 
            this.tbBattery.BackColor = System.Drawing.Color.FloralWhite;
            this.tbBattery.Location = new System.Drawing.Point(208, 64);
            this.tbBattery.Name = "tbBattery";
            this.tbBattery.Size = new System.Drawing.Size(178, 20);
            this.tbBattery.TabIndex = 57;
            // 
            // lbBattery
            // 
            this.lbBattery.AutoSize = true;
            this.lbBattery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBattery.Location = new System.Drawing.Point(82, 65);
            this.lbBattery.Name = "lbBattery";
            this.lbBattery.Size = new System.Drawing.Size(55, 15);
            this.lbBattery.TabIndex = 56;
            this.lbBattery.Text = "Battery:";
            // 
            // lbCar
            // 
            this.lbCar.AutoSize = true;
            this.lbCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCar.Location = new System.Drawing.Point(82, 45);
            this.lbCar.Name = "lbCar";
            this.lbCar.Size = new System.Drawing.Size(91, 15);
            this.lbCar.TabIndex = 55;
            this.lbCar.Text = "Selected car:";
            // 
            // lbOrderCurrent
            // 
            this.lbOrderCurrent.AutoSize = true;
            this.lbOrderCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbOrderCurrent.Location = new System.Drawing.Point(243, 12);
            this.lbOrderCurrent.Name = "lbOrderCurrent";
            this.lbOrderCurrent.Size = new System.Drawing.Size(116, 20);
            this.lbOrderCurrent.TabIndex = 54;
            this.lbOrderCurrent.Text = "Current order";
            // 
            // lbDriverLogin
            // 
            this.lbDriverLogin.AutoSize = true;
            this.lbDriverLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDriverLogin.Location = new System.Drawing.Point(59, 12);
            this.lbDriverLogin.Name = "lbDriverLogin";
            this.lbDriverLogin.Size = new System.Drawing.Size(100, 20);
            this.lbDriverLogin.TabIndex = 62;
            this.lbDriverLogin.Text = "DriverLogin";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(3, 12);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(63, 20);
            this.labelLogin.TabIndex = 61;
            this.labelLogin.Text = "Login: ";
            // 
            // ExitLoginCurrentOrder
            // 
            this.ExitLoginCurrentOrder.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ExitLoginCurrentOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitLoginCurrentOrder.Location = new System.Drawing.Point(405, 384);
            this.ExitLoginCurrentOrder.Name = "ExitLoginCurrentOrder";
            this.ExitLoginCurrentOrder.Size = new System.Drawing.Size(77, 35);
            this.ExitLoginCurrentOrder.TabIndex = 63;
            this.ExitLoginCurrentOrder.Text = "Out Login";
            this.ExitLoginCurrentOrder.UseVisualStyleBackColor = false;
            this.ExitLoginCurrentOrder.Click += new System.EventHandler(this.ExitLoginCurrentOrder_Click);
            // 
            // btnStartCharging
            // 
            this.btnStartCharging.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnStartCharging.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartCharging.Location = new System.Drawing.Point(72, 325);
            this.btnStartCharging.Name = "btnStartCharging";
            this.btnStartCharging.Size = new System.Drawing.Size(105, 48);
            this.btnStartCharging.TabIndex = 64;
            this.btnStartCharging.Text = "Start charging";
            this.btnStartCharging.UseVisualStyleBackColor = false;
            this.btnStartCharging.Click += new System.EventHandler(this.btnStartCharging_Click);
            // 
            // btnStopCharging
            // 
            this.btnStopCharging.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnStopCharging.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStopCharging.Location = new System.Drawing.Point(304, 325);
            this.btnStopCharging.Name = "btnStopCharging";
            this.btnStopCharging.Size = new System.Drawing.Size(105, 48);
            this.btnStopCharging.TabIndex = 65;
            this.btnStopCharging.Text = "Stop charging";
            this.btnStopCharging.UseVisualStyleBackColor = false;
            this.btnStopCharging.Click += new System.EventHandler(this.btnStopCharging_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(72, 282);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(337, 23);
            this.progressBar1.TabIndex = 66;
            // 
            // tbSelectedCharger
            // 
            this.tbSelectedCharger.BackColor = System.Drawing.Color.FloralWhite;
            this.tbSelectedCharger.Location = new System.Drawing.Point(208, 104);
            this.tbSelectedCharger.Name = "tbSelectedCharger";
            this.tbSelectedCharger.Size = new System.Drawing.Size(178, 20);
            this.tbSelectedCharger.TabIndex = 70;
            // 
            // lbCharger
            // 
            this.lbCharger.AutoSize = true;
            this.lbCharger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCharger.Location = new System.Drawing.Point(82, 105);
            this.lbCharger.Name = "lbCharger";
            this.lbCharger.Size = new System.Drawing.Size(116, 15);
            this.lbCharger.TabIndex = 67;
            this.lbCharger.Text = "Ordered charger:";
            // 
            // tbAddress
            // 
            this.tbAddress.BackColor = System.Drawing.Color.FloralWhite;
            this.tbAddress.Location = new System.Drawing.Point(208, 124);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(178, 20);
            this.tbAddress.TabIndex = 72;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAddress.Location = new System.Drawing.Point(82, 125);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(115, 15);
            this.lbAddress.TabIndex = 71;
            this.lbAddress.Text = "Address charger:";
            // 
            // tbGPS
            // 
            this.tbGPS.BackColor = System.Drawing.Color.FloralWhite;
            this.tbGPS.Location = new System.Drawing.Point(208, 144);
            this.tbGPS.Name = "tbGPS";
            this.tbGPS.Size = new System.Drawing.Size(178, 20);
            this.tbGPS.TabIndex = 74;
            // 
            // lbGPS
            // 
            this.lbGPS.AutoSize = true;
            this.lbGPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbGPS.Location = new System.Drawing.Point(82, 145);
            this.lbGPS.Name = "lbGPS";
            this.lbGPS.Size = new System.Drawing.Size(92, 15);
            this.lbGPS.TabIndex = 73;
            this.lbGPS.Text = "GPS charger:";
            // 
            // tbOrderTime
            // 
            this.tbOrderTime.BackColor = System.Drawing.Color.FloralWhite;
            this.tbOrderTime.Location = new System.Drawing.Point(208, 164);
            this.tbOrderTime.Name = "tbOrderTime";
            this.tbOrderTime.Size = new System.Drawing.Size(178, 20);
            this.tbOrderTime.TabIndex = 76;
            // 
            // lbTimeOfOrder
            // 
            this.lbTimeOfOrder.AutoSize = true;
            this.lbTimeOfOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTimeOfOrder.Location = new System.Drawing.Point(82, 165);
            this.lbTimeOfOrder.Name = "lbTimeOfOrder";
            this.lbTimeOfOrder.Size = new System.Drawing.Size(90, 15);
            this.lbTimeOfOrder.TabIndex = 75;
            this.lbTimeOfOrder.Text = "Order\'s time:";
            // 
            // lbStartTime
            // 
            this.lbStartTime.AutoSize = true;
            this.lbStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStartTime.Location = new System.Drawing.Point(69, 249);
            this.lbStartTime.Name = "lbStartTime";
            this.lbStartTime.Size = new System.Drawing.Size(137, 15);
            this.lbStartTime.TabIndex = 77;
            this.lbStartTime.Text = "Start charging time: ";
            // 
            // lbEndTimeExpect
            // 
            this.lbEndTimeExpect.AutoSize = true;
            this.lbEndTimeExpect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEndTimeExpect.Location = new System.Drawing.Point(275, 249);
            this.lbEndTimeExpect.Name = "lbEndTimeExpect";
            this.lbEndTimeExpect.Size = new System.Drawing.Size(134, 15);
            this.lbEndTimeExpect.TabIndex = 78;
            this.lbEndTimeExpect.Text = "End time expected: ";
            // 
            // lbTimePassedMin
            // 
            this.lbTimePassedMin.AutoSize = true;
            this.lbTimePassedMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTimePassedMin.Location = new System.Drawing.Point(205, 205);
            this.lbTimePassedMin.Name = "lbTimePassedMin";
            this.lbTimePassedMin.Size = new System.Drawing.Size(120, 15);
            this.lbTimePassedMin.TabIndex = 79;
            this.lbTimePassedMin.Text = "Seconds passed: ";
            // 
            // lbPercent
            // 
            this.lbPercent.AutoSize = true;
            this.lbPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPercent.Location = new System.Drawing.Point(230, 308);
            this.lbPercent.Name = "lbPercent";
            this.lbPercent.Size = new System.Drawing.Size(19, 15);
            this.lbPercent.TabIndex = 80;
            this.lbPercent.Text = "%";
            // 
            // lbStartTimeVal
            // 
            this.lbStartTimeVal.AutoSize = true;
            this.lbStartTimeVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStartTimeVal.Location = new System.Drawing.Point(69, 264);
            this.lbStartTimeVal.Name = "lbStartTimeVal";
            this.lbStartTimeVal.Size = new System.Drawing.Size(30, 15);
            this.lbStartTimeVal.TabIndex = 81;
            this.lbStartTimeVal.Text = "text";
            // 
            // lbEndTimeExpectVal
            // 
            this.lbEndTimeExpectVal.AutoSize = true;
            this.lbEndTimeExpectVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEndTimeExpectVal.Location = new System.Drawing.Point(275, 264);
            this.lbEndTimeExpectVal.Name = "lbEndTimeExpectVal";
            this.lbEndTimeExpectVal.Size = new System.Drawing.Size(30, 15);
            this.lbEndTimeExpectVal.TabIndex = 82;
            this.lbEndTimeExpectVal.Text = "text";
            // 
            // lbTimePassedMinVal
            // 
            this.lbTimePassedMinVal.AutoSize = true;
            this.lbTimePassedMinVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTimePassedMinVal.Location = new System.Drawing.Point(327, 205);
            this.lbTimePassedMinVal.Name = "lbTimePassedMinVal";
            this.lbTimePassedMinVal.Size = new System.Drawing.Size(30, 15);
            this.lbTimePassedMinVal.TabIndex = 83;
            this.lbTimePassedMinVal.Text = "text";
            // 
            // lbCurrentTimeVal
            // 
            this.lbCurrentTimeVal.AutoSize = true;
            this.lbCurrentTimeVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCurrentTimeVal.Location = new System.Drawing.Point(327, 190);
            this.lbCurrentTimeVal.Name = "lbCurrentTimeVal";
            this.lbCurrentTimeVal.Size = new System.Drawing.Size(30, 15);
            this.lbCurrentTimeVal.TabIndex = 85;
            this.lbCurrentTimeVal.Text = "text";
            // 
            // lbCurrentTime
            // 
            this.lbCurrentTime.AutoSize = true;
            this.lbCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCurrentTime.Location = new System.Drawing.Point(205, 190);
            this.lbCurrentTime.Name = "lbCurrentTime";
            this.lbCurrentTime.Size = new System.Drawing.Size(90, 15);
            this.lbCurrentTime.TabIndex = 84;
            this.lbCurrentTime.Text = "Current time:";
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCancel.Location = new System.Drawing.Point(405, 149);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(77, 35);
            this.btCancel.TabIndex = 86;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // lbBatteryProgressVal
            // 
            this.lbBatteryProgressVal.AutoSize = true;
            this.lbBatteryProgressVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBatteryProgressVal.Location = new System.Drawing.Point(327, 220);
            this.lbBatteryProgressVal.Name = "lbBatteryProgressVal";
            this.lbBatteryProgressVal.Size = new System.Drawing.Size(30, 15);
            this.lbBatteryProgressVal.TabIndex = 88;
            this.lbBatteryProgressVal.Text = "text";
            // 
            // lbBatteryProgress
            // 
            this.lbBatteryProgress.AutoSize = true;
            this.lbBatteryProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBatteryProgress.Location = new System.Drawing.Point(205, 220);
            this.lbBatteryProgress.Name = "lbBatteryProgress";
            this.lbBatteryProgress.Size = new System.Drawing.Size(119, 15);
            this.lbBatteryProgress.TabIndex = 87;
            this.lbBatteryProgress.Text = "Battery progress: ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbStopCharging
            // 
            this.lbStopCharging.AutoSize = true;
            this.lbStopCharging.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStopCharging.ForeColor = System.Drawing.Color.Maroon;
            this.lbStopCharging.Location = new System.Drawing.Point(164, 384);
            this.lbStopCharging.Name = "lbStopCharging";
            this.lbStopCharging.Size = new System.Drawing.Size(174, 20);
            this.lbStopCharging.TabIndex = 89;
            this.lbStopCharging.Text = "Charging is stopped!";
            this.lbStopCharging.Visible = false;
            // 
            // timerStepProgressBar
            // 
            this.timerStepProgressBar.Tick += new System.EventHandler(this.timerStepProgressBar_Tick);
            // 
            // timerBattery
            // 
            this.timerBattery.Tick += new System.EventHandler(this.timerBattery_Tick);
            // 
            // ControlOrderCurrent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Controls.Add(this.lbStopCharging);
            this.Controls.Add(this.lbBatteryProgressVal);
            this.Controls.Add(this.lbBatteryProgress);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.lbCurrentTimeVal);
            this.Controls.Add(this.lbCurrentTime);
            this.Controls.Add(this.lbTimePassedMinVal);
            this.Controls.Add(this.lbEndTimeExpectVal);
            this.Controls.Add(this.lbStartTimeVal);
            this.Controls.Add(this.lbPercent);
            this.Controls.Add(this.lbTimePassedMin);
            this.Controls.Add(this.lbEndTimeExpect);
            this.Controls.Add(this.lbStartTime);
            this.Controls.Add(this.tbOrderTime);
            this.Controls.Add(this.lbTimeOfOrder);
            this.Controls.Add(this.tbGPS);
            this.Controls.Add(this.lbGPS);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.tbSelectedCharger);
            this.Controls.Add(this.lbCharger);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnStopCharging);
            this.Controls.Add(this.btnStartCharging);
            this.Controls.Add(this.ExitLoginCurrentOrder);
            this.Controls.Add(this.lbDriverLogin);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.tbTimeToCharge);
            this.Controls.Add(this.lbTimeToCharge);
            this.Controls.Add(this.tbCar);
            this.Controls.Add(this.tbBattery);
            this.Controls.Add(this.lbBattery);
            this.Controls.Add(this.lbCar);
            this.Controls.Add(this.lbOrderCurrent);
            this.MaximumSize = new System.Drawing.Size(485, 422);
            this.MinimumSize = new System.Drawing.Size(485, 422);
            this.Name = "ControlOrderCurrent";
            this.Size = new System.Drawing.Size(485, 422);
            this.Load += new System.EventHandler(this.ControlOrderCurrent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTimeToCharge;
        private System.Windows.Forms.Label lbTimeToCharge;
        private System.Windows.Forms.TextBox tbCar;
        private System.Windows.Forms.TextBox tbBattery;
        private System.Windows.Forms.Label lbBattery;
        private System.Windows.Forms.Label lbCar;
        private System.Windows.Forms.Label lbOrderCurrent;
        private System.Windows.Forms.Label lbDriverLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button ExitLoginCurrentOrder;
        private System.Windows.Forms.Button btnStartCharging;
        private System.Windows.Forms.Button btnStopCharging;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox tbSelectedCharger;
        private System.Windows.Forms.Label lbCharger;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox tbGPS;
        private System.Windows.Forms.Label lbGPS;
        private System.Windows.Forms.TextBox tbOrderTime;
        private System.Windows.Forms.Label lbTimeOfOrder;
        private System.Windows.Forms.Label lbStartTime;
        private System.Windows.Forms.Label lbEndTimeExpect;
        private System.Windows.Forms.Label lbTimePassedMin;
        private System.Windows.Forms.Label lbPercent;
        private System.Windows.Forms.Label lbStartTimeVal;
        private System.Windows.Forms.Label lbEndTimeExpectVal;
        private System.Windows.Forms.Label lbTimePassedMinVal;
        private System.Windows.Forms.Label lbCurrentTimeVal;
        private System.Windows.Forms.Label lbCurrentTime;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label lbBatteryProgressVal;
        private System.Windows.Forms.Label lbBatteryProgress;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbStopCharging;
        private System.Windows.Forms.Timer timerStepProgressBar;
        private System.Windows.Forms.Timer timerBattery;


    }
}
