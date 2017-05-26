namespace CarCharging
{
    partial class ControlSettings
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
            this.Stats = new System.Windows.Forms.Button();
            this.DelLogin = new System.Windows.Forms.Button();
            this.textSettings = new System.Windows.Forms.Label();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.controlSettingsGraph1 = new CarCharging.ControlSettingsGraph();
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
            // Stats
            // 
            this.Stats.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Stats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Stats.Location = new System.Drawing.Point(277, 307);
            this.Stats.Name = "Stats";
            this.Stats.Size = new System.Drawing.Size(117, 41);
            this.Stats.TabIndex = 15;
            this.Stats.Text = "Statistic";
            this.Stats.UseVisualStyleBackColor = false;
            this.Stats.Click += new System.EventHandler(this.Stats_Click);
            // 
            // DelLogin
            // 
            this.DelLogin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.DelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelLogin.Location = new System.Drawing.Point(94, 307);
            this.DelLogin.Name = "DelLogin";
            this.DelLogin.Size = new System.Drawing.Size(117, 41);
            this.DelLogin.TabIndex = 16;
            this.DelLogin.Text = "Delete Login";
            this.DelLogin.UseVisualStyleBackColor = false;
            this.DelLogin.Click += new System.EventHandler(this.DelLogin_Click);
            // 
            // textSettings
            // 
            this.textSettings.AutoSize = true;
            this.textSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textSettings.Location = new System.Drawing.Point(201, 43);
            this.textSettings.Name = "textSettings";
            this.textSettings.Size = new System.Drawing.Size(76, 20);
            this.textSettings.TabIndex = 22;
            this.textSettings.Text = "Settings";
            // 
            // elementHost1
            // 
            this.elementHost1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.elementHost1.Location = new System.Drawing.Point(94, 79);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(300, 218);
            this.elementHost1.TabIndex = 23;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.elementHost1_ChildChanged);
            this.elementHost1.Child = this.controlSettingsGraph1;
            // 
            // ControlSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.textSettings);
            this.Controls.Add(this.DelLogin);
            this.Controls.Add(this.Stats);
            this.Controls.Add(this.Back);
            this.MaximumSize = new System.Drawing.Size(485, 422);
            this.MinimumSize = new System.Drawing.Size(485, 422);
            this.Name = "ControlSettings";
            this.Size = new System.Drawing.Size(485, 422);
            this.Load += new System.EventHandler(this.ControlSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Stats;
        private System.Windows.Forms.Button DelLogin;
        private System.Windows.Forms.Label textSettings;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private ControlSettingsGraph controlSettingsGraph1;
    }
}
