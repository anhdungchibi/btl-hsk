using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace QuanLyThuVien_BTL_05
{
    public partial class Sach : Form
    {
        public Sach()
        {
            InitializeComponent();
           
        }
       
        string strCon = @"Data Source=LAPTOP-CU2RCII0\SQLEXPRESS;Initial Catalog=QuanLyThuVienSach;Integrated Security=True";



        private void Sach_Load(object sender, EventArgs e)
        {
            hienDSS();
            hienMaLS();
            dtSach.Columns[0].Width = 140;
            dtSach.Columns[1].Width = 175;
            dtSach.Columns[2].Width = 175;
            dtSach.Columns[3].Width = 150;
            dtSach.Columns[4].Width = 121;

            dtSach.Columns[0].HeaderText = "Mã sách";
            dtSach.Columns[1].HeaderText = "Tên sách";
            dtSach.Columns[2].HeaderText = "Tác giả";
            dtSach.Columns[3].HeaderText = "Số lượng";
            dtSach.Columns[4].HeaderText = "Mã loại sách";

        }
        private void reLoad()
        {
            txtMaS.Text = " ";
            txtTenS.Text = " ";
            txtTacGia.Text = " ";
            txtSoL.Text = "";
        }



            private void hienMaLS()
        {
            using(SqlConnection sqlCon = new SqlConnection(strCon))
            {
                using(SqlCommand sqlCmd = new SqlCommand("pr_SelectTLSach", sqlCon))
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    using(SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd))
                    {
                        DataTable tbl = new DataTable();
                        tbl.Clear();
                        adapter.Fill(tbl);
                        DataView v = new DataView(tbl);
                        cbMaLS.DisplayMember = "maLoai";
                        cbMaLS.DataSource = v;
                    }
                }
            }
        }

        private void hienDSS()
        {
            using(SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                if (sqlCon.State == System.Data.ConnectionState.Closed)
                    return;
                using(SqlCommand sqlCmd = new SqlCommand("pr_SelectSach", sqlCon))
                {
                    sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                  
                    using(SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd))
                    {
                        DataTable tbl = new DataTable();
                        tbl.Clear();
                        adapter.Fill(tbl);
                        dtSach.DataSource = tbl;
                    }
                }
            }
        }

        private void btnThemS_Click(object sender, EventArgs e)
        {
            using(SqlConnection sqlCon = new SqlConnection(strCon))
            {

                sqlCon.Open();
                if (sqlCon.State == ConnectionState.Closed)
                    return;
                
                using (SqlCommand sqlCmd = new SqlCommand("pr_CheckMaS", sqlCon))
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.Add(new SqlParameter("@maSach", txtMaS.Text));
                    int count = (int)sqlCmd.ExecuteScalar();
                    if(count > 0)
                    {
                        MessageBox.Show("Mã trùng", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        using (SqlCommand sqlCmdS = new SqlCommand("pr_InsertSach", sqlCon))
                        {
                            sqlCmdS.CommandType = CommandType.StoredProcedure;
                            sqlCmdS.Parameters.Add(new SqlParameter("@maSach", txtMaS.Text.Trim()));
                            sqlCmdS.Parameters.Add(new SqlParameter("@tenSach", txtTenS.Text.Trim()));
                            sqlCmdS.Parameters.Add(new SqlParameter("@tacGia", txtTacGia.Text.Trim()));
                            sqlCmdS.Parameters.Add(new SqlParameter
                            {
                                ParameterName = "@soLuong",
                                DbType = System.Data.DbType.Int32,
                                SqlDbType = System.Data.SqlDbType.Int,
                                Value = Int32.Parse(txtSoL.Text.Trim())
                            });
                            sqlCmdS.Parameters.Add(new SqlParameter("@maLoai", cbMaLS.Text.Trim()));

                            sqlCmdS.ExecuteNonQuery();
                        }
                        MessageBox.Show("Thêm thành công ", " Thông báo", MessageBoxButtons.OK);
                        hienDSS();
                        reLoad();
                    }
                }
            }
        }

        
        private void btnSuaS_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn sửa sách này chứ ", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();
                    if (sqlCon.State == ConnectionState.Closed)
                        return;
                    using (SqlCommand sqlCmdS = new SqlCommand("pr_UpdateSach", sqlCon))
                    {
                        sqlCmdS.CommandType = CommandType.StoredProcedure;
                        sqlCmdS.Parameters.Add(new SqlParameter("@maSach", txtMaS.Text.Trim()));
                        sqlCmdS.Parameters.Add(new SqlParameter("@tenSach", txtTenS.Text.Trim()));
                        sqlCmdS.Parameters.Add(new SqlParameter("@tacGia", txtTacGia.Text.Trim()));
                        sqlCmdS.Parameters.Add(new SqlParameter
                            {
                                ParameterName = "@soLuong",
                                DbType = System.Data.DbType.Int32,
                                SqlDbType = System.Data.SqlDbType.Int,
                                Value = Int32.Parse(txtSoL.Text.Trim())
                            });
                        sqlCmdS.Parameters.Add(new SqlParameter("@maLoai", cbMaLS.Text.Trim()));

                        sqlCmdS.ExecuteNonQuery();

                    }
                    MessageBox.Show("Sửa thành công ", " Thông báo", MessageBoxButtons.OK);
                    hienDSS();
                    reLoad();
                }
            }
        }

       

        private void dtSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow dtgrS = dtSach.Rows[e.RowIndex];
            txtMaS.Text = dtgrS.Cells[0].Value.ToString();
            txtTenS.Text = dtgrS.Cells[1].Value.ToString();
            txtTacGia.Text = dtgrS.Cells[2].Value.ToString();
            txtSoL.Text = dtgrS.Cells[3].Value.ToString();
            cbMaLS.Text = dtgrS.Cells[4].Value.ToString();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn trở lại ? ","Thông báo",MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                this.Hide();
                MainForm frMain =new MainForm();
                frMain.ShowDialog();
                this.Close();
            }
        }

        private void btnXoaS_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc xóa sách này chứ ", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();
                    if (sqlCon.State == ConnectionState.Closed)
                        return;
                    using (SqlCommand sqlCmd = new SqlCommand("pr_DeleteSach", sqlCon))
                    {
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.Add(new SqlParameter("@maSach", txtMaS.Text));
                        sqlCmd.Parameters.Add(new SqlParameter("@maLoai", cbMaLS.Text));

                        sqlCmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    hienDSS();
                    reLoad();
                }
            }
        }

        private void txtSearchS_TextChanged(object sender, EventArgs e)
        {
            using(SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                if (sqlCon.State == ConnectionState.Closed)
                    return;
                using(SqlCommand sqlCmd = new SqlCommand("pr_CheckSach",sqlCon))
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.Add(new SqlParameter("@tenSach", txtSearchS.Text));
                    using(SqlDataReader reader = sqlCmd.ExecuteReader())
                    {
                        DataTable tbl = new DataTable();
                        tbl.Clear();
                        tbl.Load(reader);
                        dtSach.DataSource = tbl;
                    }
                    
                }
            }
        }
    }
}
