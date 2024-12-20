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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked == true)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
            }
            else PasswordTextBox.UseSystemPasswordChar = true;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string Username = UsernameTextBox.Text;
            string Password = PasswordTextBox.Text; 
            if (new Database(Username, Password).OpenDatabase() == false)
            {
                MessageBox.Show("Sai thông tin đăng nhập!", "Không thể đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                new MainForm(Username, Password).Show();
                this.Hide();
            }    
        }
    }
}
