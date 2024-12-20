namespace QuanLyShopCauLong
{
    partial class KhoForm
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
            this.IDTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddSanPhamButton = new System.Windows.Forms.Button();
            this.DataKhoView = new System.Windows.Forms.DataGridView();
            this.DeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataKhoView)).BeginInit();
            this.SuspendLayout();
            // 
            // IDTextBox
            // 
            this.IDTextBox.Enabled = false;
            this.IDTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.IDTextBox.Location = new System.Drawing.Point(144, 29);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(96, 32);
            this.IDTextBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(30, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 24);
            this.label7.TabIndex = 28;
            this.label7.Text = "Mã kho";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.NameTextBox.Location = new System.Drawing.Point(144, 91);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(306, 66);
            this.NameTextBox.TabIndex = 2;
            this.NameTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(30, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tên kho";
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CancelButton.Location = new System.Drawing.Point(594, 110);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(104, 47);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Hủy";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.AddButton.Location = new System.Drawing.Point(594, 20);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(104, 47);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Thêm";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddSanPhamButton
            // 
            this.AddSanPhamButton.Enabled = false;
            this.AddSanPhamButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.AddSanPhamButton.Location = new System.Drawing.Point(12, 221);
            this.AddSanPhamButton.Name = "AddSanPhamButton";
            this.AddSanPhamButton.Size = new System.Drawing.Size(142, 38);
            this.AddSanPhamButton.TabIndex = 5;
            this.AddSanPhamButton.Text = "Thêm sản phẩm";
            this.AddSanPhamButton.UseVisualStyleBackColor = true;
            this.AddSanPhamButton.Visible = false;
            this.AddSanPhamButton.Click += new System.EventHandler(this.AddSanPhamButton_Click);
            // 
            // DataKhoView
            // 
            this.DataKhoView.AllowUserToAddRows = false;
            this.DataKhoView.AllowUserToDeleteRows = false;
            this.DataKhoView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DataKhoView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataKhoView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeleteButton});
            this.DataKhoView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataKhoView.Location = new System.Drawing.Point(0, 265);
            this.DataKhoView.MultiSelect = false;
            this.DataKhoView.Name = "DataKhoView";
            this.DataKhoView.ReadOnly = true;
            this.DataKhoView.RowHeadersWidth = 51;
            this.DataKhoView.RowTemplate.Height = 24;
            this.DataKhoView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataKhoView.Size = new System.Drawing.Size(800, 267);
            this.DataKhoView.TabIndex = 31;
            this.DataKhoView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataKhoView_CellClick);
            this.DataKhoView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataKhoView_CellDoubleClick_1);
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
            // KhoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.DataKhoView);
            this.Controls.Add(this.AddSanPhamButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label7);
            this.Name = "KhoForm";
            this.Text = "KhoForm";
            this.Load += new System.EventHandler(this.KhoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataKhoView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox IDTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox NameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button AddSanPhamButton;
        private System.Windows.Forms.DataGridView DataKhoView;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteButton;
    }
}