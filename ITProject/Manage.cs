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
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
        }
        Methods methods = new Methods();
        private void bt_Dashboard_Click(object sender, EventArgs e)
        {
            methods.fillPanel(pn_main, new Dashboard(), 1);
        }

        private void bt_Ingredient_Click(object sender, EventArgs e)
        {
            methods.fillPanel(pn_main, new Ingredient(), 1);
        }

        private void bt_ManageAccount_Click(object sender, EventArgs e)
        {
            methods.fillPanel(pn_main, new ManageAccount(), 1);
        }

        private void btn_Exit__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Manage_Load(object sender, EventArgs e)
        {
            methods.fillPanel(pn_main, new Dashboard(), 1);
        }

        private void bt_statistics_Click(object sender, EventArgs e)
        {
            methods.fillPanel(pn_main, new Statics(), 1);
        }

        private void bt_dishes_Click(object sender, EventArgs e)
        {
            methods.fillPanel(pn_main, new Dishes(), 1);
        }
    }
}
