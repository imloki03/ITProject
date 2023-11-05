namespace ITProject
{
    partial class SelectDishes
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
            this.pn_dish = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_food = new Guna.UI2.WinForms.Guna2Button();
            this.bt_drink = new Guna.UI2.WinForms.Guna2Button();
            this.bt_order = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // pn_dish
            // 
            this.pn_dish.AutoScroll = true;
            this.pn_dish.BackColor = System.Drawing.SystemColors.Control;
            this.pn_dish.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_dish.Location = new System.Drawing.Point(18, 52);
            this.pn_dish.Name = "pn_dish";
            this.pn_dish.Size = new System.Drawing.Size(765, 430);
            this.pn_dish.TabIndex = 9;
            // 
            // bt_food
            // 
            this.bt_food.CustomBorderColor = System.Drawing.Color.Silver;
            this.bt_food.CustomBorderThickness = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.bt_food.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_food.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_food.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_food.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_food.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(203)))));
            this.bt_food.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_food.ForeColor = System.Drawing.Color.Black;
            this.bt_food.Location = new System.Drawing.Point(18, 22);
            this.bt_food.Name = "bt_food";
            this.bt_food.Size = new System.Drawing.Size(111, 30);
            this.bt_food.TabIndex = 11;
            this.bt_food.Text = "Food";
            // 
            // bt_drink
            // 
            this.bt_drink.CustomBorderColor = System.Drawing.Color.Silver;
            this.bt_drink.CustomBorderThickness = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.bt_drink.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_drink.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_drink.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_drink.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_drink.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(203)))));
            this.bt_drink.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_drink.ForeColor = System.Drawing.Color.Black;
            this.bt_drink.Location = new System.Drawing.Point(132, 22);
            this.bt_drink.Name = "bt_drink";
            this.bt_drink.Size = new System.Drawing.Size(111, 30);
            this.bt_drink.TabIndex = 12;
            this.bt_drink.Text = "Drink";
            // 
            // bt_order
            // 
            this.bt_order.BorderRadius = 5;
            this.bt_order.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_order.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_order.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_order.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_order.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_order.ForeColor = System.Drawing.Color.White;
            this.bt_order.Location = new System.Drawing.Point(670, 7);
            this.bt_order.Name = "bt_order";
            this.bt_order.Size = new System.Drawing.Size(111, 39);
            this.bt_order.TabIndex = 13;
            this.bt_order.Text = "Order";
            // 
            // SelectDishes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ITProject.Properties.Resources.bgr_white;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.bt_order);
            this.Controls.Add(this.bt_drink);
            this.Controls.Add(this.bt_food);
            this.Controls.Add(this.pn_dish);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectDishes";
            this.Text = "SelectDishes";
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.FlowLayoutPanel pn_dish;
        private Guna.UI2.WinForms.Guna2Button bt_food;
        private Guna.UI2.WinForms.Guna2Button bt_drink;
        private Guna.UI2.WinForms.Guna2Button bt_order;
    }
}