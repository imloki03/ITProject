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
    public partial class Statics : Form
    {
        public Statics()
        {
            InitializeComponent();
        }
        Methods methods = new Methods();
        private void bt_revenue_Click(object sender, EventArgs e)
        {
            methods.fillPanel(pn_main, new Revenue_static(), 1);
        }

        private void bt_order_Click(object sender, EventArgs e)
        {
            methods.fillPanel(pn_main, new Order_static(), 1);
        }

        private void bt_bestseller_Click(object sender, EventArgs e)
        {
            methods.fillPanel(pn_main, new Bestseller_static(), 1);
        }
    }
}
