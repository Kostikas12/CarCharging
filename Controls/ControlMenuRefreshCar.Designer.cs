namespace CarCharging
{
    partial class ControlMenuRefreshCar
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
            this.lbCarRefresh = new System.Windows.Forms.Label();
            this.TimeToCharge = new System.Windows.Forms.Label();
            this.Battery = new System.Windows.Forms.Label();
            this.CarType = new System.Windows.Forms.Label();
            this.tbChargeTime = new System.Windows.Forms.TextBox();
            this.tbBattery = new System.Windows.Forms.TextBox();
            this.tbCarType = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.tbCarName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbCarRefresh
            // 
            this.lbCarRefresh.AutoSize = true;
            this.lbCarRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCarRefresh.Location = new System.Drawing.Point(63, 11);
            this.lbCarRefresh.Name = "lbCarRefresh";
            this.lbCarRefresh.Size = new System.Drawing.Size(103, 20);
            this.lbCarRefresh.TabIndex = 44;
            this.lbCarRefresh.Text = "Refresh car";
            // 
            // TimeToCharge
            // 
            this.TimeToCharge.AutoSize = true;
            this.TimeToCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeToCharge.Location = new System.Drawing.Point(39, 187);
            this.TimeToCharge.Name = "TimeToCharge";
            this.TimeToCharge.Size = new System.Drawing.Size(103, 16);
            this.TimeToCharge.TabIndex = 43;
            this.TimeToCharge.Text = "Charging time";
            // 
            // Battery
            // 
            this.Battery.AutoSize = true;
            this.Battery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Battery.Location = new System.Drawing.Point(39, 136);
            this.Battery.Name = "Battery";
            this.Battery.Size = new System.Drawing.Size(57, 16);
            this.Battery.TabIndex = 42;
            this.Battery.Text = "Battery";
            // 
            // CarType
            // 
            this.CarType.AutoSize = true;
            this.CarType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CarType.Location = new System.Drawing.Point(39, 83);
            this.CarType.Name = "CarType";
            this.CarType.Size = new System.Drawing.Size(66, 16);
            this.CarType.TabIndex = 41;
            this.CarType.Text = "Car type";
            // 
            // tbChargeTime
            // 
            this.tbChargeTime.Location = new System.Drawing.Point(42, 206);
            this.tbChargeTime.Name = "tbChargeTime";
            this.tbChargeTime.Size = new System.Drawing.Size(144, 20);
            this.tbChargeTime.TabIndex = 40;
            this.tbChargeTime.TextChanged += new System.EventHandler(this.tbChargeTime_TextChanged);
            // 
            // tbBattery
            // 
            this.tbBattery.Location = new System.Drawing.Point(42, 155);
            this.tbBattery.Name = "tbBattery";
            this.tbBattery.Size = new System.Drawing.Size(144, 20);
            this.tbBattery.TabIndex = 39;
            this.tbBattery.TextChanged += new System.EventHandler(this.tbBattery_TextChanged);
            // 
            // tbCarType
            // 
            this.tbCarType.Location = new System.Drawing.Point(42, 102);
            this.tbCarType.Name = "tbCarType";
            this.tbCarType.Size = new System.Drawing.Size(144, 20);
            this.tbCarType.TabIndex = 38;
            this.tbCarType.TextChanged += new System.EventHandler(this.tbCarType_TextChanged);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.Location = new System.Drawing.Point(21, 254);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(77, 35);
            this.Cancel.TabIndex = 37;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.CornflowerBlue;
            this.OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OK.Location = new System.Drawing.Point(139, 254);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(77, 35);
            this.OK.TabIndex = 36;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // tbCarName
            // 
            this.tbCarName.Location = new System.Drawing.Point(42, 51);
            this.tbCarName.Name = "tbCarName";
            this.tbCarName.Size = new System.Drawing.Size(144, 20);
            this.tbCarName.TabIndex = 45;
            // 
            // ControlMenuRefreshCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tbCarName);
            this.Controls.Add(this.lbCarRefresh);
            this.Controls.Add(this.TimeToCharge);
            this.Controls.Add(this.Battery);
            this.Controls.Add(this.CarType);
            this.Controls.Add(this.tbChargeTime);
            this.Controls.Add(this.tbBattery);
            this.Controls.Add(this.tbCarType);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Location = new System.Drawing.Point(140, 45);
            this.Name = "ControlMenuRefreshCar";
            this.Size = new System.Drawing.Size(232, 310);
            this.Load += new System.EventHandler(this.ControlMenuRefreshCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCarRefresh;
        private System.Windows.Forms.Label TimeToCharge;
        private System.Windows.Forms.Label Battery;
        private System.Windows.Forms.Label CarType;
        private System.Windows.Forms.TextBox tbChargeTime;
        private System.Windows.Forms.TextBox tbBattery;
        private System.Windows.Forms.TextBox tbCarType;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox tbCarName;
    }
}
