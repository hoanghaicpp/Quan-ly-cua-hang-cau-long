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
    public partial class SanPhamHoaDonForm : Form
    {
        public SanPhamHoaDonForm(string mhd, string username, string password)
        {
            InitializeComponent();
            this.mhd = mhd;
            this.username = username;
            this.password = password;
        } 
        private string mhd;
        private string username;
        private string password;
        private void SanPhamHoaDonForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCLDataSet1.Table_SanPham' table. You can move, or remove it, as needed.
            this.table_SanPhamTableAdapter.Fill(this.qLCLDataSet1.Table_SanPham);
            if (new Database(username, password).OpenDatabase() == false) this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string sql = "AddSanPhamHoaDon";
            string MaChiTietHoaDon = IDTextBox.Text;
            string MaSanPham = NameComboBox.SelectedValue.ToString();
            string SoLuong = CntTextBox.Text;
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter("@MaChiTietHoaDon", MaChiTietHoaDon));
            lstPara.Add(new CustomParameter("@MaHoaDon", mhd));
            lstPara.Add(new CustomParameter("@MaSanPham", MaSanPham));
            lstPara.Add(new CustomParameter("@SoLuong", SoLuong));
            int rs = new Database(username, password).Excute(sql, lstPara);
            if (rs == 1)
            {                
                MessageBox.Show("Thêm mới sản phẩm trong hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thực thi thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
