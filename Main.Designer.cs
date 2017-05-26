namespace CarCharging
{
    partial class Main
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.registration = new System.Windows.Forms.TabPage();
            this.enter = new System.Windows.Forms.TabPage();
            this.main1 = new System.Windows.Forms.TabPage();
            this.SuspendLayout();
            // 
            // tabcontrol
            // 
            this.tabcontrol.Location = new System.Drawing.Point(0, 0);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(200, 100);
            this.tabcontrol.TabIndex = 1;
            // 
            // registration
            // 
            this.registration.Location = new System.Drawing.Point(0, 0);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(200, 100);
            this.registration.TabIndex = 2;
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(0, 0);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(200, 100);
            this.enter.TabIndex = 3;
            // 
            // main1
            // 
            this.main1.Location = new System.Drawing.Point(0, 0);
            this.main1.Name = "main1";
            this.main1.Size = new System.Drawing.Size(200, 100);
            this.main1.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 422);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 460);
            this.MinimumSize = new System.Drawing.Size(500, 460);
            this.Name = "Main";
            this.Text = "Car Charger";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcontrol;
        private System.Windows.Forms.TabPage registration;
        private System.Windows.Forms.TabPage enter;
        private System.Windows.Forms.TabPage main1;
    }
}

