namespace ITProject
{
    partial class Bestseller_static
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
            this.chart_bestseller = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_bestseller)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_bestseller
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_bestseller.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_bestseller.Legends.Add(legend1);
            this.chart_bestseller.Location = new System.Drawing.Point(9, 74);
            this.chart_bestseller.Name = "chart_bestseller";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_bestseller.Series.Add(series1);
            this.chart_bestseller.Size = new System.Drawing.Size(891, 422);
            this.chart_bestseller.TabIndex = 21;
            this.chart_bestseller.Text = "chart1";
            // 
            // Bestseller_static
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 523);
            this.Controls.Add(this.chart_bestseller);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Bestseller_static";
            this.Text = "Bestseller_static";
            this.Load += new System.EventHandler(this.Bestseller_static_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_bestseller)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_bestseller;
    }
}