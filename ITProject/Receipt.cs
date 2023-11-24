using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITProject
{
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }
        public string oderid;
        public int table;
        public int qguest;
        Order_Class order = new Order_Class();
        Employee_Class employee = new Employee_Class();
        Bill_Class bill = new Bill_Class();
        private void Receipt_Load(object sender, EventArgs e)
        {
            cb_payment.SelectedIndex = 0;
            dv_bill.DataSource = order.getOder(new System.Data.SqlClient.SqlCommand("SELECT name as Dishes, cost as UnitPrice, quantity As Quantity FROM [ORDER] o, Dishes d WHERE d.dishID = o.dishID AND o.orderID = '" + oderid + "'"));
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Ammount";
            dv_bill.Columns.Add(column);
            int t = 0;
            foreach (DataGridViewRow row in dv_bill.Rows)
            {
                int cell1Value;
                int cell2Value;
                Int32.TryParse(row.Cells[1].Value?.ToString(), out cell1Value);
                Int32.TryParse(row.Cells[2].Value?.ToString(), out cell2Value);
                int result = cell1Value * cell2Value;
                row.Cells[3].Value = result.ToString();
                t += Int32.Parse(row.Cells[3].Value.ToString());
            }
            lb_time.Text = "Date: " + DateTime.Now.ToString();
            lb_cashier.Text = "Cashier: " + employee.getEmName(StaticVars_Class.emID);
            lb_bilnumber.Text = "Bill Num: " + bill.getNextBillID();
            lb_table.Text = "Table " + table;
            lb_money.Text = t.ToString();

            string tableid;
            if (table < 10)
                tableid = "Table0" + table.ToString();
            else
                tableid = "Table" + table.ToString();

            bill.addBill(qguest, t, tableid, oderid, DateTime.Now);
        }

        private void cb_payment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_payment.SelectedIndex == 0)
            {
                bt_qrpay.Visible = false;
            }
            else
            {
                bt_qrpay.Visible=true;
            }
        }

        private void btn_Exit__Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void bt_qrpay_Click(object sender, EventArgs e)
        {
            MomoQR payQR = new MomoQR();
            payQR.lb_money.Text = this.lb_money.Text;
            payQR.Show(this);
        }
    }
}
