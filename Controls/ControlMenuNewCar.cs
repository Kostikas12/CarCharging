using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarCharging
{
    public partial class ControlMenuNewCar : UserControl
    {
        public ControlMenuNewCar()
        {
            InitializeComponent();
            tbBattery.BackColor = Color.FloralWhite;
            this.tbBattery.KeyPress += new KeyPressEventHandler(this.tbBattery_KeyPress);
            this.tbChargeTime.KeyPress += new KeyPressEventHandler(this.tbChargeTime_KeyPress);
            AddCar.Enabled = false;
            tbCarType.MaxLength = 15;
            tbBattery.MaxLength = 3;
            tbChargeTime.MaxLength = 3;
        }

        private static ControlMenuNewCar InstanceMenuNewCar;
        public static ControlMenuNewCar Instance
        {
            get
            {
                if (InstanceMenuNewCar == null)
                {
                    InstanceMenuNewCar = new ControlMenuNewCar();
                }
                return InstanceMenuNewCar;
            }
        }

        public void FocusCarType()
        {
            tbCarType.Focus();
        }

        private void ControlMenuNewCar_Load(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            CancelClickFun();
        }
        public void CancelClickFun()
        {
            tbCarType.Clear();
            tbBattery.Clear();
            tbChargeTime.Clear();
            tbBattery.BackColor = Color.FloralWhite;
            this.Visible = false;
            ControlMenu.Instance.EnableMenu();
        }

        private void tbCarType_TextChanged(object sender, EventArgs e)
        {
            CheckTextBox();
        }

        private void tbBattery_TextChanged(object sender, EventArgs e)
        {
            CheckTextBox();
        }

        private void tbChargeTime_TextChanged(object sender, EventArgs e)
        {
            CheckTextBox();
        }

        private void CheckTextBox()
        {
            if (tbCarType.Text.Length == 0 || tbBattery.Text.Length == 0 || tbChargeTime.Text.Length == 0 || (tbBattery.Text.Length > 2 && Convert.ToInt32(tbBattery.Text) > 100) )
            {
                AddCar.Enabled = false;
                if ((tbBattery.Text.Length > 2 && Convert.ToInt32(tbBattery.Text) > 100))
                {
                    tbBattery.BackColor = Color.Orange;
                }
            }
            else
            {
                AddCar.Enabled = true;
                tbBattery.BackColor = Color.FloralWhite;
            }
        }

        private void tbBattery_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Back) || Char.IsDigit(e.KeyChar))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbChargeTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Back) || Char.IsDigit(e.KeyChar))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void AddCar_Click(object sender, EventArgs e)
        {
            new Direction().MenuAddCar(tbCarType, tbBattery, tbChargeTime);
        }
    }
}
