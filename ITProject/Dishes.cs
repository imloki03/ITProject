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
    public partial class Dishes : Form
    {
        public Dishes()
        {
            InitializeComponent();
        }
        Dishes_class dis = new Dishes_class();
        private void Dishes_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("select * from Dishes"));
        }

        public void fillGrid(SqlCommand cmd)
        {
            list_account.RowTemplate.Height = 50;
            list_account.DataSource = dis.getDishes(cmd);
            list_account.Columns[0].HeaderText = "ID";
            list_account.Columns[1].HeaderText = "Name";
            list_account.Columns[2].HeaderText = "recipeID";
            list_account.Columns[3].HeaderText = "Picture";
            list_account.Columns[4].HeaderText = "Cost";

            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)list_account.Columns[3];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;

            list_account.Columns[0].Width = 60;
            list_account.Columns[1].Width = 80;
            list_account.Columns[2].Width = 50;
            list_account.Columns[3].Width = 100;
            list_account.Columns[4].Width = 60;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            AddDishes dishes = new AddDishes();
            dishes.Show();
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            EditDish edit = new EditDish();
            edit.selectededEid = list_account.CurrentRow.Cells[0].Value.ToString();
            edit.tb_name.Text = list_account.CurrentRow.Cells[1].Value.ToString();
            edit.recipeID = list_account.CurrentRow.Cells[2].Value.ToString();
            edit.tb_cost.Text = list_account.CurrentRow.Cells[4].Value.ToString();
            
            byte[] pic;

            if (list_account.CurrentRow.Cells[3].Value != null && list_account.CurrentRow.Cells[3].Value is byte[])
            {
                pic = (byte[])list_account.CurrentRow.Cells[3].Value;
                MemoryStream picture = new MemoryStream(pic);
                edit.pc_picture.Image = Image.FromStream(picture);
            }
            edit.Show();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            dis.deleteDishes(list_account.CurrentRow.Cells[0].Value.ToString());
        }
    }
}
