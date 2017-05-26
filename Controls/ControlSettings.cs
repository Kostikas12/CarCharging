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
    public partial class ControlSettings : UserControl
    {
        public ControlSettings()
        {
            InitializeComponent();
        }
        private static ControlSettings InstanceSettings;
        public static ControlSettings Instance
        {
            get
            {
                if (InstanceSettings == null)
                {
                    InstanceSettings = new ControlSettings();
                }
                return InstanceSettings;
            }
            set
            {
                InstanceSettings = value;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            ControlMenu.Instance.RefreshCars();
            controlSettingsGraph1.GraphUnvisible();
            this.Visible = false;
            ControlMenu.Instance.Visible = true;
            ControlMenu.Instance.BringToFront();
        }

        private void ControlSettings_Load(object sender, EventArgs e)
        {

        }

        private void DelLogin_Click(object sender, EventArgs e)
        {
            Stats.Enabled = false;
            DelLogin.Enabled = false;
            Back.Enabled = false;
            string st = string.Format("Delete Login: "+new DriverInfo().LoginGet()+"?");
            ControlSettingsYesNo.Instance.AddLoginYesNo(st);
            ControlSettingsYesNo.Instance.Visible = true;
            ControlSettingsYesNo.Instance.BringToFront();
        }

        private void panelDelete_Paint(object sender, PaintEventArgs e)
        {

        }

        public void EnableSettings()
        {
            Stats.Enabled = true;
            DelLogin.Enabled = true;
            Back.Enabled = true;
        }

        private void Stats_Click(object sender, EventArgs e)
        {
            controlSettingsGraph1.MakeGraph();
            controlSettingsGraph1.GraphVisible();
        }
        public void GraphUnvisible()
        {
            controlSettingsGraph1.GraphUnvisible();
        }
        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
