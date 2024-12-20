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
    public partial class SanPhamForm : Form
    {
        public SanPhamForm(string msp, string username, string password)
        {
            InitializeComponent();
            this.msp = msp;
            this.username = username;
            this.password = password;
        }
        private string msp;
        private string username;
        private string password;
        private void SanPhamForm_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(msp)) 
            {
                this.Text = "Thêm mới sản phẩm";
                IDTextBox.Enabled = true;
            }
            else
            {
                this.Text = "Cập nhật thông tin sản phẩm";
                AddButton.Text = "Sửa";
                if (new Database(username, password).OpenDatabase() == false) this.Close();
                DataRow datarow = new Database(username, password).Select("SelectSanPham '" + msp + "'");
                IDTextBox.Text = datarow["MaSanPham"].ToString();
                NameTextBox.Text = datarow["TenSanPham"].ToString();
                YearTextBox.Text = datarow["NamSanXuat"].ToString();
                PriceTextBox.Text = datarow["DonGia"].ToString();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string sql = "";
            string MaSanPham = IDTextBox.Text;
            string TenSanPham = NameTextBox.Text;
            string NamSanXuat = YearTextBox.Text;
            string DonGia = PriceTextBox.Text;
            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (String.IsNullOrEmpty(msp))
            {
                sql = "AddSanPham";
                lstPara.Add(new CustomParameter("@MaSanPham", MaSanPham));
            }
            else
            {
                sql = "UpdateSanPham";
                lstPara.Add(new CustomParameter("@MaSanPham", msp));
            }
            lstPara.Add(new CustomParameter("@TenSanPham", TenSanPham));
            lstPara.Add(new CustomParameter("@NamSanXuat", NamSanXuat));
            lstPara.Add(new CustomParameter("@DonGia", DonGia.Replace(".", "").Replace(",", "").Replace("đ", "").Trim()));

            int rs = new Database(username, password).Excute(sql, lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(msp))
                {
                    MessageBox.Show("Thêm mới sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thực thi thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
