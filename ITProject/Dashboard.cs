using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WinFormsRestaurant;

namespace ITProject
{
    public partial class Dashboard : Form
    {
        public Button currentButton;
        Employee_Class emp = new Employee_Class();
        Dashboard_Class dashboard = new Dashboard_Class();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            DisplayCurrentDate();
            lb_total.Text = "" + emp.amountOfEmloyees();
            lb_orders.Text = "" + dashboard.numberOfOrders();
            lb_diners.Text = "" + dashboard.numberOfDiners();
            lb_revenue.Text = "" + dashboard.totalOfRevenue();
            Pie(6,22);
            Col(6,22);
        }

        private void DisplayCurrentDate()
        {
            // Lấy ngày hôm nay
            DateTime currentDate = DateTime.Now;

            // Định dạng ngày theo dạng "dddd, MMM dd, yyyy"
            string formattedDate = currentDate.ToString("dddd, MMM dd, yyyy");

            // Gán giá trị định dạng vào Label
            lb_date.Text = formattedDate;
        }

        private void Pie(int startHour, int endHour)
        {
            //pie
            DateTime start = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, startHour, 0, 0);
            DateTime end = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, endHour, 0, 0);
            chart_bestseller.Series.Clear();
            chart_bestseller.Titles.Clear();
            Series series2 = new Series();
            series2.ChartType = SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;

            foreach (DataRow row in dashboard.getBestSeller(start, end).Rows)
            {
                string name = row["name"].ToString();
                double total = Convert.ToDouble(row["total"]);

                series2.Points.AddXY(name, total);
            }

            chart_bestseller.Series.Add(series2);
            chart_bestseller.Titles.Add("Best Seller");
            chart_bestseller.Titles[0].Font = new Font(chart_bestseller.Titles[0].Font.FontFamily, 20, FontStyle.Bold);
        }
        DateTime currentDate = DateTime.Now.Date;
        private void Col(int startHour, int endHour)
        {
            DateTime start = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, startHour, 0, 0);
            DateTime end = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, endHour, 0, 0);
            Series series = new Series();
            chart_order.Series.Clear();
            chart_order.Titles.Clear();
            chart_order.ChartAreas[0].AxisX.Interval = 1;
            series.ChartType = SeriesChartType.Column;
            series.XValueType = ChartValueType.String;
            series.IsValueShownAsLabel = true;
            series.IsVisibleInLegend = false;
            DataTable table = dashboard.getOrdersperHour(start,end);
            foreach (DataRow row in table.Rows)
            {
                series.Points.AddXY(row[0], row[1]);
            }
            chart_order.Series.Add(series);
            chart_order.Titles.Add("Orders By Hours");
            chart_order.Titles[0].Font = new Font(chart_order.Titles[0].Font.FontFamily, 20, FontStyle.Bold);
            chart_order.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
            chart_order.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart_order.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart_order.ChartAreas[0].AxisX.Title = "(Orders)";
            chart_order.ChartAreas[0].AxisX.ArrowStyle = AxisArrowStyle.SharpTriangle;
            chart_order.ChartAreas[0].AxisY.ArrowStyle = AxisArrowStyle.SharpTriangle;
            chart_order.ChartAreas[0].AxisY.Title = "(Hour)";
            chart_order.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Far;
            chart_order.ChartAreas[0].AxisY.TextOrientation = TextOrientation.Horizontal;
        }
    }
}
