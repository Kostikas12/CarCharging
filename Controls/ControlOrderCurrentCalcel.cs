using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarCharging
{
    public partial class ControlOrderCurrentCalcel : UserControl
    {
        public ControlOrderCurrentCalcel()
        {
            InitializeComponent();
        }

        private static ControlOrderCurrentCalcel ControlOrderCurrentCalcelInstance;

        public static ControlOrderCurrentCalcel Instance
        {
            get
            {
                if (ControlOrderCurrentCalcelInstance == null)
                {
                    ControlOrderCurrentCalcelInstance = new ControlOrderCurrentCalcel();
                }
                return ControlOrderCurrentCalcelInstance;
            }
        }

        private void ControlOrderCurrentCalcel_Load(object sender, EventArgs e)
        {

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ControlOrderCurrent.Instance.OrderCurrentEnable();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Direction().OrderCurrentCancelByUser();
            ControlOrderCurrent.Instance.OrderCurrentEnable();
            ControlOrderCurrent.Instance.OrderCurrentExitClear();
        }
    }
}
