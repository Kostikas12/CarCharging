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
    public partial class ControlMenuCarsXml : UserControl
    {
        public ControlMenuCarsXml()
        {
            InitializeComponent();
        }

        private static ControlMenuCarsXml InstanceCarsXml;

        public static ControlMenuCarsXml Instance
        {
            get
            {
                if (InstanceCarsXml == null)
                {
                    InstanceCarsXml = new ControlMenuCarsXml();
                }
                return InstanceCarsXml;
            }
        }
        private void ControlMenuCarsXml_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ControlMenu.Instance.EnableMenu();
        }
    }
}
