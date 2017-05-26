namespace CarCharging
{
    partial class ControlOrderChargeOk
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
            this.lbTextOK = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTextOK
            // 
            this.lbTextOK.AutoSize = true;
            this.lbTextOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTextOK.Location = new System.Drawing.Point(52, 11);
            this.lbTextOK.Name = "lbTextOK";
            this.lbTextOK.Size = new System.Drawing.Size(91, 20);
            this.lbTextOK.TabIndex = 35;
            this.lbTextOK.Text = "Successful!";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOK.Location = new System.Drawing.Point(59, 40);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(77, 35);
            this.btnOK.TabIndex = 36;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ControlOrderChargeOk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbTextOK);
            this.Controls.Add(this.btnOK);
            this.Location = new System.Drawing.Point(150, 165);
            this.Name = "ControlOrderChargeOk";
            this.Size = new System.Drawing.Size(195, 86);
            this.Load += new System.EventHandler(this.ControlOrderChargeOk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTextOK;
        private System.Windows.Forms.Button btnOK;
    }
}
