namespace CarCharging
{
    partial class ControlOrderCharge
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
            this.Back = new System.Windows.Forms.Button();
            this.lbOrderCharge = new System.Windows.Forms.Label();
            this.lbCar = new System.Windows.Forms.Label();
            this.lbBattery = new System.Windows.Forms.Label();
            this.tbBattery = new System.Windows.Forms.TextBox();
            this.tbCar = new System.Windows.Forms.TextBox();
            this.lbChargers = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.MakeOrder = new System.Windows.Forms.Button();
            this.tbgps = new System.Windows.Forms.TextBox();
            this.lbgps = new System.Windows.Forms.Label();
            this.tbEmptyPlaces = new System.Windows.Forms.TextBox();
            this.lbEmptyPlaces = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbNoChargers = new System.Windows.Forms.Label();
            this.tbWaitForEmpty = new System.Windows.Forms.TextBox();
            this.lbTimeWaitEmptyPlace = new System.Windows.Forms.Label();
            this.tbProbability = new System.Windows.Forms.TextBox();
            this.lbProbabilityCharger = new System.Windows.Forms.Label();
            this.tbTimeToCharger = new System.Windows.Forms.TextBox();
            this.lbTimeToCharger = new System.Windows.Forms.Label();
            this.tbOrderedPlaces = new System.Windows.Forms.TextBox();
            this.lbOrderedPlaces = new System.Windows.Forms.Label();
            this.tbAllPlaces = new System.Windows.Forms.TextBox();
            this.lbAllPlaces = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(405, 384);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(77, 35);
            this.Back.TabIndex = 13;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // lbOrderCharge
            // 
            this.lbOrderCharge.AutoSize = true;
            this.lbOrderCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbOrderCharge.Location = new System.Drawing.Point(172, 26);
            this.lbOrderCharge.Name = "lbOrderCharge";
            this.lbOrderCharge.Size = new System.Drawing.Size(180, 20);
            this.lbOrderCharge.TabIndex = 36;
            this.lbOrderCharge.Text = "Order charger station";
            // 
            // lbCar
            // 
            this.lbCar.AutoSize = true;
            this.lbCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCar.Location = new System.Drawing.Point(58, 61);
            this.lbCar.Name = "lbCar";
            this.lbCar.Size = new System.Drawing.Size(91, 15);
            this.lbCar.TabIndex = 37;
            this.lbCar.Text = "Selected car:";
            this.lbCar.Click += new System.EventHandler(this.lbCar_Click);
            // 
            // lbBattery
            // 
            this.lbBattery.AutoSize = true;
            this.lbBattery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBattery.Location = new System.Drawing.Point(58, 81);
            this.lbBattery.Name = "lbBattery";
            this.lbBattery.Size = new System.Drawing.Size(55, 15);
            this.lbBattery.TabIndex = 38;
            this.lbBattery.Text = "Battery:";
            // 
            // tbBattery
            // 
            this.tbBattery.BackColor = System.Drawing.Color.FloralWhite;
            this.tbBattery.Location = new System.Drawing.Point(199, 80);
            this.tbBattery.Name = "tbBattery";
            this.tbBattery.Size = new System.Drawing.Size(153, 20);
            this.tbBattery.TabIndex = 39;
            // 
            // tbCar
            // 
            this.tbCar.BackColor = System.Drawing.Color.FloralWhite;
            this.tbCar.Location = new System.Drawing.Point(199, 60);
            this.tbCar.Name = "tbCar";
            this.tbCar.Size = new System.Drawing.Size(153, 20);
            this.tbCar.TabIndex = 40;
            this.tbCar.TextChanged += new System.EventHandler(this.tbCar_TextChanged);
            // 
            // lbChargers
            // 
            this.lbChargers.AutoSize = true;
            this.lbChargers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbChargers.Location = new System.Drawing.Point(58, 153);
            this.lbChargers.Name = "lbChargers";
            this.lbChargers.Size = new System.Drawing.Size(113, 15);
            this.lbChargers.TabIndex = 42;
            this.lbChargers.Text = "Chargers online:";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FloralWhite;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(61, 171);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(291, 69);
            this.listBox1.TabIndex = 41;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // MakeOrder
            // 
            this.MakeOrder.BackColor = System.Drawing.Color.CornflowerBlue;
            this.MakeOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MakeOrder.Location = new System.Drawing.Point(367, 182);
            this.MakeOrder.Name = "MakeOrder";
            this.MakeOrder.Size = new System.Drawing.Size(105, 48);
            this.MakeOrder.TabIndex = 43;
            this.MakeOrder.Text = "Make Order";
            this.MakeOrder.UseVisualStyleBackColor = false;
            this.MakeOrder.Click += new System.EventHandler(this.MakeOrder_Click);
            // 
            // tbgps
            // 
            this.tbgps.BackColor = System.Drawing.Color.FloralWhite;
            this.tbgps.Location = new System.Drawing.Point(199, 266);
            this.tbgps.Name = "tbgps";
            this.tbgps.Size = new System.Drawing.Size(153, 20);
            this.tbgps.TabIndex = 46;
            // 
            // lbgps
            // 
            this.lbgps.AutoSize = true;
            this.lbgps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbgps.Location = new System.Drawing.Point(58, 267);
            this.lbgps.Name = "lbgps";
            this.lbgps.Size = new System.Drawing.Size(39, 15);
            this.lbgps.TabIndex = 45;
            this.lbgps.Text = "GPS:";
            // 
            // tbEmptyPlaces
            // 
            this.tbEmptyPlaces.BackColor = System.Drawing.Color.FloralWhite;
            this.tbEmptyPlaces.Location = new System.Drawing.Point(199, 306);
            this.tbEmptyPlaces.Name = "tbEmptyPlaces";
            this.tbEmptyPlaces.Size = new System.Drawing.Size(153, 20);
            this.tbEmptyPlaces.TabIndex = 49;
            this.tbEmptyPlaces.TextChanged += new System.EventHandler(this.tbEmptyPlaces_TextChanged);
            // 
            // lbEmptyPlaces
            // 
            this.lbEmptyPlaces.AutoSize = true;
            this.lbEmptyPlaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEmptyPlaces.Location = new System.Drawing.Point(58, 307);
            this.lbEmptyPlaces.Name = "lbEmptyPlaces";
            this.lbEmptyPlaces.Size = new System.Drawing.Size(96, 15);
            this.lbEmptyPlaces.TabIndex = 48;
            this.lbEmptyPlaces.Text = "Empty places:";
            // 
            // tbAddress
            // 
            this.tbAddress.BackColor = System.Drawing.Color.FloralWhite;
            this.tbAddress.Location = new System.Drawing.Point(199, 246);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(153, 20);
            this.tbAddress.TabIndex = 51;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAddress.Location = new System.Drawing.Point(58, 247);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(62, 15);
            this.lbAddress.TabIndex = 50;
            this.lbAddress.Text = "Address:";
            // 
            // tbTime
            // 
            this.tbTime.BackColor = System.Drawing.Color.FloralWhite;
            this.tbTime.Location = new System.Drawing.Point(199, 100);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(153, 20);
            this.tbTime.TabIndex = 53;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTime.Location = new System.Drawing.Point(58, 101);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(103, 15);
            this.lbTime.TabIndex = 52;
            this.lbTime.Text = "Time charging:";
            // 
            // lbNoChargers
            // 
            this.lbNoChargers.AutoSize = true;
            this.lbNoChargers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNoChargers.Location = new System.Drawing.Point(177, 153);
            this.lbNoChargers.Name = "lbNoChargers";
            this.lbNoChargers.Size = new System.Drawing.Size(131, 15);
            this.lbNoChargers.TabIndex = 54;
            this.lbNoChargers.Text = "no online chargers!";
            // 
            // tbWaitForEmpty
            // 
            this.tbWaitForEmpty.BackColor = System.Drawing.Color.FloralWhite;
            this.tbWaitForEmpty.Location = new System.Drawing.Point(199, 366);
            this.tbWaitForEmpty.Name = "tbWaitForEmpty";
            this.tbWaitForEmpty.Size = new System.Drawing.Size(153, 20);
            this.tbWaitForEmpty.TabIndex = 56;
            // 
            // lbTimeWaitEmptyPlace
            // 
            this.lbTimeWaitEmptyPlace.AutoSize = true;
            this.lbTimeWaitEmptyPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTimeWaitEmptyPlace.Location = new System.Drawing.Point(58, 367);
            this.lbTimeWaitEmptyPlace.Name = "lbTimeWaitEmptyPlace";
            this.lbTimeWaitEmptyPlace.Size = new System.Drawing.Size(141, 15);
            this.lbTimeWaitEmptyPlace.TabIndex = 55;
            this.lbTimeWaitEmptyPlace.Text = "Wait for empty place:";
            // 
            // tbProbability
            // 
            this.tbProbability.BackColor = System.Drawing.Color.FloralWhite;
            this.tbProbability.Location = new System.Drawing.Point(199, 346);
            this.tbProbability.Name = "tbProbability";
            this.tbProbability.Size = new System.Drawing.Size(153, 20);
            this.tbProbability.TabIndex = 58;
            this.tbProbability.TextChanged += new System.EventHandler(this.tbProbability_TextChanged);
            // 
            // lbProbabilityCharger
            // 
            this.lbProbabilityCharger.AutoSize = true;
            this.lbProbabilityCharger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbProbabilityCharger.Location = new System.Drawing.Point(58, 347);
            this.lbProbabilityCharger.Name = "lbProbabilityCharger";
            this.lbProbabilityCharger.Size = new System.Drawing.Size(133, 15);
            this.lbProbabilityCharger.TabIndex = 57;
            this.lbProbabilityCharger.Text = "Charger probability:";
            // 
            // tbTimeToCharger
            // 
            this.tbTimeToCharger.BackColor = System.Drawing.Color.FloralWhite;
            this.tbTimeToCharger.Location = new System.Drawing.Point(199, 120);
            this.tbTimeToCharger.Name = "tbTimeToCharger";
            this.tbTimeToCharger.Size = new System.Drawing.Size(153, 20);
            this.tbTimeToCharger.TabIndex = 60;
            this.tbTimeToCharger.TextChanged += new System.EventHandler(this.tbTimeToCharger_TextChanged);
            // 
            // lbTimeToCharger
            // 
            this.lbTimeToCharger.AutoSize = true;
            this.lbTimeToCharger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTimeToCharger.Location = new System.Drawing.Point(58, 121);
            this.lbTimeToCharger.Name = "lbTimeToCharger";
            this.lbTimeToCharger.Size = new System.Drawing.Size(112, 15);
            this.lbTimeToCharger.TabIndex = 59;
            this.lbTimeToCharger.Text = "Time to charger:";
            // 
            // tbOrderedPlaces
            // 
            this.tbOrderedPlaces.BackColor = System.Drawing.Color.FloralWhite;
            this.tbOrderedPlaces.Location = new System.Drawing.Point(199, 326);
            this.tbOrderedPlaces.Name = "tbOrderedPlaces";
            this.tbOrderedPlaces.Size = new System.Drawing.Size(153, 20);
            this.tbOrderedPlaces.TabIndex = 62;
            // 
            // lbOrderedPlaces
            // 
            this.lbOrderedPlaces.AutoSize = true;
            this.lbOrderedPlaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbOrderedPlaces.Location = new System.Drawing.Point(58, 327);
            this.lbOrderedPlaces.Name = "lbOrderedPlaces";
            this.lbOrderedPlaces.Size = new System.Drawing.Size(109, 15);
            this.lbOrderedPlaces.TabIndex = 61;
            this.lbOrderedPlaces.Text = "Ordered places:";
            // 
            // tbAllPlaces
            // 
            this.tbAllPlaces.BackColor = System.Drawing.Color.FloralWhite;
            this.tbAllPlaces.Location = new System.Drawing.Point(199, 286);
            this.tbAllPlaces.Name = "tbAllPlaces";
            this.tbAllPlaces.Size = new System.Drawing.Size(153, 20);
            this.tbAllPlaces.TabIndex = 64;
            // 
            // lbAllPlaces
            // 
            this.lbAllPlaces.AutoSize = true;
            this.lbAllPlaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAllPlaces.Location = new System.Drawing.Point(58, 287);
            this.lbAllPlaces.Name = "lbAllPlaces";
            this.lbAllPlaces.Size = new System.Drawing.Size(73, 15);
            this.lbAllPlaces.TabIndex = 63;
            this.lbAllPlaces.Text = "All places:";
            // 
            // ControlOrderCharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Controls.Add(this.tbAllPlaces);
            this.Controls.Add(this.lbAllPlaces);
            this.Controls.Add(this.tbOrderedPlaces);
            this.Controls.Add(this.lbOrderedPlaces);
            this.Controls.Add(this.tbTimeToCharger);
            this.Controls.Add(this.lbTimeToCharger);
            this.Controls.Add(this.tbProbability);
            this.Controls.Add(this.lbProbabilityCharger);
            this.Controls.Add(this.tbWaitForEmpty);
            this.Controls.Add(this.lbTimeWaitEmptyPlace);
            this.Controls.Add(this.lbNoChargers);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.tbEmptyPlaces);
            this.Controls.Add(this.lbEmptyPlaces);
            this.Controls.Add(this.tbgps);
            this.Controls.Add(this.lbgps);
            this.Controls.Add(this.MakeOrder);
            this.Controls.Add(this.lbChargers);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tbCar);
            this.Controls.Add(this.tbBattery);
            this.Controls.Add(this.lbBattery);
            this.Controls.Add(this.lbCar);
            this.Controls.Add(this.lbOrderCharge);
            this.Controls.Add(this.Back);
            this.MaximumSize = new System.Drawing.Size(485, 422);
            this.MinimumSize = new System.Drawing.Size(485, 422);
            this.Name = "ControlOrderCharge";
            this.Size = new System.Drawing.Size(485, 422);
            this.Load += new System.EventHandler(this.ControlOrderCharge_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label lbOrderCharge;
        private System.Windows.Forms.Label lbCar;
        private System.Windows.Forms.Label lbBattery;
        private System.Windows.Forms.TextBox tbBattery;
        private System.Windows.Forms.TextBox tbCar;
        private System.Windows.Forms.Label lbChargers;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button MakeOrder;
        private System.Windows.Forms.TextBox tbgps;
        private System.Windows.Forms.Label lbgps;
        private System.Windows.Forms.TextBox tbEmptyPlaces;
        private System.Windows.Forms.Label lbEmptyPlaces;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbNoChargers;
        private System.Windows.Forms.TextBox tbWaitForEmpty;
        private System.Windows.Forms.Label lbTimeWaitEmptyPlace;
        private System.Windows.Forms.TextBox tbProbability;
        private System.Windows.Forms.Label lbProbabilityCharger;
        private System.Windows.Forms.TextBox tbTimeToCharger;
        private System.Windows.Forms.Label lbTimeToCharger;
        private System.Windows.Forms.TextBox tbOrderedPlaces;
        private System.Windows.Forms.Label lbOrderedPlaces;
        private System.Windows.Forms.TextBox tbAllPlaces;
        private System.Windows.Forms.Label lbAllPlaces;
    }
}
