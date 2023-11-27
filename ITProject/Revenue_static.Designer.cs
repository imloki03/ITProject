namespace ITProject
{
    partial class Revenue_static
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_revenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_revenue)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_revenue
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_revenue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_revenue.Legends.Add(legend1);
            this.chart_revenue.Location = new System.Drawing.Point(13, 82);
            this.chart_revenue.Margin = new System.Windows.Forms.Padding(4);
            this.chart_revenue.Name = "chart_revenue";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn100;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_revenue.Series.Add(series1);
            this.chart_revenue.Size = new System.Drawing.Size(891, 422);
            this.chart_revenue.TabIndex = 1;
            this.chart_revenue.Text = "chart1";
            // 
            // Revenue_static
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(930, 570);
            this.Controls.Add(this.chart_revenue);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Revenue_static";
            this.Text = "Revenue_static";
            this.Load += new System.EventHandler(this.Revenue_static_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_revenue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_revenue;
    }
}