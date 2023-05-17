using System;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace QuanLyThuVien_BTL_05
{
    public partial class DangKy : Form
    {
        
        public DangKy()
        {
            InitializeComponent();
        }
        //Regex hasTwoNumbers = new Regex(@"(?:\d.*){2}"); // Xử lý nếu ít nhất phải có 2 số
        string strCon = @"Data Source=LAPTOP-CU2RCII0\SQLEXPRESS;Initial Catalog=QuanLyThuVienSach;Integrated Security=True";
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            DangNhap frLogin = new DangNhap();
            frLogin.ShowDialog();
            this.Close();
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                //Regex hasNumber = new Regex(@"[0-9]+");
                //Regex hasUpperChar = new Regex(@"[A-Z]+");
                //Regex hasSpecialChar = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
                sqlCon.Open();
                using (SqlCommand sqlCmd = new SqlCommand("pr_CheckTrung", sqlCon))
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.Add(new SqlParameter("@username", SqlDbType.NVarChar, 100)).Value = txtUsername.Text.Trim();

                    int count = (int)sqlCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Tài khoản này đã tồn tại ", "Thông báo ", MessageBoxButtons.OK);
                        txtUsername.Focus();
                    }
                    else if(txtUsername.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Vui lòng nhập tài khoản ", "Thông báo ", MessageBoxButtons.OK);
                        txtUsername.Focus();
                    }
                    else if(txtPassword.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Vui lòng nhập mật khẩu ", "Thông báo ", MessageBoxButtons.OK);
                        txtPassword.Focus();
                    }
                    //else if (!hasNumber.IsMatch(txtPassword.Text.Trim()))
                    //{
                    //    MessageBox.Show("Mật khẩu phải chứa ít nhất một chữ số", "Thông báo ", MessageBoxButtons.OK);
                    //    txtPassword.Focus();
                    //}
                    //else if (!hasUpperChar.IsMatch(txtPassword.Text.Trim()))
                    //{
                    //    MessageBox.Show("Mật khẩu phải chứa ít nhất một chữ hoa", "Thông báo ", MessageBoxButtons.OK);
                    //    txtPassword.Focus();
                    //}
                    //else if (!hasSpecialChar.IsMatch(txtPassword.Text.Trim()))
                    //{
                    //    MessageBox.Show("Mật khẩu phải chứa ít nhất một ký tự đặc biệt", "Thông báo ", MessageBoxButtons.OK);
                    //    txtPassword.Focus();
                    //}
                    else if (txtRepassword.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Vui lòng nhập lại mật khẩu", "Thông báo ", MessageBoxButtons.OK);
                        txtRepassword.Focus();
                    }
                    else if (txtPassword.Text.Trim() != txtRepassword.Text.Trim())
                    {
                        MessageBox.Show("Mật khẩu nhập lại không khớp ", "Thông báo ", MessageBoxButtons.OK);
                        txtRepassword.Focus();
                    }
                    else
                    {
                        using (SqlCommand sqlCmdin = new SqlCommand("pr_InsertUser", sqlCon))
                        {
                            sqlCmdin.CommandType = CommandType.StoredProcedure;
                            sqlCmdin.Parameters.AddWithValue("@username",txtUsername.Text.Trim());
                            sqlCmdin.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                            sqlCmdin.ExecuteNonQuery();

                        }
                        MessageBox.Show("Đăng ký thành công ", "Thông báo ", MessageBoxButtons.OK);
                        reLoad();
                    }
                }
            }
        }

        public void reLoad()
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
            txtRepassword.Text = " ";
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtRepassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtRepassword.UseSystemPasswordChar = true;
            }
        }
    }
}
