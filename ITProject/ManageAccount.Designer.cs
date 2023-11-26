namespace ITProject
{
    partial class ManageAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageAccount));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_search = new Guna.UI2.WinForms.Guna2ImageButton();
            this.tb_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.bt_delete = new Guna.UI2.WinForms.Guna2ImageButton();
            this.bt_edit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.bt_add = new Guna.UI2.WinForms.Guna2ImageButton();
            this.list_account = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.list_account)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.Location = new System.Drawing.Point(20, 119);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(890, 22);
            this.guna2Separator1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(20, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 37);
            this.label2.TabIndex = 12;
            this.label2.Text = "Staff";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(580, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "search";
            // 
            // bt_search
            // 
            this.bt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_search.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.bt_search.HoverState.ImageSize = new System.Drawing.Size(52, 52);
            this.bt_search.Image = ((System.Drawing.Image)(resources.GetObject("bt_search.Image")));
            this.bt_search.ImageOffset = new System.Drawing.Point(0, 0);
            this.bt_search.ImageRotate = 0F;
            this.bt_search.ImageSize = new System.Drawing.Size(50, 50);
            this.bt_search.Location = new System.Drawing.Point(848, 60);
            this.bt_search.Name = "bt_search";
            this.bt_search.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.bt_search.Size = new System.Drawing.Size(62, 53);
            this.bt_search.TabIndex = 18;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // tb_search
            // 
            this.tb_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_search.DefaultText = "";
            this.tb_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_search.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_search.Location = new System.Drawing.Point(584, 60);
            this.tb_search.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tb_search.Name = "tb_search";
            this.tb_search.PasswordChar = '\0';
            this.tb_search.PlaceholderText = "Search Here ...";
            this.tb_search.SelectedText = "";
            this.tb_search.Size = new System.Drawing.Size(257, 53);
            this.tb_search.TabIndex = 17;
            // 
            // bt_delete
            // 
            this.bt_delete.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.bt_delete.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.bt_delete.Image = ((System.Drawing.Image)(resources.GetObject("bt_delete.Image")));
            this.bt_delete.ImageOffset = new System.Drawing.Point(0, 0);
            this.bt_delete.ImageRotate = 0F;
            this.bt_delete.ImageSize = new System.Drawing.Size(48, 48);
            this.bt_delete.Location = new System.Drawing.Point(187, 60);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.PressedState.ImageSize = new System.Drawing.Size(48, 48);
            this.bt_delete.Size = new System.Drawing.Size(62, 53);
            this.bt_delete.TabIndex = 16;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.bt_edit.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.bt_edit.Image = ((System.Drawing.Image)(resources.GetObject("bt_edit.Image")));
            this.bt_edit.ImageOffset = new System.Drawing.Point(0, 0);
            this.bt_edit.ImageRotate = 0F;
            this.bt_edit.ImageSize = new System.Drawing.Size(48, 48);
            this.bt_edit.Location = new System.Drawing.Point(102, 60);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.PressedState.ImageSize = new System.Drawing.Size(48, 48);
            this.bt_edit.Size = new System.Drawing.Size(62, 53);
            this.bt_edit.TabIndex = 15;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // bt_add
            // 
            this.bt_add.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.bt_add.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.bt_add.Image = ((System.Drawing.Image)(resources.GetObject("bt_add.Image")));
            this.bt_add.ImageOffset = new System.Drawing.Point(0, 0);
            this.bt_add.ImageRotate = 0F;
            this.bt_add.ImageSize = new System.Drawing.Size(48, 48);
            this.bt_add.Location = new System.Drawing.Point(20, 60);
            this.bt_add.Name = "bt_add";
            this.bt_add.PressedState.ImageSize = new System.Drawing.Size(48, 48);
            this.bt_add.Size = new System.Drawing.Size(62, 53);
            this.bt_add.TabIndex = 11;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // list_account
            // 
            this.list_account.AllowUserToAddRows = false;
            this.list_account.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.list_account.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.list_account.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.list_account.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.list_account.ColumnHeadersHeight = 40;
            this.list_account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.list_account.DefaultCellStyle = dataGridViewCellStyle3;
            this.list_account.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.list_account.Location = new System.Drawing.Point(20, 147);
            this.list_account.Name = "list_account";
            this.list_account.ReadOnly = true;
            this.list_account.RowHeadersVisible = false;
            this.list_account.RowHeadersWidth = 51;
            this.list_account.RowTemplate.Height = 24;
            this.list_account.Size = new System.Drawing.Size(890, 413);
            this.list_account.TabIndex = 14;
            this.list_account.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.list_account.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.list_account.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.list_account.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.list_account.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.list_account.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.list_account.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.list_account.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.list_account.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.list_account.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.list_account.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.list_account.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.list_account.ThemeStyle.HeaderStyle.Height = 40;
            this.list_account.ThemeStyle.ReadOnly = true;
            this.list_account.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.list_account.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.list_account.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.list_account.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.list_account.ThemeStyle.RowsStyle.Height = 24;
            this.list_account.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.list_account.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ManageAccount
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(930, 570);
            this.Controls.Add(this.list_account);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.bt_add);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageAccount";
            this.Load += new System.EventHandler(this.ManageAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.list_account)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton bt_search;
        private Guna.UI2.WinForms.Guna2TextBox tb_search;
        private Guna.UI2.WinForms.Guna2ImageButton bt_delete;
        private Guna.UI2.WinForms.Guna2ImageButton bt_edit;
        private Guna.UI2.WinForms.Guna2ImageButton bt_add;
        private Guna.UI2.WinForms.Guna2DataGridView list_account;
    }
}