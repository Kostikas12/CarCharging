using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CarCharging
{
    public partial class ControlMain : UserControl
    {
        public ControlMain()
        {
            InitializeComponent();
            this.Controls.Add(ControlMainAbout.Instance);
            ControlMainAbout.Instance.BringToFront();
            ControlMainAbout.Instance.Visible = false;
            ControlLoad.Instance.BringToFront();
            pictureBox1.MouseClick+=ControlMain_MouseClick;
            pictureBox2.MouseClick += ControlMain_MouseClick;
            pictureBox3.MouseClick += ControlMain_MouseClick;
            pictureBox4.MouseClick += ControlMain_MouseClick;
            pictureBox5.MouseClick += ControlMain_MouseClick;
            Start();
        }

        private static ControlMain InstanceMain;
        public static ControlMain Instance
        {
            get
            {
                if (InstanceMain == null)
                {
                    InstanceMain = new ControlMain();
                }
                return InstanceMain;
            }
        }

        private void Start()
        {
            FileStream f1 = new FileStream(new ConnString().AppPathGet() + @"\photo\p1.jpg", FileMode.Open);
            Image img1 = Image.FromStream(f1);
            pictureBox1.Image = img1;
            pictureBox1.Visible = true;
            FileStream f2 = new FileStream(new ConnString().AppPathGet() + @"\photo\p2.jpg", FileMode.Open);
            Image img2 = Image.FromStream(f2);
            pictureBox2.Image = img2;
            pictureBox2.Visible = false;
            FileStream f3 = new FileStream(new ConnString().AppPathGet() + @"\photo\p3.jpg", FileMode.Open);
            Image img3 = Image.FromStream(f3);
            pictureBox3.Image = img3;
            pictureBox3.Visible = false;
            FileStream f4 = new FileStream(new ConnString().AppPathGet() + @"\photo\p4.jpg", FileMode.Open);
            Image img4 = Image.FromStream(f4);
            pictureBox4.Image = img4;
            pictureBox4.Visible = false;
            FileStream f5 = new FileStream(new ConnString().AppPathGet() + @"\photo\p5.jpg", FileMode.Open);
            Image img5 = Image.FromStream(f5);
            pictureBox5.Image = img5;
            pictureBox5.Visible = false;
            num = 1;
            timer.Interval = 1500;
            timer.Start();
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            timer.Stop();
            ControlReg.Instance.FocustextBName();
            ControlReg.Instance.Visible = true;
            ControlReg.Instance.BringToFront();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            timer.Stop();
            ControlEnter.Instance.FocusLogin();
            ControlEnter.Instance.Visible = true;
            ControlEnter.Instance.BringToFront();
        }

        private void ControlMain_Load(object sender, EventArgs e)
        {
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ControlMain_MouseClick(object sender, MouseEventArgs e)
        {
            if ( e.X>=3 && e.X<=94 && e.Y>=3 && e.Y<=159 )
            {
                TimerCase();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void TimerStart()
        {
            timer.Start();
        }
        private static int num; // 1;5  first = 1
        private void timer_Tick(object sender, EventArgs e)
        {
            TimerCase();
        }
        private void TimerCase()
        {
            switch (num)
            {
                case 1:
                    {
                        pictureBox2.Visible = false;
                        pictureBox3.Visible = false;
                        pictureBox4.Visible = false;
                        pictureBox5.Visible = false;
                        pictureBox1.Visible = true;
                        num = 2;
                    } ; break;
                case 2:
                    {
                        pictureBox1.Visible = false;
                        pictureBox3.Visible = false;
                        pictureBox4.Visible = false;
                        pictureBox5.Visible = false;
                        pictureBox2.Visible = true;
                        num = 3;
                    }; break;
                case 3:
                    {
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = false;
                        pictureBox4.Visible = false;
                        pictureBox5.Visible = false;
                        pictureBox3.Visible = true;
                        num = 4;
                    }; break;
                case 4:
                    {
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = false;
                        pictureBox3.Visible = false;
                        pictureBox5.Visible = false;
                        pictureBox4.Visible = true;
                        num = 5;
                    }; break;
                case 5:
                    {
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = false;
                        pictureBox3.Visible = false;
                        pictureBox4.Visible = false;
                        pictureBox5.Visible = true;
                        num = 1;
                    }; break;
            }
        }

        private void lbAppName_Click(object sender, EventArgs e)
        {

        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
            ControlReg.Instance.FocustextBName();
            ControlReg.Instance.Visible = true;
            ControlReg.Instance.BringToFront();
        }

        private void enterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
            ControlEnter.Instance.FocusLogin();
            ControlEnter.Instance.Visible = true;
            ControlEnter.Instance.BringToFront();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DisableMain();
            ControlMainAbout.Instance.Visible = true;
            ControlMainAbout.Instance.BringToFront();
        }

        private void DisableMain()
        {
            Enter.Enabled = false;
            Registration.Enabled = false;
            Exit.Enabled = false;
            menuStrip1.Enabled = false;
        }
        public void EnableMain()
        {
            Enter.Enabled = true;
            Registration.Enabled = true;
            Exit.Enabled = true;
            menuStrip1.Enabled = true;
        }
    }
}
