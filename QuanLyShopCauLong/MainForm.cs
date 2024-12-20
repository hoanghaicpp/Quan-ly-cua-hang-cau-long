using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShopCauLong
{
    public partial class MainForm : Form
    {
        
        public MainForm(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }
        int id = 0;
        int hd = 0;
        private string username;
        private string password;
        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            id = 0;
            ShowTable(false);
        }

        private void NhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            id = 1;
            ShowTable(true);
            LoadDataNhanVien("");
        }

        private void KhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            id = 2;
            ShowTable(true);
            LoadDataKhachHang("");
        }

        private void HoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            id = 3;
        }

        private void SanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            id = 4;
            ShowTable(true);
            LoadDataSanPham("");
        }

        void LoadDataSanPham(string tukhoa)
        {
            string sql = "SelectAllSanPham";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter("@tukhoa", tukhoa));
            DataView.DataSource = new Database(username, password).SelectData(sql, lstPara);
            DataView.Columns["MaSanPham"].HeaderText = "Mã sản phẩm";
            DataView.Columns["TenSanPham"].HeaderText = "Tên sản phẩm";
            DataView.Columns["NamSanXuat"].HeaderText = "Năm sản xuất";
            DataView.Columns["DonGia"].HeaderText = "Đơn giá";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            if (new Database(username, password).OpenDatabase() == false) this.Close();
            
        }

        void ShowTable(bool show)
        {
            DataView.Visible = show;
            SearchButton.Visible = show;
            SearchButton.Enabled = show;
            SearchTextBox.Visible = show;
            SearchTextBox.Enabled = show;
            KeyLabel.Visible = show;
            AddButton.Visible = show;
            AddButton.Enabled = show;
            DeleteButton.Visible = show;
            SearchTextBox.Text = "";
        }

        void LoadDataNhanVien(string tukhoa)
        {
            string sql = "SelectAllNhanVien";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter("@tukhoa", tukhoa));
            DataView.DataSource = new Database(username, password).SelectData(sql, lstPara);
            if (DataView.DataSource != null)
            {
                DataView.Columns["MaNhanVien"].HeaderText = "Mã nhân viên";
                DataView.Columns["HoTen"].HeaderText = "Họ và tên";
                DataView.Columns["GioiTinh"].HeaderText = "Giới tính";
                DataView.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                DataView.Columns["TenViTri"].HeaderText = "Vị trí";
                DataView.Columns["Luong"].HeaderText = "Lương";
                DataView.Columns["Sdt"].HeaderText = "Số điện thoại";
                DataView.Columns["DiaChi"].HeaderText = "Địa chỉ";
            }
            else
            {
                MessageBox.Show("Tài khoản không có quyền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void LoadDataKhachHang(string tukhoa)
        {
            string sql = "SelectAllKhachHang";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter("@tukhoa", tukhoa));
            DataView.DataSource = new Database(username, password).SelectData(sql, lstPara);
            DataView.Columns["MaKhachHang"].HeaderText = "Mã khách hàng";
            DataView.Columns["HoTen"].HeaderText = "Họ và tên";
            DataView.Columns["Sdt"].HeaderText = "Số điện thoại";
            DataView.Columns["DiaChi"].HeaderText = "Địa chỉ";
        }
        private void DataView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (id)
            {
                case 1:
                    if (e.RowIndex >= 0)
                    {
                        string mnv = DataView.Rows[e.RowIndex].Cells["MaNhanVien"].Value.ToString();
                        new NhanVienForm(mnv, username, password).ShowDialog();
                        LoadDataNhanVien("");
                        SearchTextBox.Text = "";
                    }
                    break;
                case 2:
                    if (e.RowIndex >= 0)
                    {
                        string mkh = DataView.Rows[e.RowIndex].Cells["MaKhachHang"].Value.ToString();
                        new KhachHangForm(mkh, username, password).ShowDialog();
                        LoadDataKhachHang("");
                        SearchTextBox.Text = "";
                    }
                    break;
                case 3:
                    if (hd == 1)
                    {
                        string mhd = DataView.Rows[e.RowIndex].Cells["MaHoaDon"].Value.ToString();
                        new HoaDonForm(mhd, username, password).ShowDialog();
                        LoadDataTKHoaDon("");
                        SearchTextBox.Text = "";
                    }
                    break;
                case 4:
                    if (e.RowIndex >= 0)
                    {
                        string msp = DataView.Rows[e.RowIndex].Cells["MaSanPham"].Value.ToString();
                        new SanPhamForm(msp, username, password).ShowDialog();
                        LoadDataSanPham("");
                        SearchTextBox.Text = "";
                    }
                    break;
                case 5:
                    if (e.RowIndex >= 0)
                    {
                        string mk = DataView.Rows[e.RowIndex].Cells["MaKho"].Value.ToString();
                        new KhoForm(mk, username, password).ShowDialog();
                        LoadDataKho("");
                        SearchTextBox.Text = "";
                    }
                    break;
                case 6:
                    if (e.RowIndex >= 0)
                    {
                        string mvt = DataView.Rows[e.RowIndex].Cells["MaViTri"].Value.ToString();
                        new ViTriForm(mvt, username, password).ShowDialog();
                        LoadDataViTri();
                    }
                    break;
            }   
            
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string key = SearchTextBox.Text;
            switch (id)
            {
                case 1:
                    LoadDataNhanVien(key);
                    break;
                case 2:
                    LoadDataKhachHang(key);
                    break;
                case 3:
                    switch (hd)
                    {
                        case 1:
                            LoadDataTKHoaDon(key);
                            break;
                        case 2:
                            LoadDataTKHoaDonNhanVien(key);
                            break;
                    }
                    break;
                case 4:
                    LoadDataSanPham(key); 
                    break;
                case 5:
                    LoadDataKho(key);
                    break;
            }  
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            switch (id)
            {
                case 1:
                    new NhanVienForm(null, username, password).ShowDialog();
                    LoadDataNhanVien("");
                    SearchTextBox.Text = "";
                    break;
                case 2:
                    new KhachHangForm(null, username, password).ShowDialog();
                    LoadDataKhachHang("");
                    SearchTextBox.Text = "";
                    break;
                case 3:
                    if (hd == 1)
                    {
                        new HoaDonForm(null, username, password).ShowDialog();
                        LoadDataTKHoaDon("");
                        SearchTextBox.Text = "";
                    }
                    break;
                case 4:
                    new SanPhamForm(null, username, password).ShowDialog();
                    LoadDataSanPham("");
                    SearchTextBox.Text = "";
                    break;
                case 5:
                    new KhoForm(null, username, password).ShowDialog();
                    LoadDataKho("");
                    SearchTextBox.Text = "";
                    break;
            }
        }

        private void TKHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hd = 1;
            ShowTable(true);
            LoadDataTKHoaDon("");
        }
        void LoadDataTKHoaDon(string tukhoa)
        {
            string sql = "SelectAllHoaDon";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter("@tukhoa", tukhoa));
            DataView.DataSource = new Database(username, password).SelectData(sql, lstPara);
            DataView.Columns["MaHoaDon"].HeaderText = "Mã hóa đơn";
            DataView.Columns["HoTenKH"].HeaderText = "Tên khách hàng";
            DataView.Columns["HoTenNV"].HeaderText = "Nhân viên thu ngân";
            DataView.Columns["NgayLap"].HeaderText = "Ngày lập hóa đơn";
        }

        private void HoaDonThuNganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hd = 2;
            ShowTable(true);
            AddButton.Visible = false;
            AddButton.Enabled = false;
            DeleteButton.Visible = false;
            LoadDataTKHoaDonNhanVien("");
        }

        void LoadDataTKHoaDonNhanVien(string tukhoa)
        {
            string sql = "SelectAllHoaDonNhanVien";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter("@tukhoa", tukhoa));
            DataView.DataSource = new Database(username, password).SelectData(sql, lstPara);
            if (DataView.DataSource != null)
            {
                DataView.Columns["HoTen"].HeaderText = "Nhân viên thu ngân";
                DataView.Columns["Count_NhanVien"].HeaderText = "Số lượng hóa đơn đã tạo";
            }
            else MessageBox.Show("Tài khoản không có quyền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void HoaDonTrongNgayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTable(false);
            DataView.Visible = true;
            LoadDataTKHoaDonNgay();
        }
        void LoadDataTKHoaDonNgay()
        {
            string sql = "SelectAllHoaDonNgay";
            DataView.DataSource = new Database(username, password).SelectData(sql, null);
            if (DataView.DataSource != null)
            {
                DataView.Columns["NgayLap"].HeaderText = "Thời gian";
                DataView.Columns["Count_NgayLap"].HeaderText = "Số lượng hóa đơn được tạo";
            }
            else MessageBox.Show("Tài khoản không có quyền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void khoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            id = 5;
            ShowTable(true);
            LoadDataKho("");
        }
        void LoadDataKho(string tukhoa)
        {
            string sql = "SelectAllKho";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter("@tukhoa", tukhoa));
            DataView.DataSource = new Database(username, password).SelectData(sql, lstPara);
            DataView.Columns["MaKho"].HeaderText = "Mã kho";
            DataView.Columns["TenKho"].HeaderText = "Tên kho";
        }

        private void DataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == DataView.Columns["DeleteButton"].Index)
                {
                    if (MessageBox.Show("Bạn có thực sự muốn xóa thông tin này?", "Xóa thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string sql = "";
                        string Ma = "";
                        switch (id)
                        {
                            case 1:
                                Ma = DataView.Rows[e.RowIndex].Cells["MaNhanVien"].Value.ToString();
                                sql = "DeleteNhanVien";
                                List<CustomParameter> lstPara = new List<CustomParameter>();
                                lstPara.Add(new CustomParameter("@MaNhanVien", Ma));
                                if (new Database(username, password).Excute(sql, lstPara) != -100)
                                    MessageBox.Show("Xóa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadDataNhanVien("");
                                SearchTextBox.Text = "";
                                break;
                            case 2:
                                Ma = DataView.Rows[e.RowIndex].Cells["MaKhachHang"].Value.ToString();
                                sql = "DeleteKhachHang";
                                lstPara = new List<CustomParameter>();
                                lstPara.Add(new CustomParameter("@MaKhachHang", Ma));
                                if (new Database(username, password).Excute(sql, lstPara) != -100)
                                    MessageBox.Show("Xóa khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadDataKhachHang("");
                                SearchTextBox.Text = "";
                                break;
                            case 3:
                                Ma = DataView.Rows[e.RowIndex].Cells["MaHoaDon"].Value.ToString();
                                sql = "DeleteHoaDon";
                                lstPara = new List<CustomParameter>();
                                lstPara.Add(new CustomParameter("@MaHoaDon", Ma));
                                if (new Database(username, password).Excute(sql, lstPara) != -100)
                                    MessageBox.Show("Xóa hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadDataTKHoaDon("");
                                SearchTextBox.Text = "";
                                break;
                            case 4:
                                Ma = DataView.Rows[e.RowIndex].Cells["MaSanPham"].Value.ToString();
                                sql = "DeleteSanPham";
                                lstPara = new List<CustomParameter>();
                                lstPara.Add(new CustomParameter("@MaSanPham", Ma));
                                if (new Database(username, password).Excute(sql, lstPara) != -100)
                                    MessageBox.Show("Xóa sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadDataSanPham("");
                                SearchTextBox.Text = "";
                                break;
                            case 5:
                                Ma = DataView.Rows[e.RowIndex].Cells["MaKho"].Value.ToString();
                                sql = "DeleteKho";
                                lstPara = new List<CustomParameter>();
                                lstPara.Add(new CustomParameter("@MaKho", Ma));
                                if (new Database(username, password).Excute(sql, lstPara) != -100)
                                    MessageBox.Show("Xóa kho thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadDataKho("");
                                SearchTextBox.Text = "";
                                break;
                        }
                    }    
                }
            }
        }

        private void ViTriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            id = 6;
            ShowTable(false);
            DataView.Visible = true;
            DeleteButton.Visible = false;
            LoadDataViTri();
        }
        void LoadDataViTri()
        {
            string sql = "select MaViTri, TenViTri, FORMAT(Luong, 'N0') + N'đ' as Luong from Table_ViTri";
            DataView.DataSource = new Database(username, password).SelectData(sql, null);
            DataView.Columns["MaViTri"].HeaderText = "Mã vị trí";
            DataView.Columns["TenViTri"].HeaderText = "Tên vị trí";
            DataView.Columns["Luong"].HeaderText = "Lương";
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }
    }
}
