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
    public partial class ControlMainAbout : UserControl
    {
        public ControlMainAbout()
        {
            InitializeComponent();
        }
        private static ControlMainAbout InstanceAbout;

        public static ControlMainAbout Instance
        {
            get
            {
                if (InstanceAbout == null)
                {
                    InstanceAbout = new ControlMainAbout();
                }
                return InstanceAbout;
            }
        }

        private void ControlMainAbout_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ControlMain.Instance.EnableMain();
        }
    }
}
