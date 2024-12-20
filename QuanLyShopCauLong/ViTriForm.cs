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
    public partial class ViTriForm : Form
    {
        public ViTriForm(string mvt, string username, string password)
        {
            InitializeComponent();
            this.mvt = mvt;
            this.username = username;
            this.password = password;
        }
        private string mvt;
        private string username;
        private string password;
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViTriForm_Load(object sender, EventArgs e)
        {
            if (new Database(username, password).OpenDatabase() == false) this.Close();
            DataRow datarow = new Database(username, password).Select("SelectTBViTri '" + mvt + "'");
            IDTextBox.Text = datarow["MaViTri"].ToString();
            NameTextBox.Text = datarow["TenViTri"].ToString();
            SalaryTextBox.Text = datarow["Luong"].ToString();
        }

        private void FixButton_Click(object sender, EventArgs e)
        {
            string sql = "UpdateViTri";
            string Luong = SalaryTextBox.Text;
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter("@MaViTri", mvt));
            lstPara.Add(new CustomParameter("@Luong", Luong.Replace(".", "").Replace(",", "").Replace("đ", "").Trim()));
            int rs = new Database(username, password).Excute(sql, lstPara);
            if (rs == 1)
            {
                MessageBox.Show("Cập nhật thông tin vị trí thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thực thi thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
