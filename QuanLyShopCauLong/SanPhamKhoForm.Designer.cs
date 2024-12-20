namespace QuanLyShopCauLong
{
    partial class SanPhamKhoForm
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
            this.IDTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CntTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.NameComboBox = new System.Windows.Forms.ComboBox();
            this.qLCLDataSet1 = new QuanLyShopCauLong.QLCLDataSet1();
            this.tableSanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_SanPhamTableAdapter = new QuanLyShopCauLong.QLCLDataSet1TableAdapters.Table_SanPhamTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qLCLDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableSanPhamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // IDTextBox
            // 
            this.IDTextBox.Enabled = false;
            this.IDTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.IDTextBox.Location = new System.Drawing.Point(166, 16);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(96, 32);
            this.IDTextBox.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(25, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 24);
            this.label7.TabIndex = 30;
            this.label7.Text = "Mã chi tiết kho";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(25, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "Tên sản phẩm";
            // 
            // CntTextBox
            // 
            this.CntTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CntTextBox.Location = new System.Drawing.Point(166, 172);
            this.CntTextBox.Name = "CntTextBox";
            this.CntTextBox.Size = new System.Drawing.Size(126, 32);
            this.CntTextBox.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(25, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 36;
            this.label3.Text = "Số lượng";
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CancelButton.Location = new System.Drawing.Point(300, 250);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(104, 47);
            this.CancelButton.TabIndex = 38;
            this.CancelButton.Text = "Hủy";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.AddButton.Location = new System.Drawing.Point(80, 250);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(104, 47);
            this.AddButton.TabIndex = 37;
            this.AddButton.Text = "Thêm";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // NameComboBox
            // 
            this.NameComboBox.DataSource = this.tableSanPhamBindingSource;
            this.NameComboBox.DisplayMember = "TenSanPham";
            this.NameComboBox.Enabled = false;
            this.NameComboBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.NameComboBox.FormattingEnabled = true;
            this.NameComboBox.Location = new System.Drawing.Point(166, 78);
            this.NameComboBox.Name = "NameComboBox";
            this.NameComboBox.Size = new System.Drawing.Size(257, 32);
            this.NameComboBox.TabIndex = 39;
            this.NameComboBox.ValueMember = "MaSanPham";
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
            // SanPhamKhoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 342);
            this.Controls.Add(this.NameComboBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CntTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label7);
            this.Name = "SanPhamKhoForm";
            this.Text = "SanPhamKhoForm";
            this.Load += new System.EventHandler(this.SanPhamKhoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLCLDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableSanPhamBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox IDTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox CntTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ComboBox NameComboBox;
        private QLCLDataSet1 qLCLDataSet1;
        private System.Windows.Forms.BindingSource tableSanPhamBindingSource;
        private QLCLDataSet1TableAdapters.Table_SanPhamTableAdapter table_SanPhamTableAdapter;
    }
}