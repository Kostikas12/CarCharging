namespace CarCharging
{
    partial class ControlReg
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
            this.textBName = new System.Windows.Forms.TextBox();
            this.textBLogin = new System.Windows.Forms.TextBox();
            this.textBAge = new System.Windows.Forms.TextBox();
            this.textBPassword = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Apply = new System.Windows.Forms.Button();
            this.textReg = new System.Windows.Forms.Label();
            this.Age1 = new System.Windows.Forms.Label();
            this.Password1 = new System.Windows.Forms.Label();
            this.Login1 = new System.Windows.Forms.Label();
            this.Name1 = new System.Windows.Forms.Label();
            this.labelTextMess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBName
            // 
            this.textBName.BackColor = System.Drawing.Color.FloralWhite;
            this.textBName.Location = new System.Drawing.Point(237, 127);
            this.textBName.Name = "textBName";
            this.textBName.Size = new System.Drawing.Size(126, 20);
            this.textBName.TabIndex = 10;
            this.textBName.TextChanged += new System.EventHandler(this.textBName_TextChanged);
            // 
            // textBLogin
            // 
            this.textBLogin.BackColor = System.Drawing.Color.FloralWhite;
            this.textBLogin.Location = new System.Drawing.Point(237, 167);
            this.textBLogin.Name = "textBLogin";
            this.textBLogin.Size = new System.Drawing.Size(126, 20);
            this.textBLogin.TabIndex = 12;
            this.textBLogin.TextChanged += new System.EventHandler(this.textBLogin_TextChanged);
            // 
            // textBAge
            // 
            this.textBAge.BackColor = System.Drawing.Color.FloralWhite;
            this.textBAge.Location = new System.Drawing.Point(237, 244);
            this.textBAge.Name = "textBAge";
            this.textBAge.Size = new System.Drawing.Size(126, 20);
            this.textBAge.TabIndex = 16;
            this.textBAge.TextChanged += new System.EventHandler(this.textBAge_TextChanged);
            // 
            // textBPassword
            // 
            this.textBPassword.BackColor = System.Drawing.Color.FloralWhite;
            this.textBPassword.Location = new System.Drawing.Point(237, 204);
            this.textBPassword.Name = "textBPassword";
            this.textBPassword.Size = new System.Drawing.Size(126, 20);
            this.textBPassword.TabIndex = 14;
            this.textBPassword.TextChanged += new System.EventHandler(this.textBPassword_TextChanged);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(405, 384);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(77, 35);
            this.Back.TabIndex = 17;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.Location = new System.Drawing.Point(120, 296);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(105, 48);
            this.Clear.TabIndex = 19;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Apply
            // 
            this.Apply.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Apply.Location = new System.Drawing.Point(258, 296);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(105, 48);
            this.Apply.TabIndex = 20;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = false;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // textReg
            // 
            this.textReg.AutoSize = true;
            this.textReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textReg.Location = new System.Drawing.Point(189, 44);
            this.textReg.Name = "textReg";
            this.textReg.Size = new System.Drawing.Size(107, 20);
            this.textReg.TabIndex = 21;
            this.textReg.Text = "Registration";
            // 
            // Age1
            // 
            this.Age1.AutoSize = true;
            this.Age1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Age1.Location = new System.Drawing.Point(117, 245);
            this.Age1.Name = "Age1";
            this.Age1.Size = new System.Drawing.Size(40, 16);
            this.Age1.TabIndex = 29;
            this.Age1.Text = "Age:";
            // 
            // Password1
            // 
            this.Password1.AutoSize = true;
            this.Password1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password1.Location = new System.Drawing.Point(117, 205);
            this.Password1.Name = "Password1";
            this.Password1.Size = new System.Drawing.Size(80, 16);
            this.Password1.TabIndex = 28;
            this.Password1.Text = "Password:";
            // 
            // Login1
            // 
            this.Login1.AutoSize = true;
            this.Login1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login1.Location = new System.Drawing.Point(117, 168);
            this.Login1.Name = "Login1";
            this.Login1.Size = new System.Drawing.Size(54, 16);
            this.Login1.TabIndex = 27;
            this.Login1.Text = "Login: ";
            // 
            // Name1
            // 
            this.Name1.AutoSize = true;
            this.Name1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name1.Location = new System.Drawing.Point(117, 128);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(57, 16);
            this.Name1.TabIndex = 26;
            this.Name1.Text = "Name: ";
            // 
            // labelTextMess
            // 
            this.labelTextMess.AutoSize = true;
            this.labelTextMess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextMess.Location = new System.Drawing.Point(155, 85);
            this.labelTextMess.Name = "labelTextMess";
            this.labelTextMess.Size = new System.Drawing.Size(199, 20);
            this.labelTextMess.TabIndex = 30;
            this.labelTextMess.Text = "This Login is already exists!";
            // 
            // ControlReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Controls.Add(this.labelTextMess);
            this.Controls.Add(this.Age1);
            this.Controls.Add(this.Password1);
            this.Controls.Add(this.Login1);
            this.Controls.Add(this.Name1);
            this.Controls.Add(this.textReg);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.textBAge);
            this.Controls.Add(this.textBPassword);
            this.Controls.Add(this.textBLogin);
            this.Controls.Add(this.textBName);
            this.MaximumSize = new System.Drawing.Size(485, 422);
            this.MinimumSize = new System.Drawing.Size(485, 422);
            this.Name = "ControlReg";
            this.Size = new System.Drawing.Size(485, 422);
            this.Load += new System.EventHandler(this.ControlReg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBName;
        private System.Windows.Forms.TextBox textBLogin;
        private System.Windows.Forms.TextBox textBAge;
        private System.Windows.Forms.TextBox textBPassword;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.Label textReg;
        private System.Windows.Forms.Label Age1;
        private System.Windows.Forms.Label Password1;
        private System.Windows.Forms.Label Login1;
        private System.Windows.Forms.Label Name1;
        private System.Windows.Forms.Label labelTextMess;
    }
}
