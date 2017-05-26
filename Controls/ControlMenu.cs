using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarCharging
{
    public partial class ControlMenu : UserControl
    {
        public ControlMenu()
        {
            InitializeComponent();
            OrderCharge.Enabled = false;
            DelCar.Enabled = false;
            Update.Enabled = false;
            btnToXML.Enabled = false;
            lbNoCars.Visible = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.SelectionChanged += new EventHandler(DataGridViewSelectionChanged);
        }

        private static ControlMenu InstanceMenu;
        public static ControlMenu Instance
        {
            get
            {
                if (InstanceMenu == null)
                {
                    InstanceMenu = new ControlMenu();
                }
                return InstanceMenu;
            }
        }

        public void ControlMenuGo()
        {
            AddLogin();
            new Direction().MenuCheckCars(dataGridView1, lbNoCars, OrderCharge, DelCar, Update, btnToXML);
        }

        public void AddLogin()
        {
            lbDriverLogin.Text = string.Format("{0}", new DriverInfo().LoginGet());
        }
        public void ClearLogin()
        {
            lbDriverLogin.Text = "DriverLogin";
        }

        public void RefreshCars()
        {
            new Direction().MenuCheckCars(dataGridView1, lbNoCars, OrderCharge, DelCar, Update, btnToXML);
        }

        private void ControlMenu_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            lbDriverLogin.Text = "DriverLogin";
            dataGridView1.DataSource = null;
            DelCar.Enabled = false;
            OrderCharge.Enabled = false;
            new DriverInfo().CarSet(null);
            new DriverInfo().LoginPassOfflineClear();
            new DriverInfo().CarsListSet(null);
            ControlMain.Instance.TimerStart();
            ControlMain.Instance.BringToFront();
            ControlMain.Instance.Visible = true;
        }

        private void OrderCharge_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index !=-1)
            {
                new DriverInfo().CarSet(new DriverInfo().CarsListGet().ElementAt(dataGridView1.CurrentRow.Index));
                new DriverInfo().CarsListSet(null);
                new Direction().ToOrderCharge();
            }
        }

        private void labelDriverName_Click(object sender, EventArgs e)
        {

        }

        private void Settings_Click(object sender, EventArgs e)
        {
            new Direction().ToSettings();
        }

        private void lbTextMess_Click(object sender, EventArgs e)
        {

        }

        private void NewCar_Click(object sender, EventArgs e)
        {
            DisableMenu();
            ControlMenuNewCar.Instance.Visible = true;
            ControlMenuNewCar.Instance.FocusCarType();
            ControlMenuNewCar.Instance.BringToFront();
        }

        public void DisableMenu()
        {
            if (new Direction().IndexExistCarsGet() ==0)
            {
                lbNoCars.Visible = false;
            }
            NewCar.Enabled = false;
            Settings.Enabled = false;
            ExitLogin.Enabled = false;
            btnToXML.Enabled = false;
            dataGridView1.Enabled = false;

            Update.Enabled = false;
            DelCar.Enabled = false;
            OrderCharge.Enabled = false;
        }
        public void EnableMenu()
        {
            if (new Direction().IndexExistCarsGet() == 0)
            {
                lbNoCars.Visible = true;
                btnToXML.Enabled = false;
                Update.Enabled = false;
                DelCar.Enabled = false;
                OrderCharge.Enabled = false;
            }
            else
            {
                lbNoCars.Visible = false;
                btnToXML.Enabled = true;
                Update.Enabled = true;
                DelCar.Enabled = true;
                OrderCharge.Enabled = true;
            }
            NewCar.Enabled = true;
            Settings.Enabled = true;
            ExitLogin.Enabled = true;
            dataGridView1.Enabled = true;
        }

        private void DelCar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index!=-1)
            {
                new DriverInfo().CarSet(new DriverInfo().CarsListGet().ElementAt(dataGridView1.CurrentRow.Index));
                DisableMenu();
                ControlMenuDelCar.Instance.Visible = true;
                ControlMenuDelCar.Instance.BringToFront();
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void DataGridViewSelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index == -1)
            {
                DelCar.Enabled = false;
                OrderCharge.Enabled = false;
                Update.Enabled = false;
                new DriverInfo().CarSet(null);
            }
            else
            {
                DelCar.Enabled = true;
                OrderCharge.Enabled = true;
                Update.Enabled = true;
            }
        }

        private void btnToXML_Click(object sender, EventArgs e)
        {
            new Direction().MenuToXML();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index !=-1)
            {
                new DriverInfo().CarSet(new DriverInfo().CarsListGet().ElementAt(dataGridView1.CurrentRow.Index));
                ControlMenuUpdateCar.Instance.LoadCar(new DriverInfo().CarGet().CarTypeGetSet);
                ControlMenuUpdateCar.Instance.Visible = true;
                ControlMenuUpdateCar.Instance.BringToFront();
                DisableMenu();
            }
        }
    }
}
