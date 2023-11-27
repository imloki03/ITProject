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
    public partial class Bestseller_static : Form
    {
        public Bestseller_static()
        {
            InitializeComponent();
        }
        Statics_Class statics = new Statics_Class();

        private void Bestseller_static_Load(object sender, EventArgs e)
        {
            Pie();
        }
        private void Pie()
        {
            //pie
            chart_bestseller.Series.Clear();
            chart_bestseller.Titles.Clear();
            Series series2 = new Series();
            series2.ChartType = SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;

            foreach (DataRow row in statics.getBestSeller().Rows)
            {
                string name = row["name"].ToString();
                double total = Convert.ToDouble(row["total"]);

                series2.Points.AddXY(name, total);
            }

            chart_bestseller.Series.Add(series2);
            chart_bestseller.Titles.Add("Best Seller");
            chart_bestseller.Titles[0].Font = new Font(chart_bestseller.Titles[0].Font.FontFamily, 20, FontStyle.Bold);
        }
    }
}
