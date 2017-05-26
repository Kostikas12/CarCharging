using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace CarCharging
{
    public partial class ControlReg : UserControl
    {
        public ControlReg()
        {
            InitializeComponent();
            textBName.MaxLength = 15;
            textBLogin.MaxLength = 15;
            textBPassword.MaxLength = 25;
            textBAge.MaxLength = 4;
            textBPassword.PasswordChar = '*';
            this.textBAge.KeyPress+=new KeyPressEventHandler(this.textBAge_KeyPr);
            labelTextMess.Visible = false;
            Apply.Enabled = false;
        }

        private static ControlReg InstanceReg;
        public static ControlReg Instance
        {
            get
            {
                if (InstanceReg == null)
                {
                    InstanceReg = new ControlReg();
                }
                return InstanceReg;
            }
        }

        public void FocustextBName()
        {
            textBName.Focus();
        }
        private void Back_Click(object sender, EventArgs e)
        {
            ClearText();
            ControlMain.Instance.TimerStart();
            ControlMain.Instance.Visible = true;
            ControlMain.Instance.BringToFront();
        }

        private void ControlReg_Load(object sender, EventArgs e)
        {

        }

        private void Apply_Click(object sender, EventArgs e)
        {
            new Direction().MainRegApply(textBName, textBLogin, textBPassword, textBAge, labelTextMess);
        }

        private void textBName_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }
        private void textBAge_KeyPr(object sender, KeyPressEventArgs e)
        {
            if ( (e.KeyChar == (char)Keys.Back) || Char.IsDigit(e.KeyChar) )
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
            CheckTextBoxes();
        }
        private void textBLogin_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }
        private void textBPassword_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }
        private void textBAge_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }

        private void CheckTextBoxes()
        {
            if (textBName.Text.Length == 0 || textBLogin.Text.Length == 0 || textBAge.Text.Length == 0 || textBPassword.Text.Length == 0)
            {
                Apply.Enabled = false;
            }
            else
            {
                Apply.Enabled = true;
            }
            if (labelTextMess.Visible == true)
            {
                labelTextMess.Visible = false;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ClearText();
        }
        private void ClearText()
        {
            textBName.Clear();
            textBLogin.Clear();
            textBAge.Clear();
            textBPassword.Clear();
            labelTextMess.Visible = false;
        }

        private void textReg_Click(object sender, EventArgs e)
        {

        }

        public void DisableReg()
        {
            Clear.Enabled = false;
            Apply.Enabled = false;
            Back.Enabled = false;
            textBName.Enabled = false;
            textBLogin.Enabled = false;
            textBPassword.Enabled = false;
            textBAge.Enabled = false;
        }
        public void EnableClearRegToEnter()
        {
            ClearText();
            Clear.Enabled = true;
            Apply.Enabled = false;
            Back.Enabled = true;
            textBName.Enabled = true;
            textBLogin.Enabled = true;
            textBPassword.Enabled = true;
            textBAge.Enabled = true;
            labelTextMess.Visible = false;
            ControlEnter.Instance.Visible = true;
            ControlEnter.Instance.FocusLogin();
            ControlEnter.Instance.BringToFront();
        }
    }
}
