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
    public partial class ControlMenuDelCar : UserControl
    {
        public ControlMenuDelCar()
        {
            InitializeComponent();
        }

        private static ControlMenuDelCar InstanceMenuDelCar;
        public static ControlMenuDelCar Instance
        {
            get
            {
                if (InstanceMenuDelCar == null)
                {
                    InstanceMenuDelCar = new ControlMenuDelCar();
                }
                return InstanceMenuDelCar;
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            new Direction().MenuDeleteSelectedCar();
            this.Visible = false;
            ControlMenu.Instance.EnableMenu();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ControlMenu.Instance.EnableMenu();
        }

        private void ControlMenuDelCar_Load(object sender, EventArgs e)
        {

        }
    }
}
