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
    public partial class ControlOrderChargeOk : UserControl
    {
        public ControlOrderChargeOk()
        {
            InitializeComponent();
        }

        private static ControlOrderChargeOk ControlOrderChargeOkInstance;
        public static ControlOrderChargeOk Instance
        {
            get
            {
                if (ControlOrderChargeOkInstance == null)
                {
                    ControlOrderChargeOkInstance = new ControlOrderChargeOk();
                }
                return ControlOrderChargeOkInstance;
            }
        }
        private void ControlOrderChargeOk_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ControlOrderCharge.Instance.Clear();
            ControlOrderCharge.Instance.OrderChargeEnable();
            ControlOrderCurrent.Instance.LoadFromOrder();
            ControlOrderCurrent.Instance.Visible = true;
            ControlOrderCurrent.Instance.BringToFront();
        }
    }
}
