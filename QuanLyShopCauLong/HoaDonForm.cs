using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShopCauLong
{
    public partial class HoaDonForm : Form
    {
        public HoaDonForm(string mhd, string username, string password)
        {
            InitializeComponent();
            this.mhd = mhd;
            this.username = username;
            this.password = password;
        }
        private string mhd;
        private string username;
        private string password;
        private void HoaDonForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCLDataSet2.Table_KhachHang' table. You can move, or remove it, as needed.
            this.table_KhachHangTableAdapter.Fill(this.qLCLDataSet2.Table_KhachHang);
            // TODO: This line of code loads data into the 'qLCLDataSet1.Table_SanPham' table. You can move, or remove it, as needed.
            this.table_SanPhamTableAdapter.Fill(this.qLCLDataSet1.Table_SanPham);
            // TODO: This line of code loads data into the 'qLCLDataSet.Table_ViTri' table. You can move, or remove it, as needed.
            this.table_ViTriTableAdapter.Fill(this.qLCLDataSet.Table_ViTri);
            DataTable datatable = new Database(username, password).SelectData("SelectNhanVienThuNgan", null);
            NVComboBox.DataSource = datatable;
            NVComboBox.DisplayMember = "HoTen";
            NVComboBox.ValueMember = "MaNhanVien";
            if (string.IsNullOrEmpty(mhd))
            {
                this.Text = "Thêm mới hóa đơn";
                IDTextBox.Enabled = true;
                AddButton.Visible = true;
                AddButton.Enabled = true;
                KHComboBox.Enabled = true;
                NVComboBox.Enabled = true;
                DateTextBox.Enabled = true;
            }
            else
            {
                AddSanPhamButton.Visible = true;
                AddSanPhamButton.Enabled = true;
                this.Text = "Cập nhật thông tin hóa đơn";
                if (new Database(username, password).OpenDatabase() == false) this.Close();
                DataRow datarow = new Database(username, password).Select("SelectHoaDon '" + mhd + "'");
                IDTextBox.Text = datarow["MaHoaDon"].ToString();
                KHComboBox.Text = datarow["HoTenKH"].ToString();
                NVComboBox.Text = datarow["HoTenNV"].ToString();
                DateTextBox.Text = datarow["NgayLap"].ToString();
                LoadDataSanPhamHoaDon();
            }
        }
        void LoadDataSanPhamHoaDon()
        {
            string sql = "SelectAllSanPhamHoaDon";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter("@MaHoaDon", IDTextBox.Text));
            DataNVView.DataSource = new Database(username, password).SelectData(sql, lstPara);
            DataNVView.Columns["MaChiTietHoaDon"].HeaderText = "Mã chi tiết hóa đơn";
            DataNVView.Columns["TenSanPham"].HeaderText = "Tên sản phẩm";
            DataNVView.Columns["NamSanXuat"].HeaderText = "Năm sản xuất";
            DataNVView.Columns["DonGia"].HeaderText = "Đơn giá";
            DataNVView.Columns["SoLuong"].HeaderText = "Số lượng";
        }

        private void AddSanPhamButton_Click(object sender, EventArgs e)
        {
            new SanPhamHoaDonForm(mhd, username, password).ShowDialog();
            LoadDataSanPhamHoaDon();
        }



        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string MaHoaDon = IDTextBox.Text;
            string MaKhachHang = KHComboBox.SelectedValue.ToString();
            string MaNhanVien = NVComboBox.SelectedValue.ToString();
            DateTime NgayLap;
            try
            {
                NgayLap = DateTime.ParseExact(DateTextBox.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ngày sinh không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DateTextBox.Select();
                return;
            }
            string sql = "AddHoaDon";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter("@MaHoaDon", MaHoaDon));
            lstPara.Add(new CustomParameter("@MaKhachHang", MaKhachHang));
            lstPara.Add(new CustomParameter("@MaNhanVien", MaNhanVien));
            lstPara.Add(new CustomParameter("@NgayLap", NgayLap.ToString("yyyy-MM-dd")));
            int rs = new Database(username, password).Excute(sql, lstPara);
            if (rs == 1)
            {
                MessageBox.Show("Thêm mới nhân viên hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thực thi thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataNVView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == DataNVView.Columns["DeleteButton"].Index)
                {
                    if (MessageBox.Show("Bạn có thực sự muốn xóa thông tin này?", "Xóa thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string sql = "";
                        string Ma = "";
                        Ma = DataNVView.Rows[e.RowIndex].Cells["MaChiTietHoaDon"].Value.ToString();
                        sql = "DeleteChiTietHoaDon";
                        List<CustomParameter> lstPara = new List<CustomParameter>();
                        lstPara.Add(new CustomParameter("@MaChiTietHoaDon", Ma));
                        if (new Database(username, password).Excute(sql, lstPara) != -100)
                            MessageBox.Show("Xóa sản phẩm trong hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataSanPhamHoaDon();
                    }
                }
            }
        }
    }
}
