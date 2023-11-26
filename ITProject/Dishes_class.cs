using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsRestaurant;
using System.Windows.Forms;
using System.IO;

namespace ITProject
{
    class Dishes_class
    {
        DB_Class db = new DB_Class();
        public DataTable getDishes(SqlCommand cmd)
        {
            cmd.Connection = db.getConnection;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }

        public void addDishFood(string name, string recipe, int cost, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("insert into Dishes values ([dbo].[AUTO_IDDishesFood](), @name, @recipe, @picture, @cost)", db.getConnection);
            command.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@recipe", System.Data.SqlDbType.NVarChar).Value = recipe;
            command.Parameters.Add("@cost", System.Data.SqlDbType.Int).Value = cost;
            command.Parameters.Add("@picture", System.Data.SqlDbType.Image).Value = picture.ToArray();

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Add Dishes Successfully");
            else
                MessageBox.Show("Add Dishes Unsuccessfully!!!");
            db.closeConnection();
        }
        public void addDishDrink(string name, string recipe, int cost, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("insert into Dishes values ([dbo].[AUTO_IDDishesDrink](), @name, @recipe, @picture, @cost)", db.getConnection);
            command.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@recipe", System.Data.SqlDbType.NVarChar).Value = recipe;
            command.Parameters.Add("@cost", System.Data.SqlDbType.Int).Value = cost;
            command.Parameters.Add("@picture", System.Data.SqlDbType.Image).Value = picture.ToArray();

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Add Dishes Successfully");
            else
                MessageBox.Show("Add Dishes Unsuccessfully!!!");
            db.closeConnection();
        }

        public void updateDishes(string eid, string name, string recipe, int cost , MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE Dishes SET name = @name, recipeID = @gender, cost = @cost , picture = @picture WHERE dishID = @eid", db.getConnection);
            command.Parameters.Add("@eid", System.Data.SqlDbType.NVarChar).Value = eid;
            command.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@gender", System.Data.SqlDbType.NVarChar).Value = recipe;
            command.Parameters.Add("@cost", System.Data.SqlDbType.Int).Value = cost;
            command.Parameters.Add("@picture", System.Data.SqlDbType.Image).Value = picture.ToArray();

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Update Dishes Successfully");
            else
                MessageBox.Show("Update dishes Unsuccessfully!!!");
            db.closeConnection();
        }

        public void deleteDishes(string eid)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Dishes WHERE dishID = @eid", db.getConnection);
            command.Parameters.Add("@eid", System.Data.SqlDbType.NVarChar).Value = eid;
            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Delete Dishes Successfully");
            else
                MessageBox.Show("Delete Dishes Unsuccessfully!!!");
            db.closeConnection();
        }
    }
}
