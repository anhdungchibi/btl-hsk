using System;

using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace QuanLyThuVien_BTL_05
{
    public partial class Sinhvien : Form
    {
        public Sinhvien()
        {
            InitializeComponent();
        }
        string strCon = @"Data Source=LAPTOP-CU2RCII0\SQLEXPRESS;Initial Catalog=QuanLyThuVienSach;Integrated Security=True";
  

        private void Sinhvien_Load(object sender, EventArgs e)
        {
            hienDSSV();
            dtSinhVien.Columns[0].Width = 150;
            dtSinhVien.Columns[1].Width = 188;
            dtSinhVien.Columns[2].Width = 150;
            dtSinhVien.Columns[3].Width = 150;
            dtSinhVien.Columns[4].Width = 150;
            dtSinhVien.Columns[5].Width = 150;
         


            dtSinhVien.Columns[0].HeaderText = "Mã sinh viên";
            dtSinhVien.Columns[1].HeaderText = "Tên sinh viên";
            dtSinhVien.Columns[2].HeaderText = "Ngày sinh";
            dtSinhVien.Columns[3].HeaderText = "Giới tính";
            dtSinhVien.Columns[4].HeaderText = "Lớp hành chính";
            dtSinhVien.Columns[5].HeaderText = "Số điện thoại";

        }

     

        private void hienDSSV()
        {
            
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                using (SqlCommand sqlCmd = new SqlCommand("pr_SelectSinhVien", sqlCon))
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd))
                    {
                        DataTable tbl = new DataTable("tblSinhVien");
                        tbl.Clear();
                        adapter.Fill(tbl);
                        DataView v = new DataView(tbl);
                        dtSinhVien.DataSource = v;
                    }
                }

            }
        }
   
        private void reLoad()
        {
            txtMaSv.Text = " ";
            txtTen.Text = " ";
            cbGioitinh.Text = " ";
            dtNgaysinh.Text = "2/2/2002";
            txtLop.Text = " ";
            txtSDT.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                if (sqlCon.State == System.Data.ConnectionState.Closed)
                    return;
                using (SqlCommand sqlCmd = new SqlCommand("pr_CheckMaSV", sqlCon))
                {
                    sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCmd.Parameters.Add(new SqlParameter("@maSV", txtMaSv.Text));

                    int count = (int)sqlCmd.ExecuteScalar(); // sử dụng ExecuteScalar để trả về số lượng bản ghi trùng mã

                    if (count > 0) // nếu có bản ghi trùng mã
                    {
                        MessageBox.Show("Mã sinh viên : " + txtMaSv.Text + " đã tồn tại!", " Thông báo ", MessageBoxButtons.OK);
                    }
                    else if (txtMaSv.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Vui lòng nhập mã sinh viên ", "Thông báo", MessageBoxButtons.OK);
                        txtMaSv.Focus();
                    }
                    else if (txtTen.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Vui lòng nhập tên sinh viên ", "Thông báo", MessageBoxButtons.OK);
                        txtTen.Focus();
                    }
                    else if (dtNgaysinh.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Vui lòng nhập ngày sinh ", "Thông báo", MessageBoxButtons.OK);
                        dtNgaysinh.Focus();
                    }
                    else if (cbGioitinh.SelectedIndex == -1)
                    {
                        MessageBox.Show("Vui lòng chọn giới tính ", "Thông báo", MessageBoxButtons.OK);
                        cbGioitinh.Focus();
                    }
                    else if (txtLop.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Vui lòng nhập lớp hành chính ", "Thông báo", MessageBoxButtons.OK);
                        txtLop.Focus();
                    }
                    else if (txtSDT.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Vui lòng nhập số điện thoại ", "Thông báo", MessageBoxButtons.OK);
                        txtSDT.Focus();
                    }
                    else
                    {
                        using (SqlCommand sqlCmdsv = new SqlCommand("pr_InsertSinhVien", sqlCon))
                        {
                            sqlCmdsv.CommandType = System.Data.CommandType.StoredProcedure;
                            sqlCmdsv.Parameters.Add(new SqlParameter("@maSV", txtMaSv.Text.Trim()));
                            sqlCmdsv.Parameters.Add(new SqlParameter("@hoTen", txtTen.Text.Trim()));
                            sqlCmdsv.Parameters.Add(new SqlParameter
                            {
                                ParameterName = "@ngaySinh",
                                DbType = System.Data.DbType.DateTime,
                                SqlDbType = System.Data.SqlDbType.DateTime,
                                Value = DateTime.Parse(dtNgaysinh.Text.Trim())
                            });
                            sqlCmdsv.Parameters.Add(new SqlParameter("@gioiTinh", cbGioitinh.SelectedItem.ToString()));
                            sqlCmdsv.Parameters.Add(new SqlParameter("@lopHC", txtLop.Text.Trim()));
                            sqlCmdsv.Parameters.Add(new SqlParameter("@soDT", txtSDT.Text.Trim()));

                            sqlCmdsv.ExecuteNonQuery();
       
                        }
                        MessageBox.Show("Thêm thành công ","Thông báo");
                        hienDSSV();
                        reLoad();
                    }
                }
            }
        }



        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn sửa sinh viên này chứ ", "Thông báo ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();
                    if (sqlCon.State == System.Data.ConnectionState.Closed)
                        return;
                    using (SqlCommand sqlCmd = new SqlCommand("pr_UpdateSinhVien", sqlCon))
                    {
                        sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCmd.Parameters.Add(new SqlParameter("@maSV", txtMaSv.Text.Trim()));
                        sqlCmd.Parameters.Add(new SqlParameter("@hoTen", txtTen.Text.Trim()));
                        sqlCmd.Parameters.Add(new SqlParameter
                        {
                            ParameterName = "@ngaySinh",
                            DbType = System.Data.DbType.DateTime,
                            SqlDbType = System.Data.SqlDbType.DateTime,
                            Value = DateTime.Parse(dtNgaysinh.Text.Trim())
                        });
                        sqlCmd.Parameters.Add(new SqlParameter("@gioiTinh", cbGioitinh.Text.Trim()));
                        sqlCmd.Parameters.Add(new SqlParameter("@lopHC", txtLop.Text.Trim()));
                        sqlCmd.Parameters.Add(new SqlParameter("@soDT", txtSDT.Text.Trim()));

                        sqlCmd.ExecuteNonQuery();

                    }
                    MessageBox.Show("Sửa thành công ", "Thông báo");
                    hienDSSV();
                    reLoad();
                }
            }
            else
            {
                reLoad();
            }
            

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Nếu sinh viên đã đăng ký phiếu mượn thì dữ liệu trong phiếu mượn chứa thì thông tin sinh viên sẽ bị xóa.\nBạn có chắc là muốn xóa sinh viên này chứ", "Thông báo ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();
                    if (sqlCon.State == System.Data.ConnectionState.Closed)
                        return;
                    using (SqlCommand sqlCmd = new SqlCommand("pr_DeleteSinhVien", sqlCon))
                    {
                        sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCmd.Parameters.Add(new SqlParameter("@maSV", txtMaSv.Text.Trim()));
                        sqlCmd.ExecuteNonQuery();

                    }
                    MessageBox.Show("Xóa thành công ", "Thông báo");
                    hienDSSV();
                    reLoad();
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn trở lại ? ", "Thông báo ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                MainForm frMain = new MainForm();
                frMain.ShowDialog();
                this.Close();
            }    
        }

        private void dtSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow dtsv = dtSinhVien.Rows[e.RowIndex];
            txtMaSv.Text = dtsv.Cells[0].Value.ToString();
            txtTen.Text = dtsv.Cells[1].Value.ToString();
            dtNgaysinh.Text = dtsv.Cells[2].Value.ToString();
            cbGioitinh.Text = dtsv.Cells[3].Value.ToString();
            txtLop.Text = dtsv.Cells[4].Value.ToString();
            txtSDT.Text = dtsv.Cells[5].Value.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                if (sqlCon.State == System.Data.ConnectionState.Closed)
                    return;
                using (SqlCommand sqlCmd = new SqlCommand("pr_SearchSinhVien", sqlCon))
                {
                    sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCmd.Parameters.Add(new SqlParameter("@tensv", txtTimKiem.Text.Trim()));
                    using (SqlDataReader reader = sqlCmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dtSinhVien.DataSource = dt;
                    }
                 
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            
            //if (!string.IsNullOrEmpty(txtTimKiem.Text))
            //{
            //    using (SqlConnection sqlCon = new SqlConnection(strCon))
            //    {
            //        sqlCon.Open();
            //        if (sqlCon.State == System.Data.ConnectionState.Closed)
            //            return;
            //        using (SqlCommand sqlCmd = new SqlCommand("pr_SearchSinhVien", sqlCon))
            //        {
            //            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
            //            sqlCmd.Parameters.Add(new SqlParameter("@tensv", txtTimKiem.Text));
            //            using (SqlDataReader reader = sqlCmd.ExecuteReader())
            //            {
            //                DataTable dt = new DataTable();
            //                dt.Load(reader);
            //                dtSinhVien.DataSource = dt;
            //            }
            //        }
            //    }
            //}
        }

        
    }
}
