using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShopCauLong
{
    public partial class NhanVienForm : Form
    {
        public NhanVienForm(string mnv, string username, string password)
        {
            InitializeComponent();
            this.mnv = mnv;
            this.username = username;
            this.password = password;
        }
        private string mnv;
        private string username;
        private string password;
        private void NhanVienForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCLDataSet.Table_ViTri' table. You can move, or remove it, as needed.
            this.table_ViTriTableAdapter.Fill(this.qLCLDataSet.Table_ViTri);

            if (string.IsNullOrEmpty(mnv))
            {
                this.Text = "Thêm mới nhân viên";
                IDTextBox.Enabled = true;
                JobComboBox.Enabled = true;
            }
            else
            {
                this.Text = "Cập nhật thông tin nhân viên";
                AddButton.Text = "Sửa";
                if (new Database(username, password).OpenDatabase() == false) this.Close();
                DataRow datarow = new Database(username, password).Select("SelectNhanVien '" + mnv + "'");
                IDTextBox.Text = datarow["MaNhanVien"].ToString();
                NameTextBox.Text = datarow["HoTen"].ToString();
                DateTextBox.Text = datarow["NgaySinh"].ToString();
                if (datarow["GioiTinh"] is true)  MaleRadioButton.Checked = true;
                else FemaleRadioButton.Checked = true;
                JobComboBox.Text = datarow["TenViTri"].ToString();
                SalaryTextBox.Text = datarow["Luong"].ToString();
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
            string MaNhanVien = IDTextBox.Text;
            string HoTen = NameTextBox.Text;
            int GioiTinh = (MaleRadioButton.Checked ? 1 : 0);
            DateTime NgaySinh;
            try
            {
                NgaySinh = DateTime.ParseExact(DateTextBox.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Ngày sinh không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DateTextBox.Select();
                return;
            } 
            int MaViTri = int.Parse(JobComboBox.SelectedValue.ToString());
            string Sdt = PhoneTextBox.Text;
            string DiaChi = AddressTextBox.Text;
            List<CustomParameter> lstPara = new List<CustomParameter>();
            if(string.IsNullOrEmpty(mnv))
            {
                sql = "AddNhanVien";
                lstPara.Add(new CustomParameter("@MaNhanVien", MaNhanVien));
            }
            else
            {
                sql = "UpdateNhanVien";
                lstPara.Add(new CustomParameter("@MaNhanVien", mnv));
            }
            lstPara.Add(new CustomParameter("@HoTen", HoTen));
            lstPara.Add(new CustomParameter("@NgaySinh", NgaySinh.ToString("yyyy-MM-dd")));
            lstPara.Add(new CustomParameter("@GioiTinh", GioiTinh.ToString()));
            lstPara.Add(new CustomParameter("@MaViTri", MaViTri.ToString()));
            lstPara.Add(new CustomParameter("@Sdt", Sdt));
            lstPara.Add(new CustomParameter("@DiaChi", DiaChi));
            
            int rs = new Database(username, password).Excute(sql, lstPara);
            if(rs == 1)
            {
                if (string.IsNullOrEmpty(mnv))
                {
                    MessageBox.Show("Thêm mới nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thực thi thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void JobComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (JobComboBox.SelectedValue != null)
            {
                int MaViTri = int.Parse(JobComboBox.SelectedValue.ToString());
                DataRow datarow = new Database(username, password).Select("SelectViTri '" + MaViTri.ToString() + "'");
                SalaryTextBox.Text = datarow["Luong"].ToString();
            }
        }
    }
}
