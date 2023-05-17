using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace QuanLyThuVien_BTL_05
{
    public partial class TheLoaiSach : Form
    {
        string strCon = @"Data Source=LAPTOP-CU2RCII0\SQLEXPRESS;Initial Catalog=QuanLyThuVienSach;Integrated Security=True";

        public TheLoaiSach()
        {
            InitializeComponent();
        }



        private void TheLoaiSach_Load(object sender, EventArgs e)
        {
            hienDSTLS();
            this.dtTheLoaiS.Columns[0].Width = 172;
            this.dtTheLoaiS.Columns[1].Width = 230;
            dtTheLoaiS.Columns[0].HeaderText = "Mã loại sách";
            this.dtTheLoaiS.Columns[1].HeaderText = "Tên loại sách";

        }

        private void hienDSTLS()
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                using (SqlCommand sqlCmd = new SqlCommand("pr_SelectTLSach", sqlCon))
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd))
                    {
                        DataTable tbl = new DataTable();
                        tbl.Clear();
                        adapter.Fill(tbl);
                        DataView v = new DataView(tbl);
                        dtTheLoaiS.DataSource = v;
                    }
                }
            }

        }
        public void loadTLS()
        {
            txtMaLS.Text = " ";
            txtTenLS.Text = " ";
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn trở lại trang chủ ? ", " Thông báo ",MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                this.Hide();
                MainForm main = new MainForm();
                main.ShowDialog();
                this.Close();
            }
        }

        private void btnThemLS_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                if (sqlCon.State == System.Data.ConnectionState.Closed)
                    return;
                using (SqlCommand sqlCmd = new SqlCommand("pr_CheckMaTL", sqlCon))
                {
                    sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCmd.Parameters.Add(new SqlParameter("@maloai", txtMaLS.Text.Trim()));

                    int count = (int)sqlCmd.ExecuteScalar(); // sử dụng ExecuteScalar để trả về số lượng bản ghi trùng mã

                    if(txtMaLS.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Vui lòng nhập mã loại sách", "Thông báo ", MessageBoxButtons.OK);
                        txtMaLS.Focus();
                    }
                    else if (count > 0) // nếu có bản ghi trùng mã
                    {
                        MessageBox.Show("Trùng mã !!!", " Thông báo ", MessageBoxButtons.OK);
                    }

                    else if (txtTenLS.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Vui lòng nhập tên loại sách ", "Thông báo", MessageBoxButtons.OK);
                        txtTenLS.Focus();
                    }


                    else
                    {
                        using (SqlCommand sqlCmdtls = new SqlCommand("pr_InsertTheLoai", sqlCon))
                        {
                            sqlCmdtls.CommandType = CommandType.StoredProcedure;
                            sqlCmdtls.Parameters.Add(new SqlParameter("@maloai", txtMaLS.Text.Trim()));
                            sqlCmdtls.Parameters.Add(new SqlParameter("@tenloai", txtTenLS.Text.Trim()));

                            sqlCmdtls.ExecuteNonQuery();
                            
                        }
                        MessageBox.Show("Thêm thành công ", "Thông báo");
                        hienDSTLS();
                        loadTLS();
                    }
                }
            }

        }
        ////
        //string ghichu = "";
        //                    if (checkBox1.Checked)
        //                    {
        //                        ghichu += checkBox1.Text.Trim() + ";";
        //                    }
        //                    if (checkBox2.Checked)
        //                    {
        //                        ghichu += checkBox2.Text.Trim() + ";";
        //                    }
        //                    if (checkBox3.Checked)
        //                    {
        //                        ghichu += checkBox3.Text.Trim() + ";";
        //                    }

        //                    // remove the last semicolon if it exists
        //                    if (ghichu.EndsWith(";"))
        //                    {
        //                        ghichu = ghichu.Substring(0, ghichu.Length - 1);
        //                    } //ghichu 
private void btnSuaLS_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn sửa tên loại sách này chứ ", "Thông báo ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();
                    if (sqlCon.State == ConnectionState.Closed)
                        return;
                    using (SqlCommand sqlCmd = new SqlCommand("pr_UpdateTheLoai", sqlCon))
                    {
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.Add(new SqlParameter("@maloai", txtMaLS.Text.Trim()));
                        sqlCmd.Parameters.Add(new SqlParameter("@tenloai", txtTenLS.Text.Trim()));
                        sqlCmd.ExecuteNonQuery();
                        
                    }
                    MessageBox.Show("Sửa thành công ", "Thông báo");
                    hienDSTLS();
                    loadTLS();
                }
            }
            else
            {
                loadTLS();
            }
        }

        private void dtTheLoaiS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow dttls = dtTheLoaiS.Rows[e.RowIndex];
            txtMaLS.Text = dttls.Cells[0].Value.ToString();
            txtTenLS.Text = dttls.Cells[1].Value.ToString();
        }

        private void btnXoaLS_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thông tin của Sách cũng sẽ bị xóa theo\n Bạn có chắc là muốn xóa loại sách này chứ ", "Thông báo ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();
                    if (sqlCon.State == ConnectionState.Closed)
                        return;
                    using (SqlCommand sqlCmd = new SqlCommand("pr_DeleteTheLoai", sqlCon))
                    {
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.Add(new SqlParameter("@maloai", txtMaLS.Text.Trim()));
                        sqlCmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Xóa thành công ", "Thông báo");
                    hienDSTLS();
                }
                loadTLS();
            }
        }

        private void txtTimKiemLS_TextChanged(object sender, EventArgs e)
        {
            
            using(SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                if (sqlCon.State == ConnectionState.Closed)
                    return;
                using(SqlCommand sqlCmd = new SqlCommand("pr_SearchTenTL", sqlCon))
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.Add(new SqlParameter("@tenloai", txtTimKiemLS.Text.Trim()));
                    using(SqlDataReader reader = sqlCmd.ExecuteReader())
                    {
                        DataTable tbl = new DataTable();
                        tbl.Load(reader);
                        dtTheLoaiS.DataSource = tbl;    
                    }

                }
            }
        }
    }
}
