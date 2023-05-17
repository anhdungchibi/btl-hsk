using System;
using System.Data.SqlClient;
using System.Data;


using System.Windows.Forms;

namespace QuanLyThuVien_BTL_05
{
    public partial class Thuthu : Form
    {
        string strCon = @"Data Source=LAPTOP-CU2RCII0\SQLEXPRESS;Initial Catalog=QuanLyThuVienSach;Integrated Security=True";


        public Thuthu()
        {
            InitializeComponent();
        }
        private void Thuthu_Load(object sender, EventArgs e)
        {
            hienDSTT();
            dtThuthu.Columns[0].Width = 180;
            dtThuthu.Columns[1].Width = 180;
            dtThuthu.Columns[2].Width = 170;
            dtThuthu.Columns[3].Width = 176;

            dtThuthu.Columns[0].HeaderText = "Mã thủ thư";
            dtThuthu.Columns[1].HeaderText = "Tên thủ thư";
            dtThuthu.Columns[2].HeaderText = "Số điện thoại";
            dtThuthu.Columns[3].HeaderText = "Địa chỉ";

        }
        private void hienDSTT()
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                if (sqlCon.State == ConnectionState.Closed)
                    return;
                using (SqlCommand sqlCmd = new SqlCommand("pr_SelectThuThu", sqlCon))
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd))
                    {
                        DataTable tbl = new DataTable();
                        tbl.Clear();
                        adapter.Fill(tbl);
                        DataView v = new DataView(tbl);
                        dtThuthu.DataSource = v;
                    }
                }
            }
          
        }
        private void reloadTT()
        {
            txtMaTT.Text = " ";
            txtTenTT.Text = "";
            txtsdtTT.Text = " ";
            txtdcTT.Text = " ";

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                if (sqlCon.State == ConnectionState.Closed)
                    return;
                using (SqlCommand sqlCmd = new SqlCommand("pr_CheckMaTT", sqlCon))
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.Add(new SqlParameter("@matt", txtMaTT.Text.Trim()));

                    int count = (int)sqlCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Mã trùng !!!", "Thông báo", MessageBoxButtons.OK);
                        txtMaTT.Focus();
                    }
                    else if (txtMaTT.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Vui lòng điền mã thủ thư ", "Thông báo", MessageBoxButtons.OK);
                        txtMaTT.Focus();
                    }
                    else if (txtTenTT.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Vui lòng điền họ tên thủ thư ", "Thông báo ", MessageBoxButtons.OK);
                        txtTenTT.Focus();
                    }
                    else if (txtsdtTT.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Vui lòng điền số điện thoại thủ thư ", "Thông báo ", MessageBoxButtons.OK);
                        txtsdtTT.Focus();
                    }
                    else if (txtdcTT.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Vui lòng điền địa chỉ thủ thư ", "Thông báo ", MessageBoxButtons.OK);
                        txtdcTT.Focus();
                    }

                    else
                    {
                        using (SqlCommand sqlCmdtt = new SqlCommand("pr_InsertThuThu", sqlCon))
                        {
                            sqlCmdtt.CommandType = CommandType.StoredProcedure;
                            sqlCmdtt.Parameters.Add(new SqlParameter("@matt", txtMaTT.Text.Trim()));
                            sqlCmdtt.Parameters.Add(new SqlParameter("@hoten", txtTenTT.Text.Trim()));
                            sqlCmdtt.Parameters.Add(new SqlParameter("@sdttt", txtsdtTT.Text.Trim()));
                            sqlCmdtt.Parameters.Add(new SqlParameter("@dctt", txtdcTT.Text.Trim()));


                            sqlCmdtt.ExecuteNonQuery();
                        }
                        
                        MessageBox.Show("Thêm thông tin thành công", "Thông báo", MessageBoxButtons.OK);
                        hienDSTT();
                        reloadTT();
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                if (sqlCon.State == ConnectionState.Closed)
                    return;
                using (SqlCommand sqlCmd = new SqlCommand("pr_UpdateThuThu", sqlCon))
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.Add(new SqlParameter("@matt", txtMaTT.Text.Trim()));
                    sqlCmd.Parameters.Add(new SqlParameter("@hoten", txtTenTT.Text.Trim()));
                    sqlCmd.Parameters.Add(new SqlParameter("@sdttt", txtsdtTT.Text.Trim()));
                    sqlCmd.Parameters.Add(new SqlParameter("@dctt", txtdcTT.Text.Trim()));

                    sqlCmd.ExecuteNonQuery();
                }
                MessageBox.Show("Sửa thành công ", "Thông báo ", MessageBoxButtons.OK);
                hienDSTT();
                reloadTT();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", " Thông báo ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();
                    if (sqlCon.State == ConnectionState.Closed)
                        return;
                    using (SqlCommand sqlCmd = new SqlCommand("pr_DeleteThuThu", sqlCon))
                    {
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.Add(new SqlParameter("@matt", txtMaTT.Text.Trim()));

                        sqlCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Xóa thành công ", "Thông báo ", MessageBoxButtons.OK);
                    hienDSTT();
                    reloadTT();
                }
            }
        }

        private void Click_ThuThu(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow dttt = dtThuthu.Rows[e.RowIndex];
            txtMaTT.Text = dttt.Cells[0].Value.ToString();
            txtTenTT.Text = dttt.Cells[1].Value.ToString();
            txtsdtTT.Text = dttt.Cells[2].Value.ToString();
            txtdcTT.Text = dttt.Cells[3].Value.ToString();
        }

        private void txtSearchThuThu_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchThuThu.Text.Trim()))
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();
                    if (sqlCon.State == ConnectionState.Closed)
                        return;
                    using (SqlCommand sqlCmd = new SqlCommand("pr_SearchTT", sqlCon))
                    {
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.Add(new SqlParameter("@tentt", txtSearchThuThu.Text.Trim()));
                        using (SqlDataReader data = sqlCmd.ExecuteReader())
                        {
                            DataTable tbl = new DataTable("tblThuThu");
                            tbl.Load(data);
                            dtThuthu.DataSource = tbl;
                        }

                    }
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn quay lại ? ","Thông báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                MainForm frMain = new MainForm();
                frMain.ShowDialog();
                this.Close();
            }
        }
    }
}
