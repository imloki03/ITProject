using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsRestaurant;

namespace ITProject
{
    class Statics_Class
    {
        DB_Class db = new DB_Class();

        public DataTable GetRevenueData()
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT FORMAT([time], 'MM/yyyy') AS MonthYear, SUM([money]) AS TotalMoney " +
                               "FROM [dbo].[Bill] " +
                               "GROUP BY FORMAT([time], 'MM/yyyy')", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }

        public DataTable GetOrder()
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT FORMAT([time], 'MM/yyyy') AS MonthYear, COUNT([orderID]) AS OrderCount " +
                       "FROM [dbo].[Bill] " +
                       "GROUP BY FORMAT([time], 'MM/yyyy')", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }

        public DataTable getBestSeller()
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT d.dishID, d.name, P.total FROM (SELECT TOP 5 Q.dishID, sum(Q.quantity) as total from (select o.dishID, o.quantity from Bill b, [Order] o where b.orderID = o.orderID) Q GROUP BY Q.dishID ORDER BY total) P, Dishes d where P.dishID = d.dishID", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }
    }
}
