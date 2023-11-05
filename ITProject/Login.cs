using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_username.Text))
                lb_username.Visible = true;
            else
                lb_username.Visible = false;
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_password.Text))
                lb_password.Visible = true;
            else
                lb_password.Visible = false;
        }

        private void cb_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showpass.Checked)
                tb_password.PasswordChar = '\0';
            else
                tb_password.PasswordChar = '*';
        }
    }
}
