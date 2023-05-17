using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QuanLyThuVien_BTL_05
{
    
    public partial class DangNhap : Form
    {
        string strCon = @"Data Source=LAPTOP-CU2RCII0\SQLEXPRESS;Initial Catalog=QuanLyThuVienSach;Integrated Security=True";
        public DangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                if (sqlCon.State == ConnectionState.Closed)
                    return;
                if(txtUserName.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập tài khoản ", "Thông báo ", MessageBoxButtons.OK);
                    txtUserName.Focus();
                }
                else if(txtUserName.Text.Trim().Length !=0)
                {
                    using (SqlCommand sqlCmdTK = new SqlCommand("pr_CheckTK", sqlCon))
                    {
                        sqlCmdTK.CommandType = CommandType.StoredProcedure;
                        sqlCmdTK.Parameters.AddWithValue("@username", txtUserName.Text.Trim());

                        int count = (int)sqlCmdTK.ExecuteScalar();
                        if(count == 1)
                        {
                            if (txtMatKhau.Text.Trim().Length == 0)
                            {
                                MessageBox.Show("Vui lòng điền mật khẩu ", "Thông báo ", MessageBoxButtons.OK);
                                txtMatKhau.Focus();
                            }
                            else if (txtMatKhau.Text.Trim().Length != 0)
                            {
                                using (SqlCommand sqlCmdMK = new SqlCommand("pr_CheckMK", sqlCon))
                                {
                                    sqlCmdMK.CommandType = CommandType.StoredProcedure;
                                    sqlCmdMK.Parameters.AddWithValue("@password", txtMatKhau.Text.Trim());

                                    int countmk = (int)sqlCmdMK.ExecuteScalar();
                                    if (countmk == 1)
                                    {
                                        MessageBox.Show("Đăng nhập thành công ", "Thông báo ", MessageBoxButtons.OK);
                                        this.Hide();
                                        MainForm frMain = new MainForm();
                                        frMain.ShowDialog();
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Mật khẩu chưa chính xác ", "Thông báo ", MessageBoxButtons.OK);
                                        txtMatKhau.Focus();
                                    }
                                    sqlCmdMK.ExecuteNonQuery();

                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản chưa chính xác ", "Thông báo ", MessageBoxButtons.OK);
                            txtUserName.Focus();
                        }
                        sqlCmdTK.ExecuteNonQuery();
                        sqlCon.Close();

                    }
                }
                
            }

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                this.txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtMatKhau.UseSystemPasswordChar = true;
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            DangKy frRegister = new DangKy();
            frRegister.ShowDialog();
            this.Close();

        }
    }
}
