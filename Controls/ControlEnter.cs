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
    public partial class ControlEnter : UserControl
    {
        public ControlEnter()
        {
            InitializeComponent();
            tbLogin.KeyPress += new KeyPressEventHandler(tbLogin_KeyPress);
            tbPass.KeyPress += new KeyPressEventHandler(tbPass_KeyPress);
            tbLogin.TextAlign = HorizontalAlignment.Left;
            tbPass.TextAlign = HorizontalAlignment.Left;
            tbPass.PasswordChar='*';
            tbPass.MaxLength = 25;
            tbLogin.MaxLength = 15;
            Enter.Enabled = false;
            lbTextMess.Visible = false;
        }

        private static ControlEnter InstanceEnter;
        public static ControlEnter Instance
        {
            get
            {
                if (InstanceEnter == null)
                {
                    InstanceEnter = new ControlEnter();
                }
                return InstanceEnter;
            }
        }

        public void FocusLogin()
        {
            tbLogin.Focus();
        }

        private void ControlEnter_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            tbLogin.Clear();
            tbPass.Clear();
            lbTextMess.Visible = false;
            ControlMain.Instance.TimerStart();
            ControlMain.Instance.Visible = true;
            ControlMain.Instance.BringToFront();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            new Direction().EnterPress(tbLogin, tbPass, lbTextMess, Enter);
        }

        private void tbLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                e.Handled = true;
                tbPass.Focus();
            }
        }
        private void tbPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                e.Handled = true;
                Enter.Focus();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (tbLogin.Text.Length == 0  || tbPass.Text.Length == 0)
            {
                Enter.Enabled = false;
            }
            else
            {
                Enter.Enabled = true;
            }
            
            if (lbTextMess.Visible==true)
            {
                lbTextMess.Visible = false;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (tbLogin.Text.Length == 0 || tbPass.Text.Length == 0)
            {
                Enter.Enabled = false;
            }
            else
            {
                Enter.Enabled = true;
            }

            if (lbTextMess.Visible == true)
            {
                lbTextMess.Visible = false;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbTextMess_Click(object sender, EventArgs e)
        {

        }
    }
}
