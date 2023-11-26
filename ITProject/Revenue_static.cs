using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WinFormsRestaurant;

namespace ITProject
{
    public partial class Revenue_static : Form
    {
        public Revenue_static()
        {
            InitializeComponent();
        }
        Statics_Class statics = new Statics_Class();
        private void Revenue_static_Load(object sender, EventArgs e)
        {
            DrawChart();
        }
        private void DrawChart()
        {
            DataTable data = statics.GetRevenueData();
            // Xóa dữ liệu cũ trước khi vẽ biểu đồ
            chart_revenue.Series.Clear();

            // Thêm một loạt dữ liệu cho biểu đồ cột
            Series series = chart_revenue.Series.Add("Total Revenue");
            series.ChartType = SeriesChartType.Column;

            foreach (DataRow row in data.Rows)
            {
                // Lấy giá trị từ dòng của DataTable
                string monthYear = row["MonthYear"].ToString();
                int totalMoney = Convert.ToInt32(row["TotalMoney"]);

                // Thêm điểm vào loạt dữ liệu của biểu đồ
                series.Points.AddXY(monthYear, totalMoney);
            }

            // Định cấu hình trục x và trục y
            chart_revenue.ChartAreas[0].AxisX.Interval = 1;
            chart_revenue.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chart_revenue.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

            chart_revenue.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
            chart_revenue.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart_revenue.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart_revenue.ChartAreas[0].AxisX.Title = "(Month/Year)";
            chart_revenue.ChartAreas[0].AxisX.ArrowStyle = AxisArrowStyle.SharpTriangle;
            chart_revenue.ChartAreas[0].AxisY.ArrowStyle = AxisArrowStyle.SharpTriangle;
            chart_revenue.ChartAreas[0].AxisY.Title = "(Money)";
            chart_revenue.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Far;       
            chart_revenue.ChartAreas[0].AxisY.TextOrientation = TextOrientation.Horizontal;

            // Hiển thị chú thích
            chart_revenue.Legends.Add(new Legend("Legend"));
            chart_revenue.Legends["Legend"].Docking = Docking.Bottom;
        }
    }
}
