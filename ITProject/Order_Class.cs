using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITProject;

namespace ITProject
{
    internal class Order_Class
    {
        DB_Class dB = new DB_Class();
        public DataTable getOder(SqlCommand cmd)
        {
            cmd.Connection = dB.getConnection;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }
    }
}
