using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsRestaurant;

namespace ITProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Employee_Class em = new Employee_Class();

        private void cb_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showpass.Checked)
                tb_password.PasswordChar = '\0';
            else
                tb_password.PasswordChar = '*';
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            Login_Class login = new Login_Class();
            string user = tb_username.Text;
            string password = tb_password.Text;
            if (login.checklogin(user, password))
            {
                StaticVars_Class.username = user;
                StaticVars_Class.emID = em.whatEmIDByAcc(user);
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Ivalid Username or Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
