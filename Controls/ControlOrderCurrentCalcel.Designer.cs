namespace CarCharging
{
    partial class ControlOrderCurrentCalcel
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
            this.btnYes = new System.Windows.Forms.Button();
            this.lbCancelCurrentOrder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNo.Location = new System.Drawing.Point(18, 54);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(77, 35);
            this.btnNo.TabIndex = 38;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnYes.Location = new System.Drawing.Point(129, 54);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(77, 35);
            this.btnYes.TabIndex = 37;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // lbCancelCurrentOrder
            // 
            this.lbCancelCurrentOrder.AutoSize = true;
            this.lbCancelCurrentOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCancelCurrentOrder.Location = new System.Drawing.Point(41, 20);
            this.lbCancelCurrentOrder.Name = "lbCancelCurrentOrder";
            this.lbCancelCurrentOrder.Size = new System.Drawing.Size(137, 20);
            this.lbCancelCurrentOrder.TabIndex = 55;
            this.lbCancelCurrentOrder.Text = "Cancel this order?";
            // 
            // ControlOrderCurrentCalcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbCancelCurrentOrder);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Location = new System.Drawing.Point(150, 165);
            this.Name = "ControlOrderCurrentCalcel";
            this.Size = new System.Drawing.Size(224, 107);
            this.Load += new System.EventHandler(this.ControlOrderCurrentCalcel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Label lbCancelCurrentOrder;
    }
}
