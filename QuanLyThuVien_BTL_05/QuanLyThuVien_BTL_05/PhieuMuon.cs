using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyThuVien_BTL_05
{
    public partial class PhieuMuon : Form
    {
        string strCon = @"Data Source=LAPTOP-CU2RCII0\SQLEXPRESS;Initial Catalog=QuanLyThuVienSach;Integrated Security=True";

        public PhieuMuon()
        {
            InitializeComponent();
        }

        private void PhieuMuon_Load(object sender, EventArgs e)
        {
            hienDSPM();
            hienMaTT();
            hienMaSV();
            dtPhieumuon.Columns[0].Width = 153;
            dtPhieumuon.Columns[1].Width = 140;
            dtPhieumuon.Columns[2].Width = 140;
            dtPhieumuon.Columns[3].Width = 175;
            dtPhieumuon.Columns[4].Width = 175;

            dtPhieumuon.Columns[0].HeaderText = "Số phiếu mượn";
            dtPhieumuon.Columns[1].HeaderText = "Mã sinh viên";
            dtPhieumuon.Columns[2].HeaderText = "Mã thủ thư";
            dtPhieumuon.Columns[3].HeaderText = "Tên sinh viên";
            dtPhieumuon.Columns[4].HeaderText = "Tên thủ thư";

        }

        private void hienMaTT()
        {
            
            using(SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                if (sqlCon.State == ConnectionState.Closed)
                    return;
                using(SqlCommand sqlCmd = new SqlCommand("pr_SelectThuThu", sqlCon))
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    using(SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd))
                    {
                        DataTable tbl = new DataTable();
                        tbl.Clear();
                        adapter.Fill(tbl);
                        DataView v = new DataView(tbl);
                        cbmaTT.ValueMember = "maTT";
                        cbmaTT.DataSource = v;
                    }
                }
            }
        }

        private void hienMaSV()
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                if (sqlCon.State == ConnectionState.Closed)
                    return;
                using (SqlCommand sqlCmd = new SqlCommand("pr_SelectSinhVien", sqlCon))
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd))
                    {
                        DataTable tbl = new DataTable();
                        tbl.Clear();
                        adapter.Fill(tbl);
                        DataView v = new DataView(tbl);
                        cbmaSV.DisplayMember = "maSV";
                        cbmaSV.DataSource = v;
                    }
                }
            }

        }

        private void hienDSPM()
        {
            using(SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                if (sqlCon.State == ConnectionState.Closed)
                    return;
                using(SqlCommand sqlCmd = new SqlCommand("pr_SelectPhieuMuon", sqlCon))
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    using(SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd))
                    {
                        DataTable tbl = new DataTable();
                        tbl.Clear();
                        adapter.Fill(tbl);
                        DataView v = new DataView(tbl);
                        dtPhieumuon.DataSource = v;
                    }
                }
            }
           
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn trở lại ? ","Thông báo ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                MainForm frmainForm = new MainForm();
                frmainForm.ShowDialog();
                this.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                if (sqlCon.State == ConnectionState.Closed)
                    return;
                using (SqlCommand sqlCmd = new SqlCommand("pr_CheckMaPM", sqlCon))
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.Add(new SqlParameter("@sopm", txtMaPM.Text.Trim()));

                    int countmapm = (int)sqlCmd.ExecuteScalar();
                    if (countmapm > 0)
                    {
                        MessageBox.Show("Số phiếu mượn : " + txtMaPM.Text + "đã tồn tại !", "Thông báo", MessageBoxButtons.OK);
                        txtMaPM.Focus();
                    }
                    else if (txtMaPM.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Vui lòng điền mã", "Thông báo", MessageBoxButtons.OK);
                        txtMaPM.Focus();
                    }
                    else
                    {
                        // Đoạn mã kiểm tra mã sinh viên (maSV) đã tồn tại trong bảng tblPhieuMuon
                        using (SqlCommand sqlCmdCheckMaSV = new SqlCommand("pr_CheckMaSVM", sqlCon))
                        {
                            sqlCmdCheckMaSV.CommandType = CommandType.StoredProcedure;
                            sqlCmdCheckMaSV.Parameters.AddWithValue("@maSV", cbmaSV.Text);
                            int countMaSV = (int)sqlCmdCheckMaSV.ExecuteScalar();
                            if (countMaSV > 0)
                            {
                                MessageBox.Show("Một sinh viên chỉ được cấp duy nhất 1 phiếu mượn!\n Hãy chọn sinh viên khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                cbmaSV.Focus();
                                return; // Dừng thực hiện các lệnh phía dưới nếu mã sinh viên đã tồn tại
                            }
                        }

                        using (SqlCommand sqlCmdPM = new SqlCommand("pr_InsertPhieuMuon", sqlCon))
                        {
                            sqlCmdPM.CommandType = CommandType.StoredProcedure;
                            sqlCmdPM.Parameters.Add(new SqlParameter("@sopmuon", txtMaPM.Text.Trim()));
                            sqlCmdPM.Parameters.Add(new SqlParameter("@masv", cbmaSV.Text));
                            sqlCmdPM.Parameters.Add(new SqlParameter("@matt", cbmaTT.SelectedValue.ToString()));

                            sqlCmdPM.ExecuteNonQuery();

                        }
                        MessageBox.Show("Thêm thành công ", "Thông báo", MessageBoxButtons.OK);
                        hienDSPM();
                        reLoad();
                    }
                }
            }


        }

        private void reLoad()
        {
            txtMaPM.Text = " ";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using(SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                if (sqlCon.State == ConnectionState.Closed)
                    return;
                using (SqlCommand sqlCmdCheckMaSV = new SqlCommand("pr_CheckMaSVM", sqlCon))
                {
                    sqlCmdCheckMaSV.CommandType = CommandType.StoredProcedure;
                    sqlCmdCheckMaSV.Parameters.AddWithValue("@maSV", cbmaSV.Text);
                    int countMaSV = (int)sqlCmdCheckMaSV.ExecuteScalar();
                    if (countMaSV > 0)
                    {
                        MessageBox.Show("Một sinh viên chỉ được cấp duy nhất 1 phiếu mượn!\n Hãy chọn sinh viên khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cbmaSV.Focus();
                        return; // Dừng thực hiện các lệnh phía dưới nếu mã sinh viên đã tồn tại
                    }

                    using (SqlCommand sqlCmdPM = new SqlCommand("pr_UpdatePhieuMuon", sqlCon))
                    {
                        sqlCmdPM.CommandType = CommandType.StoredProcedure;
                        sqlCmdPM.Parameters.Add(new SqlParameter("@sopmuon", txtMaPM.Text.Trim()));
                        sqlCmdPM.Parameters.Add(new SqlParameter("@masv", cbmaSV.Text));
                        sqlCmdPM.Parameters.Add(new SqlParameter("@matt", cbmaTT.SelectedValue.ToString()));

                        sqlCmdPM.ExecuteNonQuery();
                    }
                    MessageBox.Show("Sửa thành công ", "Thông báo", MessageBoxButtons.OK);
                    hienDSPM();
                    reLoad();
                }
            }
        }

        private void Cell_PM(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow dtpm = dtPhieumuon.Rows[e.RowIndex];
            txtMaPM.Text = dtpm.Cells[0].Value.ToString();
            cbmaSV.Text = dtpm.Cells[1].Value.ToString();
            cbmaTT.Text = dtpm.Cells[2].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thông tin trong chi tiết phiếu mượn sẽ bị ảnh hưởng.\n Bạn có muốn xóa phiếu mượn này không?", "Thông báo ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();
                    if (sqlCon.State == ConnectionState.Closed)
                        return;
                    using (SqlCommand sqlCmd = new SqlCommand("pr_DeletePhieuMuon", sqlCon))
                    {
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.Add(new SqlParameter("@sopm", txtMaPM.Text.Trim()));
                        sqlCmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    hienDSPM();
                    reLoad();
                }
            }
        }

        private void txtSearchPM_TextChanged(object sender, EventArgs e)
        {
            using(SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                if (sqlCon.State == ConnectionState.Closed)
                    return;
                using(SqlCommand sqlCmd = new SqlCommand("pr_SearchPhieuMuon", sqlCon))
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.Add(new SqlParameter("@sopm", txtSearchPM.Text.Trim()));
                    using(SqlDataReader reader = sqlCmd.ExecuteReader())
                    {
                        DataTable tbl = new DataTable();
                        tbl.Load(reader);
                        dtPhieumuon.DataSource = tbl;
                    }
                    
                }
            }
        }

       
    }
 }

