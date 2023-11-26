namespace ITProject
{
    partial class Order_static
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_order = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_order)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_order
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_order.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_order.Legends.Add(legend2);
            this.chart_order.Location = new System.Drawing.Point(20, 74);
            this.chart_order.Margin = new System.Windows.Forms.Padding(4);
            this.chart_order.Name = "chart_order";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn100;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_order.Series.Add(series2);
            this.chart_order.Size = new System.Drawing.Size(891, 422);
            this.chart_order.TabIndex = 2;
            this.chart_order.Text = "chart1";
            // 
            // Order_static
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(930, 570);
            this.Controls.Add(this.chart_order);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Order_static";
            this.Text = "Order_static";
            this.Load += new System.EventHandler(this.Order_static_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_order)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_order;
    }
}