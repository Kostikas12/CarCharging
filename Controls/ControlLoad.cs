using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace CarCharging
{
    public partial class ControlLoad : UserControl
    {
        public ControlLoad()
        {
            InitializeComponent();
            new Direction().CheckOldOrders();
            timer1.Interval = 5300;
            timer1.Start();

        }

        private static ControlLoad InstanceLoad;
        public static ControlLoad Instance
        {
            get
            {
                if (InstanceLoad == null)
                {
                    InstanceLoad = new ControlLoad();
                }
                return InstanceLoad;
            }
        }

        private void ControlLoad_Load(object sender, EventArgs e)
        {

        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Loading();
        }
        private void Loading()
        {
            timer1.Stop();
            controlWLog1.TimerStop();
            this.Visible = false;
            ControlMain.Instance.Visible = true;
            ControlMain.Instance.BringToFront();
        }
    }
}
