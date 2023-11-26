using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsRestaurant;
using System.IO;
using System.Windows.Forms;

namespace ITProject
{
    class Ingredient_class
    {
        DB_Class db = new DB_Class();
        public DataTable getIngredient(SqlCommand cmd)
        {
            cmd.Connection = db.getConnection;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }

        public void addIngredient(string name,int quantity,string unit)
        {
            SqlCommand command = new SqlCommand("insert into Ingredient values ([dbo].[AUTO_IDIngredient](), @name, @quantity, @unit)", db.getConnection);
            command.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@quantity", System.Data.SqlDbType.Int).Value = quantity;
            command.Parameters.Add("@unit", System.Data.SqlDbType.NVarChar).Value = unit;

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Add Ingredient Successfully");
            else
                MessageBox.Show("Add Ingredient Unsuccessfully!!!");
            db.closeConnection();
        }

        public void updateIngredient(string eid, string name,int quantity, string unit)
        {
            SqlCommand command = new SqlCommand("UPDATE Ingredient SET Name = @name, quantity = @quantity, unit = @unit WHERE ingredientID = @eid", db.getConnection);
            command.Parameters.Add("@eid", System.Data.SqlDbType.NVarChar).Value = eid;
            command.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@quantity", System.Data.SqlDbType.Int).Value = quantity;
            command.Parameters.Add("@unit", System.Data.SqlDbType.NVarChar).Value = unit;

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Update Ingredient Successfully");
            else
                MessageBox.Show("Update Ingredinet Unsuccessfully!!!");
            db.closeConnection();
        }

        public void deleteIngredient(string eid)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Ingredient WHERE ingredientID = @eid", db.getConnection);
            command.Parameters.Add("@eid", System.Data.SqlDbType.NVarChar).Value = eid;
            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Delete Ingredient Successfully");
            else
                MessageBox.Show("Delete Ingredient Unsuccessfully!!!");
            db.closeConnection();
        }
    }
}
