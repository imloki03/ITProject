namespace ITProject
{
    partial class EditDish
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDish));
            this.label6 = new System.Windows.Forms.Label();
            this.cb_recipeID = new System.Windows.Forms.ComboBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_upload = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pc_picture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.bt_edit = new Guna.UI2.WinForms.Guna2Button();
            this.bt_cancel = new Guna.UI2.WinForms.Guna2Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_cost = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_picture)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(18, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 23);
            this.label6.TabIndex = 91;
            this.label6.Text = "RecipeID:";
            // 
            // cb_recipeID
            // 
            this.cb_recipeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_recipeID.FormattingEnabled = true;
            this.cb_recipeID.Location = new System.Drawing.Point(22, 268);
            this.cb_recipeID.Margin = new System.Windows.Forms.Padding(4);
            this.cb_recipeID.Name = "cb_recipeID";
            this.cb_recipeID.Size = new System.Drawing.Size(233, 33);
            this.cb_recipeID.TabIndex = 90;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(639, 114);
            this.guna2Panel1.TabIndex = 78;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::ITProject.Properties.Resources.salt;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(22, 24);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(90, 77);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(118, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Edit Dishes";
            // 
            // bt_upload
            // 
            this.bt_upload.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.bt_upload.HoverState.ImageSize = new System.Drawing.Size(57, 57);
            this.bt_upload.Image = ((System.Drawing.Image)(resources.GetObject("bt_upload.Image")));
            this.bt_upload.ImageOffset = new System.Drawing.Point(0, 0);
            this.bt_upload.ImageRotate = 0F;
            this.bt_upload.ImageSize = new System.Drawing.Size(55, 55);
            this.bt_upload.Location = new System.Drawing.Point(429, 387);
            this.bt_upload.Name = "bt_upload";
            this.bt_upload.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.bt_upload.Size = new System.Drawing.Size(64, 54);
            this.bt_upload.TabIndex = 86;
            this.bt_upload.Click += new System.EventHandler(this.bt_upload_Click);
            // 
            // pc_picture
            // 
            this.pc_picture.BackColor = System.Drawing.Color.Transparent;
            this.pc_picture.FillColor = System.Drawing.Color.WhiteSmoke;
            this.pc_picture.Image = global::ITProject.Properties.Resources.food__1_;
            this.pc_picture.ImageRotate = 0F;
            this.pc_picture.Location = new System.Drawing.Point(309, 160);
            this.pc_picture.Name = "pc_picture";
            this.pc_picture.Size = new System.Drawing.Size(300, 200);
            this.pc_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pc_picture.TabIndex = 85;
            this.pc_picture.TabStop = false;
            this.pc_picture.UseTransparentBackground = true;
            this.pc_picture.Click += new System.EventHandler(this.pc_picture_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.AutoRoundedCorners = true;
            this.bt_edit.BackColor = System.Drawing.Color.Gainsboro;
            this.bt_edit.BorderRadius = 25;
            this.bt_edit.CustomizableEdges.TopRight = false;
            this.bt_edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_edit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.bt_edit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_edit.ForeColor = System.Drawing.Color.White;
            this.bt_edit.Location = new System.Drawing.Point(429, 16);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(180, 53);
            this.bt_edit.TabIndex = 0;
            this.bt_edit.Text = "EDIT";
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.AutoRoundedCorners = true;
            this.bt_cancel.BackColor = System.Drawing.Color.Gainsboro;
            this.bt_cancel.BorderRadius = 25;
            this.bt_cancel.CustomizableEdges.TopRight = false;
            this.bt_cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_cancel.FillColor = System.Drawing.Color.Gray;
            this.bt_cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_cancel.ForeColor = System.Drawing.Color.White;
            this.bt_cancel.Location = new System.Drawing.Point(223, 16);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(180, 53);
            this.bt_cancel.TabIndex = 1;
            this.bt_cancel.Text = "CANCEL";
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(305, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 23);
            this.label10.TabIndex = 84;
            this.label10.Text = "Picture:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(18, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 23);
            this.label9.TabIndex = 83;
            this.label9.Text = "Cost:";
            // 
            // tb_cost
            // 
            this.tb_cost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_cost.DefaultText = "";
            this.tb_cost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_cost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_cost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_cost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_cost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_cost.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_cost.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_cost.Location = new System.Drawing.Point(22, 367);
            this.tb_cost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_cost.Name = "tb_cost";
            this.tb_cost.PasswordChar = '\0';
            this.tb_cost.PlaceholderText = "";
            this.tb_cost.SelectedText = "";
            this.tb_cost.Size = new System.Drawing.Size(233, 48);
            this.tb_cost.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(18, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 81;
            this.label2.Text = "Name:";
            // 
            // tb_name
            // 
            this.tb_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_name.DefaultText = "";
            this.tb_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_name.Location = new System.Drawing.Point(22, 160);
            this.tb_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_name.Name = "tb_name";
            this.tb_name.PasswordChar = '\0';
            this.tb_name.PlaceholderText = "";
            this.tb_name.SelectedText = "";
            this.tb_name.Size = new System.Drawing.Size(233, 48);
            this.tb_name.TabIndex = 80;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.bt_cancel);
            this.guna2Panel2.Controls.Add(this.bt_edit);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 475);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(639, 81);
            this.guna2Panel2.TabIndex = 79;
            // 
            // EditDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(639, 556);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_recipeID);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.bt_upload);
            this.Controls.Add(this.pc_picture);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_cost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.guna2Panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditDish";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditDish";
            this.Load += new System.EventHandler(this.EditDish_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_picture)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cb_recipeID;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton bt_upload;
        public Guna.UI2.WinForms.Guna2PictureBox pc_picture;
        private Guna.UI2.WinForms.Guna2Button bt_edit;
        private Guna.UI2.WinForms.Guna2Button bt_cancel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        public Guna.UI2.WinForms.Guna2TextBox tb_cost;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2TextBox tb_name;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}