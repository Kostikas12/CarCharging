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
    public partial class ControlMenuUpdateCar : UserControl
    {
        public ControlMenuUpdateCar()
        {
            InitializeComponent();
            tbBattery.MaxLength = 3;
            tbChargeTime.MaxLength = 3;
            tbCarName.TextAlign = HorizontalAlignment.Center;
            tbCarName.Enabled = false;
            OK.Enabled = false;
            this.tbBattery.KeyPress += new KeyPressEventHandler(this.tbBattery_KeyPress);
            this.tbChargeTime.KeyPress += new KeyPressEventHandler(this.tbChargeTime_KeyPress);
        }

        private static ControlMenuUpdateCar InstanceMenuUpdateCar;
        public static ControlMenuUpdateCar Instance
        {
            get
            {
                if (InstanceMenuUpdateCar == null)
                {
                    InstanceMenuUpdateCar = new ControlMenuUpdateCar();
                }
                return InstanceMenuUpdateCar;
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
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Clear();
            tbBattery.BackColor = Color.FloralWhite;
            this.Visible = false;
            ControlMenu.Instance.EnableMenu();
        }

        public void LoadCar(string CarTypeGetSet)
        {
            tbCarName.Text = CarTypeGetSet;
            tbCarType.Focus();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            car.CarTypeGetSet = tbCarType.Text;
            car.CarBatteryLevelGetSet = int.Parse(tbBattery.Text);
            car.CarTimeToChargeGetSet = int.Parse(tbChargeTime.Text);
            new Direction().MenuUpdateCar(car);
            Clear();
            ControlMenu.Instance.RefreshCars();
            this.Visible = false;
            ControlMenu.Instance.EnableMenu();
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
            if (tbCarType.Text.Length == 0 || tbBattery.Text.Length == 0 || tbChargeTime.Text.Length == 0 || ( tbBattery.Text.Length>2 && Convert.ToInt32(tbBattery.Text)>100)  )
            {
                OK.Enabled = false;
                if ((tbBattery.Text.Length > 2 && Convert.ToInt32(tbBattery.Text) > 100))
                {
                    tbBattery.BackColor = Color.Orange;
                }
            }
            else
            {
                OK.Enabled = true;
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

        private void tbCarName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
