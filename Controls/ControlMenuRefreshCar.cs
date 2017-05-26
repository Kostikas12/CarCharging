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
    public partial class ControlMenuRefreshCar : UserControl
    {
        public ControlMenuRefreshCar()
        {
            InitializeComponent();
            tbCarName.TextAlign = HorizontalAlignment.Center;
            tbCarName.Enabled = false;
            OK.Enabled = false;
        }

        private static ControlMenuRefreshCar InstanceMenuRefreshCar;
        public static ControlMenuRefreshCar Instance
        {
            get
            {
                if (InstanceMenuRefreshCar == null)
                {
                    InstanceMenuRefreshCar = new ControlMenuRefreshCar();
                }
                return InstanceMenuRefreshCar;
            }
        }
        private void ControlMenuRefreshCar_Load(object sender, EventArgs e)
        {

        }
        private void Clear()
        {
            tbCarName.Clear();
            tbCarType.Clear();
            tbBattery.Clear();
            tbChargeTime.Clear();
            OK.Enabled = false;
            ControlMenu.Instance.EnableMenu();
            this.Visible = false;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void LoadCar(string CarTypeGetSet)
        {
            tbCarName.Text = CarTypeGetSet;
            tbCarType.Focus();
        }

        private void OK_Click(object sender, EventArgs e)
        {

            Clear();
        }

        private void tbCarType_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }

        private void tbBattery_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }

        private void tbChargeTime_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }

        private void CheckTextBoxes()
        {
            if (tbCarType.Text.Length == 0 || tbBattery.Text.Length == 0 || tbChargeTime.Text.Length == 0)
            {
                OK.Enabled = false;
            }
            else
            {
                OK.Enabled = true;
            }
        }
    }
}
