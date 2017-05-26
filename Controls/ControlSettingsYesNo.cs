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
    public partial class ControlSettingsYesNo : UserControl
    {
        public ControlSettingsYesNo()
        {
            InitializeComponent();
        }

        private static ControlSettingsYesNo InstanceSettingsYesNo;
        public static ControlSettingsYesNo Instance
        {
            get
            {
                if (InstanceSettingsYesNo == null)
                {
                    InstanceSettingsYesNo = new ControlSettingsYesNo();
                }
                return InstanceSettingsYesNo;
            }
        }

        public void AddLoginYesNo(string s)
        {
            lbTextDel.Text = s;
        }
        private void ControlSettingsYesNo_Load(object sender, EventArgs e)
        {

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            lbTextDel.Text = "lbTextDel";
            ControlSettings.Instance.EnableSettings();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            ControlSettings.Instance.GraphUnvisible();
            this.Visible = false;
            lbTextDel.Text = "lbTextDel";
            ControlSettings.Instance.EnableSettings();
            ControlMenu.Instance.ClearLogin();
            new Direction().DeleteLoginAndToMain();
        }
    }
}
