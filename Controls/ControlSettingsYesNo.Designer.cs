﻿namespace CarCharging
{
    partial class ControlSettingsYesNo
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
            this.btnNo = new System.Windows.Forms.Button();
            this.lbTextDel = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNo.Location = new System.Drawing.Point(20, 56);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(77, 35);
            this.btnNo.TabIndex = 36;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // lbTextDel
            // 
            this.lbTextDel.AutoSize = true;
            this.lbTextDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTextDel.Location = new System.Drawing.Point(22, 17);
            this.lbTextDel.Name = "lbTextDel";
            this.lbTextDel.Size = new System.Drawing.Size(75, 20);
            this.lbTextDel.TabIndex = 34;
            this.lbTextDel.Text = "lbTextDel";
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnYes.Location = new System.Drawing.Point(131, 56);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(77, 35);
            this.btnYes.TabIndex = 35;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // ControlSettingsYesNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.lbTextDel);
            this.Controls.Add(this.btnYes);
            this.Location = new System.Drawing.Point(130, 120);
            this.Name = "ControlSettingsYesNo";
            this.Size = new System.Drawing.Size(224, 107);
            this.Load += new System.EventHandler(this.ControlSettingsYesNo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label lbTextDel;
        private System.Windows.Forms.Button btnYes;
    }
}
