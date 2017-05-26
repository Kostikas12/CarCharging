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
    public partial class ControlRegOk : UserControl
    {
        public ControlRegOk()
        {
            InitializeComponent();
        }

        private static ControlRegOk InstanceRegOk;
        public static ControlRegOk Instance
        {
            get
            {
                if (InstanceRegOk == null)
                {
                    InstanceRegOk = new ControlRegOk();
                }
                return InstanceRegOk;
            }
        }

        private void ControlRegOk_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ControlReg.Instance.EnableClearRegToEnter();
        }
    }
}
