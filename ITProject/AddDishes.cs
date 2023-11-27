﻿using Emgu.CV.ML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITProject
{
    public partial class AddDishes : Form
    {
        public AddDishes()
        {
            InitializeComponent();
        }
        Dishes_class dis = new Dishes_class();
        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_upload_Click(object sender, EventArgs e)
        {
            pc_picture.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif;*.jpeg";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pc_picture.Image = Image.FromFile(opf.FileName);
            }
        }

        private void AddDishes_Load(object sender, EventArgs e)
        {
            DataTable dishesTable = dis.getDishes(new SqlCommand("SELECT recipeID FROM Recipe"));

            // Chỉ định cột hiển thị và cột giá trị
            cb_recipeID.DisplayMember = "recipeID";
            cb_recipeID.ValueMember = "recipeID";

            // Gán DataTable làm DataSource của ComboBox
            cb_recipeID.DataSource = dishesTable;
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            string name = tb_name.Text;
            MemoryStream picture = new MemoryStream();
            pc_picture.Image.Save(picture, pc_picture.Image.RawFormat);
            string recipe = cb_recipeID.Text;
            int cost = int.Parse(tb_cost.Text);

            if (rb_food.Checked)
                dis.addDishFood(name, recipe, cost, picture);
            else
                dis.addDishDrink(name, recipe, cost, picture);
        }
    }
}
