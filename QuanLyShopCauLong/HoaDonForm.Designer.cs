namespace QuanLyShopCauLong
{
    partial class HoaDonForm
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
            this.components = new System.ComponentModel.Container();
            this.AddSanPhamButton = new System.Windows.Forms.Button();
            this.DataNVView = new System.Windows.Forms.DataGridView();
            this.DateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.KHComboBox = new System.Windows.Forms.ComboBox();
            this.tableKhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLCLDataSet2 = new QuanLyShopCauLong.QLCLDataSet2();
            this.NVComboBox = new System.Windows.Forms.ComboBox();
            this.qLCLDataSet = new QuanLyShopCauLong.QLCLDataSet();
            this.tableViTriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_ViTriTableAdapter = new QuanLyShopCauLong.QLCLDataSetTableAdapters.Table_ViTriTableAdapter();
            this.qLCLDataSet1 = new QuanLyShopCauLong.QLCLDataSet1();
            this.tableSanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_SanPhamTableAdapter = new QuanLyShopCauLong.QLCLDataSet1TableAdapters.Table_SanPhamTableAdapter();
            this.table_KhachHangTableAdapter = new QuanLyShopCauLong.QLCLDataSet2TableAdapters.Table_KhachHangTableAdapter();
            this.qLCLDataSet3 = new QuanLyShopCauLong.QLCLDataSet3();
            this.tableNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_NhanVienTableAdapter = new QuanLyShopCauLong.QLCLDataSet3TableAdapters.Table_NhanVienTableAdapter();
            this.DeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataNVView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableKhachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCLDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableViTriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCLDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableSanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCLDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableNhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddSanPhamButton
            // 
            this.AddSanPhamButton.Enabled = false;
            this.AddSanPhamButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.AddSanPhamButton.Location = new System.Drawing.Point(12, 264);
            this.AddSanPhamButton.Name = "AddSanPhamButton";
            this.AddSanPhamButton.Size = new System.Drawing.Size(142, 38);
            this.AddSanPhamButton.TabIndex = 7;
            this.AddSanPhamButton.Text = "Thêm sản phẩm";
            this.AddSanPhamButton.UseVisualStyleBackColor = true;
            this.AddSanPhamButton.Visible = false;
            this.AddSanPhamButton.Click += new System.EventHandler(this.AddSanPhamButton_Click);
            // 
            // DataNVView
            // 
            this.DataNVView.AllowUserToAddRows = false;
            this.DataNVView.AllowUserToDeleteRows = false;
            this.DataNVView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DataNVView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataNVView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeleteButton});
            this.DataNVView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataNVView.Location = new System.Drawing.Point(0, 308);
            this.DataNVView.MultiSelect = false;
            this.DataNVView.Name = "DataNVView";
            this.DataNVView.ReadOnly = true;
            this.DataNVView.RowHeadersWidth = 51;
            this.DataNVView.RowTemplate.Height = 24;
            this.DataNVView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataNVView.Size = new System.Drawing.Size(800, 299);
            this.DataNVView.TabIndex = 54;
            this.DataNVView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataNVView_CellClick);
            // 
            // DateTextBox
            // 
            this.DateTextBox.Enabled = false;
            this.DateTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DateTextBox.Location = new System.Drawing.Point(167, 197);
            this.DateTextBox.Mask = "00/00/0000";
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(144, 32);
            this.DateTextBox.TabIndex = 4;
            this.DateTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(30, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 53;
            this.label3.Text = "Ngày lập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(20, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 52;
            this.label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(20, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 51;
            this.label1.Text = "Tên khách hàng";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Enabled = false;
            this.IDTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.IDTextBox.Location = new System.Drawing.Point(167, 11);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(96, 32);
            this.IDTextBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(35, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 24);
            this.label7.TabIndex = 50;
            this.label7.Text = "Mã hóa đơn";
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CancelButton.Location = new System.Drawing.Point(618, 137);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(104, 47);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Hủy";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click_1);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.AddButton.Location = new System.Drawing.Point(618, 47);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(104, 47);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Thêm";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Visible = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // KHComboBox
            // 
            this.KHComboBox.DataSource = this.tableKhachHangBindingSource;
            this.KHComboBox.DisplayMember = "HoTen";
            this.KHComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KHComboBox.Enabled = false;
            this.KHComboBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.KHComboBox.FormattingEnabled = true;
            this.KHComboBox.Location = new System.Drawing.Point(167, 70);
            this.KHComboBox.Name = "KHComboBox";
            this.KHComboBox.Size = new System.Drawing.Size(248, 32);
            this.KHComboBox.TabIndex = 2;
            this.KHComboBox.ValueMember = "MaKhachHang";
            // 
            // tableKhachHangBindingSource
            // 
            this.tableKhachHangBindingSource.DataMember = "Table_KhachHang";
            this.tableKhachHangBindingSource.DataSource = this.qLCLDataSet2;
            // 
            // qLCLDataSet2
            // 
            this.qLCLDataSet2.DataSetName = "QLCLDataSet2";
            this.qLCLDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NVComboBox
            // 
            this.NVComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NVComboBox.Enabled = false;
            this.NVComboBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.NVComboBox.FormattingEnabled = true;
            this.NVComboBox.Location = new System.Drawing.Point(167, 135);
            this.NVComboBox.Name = "NVComboBox";
            this.NVComboBox.Size = new System.Drawing.Size(248, 32);
            this.NVComboBox.TabIndex = 3;
            // 
            // qLCLDataSet
            // 
            this.qLCLDataSet.DataSetName = "QLCLDataSet";
            this.qLCLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableViTriBindingSource
            // 
            this.tableViTriBindingSource.DataMember = "Table_ViTri";
            this.tableViTriBindingSource.DataSource = this.qLCLDataSet;
            // 
            // table_ViTriTableAdapter
            // 
            this.table_ViTriTableAdapter.ClearBeforeFill = true;
            // 
            // qLCLDataSet1
            // 
            this.qLCLDataSet1.DataSetName = "QLCLDataSet1";
            this.qLCLDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableSanPhamBindingSource
            // 
            this.tableSanPhamBindingSource.DataMember = "Table_SanPham";
            this.tableSanPhamBindingSource.DataSource = this.qLCLDataSet1;
            // 
            // table_SanPhamTableAdapter
            // 
            this.table_SanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // table_KhachHangTableAdapter
            // 
            this.table_KhachHangTableAdapter.ClearBeforeFill = true;
            // 
            // qLCLDataSet3
            // 
            this.qLCLDataSet3.DataSetName = "QLCLDataSet3";
            this.qLCLDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableNhanVienBindingSource
            // 
            this.tableNhanVienBindingSource.DataMember = "Table_NhanVien";
            this.tableNhanVienBindingSource.DataSource = this.qLCLDataSet3;
            // 
            // table_NhanVienTableAdapter
            // 
            this.table_NhanVienTableAdapter.ClearBeforeFill = true;
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
            // HoaDonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 607);
            this.Controls.Add(this.NVComboBox);
            this.Controls.Add(this.KHComboBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AddSanPhamButton);
            this.Controls.Add(this.DataNVView);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label7);
            this.Name = "HoaDonForm";
            this.Text = "HoaDonForm";
            this.Load += new System.EventHandler(this.HoaDonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataNVView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableKhachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCLDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableViTriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCLDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableSanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCLDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableNhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddSanPhamButton;
        private System.Windows.Forms.DataGridView DataNVView;
        private System.Windows.Forms.MaskedTextBox DateTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox IDTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ComboBox KHComboBox;
        private System.Windows.Forms.ComboBox NVComboBox;
        private QLCLDataSet qLCLDataSet;
        private System.Windows.Forms.BindingSource tableViTriBindingSource;
        private QLCLDataSetTableAdapters.Table_ViTriTableAdapter table_ViTriTableAdapter;
        private QLCLDataSet1 qLCLDataSet1;
        private System.Windows.Forms.BindingSource tableSanPhamBindingSource;
        private QLCLDataSet1TableAdapters.Table_SanPhamTableAdapter table_SanPhamTableAdapter;
        private QLCLDataSet2 qLCLDataSet2;
        private System.Windows.Forms.BindingSource tableKhachHangBindingSource;
        private QLCLDataSet2TableAdapters.Table_KhachHangTableAdapter table_KhachHangTableAdapter;
        private QLCLDataSet3 qLCLDataSet3;
        private System.Windows.Forms.BindingSource tableNhanVienBindingSource;
        private QLCLDataSet3TableAdapters.Table_NhanVienTableAdapter table_NhanVienTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteButton;
    }
}