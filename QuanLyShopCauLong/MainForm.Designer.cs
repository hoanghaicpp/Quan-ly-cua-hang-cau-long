namespace QuanLyShopCauLong
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KhachHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HoaDonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TKHoaDonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HoaDonTrongNgayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HoaDonThuNganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SanPhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViTriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackgroundPanel = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataView = new System.Windows.Forms.DataGridView();
            this.DeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.BackgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeToolStripMenuItem,
            this.NhanVienToolStripMenuItem,
            this.KhachHangToolStripMenuItem,
            this.HoaDonToolStripMenuItem,
            this.SanPhamToolStripMenuItem,
            this.KhoToolStripMenuItem,
            this.ViTriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1083, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // HomeToolStripMenuItem
            // 
            this.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem";
            this.HomeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.HomeToolStripMenuItem.Text = "Home";
            this.HomeToolStripMenuItem.Click += new System.EventHandler(this.HomeToolStripMenuItem_Click);
            // 
            // NhanVienToolStripMenuItem
            // 
            this.NhanVienToolStripMenuItem.Name = "NhanVienToolStripMenuItem";
            this.NhanVienToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.NhanVienToolStripMenuItem.Text = "Nhân viên";
            this.NhanVienToolStripMenuItem.Click += new System.EventHandler(this.NhanVienToolStripMenuItem_Click);
            // 
            // KhachHangToolStripMenuItem
            // 
            this.KhachHangToolStripMenuItem.Name = "KhachHangToolStripMenuItem";
            this.KhachHangToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.KhachHangToolStripMenuItem.Text = "Khách hàng";
            this.KhachHangToolStripMenuItem.Click += new System.EventHandler(this.KhachHangToolStripMenuItem_Click);
            // 
            // HoaDonToolStripMenuItem
            // 
            this.HoaDonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TKHoaDonToolStripMenuItem,
            this.HoaDonTrongNgayToolStripMenuItem,
            this.HoaDonThuNganToolStripMenuItem});
            this.HoaDonToolStripMenuItem.Name = "HoaDonToolStripMenuItem";
            this.HoaDonToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.HoaDonToolStripMenuItem.Text = "Hóa đơn";
            this.HoaDonToolStripMenuItem.Click += new System.EventHandler(this.HoaDonToolStripMenuItem_Click);
            // 
            // TKHoaDonToolStripMenuItem
            // 
            this.TKHoaDonToolStripMenuItem.Name = "TKHoaDonToolStripMenuItem";
            this.TKHoaDonToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            this.TKHoaDonToolStripMenuItem.Text = "Thống kê hóa đơn";
            this.TKHoaDonToolStripMenuItem.Click += new System.EventHandler(this.TKHoaDonToolStripMenuItem_Click);
            // 
            // HoaDonTrongNgayToolStripMenuItem
            // 
            this.HoaDonTrongNgayToolStripMenuItem.Name = "HoaDonTrongNgayToolStripMenuItem";
            this.HoaDonTrongNgayToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            this.HoaDonTrongNgayToolStripMenuItem.Text = "Thống kê hóa đơn trong ngày";
            this.HoaDonTrongNgayToolStripMenuItem.Click += new System.EventHandler(this.HoaDonTrongNgayToolStripMenuItem_Click);
            // 
            // HoaDonThuNganToolStripMenuItem
            // 
            this.HoaDonThuNganToolStripMenuItem.Name = "HoaDonThuNganToolStripMenuItem";
            this.HoaDonThuNganToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            this.HoaDonThuNganToolStripMenuItem.Text = "Thống kê hóa đơn theo thu ngân";
            this.HoaDonThuNganToolStripMenuItem.Click += new System.EventHandler(this.HoaDonThuNganToolStripMenuItem_Click);
            // 
            // SanPhamToolStripMenuItem
            // 
            this.SanPhamToolStripMenuItem.Name = "SanPhamToolStripMenuItem";
            this.SanPhamToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.SanPhamToolStripMenuItem.Text = "Sản phẩm";
            this.SanPhamToolStripMenuItem.Click += new System.EventHandler(this.SanPhamToolStripMenuItem_Click);
            // 
            // KhoToolStripMenuItem
            // 
            this.KhoToolStripMenuItem.Name = "KhoToolStripMenuItem";
            this.KhoToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.KhoToolStripMenuItem.Text = "Kho";
            this.KhoToolStripMenuItem.Click += new System.EventHandler(this.khoToolStripMenuItem_Click);
            // 
            // ViTriToolStripMenuItem
            // 
            this.ViTriToolStripMenuItem.Name = "ViTriToolStripMenuItem";
            this.ViTriToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.ViTriToolStripMenuItem.Text = "Vị trí công việc";
            this.ViTriToolStripMenuItem.Click += new System.EventHandler(this.ViTriToolStripMenuItem_Click);
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.BackgroundImage = global::QuanLyShopCauLong.Properties.Resources.badminton_bg;
            this.BackgroundPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundPanel.Controls.Add(this.LogoutButton);
            this.BackgroundPanel.Controls.Add(this.AddButton);
            this.BackgroundPanel.Controls.Add(this.SearchButton);
            this.BackgroundPanel.Controls.Add(this.SearchTextBox);
            this.BackgroundPanel.Controls.Add(this.KeyLabel);
            this.BackgroundPanel.Controls.Add(this.label1);
            this.BackgroundPanel.Controls.Add(this.DataView);
            this.BackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundPanel.Location = new System.Drawing.Point(0, 28);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(1083, 632);
            this.BackgroundPanel.TabIndex = 2;
            // 
            // AddButton
            // 
            this.AddButton.Enabled = false;
            this.AddButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.AddButton.Location = new System.Drawing.Point(12, 138);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(110, 27);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Thêm mới";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Visible = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Enabled = false;
            this.SearchButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SearchButton.Location = new System.Drawing.Point(935, 138);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(110, 27);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Tìm kiếm";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Visible = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Enabled = false;
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(661, 138);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(268, 30);
            this.SearchTextBox.TabIndex = 4;
            this.SearchTextBox.Visible = false;
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.BackColor = System.Drawing.SystemColors.Control;
            this.KeyLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.KeyLabel.Location = new System.Drawing.Point(578, 142);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(77, 24);
            this.KeyLabel.TabIndex = 3;
            this.KeyLabel.Text = "Từ khóa";
            this.KeyLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(253, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(591, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phần mềm quản lý cửa hàng cầu lông";
            // 
            // DataView
            // 
            this.DataView.AllowUserToAddRows = false;
            this.DataView.AllowUserToDeleteRows = false;
            this.DataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeleteButton});
            this.DataView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataView.Location = new System.Drawing.Point(0, 176);
            this.DataView.MultiSelect = false;
            this.DataView.Name = "DataView";
            this.DataView.ReadOnly = true;
            this.DataView.RowHeadersWidth = 51;
            this.DataView.RowTemplate.Height = 24;
            this.DataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataView.Size = new System.Drawing.Size(1083, 456);
            this.DataView.TabIndex = 1;
            this.DataView.Visible = false;
            this.DataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataView_CellClick);
            this.DataView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataView_CellDoubleClick);
            // 
            // DeleteButton
            // 
            this.DeleteButton.HeaderText = "";
            this.DeleteButton.MinimumWidth = 6;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.ReadOnly = true;
            this.DeleteButton.Text = "Xóa";
            this.DeleteButton.UseColumnTextForButtonValue = true;
            this.DeleteButton.Width = 6;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LogoutButton.Location = new System.Drawing.Point(935, 11);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(136, 40);
            this.LogoutButton.TabIndex = 7;
            this.LogoutButton.Text = "Đăng xuất";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 660);
            this.Controls.Add(this.BackgroundPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn hình chính";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.BackgroundPanel.ResumeLayout(false);
            this.BackgroundPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KhachHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HoaDonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SanPhamToolStripMenuItem;
        private System.Windows.Forms.Panel BackgroundPanel;
        private System.Windows.Forms.DataGridView DataView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ToolStripMenuItem HoaDonTrongNgayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HoaDonThuNganToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TKHoaDonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KhoToolStripMenuItem;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteButton;
        private System.Windows.Forms.ToolStripMenuItem ViTriToolStripMenuItem;
        private System.Windows.Forms.Button LogoutButton;
    }
}