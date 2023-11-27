namespace ITProject
{
    partial class Statics
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
            this.pn_main = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_bestseller = new System.Windows.Forms.Button();
            this.bt_order = new System.Windows.Forms.Button();
            this.bt_revenue = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_main
            // 
            this.pn_main.BackColor = System.Drawing.Color.White;
            this.pn_main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_main.Location = new System.Drawing.Point(0, 83);
            this.pn_main.Name = "pn_main";
            this.pn_main.Size = new System.Drawing.Size(930, 487);
            this.pn_main.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.panel1.Controls.Add(this.bt_bestseller);
            this.panel1.Controls.Add(this.bt_order);
            this.panel1.Controls.Add(this.bt_revenue);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 77);
            this.panel1.TabIndex = 4;
            // 
            // bt_bestseller
            // 
            this.bt_bestseller.Location = new System.Drawing.Point(610, 0);
            this.bt_bestseller.Name = "bt_bestseller";
            this.bt_bestseller.Size = new System.Drawing.Size(317, 77);
            this.bt_bestseller.TabIndex = 3;
            this.bt_bestseller.Text = "Best Seller";
            this.bt_bestseller.UseVisualStyleBackColor = true;
            this.bt_bestseller.Click += new System.EventHandler(this.bt_bestseller_Click);
            // 
            // bt_order
            // 
            this.bt_order.Location = new System.Drawing.Point(305, 1);
            this.bt_order.Name = "bt_order";
            this.bt_order.Size = new System.Drawing.Size(302, 76);
            this.bt_order.TabIndex = 2;
            this.bt_order.Text = "Order";
            this.bt_order.UseVisualStyleBackColor = true;
            this.bt_order.Click += new System.EventHandler(this.bt_order_Click);
            // 
            // bt_revenue
            // 
            this.bt_revenue.Location = new System.Drawing.Point(3, 0);
            this.bt_revenue.Name = "bt_revenue";
            this.bt_revenue.Size = new System.Drawing.Size(299, 77);
            this.bt_revenue.TabIndex = 1;
            this.bt_revenue.Text = "Revenue";
            this.bt_revenue.UseVisualStyleBackColor = true;
            this.bt_revenue.Click += new System.EventHandler(this.bt_revenue_Click);
            // 
            // Statics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(930, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pn_main);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Statics";
            this.Text = "Statics";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_main;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_bestseller;
        private System.Windows.Forms.Button bt_order;
        private System.Windows.Forms.Button bt_revenue;
    }
}