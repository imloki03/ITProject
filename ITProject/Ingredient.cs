using ManageRestaurant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITProject
{
    public partial class Ingredient : Form
    {
        public Ingredient()
        {
            InitializeComponent();
        }
        Ingredient_class ing = new Ingredient_class();

        private void Ingredient_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("select * from Ingredient"));
        }

        public void fillGrid(SqlCommand cmd)
        {
            list_account.RowTemplate.Height = 50;
            list_account.DataSource = ing.getIngredient(cmd);
            list_account.Columns[0].HeaderText = "ID";
            list_account.Columns[1].HeaderText = "Name";
            list_account.Columns[2].HeaderText = "Quantity";
            list_account.Columns[3].HeaderText = "Unit";

            list_account.Columns[0].Width = 60;
            list_account.Columns[1].Width = 100;
            list_account.Columns[2].Width = 60;
            list_account.Columns[3].Width = 60;
        }

        private void bt_search_Click_1(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("SELECT * from Ingredient where CONCAT(ingredientID,name,quantity,unit) like '%" + tb_search.Text + "%'"));

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            AddIngredient addIngredient = new AddIngredient();
            addIngredient.Show();
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            EditIngredient edit = new EditIngredient();
            edit.selectededEid = list_account.CurrentRow.Cells[0].Value.ToString();
            edit.tb_name.Text = list_account.CurrentRow.Cells[1].Value.ToString();
            edit.tb_quantity.Text = list_account.CurrentRow.Cells[2].Value.ToString();
            edit.tb_unit.Text = list_account.CurrentRow.Cells[3].Value.ToString();
            edit.Show();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            ing.deleteIngredient(list_account.CurrentRow.Cells[0].Value.ToString());
        }
    }
}
