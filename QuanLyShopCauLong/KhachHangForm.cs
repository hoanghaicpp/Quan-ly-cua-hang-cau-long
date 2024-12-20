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
    public partial class KhachHangForm : Form
    {
        public KhachHangForm(string mkh, string username, string password)
        {
            InitializeComponent();
            this.mkh = mkh;
            this.username = username;
            this.password = password;
        }
        
        private string mkh;
        private string username;
        private string password;
        private void KhachHangForm_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(mkh))
            {
                this.Text = "Thêm mới khách hàng";
                IDTextBox.Enabled = true;
            }
            else
            {
                this.Text = "Cập nhật thông tin khách hàng";
                AddButton.Text = "Sửa";
                if (new Database(username, password).OpenDatabase() == false) this.Close();
                DataRow datarow = new Database(username, password).Select("SelectKhachHang '" + mkh + "'");
                IDTextBox.Text = datarow["MaKhachHang"].ToString();
                NameTextBox.Text = datarow["HoTen"].ToString();
                PhoneTextBox.Text = datarow["Sdt"].ToString();
                AddressTextBox.Text = datarow["DiaChi"].ToString();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string sql = "";
            string MaKhachHang = IDTextBox.Text;
            string HoTen = NameTextBox.Text;
            string Sdt = PhoneTextBox.Text;
            string DiaChi = AddressTextBox.Text;
            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (String.IsNullOrEmpty(mkh))
            {
                sql = "AddKhachHang";
                lstPara.Add(new CustomParameter("@MaKhachHang", MaKhachHang));
            }
            else
            {
                sql = "UpdateKhachHang";
                lstPara.Add(new CustomParameter("@MaKhachHang", mkh));
            }
            lstPara.Add(new CustomParameter("@HoTen", HoTen));
            lstPara.Add(new CustomParameter("@Sdt", Sdt));
            lstPara.Add(new CustomParameter("@DiaChi", DiaChi));
            int rs = new Database(username, password).Excute(sql, lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(mkh))
                {
                    MessageBox.Show("Thêm mới khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
