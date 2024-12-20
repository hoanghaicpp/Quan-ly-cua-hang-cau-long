namespace QuanLyShopCauLong
{
    partial class NhanVienForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.MaskedTextBox();
            this.DateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.AddressTextBox = new System.Windows.Forms.RichTextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.JobComboBox = new System.Windows.Forms.ComboBox();
            this.tableViTriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLCLDataSet = new QuanLyShopCauLong.QLCLDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.MaskedTextBox();
            this.table_ViTriTableAdapter = new QuanLyShopCauLong.QLCLDataSetTableAdapters.Table_ViTriTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.PhoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SalaryTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableViTriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCLDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(30, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(29, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(29, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(29, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vị trí";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(29, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(12, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Số điện thoại";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.NameTextBox.Location = new System.Drawing.Point(166, 82);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(307, 32);
            this.NameTextBox.TabIndex = 12;
            // 
            // DateTextBox
            // 
            this.DateTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DateTextBox.Location = new System.Drawing.Point(166, 144);
            this.DateTextBox.Mask = "00/00/0000";
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(138, 32);
            this.DateTextBox.TabIndex = 13;
            this.DateTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MaleRadioButton.Location = new System.Drawing.Point(165, 213);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(70, 28);
            this.MaleRadioButton.TabIndex = 14;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "Nam";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FemaleRadioButton.Location = new System.Drawing.Point(289, 213);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(56, 28);
            this.FemaleRadioButton.TabIndex = 15;
            this.FemaleRadioButton.TabStop = true;
            this.FemaleRadioButton.Text = "Nữ";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.AddressTextBox.Location = new System.Drawing.Point(165, 467);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(307, 72);
            this.AddressTextBox.TabIndex = 18;
            this.AddressTextBox.Text = "";
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.AddButton.Location = new System.Drawing.Point(91, 566);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(104, 47);
            this.AddButton.TabIndex = 19;
            this.AddButton.Text = "Thêm";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CancelButton.Location = new System.Drawing.Point(311, 566);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(104, 47);
            this.CancelButton.TabIndex = 20;
            this.CancelButton.Text = "Hủy";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // JobComboBox
            // 
            this.JobComboBox.DataSource = this.tableViTriBindingSource;
            this.JobComboBox.DisplayMember = "TenViTri";
            this.JobComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JobComboBox.Enabled = false;
            this.JobComboBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.JobComboBox.FormattingEnabled = true;
            this.JobComboBox.Location = new System.Drawing.Point(165, 277);
            this.JobComboBox.Name = "JobComboBox";
            this.JobComboBox.Size = new System.Drawing.Size(248, 32);
            this.JobComboBox.TabIndex = 16;
            this.JobComboBox.ValueMember = "MaViTri";
            this.JobComboBox.SelectedIndexChanged += new System.EventHandler(this.JobComboBox_SelectedIndexChanged);
            // 
            // tableViTriBindingSource
            // 
            this.tableViTriBindingSource.DataMember = "Table_ViTri";
            this.tableViTriBindingSource.DataSource = this.qLCLDataSet;
            // 
            // qLCLDataSet
            // 
            this.qLCLDataSet.DataSetName = "QLCLDataSet";
            this.qLCLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(12, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "Mã nhân viên";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Enabled = false;
            this.IDTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.IDTextBox.Location = new System.Drawing.Point(167, 22);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(96, 32);
            this.IDTextBox.TabIndex = 11;
            // 
            // table_ViTriTableAdapter
            // 
            this.table_ViTriTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(29, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 24);
            this.label8.TabIndex = 23;
            this.label8.Text = "Lương";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.PhoneTextBox.Location = new System.Drawing.Point(167, 403);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(307, 32);
            this.PhoneTextBox.TabIndex = 17;
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Enabled = false;
            this.SalaryTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SalaryTextBox.Location = new System.Drawing.Point(165, 340);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(307, 32);
            this.SalaryTextBox.TabIndex = 17;
            // 
            // NhanVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 654);
            this.Controls.Add(this.SalaryTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.JobComboBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.FemaleRadioButton);
            this.Controls.Add(this.MaleRadioButton);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NhanVienForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NhanVienForm";
            this.Load += new System.EventHandler(this.NhanVienForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableViTriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCLDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox NameTextBox;
        private System.Windows.Forms.MaskedTextBox DateTextBox;
        private System.Windows.Forms.RadioButton MaleRadioButton;
        private System.Windows.Forms.RadioButton FemaleRadioButton;
        private System.Windows.Forms.RichTextBox AddressTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ComboBox JobComboBox;
        
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox IDTextBox;
        private System.Windows.Forms.BindingSource qLCLDataSet1BindingSource;
        private QLCLDataSet qLCLDataSet;
        private System.Windows.Forms.BindingSource tableViTriBindingSource;
        private QLCLDataSetTableAdapters.Table_ViTriTableAdapter table_ViTriTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox PhoneTextBox;
        private System.Windows.Forms.MaskedTextBox SalaryTextBox;
    }
}