namespace ITProject
{
    partial class Order
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
            this.list_dishes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_table = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_amountOfDiner = new Guna.UI2.WinForms.Guna2TextBox();
            this.bt_selectDishes = new Guna.UI2.WinForms.Guna2Button();
            this.bt_cancel = new Guna.UI2.WinForms.Guna2Button();
            this.bt_order = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.list_dishes)).BeginInit();
            this.SuspendLayout();
            // 
            // list_dishes
            // 
            this.list_dishes.AllowUserToAddRows = false;
            this.list_dishes.AllowUserToDeleteRows = false;
            this.list_dishes.AllowUserToResizeColumns = false;
            this.list_dishes.AllowUserToResizeRows = false;
            this.list_dishes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.list_dishes.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.list_dishes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_dishes.Location = new System.Drawing.Point(30, 126);
            this.list_dishes.Name = "list_dishes";
            this.list_dishes.RowHeadersVisible = false;
            this.list_dishes.Size = new System.Drawing.Size(272, 275);
            this.list_dishes.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Amount of Diner:";
            // 
            // lb_table
            // 
            this.lb_table.AutoSize = true;
            this.lb_table.BackColor = System.Drawing.Color.Transparent;
            this.lb_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_table.Location = new System.Drawing.Point(96, 16);
            this.lb_table.Name = "lb_table";
            this.lb_table.Size = new System.Drawing.Size(19, 20);
            this.lb_table.TabIndex = 9;
            this.lb_table.Text = "8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Table:";
            // 
            // tb_amountOfDiner
            // 
            this.tb_amountOfDiner.BorderRadius = 2;
            this.tb_amountOfDiner.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_amountOfDiner.DefaultText = "";
            this.tb_amountOfDiner.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_amountOfDiner.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_amountOfDiner.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_amountOfDiner.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_amountOfDiner.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_amountOfDiner.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_amountOfDiner.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_amountOfDiner.Location = new System.Drawing.Point(154, 44);
            this.tb_amountOfDiner.Name = "tb_amountOfDiner";
            this.tb_amountOfDiner.PasswordChar = '\0';
            this.tb_amountOfDiner.PlaceholderText = "";
            this.tb_amountOfDiner.SelectedText = "";
            this.tb_amountOfDiner.Size = new System.Drawing.Size(120, 23);
            this.tb_amountOfDiner.TabIndex = 16;
            // 
            // bt_selectDishes
            // 
            this.bt_selectDishes.BackColor = System.Drawing.Color.Transparent;
            this.bt_selectDishes.BorderColor = System.Drawing.Color.Transparent;
            this.bt_selectDishes.BorderRadius = 7;
            this.bt_selectDishes.BorderThickness = 1;
            this.bt_selectDishes.CustomBorderColor = System.Drawing.Color.White;
            this.bt_selectDishes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_selectDishes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_selectDishes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_selectDishes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_selectDishes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_selectDishes.ForeColor = System.Drawing.Color.White;
            this.bt_selectDishes.Location = new System.Drawing.Point(113, 78);
            this.bt_selectDishes.Name = "bt_selectDishes";
            this.bt_selectDishes.Size = new System.Drawing.Size(107, 35);
            this.bt_selectDishes.TabIndex = 17;
            this.bt_selectDishes.Text = "Select Dishes";
            this.bt_selectDishes.Click += new System.EventHandler(this.bt_selectDishes_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.AutoRoundedCorners = true;
            this.bt_cancel.BackColor = System.Drawing.Color.Transparent;
            this.bt_cancel.BorderRadius = 15;
            this.bt_cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_cancel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.bt_cancel.ForeColor = System.Drawing.Color.White;
            this.bt_cancel.Location = new System.Drawing.Point(72, 416);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(83, 32);
            this.bt_cancel.TabIndex = 53;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_order
            // 
            this.bt_order.AutoRoundedCorners = true;
            this.bt_order.BackColor = System.Drawing.Color.Transparent;
            this.bt_order.BorderRadius = 15;
            this.bt_order.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_order.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_order.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_order.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_order.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.bt_order.ForeColor = System.Drawing.Color.White;
            this.bt_order.Location = new System.Drawing.Point(177, 416);
            this.bt_order.Name = "bt_order";
            this.bt_order.Size = new System.Drawing.Size(83, 32);
            this.bt_order.TabIndex = 54;
            this.bt_order.Text = "Order";
            this.bt_order.Click += new System.EventHandler(this.bt_order_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ITProject.Properties.Resources.bgr_blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(332, 466);
            this.Controls.Add(this.bt_order);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_selectDishes);
            this.Controls.Add(this.tb_amountOfDiner);
            this.Controls.Add(this.list_dishes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_table);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Order";
            this.Text = "Order";
            ((System.ComponentModel.ISupportInitialize)(this.list_dishes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView list_dishes;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lb_table;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tb_amountOfDiner;
        private Guna.UI2.WinForms.Guna2Button bt_selectDishes;
        private Guna.UI2.WinForms.Guna2Button bt_cancel;
        private Guna.UI2.WinForms.Guna2Button bt_order;
    }
}