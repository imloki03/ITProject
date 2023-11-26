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

namespace ITProject
{
    public partial class Order_static : Form
    {
        public Order_static()
        {
            InitializeComponent();
        }
        Statics_Class statics = new Statics_Class();

        private void Order_static_Load(object sender, EventArgs e)
        {
            DrawChart();
        }
        private void DrawChart()
        {
            DataTable data = statics.GetOrder();
            // Xóa dữ liệu cũ trước khi vẽ biểu đồ
            // Xóa dữ liệu cũ trước khi vẽ biểu đồ
            chart_order.Series.Clear();

            // Thêm một loạt dữ liệu cho biểu đồ cột
            Series series = chart_order.Series.Add("Order Count");
            series.ChartType = SeriesChartType.Column;

            foreach (DataRow row in data.Rows)
            {
                // Lấy giá trị từ dòng của DataTable
                string monthYear = row["MonthYear"].ToString();
                int orderCount = Convert.ToInt32(row["OrderCount"]);

                // Thêm điểm vào loạt dữ liệu của biểu đồ
                series.Points.AddXY(monthYear, orderCount);
            }

            // Định cấu hình trục x và trục y
            chart_order.ChartAreas[0].AxisX.Interval = 1;
            chart_order.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chart_order.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0; ;

            chart_order.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
            chart_order.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart_order.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart_order.ChartAreas[0].AxisX.Title = "(Month/Year)";
            chart_order.ChartAreas[0].AxisX.ArrowStyle = AxisArrowStyle.SharpTriangle;
            chart_order.ChartAreas[0].AxisY.ArrowStyle = AxisArrowStyle.SharpTriangle;
            chart_order.ChartAreas[0].AxisY.Title = "(Order quantity)";
            chart_order.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Far;
            chart_order.ChartAreas[0].AxisY.TextOrientation = TextOrientation.Horizontal;

            // Hiển thị chú thích
            chart_order.Legends.Add(new Legend("Legend"));
            chart_order.Legends["Legend"].Docking = Docking.Bottom;
        }
    }
}
