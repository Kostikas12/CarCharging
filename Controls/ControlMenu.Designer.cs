namespace CarCharging
{
    partial class ControlMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelLogin = new System.Windows.Forms.Label();
            this.lbDriverLogin = new System.Windows.Forms.Label();
            this.OrderCharge = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.ExitLogin = new System.Windows.Forms.Button();
            this.NewCar = new System.Windows.Forms.Button();
            this.DelCar = new System.Windows.Forms.Button();
            this.lbNoCars = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnToXML = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(3, 10);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(63, 20);
            this.labelLogin.TabIndex = 7;
            this.labelLogin.Text = "Login: ";
            // 
            // lbDriverLogin
            // 
            this.lbDriverLogin.AutoSize = true;
            this.lbDriverLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDriverLogin.Location = new System.Drawing.Point(59, 10);
            this.lbDriverLogin.Name = "lbDriverLogin";
            this.lbDriverLogin.Size = new System.Drawing.Size(100, 20);
            this.lbDriverLogin.TabIndex = 8;
            this.lbDriverLogin.Text = "DriverLogin";
            this.lbDriverLogin.Click += new System.EventHandler(this.labelDriverName_Click);
            // 
            // OrderCharge
            // 
            this.OrderCharge.BackColor = System.Drawing.Color.CornflowerBlue;
            this.OrderCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderCharge.Location = new System.Drawing.Point(74, 256);
            this.OrderCharge.Name = "OrderCharge";
            this.OrderCharge.Size = new System.Drawing.Size(97, 35);
            this.OrderCharge.TabIndex = 9;
            this.OrderCharge.Text = "Order Charger";
            this.OrderCharge.UseVisualStyleBackColor = false;
            this.OrderCharge.Click += new System.EventHandler(this.OrderCharge_Click);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Settings.Location = new System.Drawing.Point(316, 256);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(97, 35);
            this.Settings.TabIndex = 10;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = false;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // ExitLogin
            // 
            this.ExitLogin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ExitLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitLogin.Location = new System.Drawing.Point(405, 384);
            this.ExitLogin.Name = "ExitLogin";
            this.ExitLogin.Size = new System.Drawing.Size(77, 35);
            this.ExitLogin.TabIndex = 12;
            this.ExitLogin.Text = "Out Login";
            this.ExitLogin.UseVisualStyleBackColor = false;
            this.ExitLogin.Click += new System.EventHandler(this.Back_Click);
            // 
            // NewCar
            // 
            this.NewCar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.NewCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewCar.Location = new System.Drawing.Point(74, 308);
            this.NewCar.Name = "NewCar";
            this.NewCar.Size = new System.Drawing.Size(97, 35);
            this.NewCar.TabIndex = 15;
            this.NewCar.Text = "New car";
            this.NewCar.UseVisualStyleBackColor = false;
            this.NewCar.Click += new System.EventHandler(this.NewCar_Click);
            // 
            // DelCar
            // 
            this.DelCar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.DelCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelCar.Location = new System.Drawing.Point(195, 308);
            this.DelCar.Name = "DelCar";
            this.DelCar.Size = new System.Drawing.Size(97, 35);
            this.DelCar.TabIndex = 16;
            this.DelCar.Text = "Delete car";
            this.DelCar.UseVisualStyleBackColor = false;
            this.DelCar.Click += new System.EventHandler(this.DelCar_Click);
            // 
            // lbNoCars
            // 
            this.lbNoCars.AutoSize = true;
            this.lbNoCars.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.lbNoCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNoCars.Location = new System.Drawing.Point(181, 38);
            this.lbNoCars.Name = "lbNoCars";
            this.lbNoCars.Size = new System.Drawing.Size(136, 20);
            this.lbNoCars.TabIndex = 32;
            this.lbNoCars.Text = "No car was found!";
            this.lbNoCars.Click += new System.EventHandler(this.lbTextMess_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Wheat;
            this.dataGridView1.Location = new System.Drawing.Point(74, 88);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(339, 138);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // btnToXML
            // 
            this.btnToXML.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnToXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnToXML.Location = new System.Drawing.Point(316, 308);
            this.btnToXML.Name = "btnToXML";
            this.btnToXML.Size = new System.Drawing.Size(97, 35);
            this.btnToXML.TabIndex = 34;
            this.btnToXML.Text = "Save to XML";
            this.btnToXML.UseVisualStyleBackColor = false;
            this.btnToXML.Click += new System.EventHandler(this.btnToXML_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Update.Location = new System.Drawing.Point(195, 256);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(97, 35);
            this.Update.TabIndex = 35;
            this.Update.Text = "Update car";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ControlMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Controls.Add(this.Update);
            this.Controls.Add(this.btnToXML);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbNoCars);
            this.Controls.Add(this.DelCar);
            this.Controls.Add(this.NewCar);
            this.Controls.Add(this.ExitLogin);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.OrderCharge);
            this.Controls.Add(this.lbDriverLogin);
            this.Controls.Add(this.labelLogin);
            this.MaximumSize = new System.Drawing.Size(485, 422);
            this.MinimumSize = new System.Drawing.Size(485, 422);
            this.Name = "ControlMenu";
            this.Size = new System.Drawing.Size(485, 422);
            this.Load += new System.EventHandler(this.ControlMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label lbDriverLogin;
        private System.Windows.Forms.Button OrderCharge;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button ExitLogin;
        private System.Windows.Forms.Button NewCar;
        private System.Windows.Forms.Button DelCar;
        private System.Windows.Forms.Label lbNoCars;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnToXML;
        private System.Windows.Forms.Button Update;
    }
}
