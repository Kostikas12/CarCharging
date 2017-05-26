namespace CarCharging
{
    partial class ControlEnter
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
            this.Login = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.TextEnter = new System.Windows.Forms.Label();
            this.Enter = new System.Windows.Forms.Button();
            this.lbTextMess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(131, 195);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(54, 16);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login: ";
            this.Login.Click += new System.EventHandler(this.label1_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(131, 245);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(84, 16);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password: ";
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(405, 384);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(77, 35);
            this.Back.TabIndex = 2;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // tbLogin
            // 
            this.tbLogin.BackColor = System.Drawing.Color.FloralWhite;
            this.tbLogin.Location = new System.Drawing.Point(221, 194);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(126, 20);
            this.tbLogin.TabIndex = 3;
            this.tbLogin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.Color.FloralWhite;
            this.tbPass.Location = new System.Drawing.Point(221, 242);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(126, 20);
            this.tbPass.TabIndex = 4;
            this.tbPass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TextEnter
            // 
            this.TextEnter.AutoSize = true;
            this.TextEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextEnter.Location = new System.Drawing.Point(193, 44);
            this.TextEnter.Name = "TextEnter";
            this.TextEnter.Size = new System.Drawing.Size(96, 20);
            this.TextEnter.TabIndex = 5;
            this.TextEnter.Text = "Enter login";
            // 
            // Enter
            // 
            this.Enter.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enter.Location = new System.Drawing.Point(242, 291);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(105, 48);
            this.Enter.TabIndex = 6;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = false;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // lbTextMess
            // 
            this.lbTextMess.AutoSize = true;
            this.lbTextMess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTextMess.Location = new System.Drawing.Point(130, 142);
            this.lbTextMess.Name = "lbTextMess";
            this.lbTextMess.Size = new System.Drawing.Size(222, 20);
            this.lbTextMess.TabIndex = 31;
            this.lbTextMess.Text = "Login or password is incorrect!";
            this.lbTextMess.Click += new System.EventHandler(this.lbTextMess_Click);
            // 
            // ControlEnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Controls.Add(this.lbTextMess);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.TextEnter);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.MaximumSize = new System.Drawing.Size(485, 422);
            this.MinimumSize = new System.Drawing.Size(485, 422);
            this.Name = "ControlEnter";
            this.Size = new System.Drawing.Size(485, 422);
            this.Load += new System.EventHandler(this.ControlEnter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label TextEnter;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Label lbTextMess;
    }
}
