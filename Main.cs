using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarCharging
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.Controls.Add(ControlMain.Instance);
            this.Controls.Add(ControlReg.Instance);
            this.Controls.Add(ControlEnter.Instance);
            this.Controls.Add(ControlMenu.Instance);
            this.Controls.Add(ControlSettings.Instance);
            this.Controls.Add(ControlOrderCharge.Instance);
            this.Controls.Add(ControlLoad.Instance);
            this.Controls.Add(ControlMenuNewCar.Instance);
            this.Controls.Add(ControlMenuDelCar.Instance);
            this.Controls.Add(ControlMenuCarsXml.Instance);
            this.Controls.Add(ControlMenuUpdateCar.Instance);
            this.Controls.Add(ControlRegOk.Instance);
            this.Controls.Add(ControlSettingsYesNo.Instance);
            this.Controls.Add(ControlOrderChargeOk.Instance);
            this.Controls.Add(ControlOrderCurrent.Instance);
            this.Controls.Add(ControlOrderCurrentCalcel.Instance);

            ControlLoad.Instance.Visible = true;
            ControlLoad.Instance.BringToFront();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void controlMain1_Load(object sender, EventArgs e)
        {

        }
    }
}
