using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyShopCauLong
{
    public class Database
    {
        private string connetionString = @"Data Source=localhost\SQLSERVER;Initial Catalog=QLCL;User ID=sa;Password=ahihi123";
        private SqlConnection conn;
        private DataTable dt;
        private SqlCommand cmd;
        private string username;
        private string password;

        public Database() { }
        public Database(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public bool OpenDatabase()
        {
            try
            {
                connetionString = @"Data Source=localhost\SQLSERVER;Initial Catalog=QLCL;User ID=" + username + ";Password=" + password;
                conn = new SqlConnection(connetionString);
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public DataTable SelectData(string sql, List<CustomParameter> lstPara)
        {
            try
            {
                connetionString = @"Data Source=localhost\SQLSERVER;Initial Catalog=QLCL;User ID=" + username + ";Password=" + password;
                dt = new DataTable();
                conn = new SqlConnection(connetionString);
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                if (lstPara != null)
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (CustomParameter p in lstPara)
                    {
                        cmd.Parameters.AddWithValue(p.key, p.value);
                    }
                }
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataRow Select(string sql)
        {
            try
            {
                dt = new DataTable();
                connetionString = @"Data Source=localhost\SQLSERVER;Initial Catalog=QLCL;User ID=" + username + ";Password=" + password;
                conn = new SqlConnection(connetionString);
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                dt.Load(cmd.ExecuteReader());
                return dt.Rows[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally 
            { 
                conn.Close(); 
            }   
        }
        public int Excute(string sql, List<CustomParameter> lstPara)
        {
            try
            {
                connetionString = @"Data Source=localhost\SQLSERVER;Initial Catalog=QLCL;User ID=" + username + ";Password=" + password;
                conn = new SqlConnection(connetionString);
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (CustomParameter p in lstPara)
                {
                    cmd.Parameters.AddWithValue(p.key, p.value);
                }
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -100;
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
