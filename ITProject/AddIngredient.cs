using Emgu.CV.ML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITProject
{
    public partial class AddIngredient : Form
    {
        public AddIngredient()
        {
            InitializeComponent();
        }
        Ingredient_class ing = new Ingredient_class();
        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            string name = tb_name.Text;
            string unit = tb_unit.Text;
            int quantity = int.Parse(tb_quantity.Text);

            ing.addIngredient(name, quantity,unit);
        }
    }
}
