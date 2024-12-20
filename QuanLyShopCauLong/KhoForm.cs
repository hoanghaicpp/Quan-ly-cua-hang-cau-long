using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShopCauLong
{
    public partial class KhoForm : Form
    {
        public KhoForm(string mk, string username, string password)
        {
            InitializeComponent();
            this.mk = mk;
            this.username = username;
            this.password = password;
        }
        private string mk;
        private string username;
        private string password;
        private void KhoForm_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mk))
            {
                this.Text = "Thêm mới kho";
                IDTextBox.Enabled = true;
            }
            else
            {
                AddSanPhamButton.Visible = true;
                AddSanPhamButton.Enabled = true;    
                this.Text = "Cập nhật thông tin kho";
                AddButton.Text = "Sửa";
                if (new Database(username, password).OpenDatabase() == false) this.Close();
                DataRow datarow = new Database(username, password).Select("SelectKho '" + mk + "'");
                IDTextBox.Text = datarow["MaKho"].ToString();
                NameTextBox.Text = datarow["TenKho"].ToString();
                LoadDataSanPhamKho();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string sql = "";
            string MaKho = IDTextBox.Text;
            string TenKho = NameTextBox.Text;
            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (String.IsNullOrEmpty(mk))
            {
                sql = "AddKho";
                lstPara.Add(new CustomParameter("@MaKho", MaKho));
            }
            else
            {
                sql = "UpdateKho";
                lstPara.Add(new CustomParameter("@MaKho", mk));
            }
            lstPara.Add(new CustomParameter("@TenKho", TenKho));
            int rs = new Database(username, password).Excute(sql, lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(mk))
                {
                    MessageBox.Show("Thêm mới kho thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin kho thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thực thi thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void LoadDataSanPhamKho()
        {
            string sql = "SelectAllSanPhamKho";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter("@MaKho", IDTextBox.Text));
            DataKhoView.DataSource = new Database(username, password).SelectData(sql, lstPara);
            DataKhoView.Columns["MaChiTietKho"].HeaderText = "Mã chi tiết kho";
            DataKhoView.Columns["TenSanPham"].HeaderText = "Tên sản phẩm";
            DataKhoView.Columns["NamSanXuat"].HeaderText = "Năm sản xuất";
            DataKhoView.Columns["DonGia"].HeaderText = "Đơn giá";
            DataKhoView.Columns["SoLuong"].HeaderText = "Số lượng";
        }

        private void DataKhoView_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string mctk = DataKhoView.Rows[e.RowIndex].Cells["MaChiTietKho"].Value.ToString();
                new SanPhamKhoForm(mctk, IDTextBox.Text, username, password).ShowDialog();
                LoadDataSanPhamKho();
            }
        }

        private void AddSanPhamButton_Click(object sender, EventArgs e)
        {
            new SanPhamKhoForm(null, IDTextBox.Text, username, password).ShowDialog();
            LoadDataSanPhamKho();
        }

        private void DataKhoView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == DataKhoView.Columns["DeleteButton"].Index)
                {
                    if (MessageBox.Show("Bạn có thực sự muốn xóa thông tin này?", "Xóa thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string sql = "";
                        string Ma = "";
                        Ma = DataKhoView.Rows[e.RowIndex].Cells["MaChiTietKho"].Value.ToString();
                        sql = "DeleteChiTietKho";
                        List<CustomParameter> lstPara = new List<CustomParameter>();
                        lstPara.Add(new CustomParameter("@MaChiTietKho", Ma));
                        if (new Database(username, password).Excute(sql, lstPara) != -100)
                            MessageBox.Show("Xóa sản phẩm trong kho thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataSanPhamKho();
                    }
                }
            }
        }
    }
}
