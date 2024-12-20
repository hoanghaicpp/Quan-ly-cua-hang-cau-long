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
    public partial class SanPhamKhoForm : Form
    {
        public SanPhamKhoForm(string mctk, string mk, string username, string password)
        {
            InitializeComponent();
            this.mctk = mctk;
            this.mk = mk;
            this.username = username;
            this.password = password;
        }
        private string mctk;
        private string mk;
        private string username;
        private string password;
        private void SanPhamKhoForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCLDataSet1.Table_SanPham' table. You can move, or remove it, as needed.
            this.table_SanPhamTableAdapter.Fill(this.qLCLDataSet1.Table_SanPham);
            if (string.IsNullOrEmpty(mctk))
            {
                this.Text = "Thêm mới sản phẩm trong kho";
                IDTextBox.Enabled = true;
                NameComboBox.Enabled = true;
            }
            else
            {
                this.Text = "Cập nhật thông tin sản phẩm trong kho";
                AddButton.Text = "Sửa";
                if (new Database(username, password).OpenDatabase() == false) this.Close();
                DataRow datarow = new Database(username, password).Select("SelectSanPhamKho '" + mctk + "'");
                IDTextBox.Text = datarow["MaChiTietKho"].ToString();
                NameComboBox.Text = datarow["TenSanPham"].ToString();
                CntTextBox.Text = datarow["SoLuong"].ToString();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string sql = "";
            string MaChiTietKho = IDTextBox.Text;
            string MaSanPham = NameComboBox.SelectedValue.ToString();
            string SoLuong = CntTextBox.Text;
            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (String.IsNullOrEmpty(mctk))
            {
                sql = "AddSanPhamKho";
                lstPara.Add(new CustomParameter("@MaChiTietKho", MaChiTietKho));
            }
            else
            {
                sql = "UpdateSanPhamKho";
                lstPara.Add(new CustomParameter("@MaChiTietKho", mctk));
            }
            lstPara.Add(new CustomParameter("@MaKho", mk));
            lstPara.Add(new CustomParameter("@MaSanPham", MaSanPham));
            lstPara.Add(new CustomParameter("@SoLuong", SoLuong));
            int rs = new Database(username, password).Excute(sql, lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(mctk))
                {
                    MessageBox.Show("Thêm mới sản phẩm trong kho thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin sản phẩm trong kho thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
