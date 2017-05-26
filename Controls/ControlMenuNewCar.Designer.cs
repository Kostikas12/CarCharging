namespace CarCharging
{
    partial class ControlMenuNewCar
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
            this.AddCar = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.TimeToCharge = new System.Windows.Forms.Label();
            this.Battery = new System.Windows.Forms.Label();
            this.CarType = new System.Windows.Forms.Label();
            this.tbChargeTime = new System.Windows.Forms.TextBox();
            this.tbBattery = new System.Windows.Forms.TextBox();
            this.tbCarType = new System.Windows.Forms.TextBox();
            this.lbCarReg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddCar
            // 
            this.AddCar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.AddCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCar.Location = new System.Drawing.Point(139, 236);
            this.AddCar.Name = "AddCar";
            this.AddCar.Size = new System.Drawing.Size(77, 35);
            this.AddCar.TabIndex = 17;
            this.AddCar.Text = "Add car";
            this.AddCar.UseVisualStyleBackColor = false;
            this.AddCar.Click += new System.EventHandler(this.AddCar_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.Location = new System.Drawing.Point(21, 236);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(77, 35);
            this.Cancel.TabIndex = 18;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // TimeToCharge
            // 
            this.TimeToCharge.AutoSize = true;
            this.TimeToCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeToCharge.Location = new System.Drawing.Point(39, 169);
            this.TimeToCharge.Name = "TimeToCharge";
            this.TimeToCharge.Size = new System.Drawing.Size(91, 16);
            this.TimeToCharge.TabIndex = 34;
            this.TimeToCharge.Text = "Charge time";
            // 
            // Battery
            // 
            this.Battery.AutoSize = true;
            this.Battery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Battery.Location = new System.Drawing.Point(39, 118);
            this.Battery.Name = "Battery";
            this.Battery.Size = new System.Drawing.Size(57, 16);
            this.Battery.TabIndex = 33;
            this.Battery.Text = "Battery";
            // 
            // CarType
            // 
            this.CarType.AutoSize = true;
            this.CarType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CarType.Location = new System.Drawing.Point(39, 65);
            this.CarType.Name = "CarType";
            this.CarType.Size = new System.Drawing.Size(66, 16);
            this.CarType.TabIndex = 32;
            this.CarType.Text = "Car type";
            // 
            // tbChargeTime
            // 
            this.tbChargeTime.BackColor = System.Drawing.Color.FloralWhite;
            this.tbChargeTime.Location = new System.Drawing.Point(42, 188);
            this.tbChargeTime.Name = "tbChargeTime";
            this.tbChargeTime.Size = new System.Drawing.Size(144, 20);
            this.tbChargeTime.TabIndex = 31;
            this.tbChargeTime.TextChanged += new System.EventHandler(this.tbChargeTime_TextChanged);
            // 
            // tbBattery
            // 
            this.tbBattery.BackColor = System.Drawing.Color.FloralWhite;
            this.tbBattery.Location = new System.Drawing.Point(42, 137);
            this.tbBattery.Name = "tbBattery";
            this.tbBattery.Size = new System.Drawing.Size(144, 20);
            this.tbBattery.TabIndex = 30;
            this.tbBattery.TextChanged += new System.EventHandler(this.tbBattery_TextChanged);
            // 
            // tbCarType
            // 
            this.tbCarType.BackColor = System.Drawing.Color.FloralWhite;
            this.tbCarType.Location = new System.Drawing.Point(42, 84);
            this.tbCarType.Name = "tbCarType";
            this.tbCarType.Size = new System.Drawing.Size(144, 20);
            this.tbCarType.TabIndex = 29;
            this.tbCarType.TextChanged += new System.EventHandler(this.tbCarType_TextChanged);
            // 
            // lbCarReg
            // 
            this.lbCarReg.AutoSize = true;
            this.lbCarReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCarReg.Location = new System.Drawing.Point(48, 15);
            this.lbCarReg.Name = "lbCarReg";
            this.lbCarReg.Size = new System.Drawing.Size(133, 20);
            this.lbCarReg.TabIndex = 35;
            this.lbCarReg.Text = "Car registration";
            // 
            // ControlMenuNewCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbCarReg);
            this.Controls.Add(this.TimeToCharge);
            this.Controls.Add(this.Battery);
            this.Controls.Add(this.CarType);
            this.Controls.Add(this.tbChargeTime);
            this.Controls.Add(this.tbBattery);
            this.Controls.Add(this.tbCarType);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.AddCar);
            this.Location = new System.Drawing.Point(140, 45);
            this.Name = "ControlMenuNewCar";
            this.Size = new System.Drawing.Size(232, 286);
            this.Load += new System.EventHandler(this.ControlMenuNewCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddCar;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label TimeToCharge;
        private System.Windows.Forms.Label Battery;
        private System.Windows.Forms.Label CarType;
        private System.Windows.Forms.TextBox tbChargeTime;
        private System.Windows.Forms.TextBox tbBattery;
        private System.Windows.Forms.TextBox tbCarType;
        private System.Windows.Forms.Label lbCarReg;
    }
}
