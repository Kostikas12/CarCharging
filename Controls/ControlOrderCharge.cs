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
    public partial class ControlOrderCharge : UserControl
    {
        public ControlOrderCharge()
        {
            InitializeComponent();
            listBox1.ScrollAlwaysVisible = true;

            tbCar.Enabled = false;
            tbBattery.Enabled = false;
            tbEmptyPlaces.Enabled = false;
            tbAddress.Enabled = false;
            tbgps.Enabled = false;
            tbTime.Enabled = false;
            tbProbability.Enabled = false;
            tbWaitForEmpty.Enabled = false;
            tbOrderedPlaces.Enabled = false;
            tbAllPlaces.Enabled = false;
            lbNoChargers.Visible = false;
            MakeOrder.Enabled = false;

            tbTimeToCharger.MaxLength = 2;

            tbTimeToCharger.KeyPress+=new KeyPressEventHandler(this.tbTimeToCharger_KeyPress);
        }

        private static ControlOrderCharge InstanceOrderCharge;

        public static ControlOrderCharge Instance
        {
            get
            {
                if (InstanceOrderCharge == null)
                {
                    InstanceOrderCharge = new ControlOrderCharge();
                }
                return InstanceOrderCharge;
            }
        }

        private void ControlOrderCharge_Load(object sender, EventArgs e)
        {

        }

        public void OrderChargeLoad()
        {
            if (tbTimeToCharger.Text.Length == 0)
            {
                tbTimeToCharger.BackColor = Color.Orange;
            }
            else
            {
                tbTimeToCharger.BackColor = Color.FloralWhite;
            }
            tbCar.Text = new DriverInfo().CarGet().CarTypeGetSet;
            tbBattery.Text = Convert.ToString(new DriverInfo().CarGet().CarBatteryLevelGetSet) + " %";
            tbTime.Text = Convert.ToString(new DriverInfo().CarGet().CarTimeToChargeGetSet) + " min";
            new Direction().OrderChargeAddChargers(listBox1, lbNoChargers);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Clear();
            lbNoChargers.Visible = false;
            this.Visible = false;
            ControlMenu.Instance.RefreshCars();
            ControlMenu.Instance.BringToFront();
        }

        public void Clear()
        {
            tbCar.Clear();
            tbBattery.Clear();
            tbTime.Clear();
            tbTimeToCharger.Clear();
            listBox1.Items.Clear();
            tbAddress.Clear();
            tbgps.Clear();
            tbAllPlaces.Clear();
            tbEmptyPlaces.Clear();
            tbOrderedPlaces.Clear();
            tbProbability.Clear();
            tbWaitForEmpty.Clear();
            tbTimeToCharger.Clear();
            tbEmptyPlaces.BackColor = Color.FloralWhite;
            MakeOrder.Enabled = false;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex!=-1)
            {
                new DriverInfo().ChargerSelectedSet(new DriverInfo().ChargerListGet().ElementAt(listBox1.SelectedIndex));

                tbAddress.Text = new DriverInfo().ChargerSelectedGet().ChargerAddressGetSet;
                tbgps.Text = new DriverInfo().ChargerSelectedGet().ChargerGPSGetSet;
                tbEmptyPlaces.Text = new DriverInfo().ChargerSelectedGet().NumEmptyPlacesGetSet.ToString();
                tbOrderedPlaces.Text = new DriverInfo().ChargerSelectedGet().NumOrderPlacesGetSet.ToString();
                tbAllPlaces.Text = new DriverInfo().ChargerSelectedGet().NumAllPlacesGetSet.ToString();

                if (tbTimeToCharger.Text.Length!=0)
                {
                    MakeOrder.Enabled = true;
                }
                else
                {
                    MakeOrder.Enabled = false;
                    tbTimeToCharger.Focus();
                }

                if (new DriverInfo().ChargerSelectedGet().NumEmptyPlacesGetSet > 0 && new DriverInfo().ChargerSelectedGet().NumOrderPlacesGetSet == 0)
                {
                    tbProbability.Text = "1";
                    tbWaitForEmpty.Text = "0 minutes!";
                    tbEmptyPlaces.BackColor = Color.FloralWhite;
                }
                else
                {
                    if (new DriverInfo().ChargerSelectedGet().NumEmptyPlacesGetSet == 0 || new DriverInfo().ChargerSelectedGet().NumOrderPlacesGetSet > 0)
                    {
                        new Direction().CountChargerProbability(tbWaitForEmpty, tbProbability);
                        tbEmptyPlaces.BackColor = Color.Orange;
                    }
                }
            }
        }

        private void lbCar_Click(object sender, EventArgs e)
        {

        }

        private void tbCar_TextChanged(object sender, EventArgs e)
        {

        }



        private void MakeOrder_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex!=-1 && tbTimeToCharger.Text.Length!=0)
            {
                new Direction().MakeOrder(tbTimeToCharger);
                OrderChargeDisable();
                ControlOrderChargeOk.Instance.Visible = true;
                ControlOrderChargeOk.Instance.BringToFront();
            }
        }

        private void OrderChargeDisable()
        {
            tbTimeToCharger.Enabled = false;
            MakeOrder.Enabled = false;
            Back.Enabled = false;
            listBox1.Enabled = false;
        }
        public void OrderChargeEnable()
        {
            tbTimeToCharger.Enabled = true;
            MakeOrder.Enabled = true;
            Back.Enabled = true;
            listBox1.Enabled = true;
        }

        private void tbTimeToCharger_TextChanged(object sender, EventArgs e)
        {
            if (tbTimeToCharger.Text.Length != 0 && listBox1.SelectedIndex != -1)
            {
                MakeOrder.Enabled = true;
            }
            else
            {
                MakeOrder.Enabled = false;
            }

            if (tbTimeToCharger.Text.Length == 0)
            {
                tbTimeToCharger.BackColor = Color.Orange;
            }
            else
            {
                tbTimeToCharger.BackColor = Color.FloralWhite;
            }
        }
        private void tbTimeToCharger_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbProbability_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEmptyPlaces_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
