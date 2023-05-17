using System;

using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QuanLyThuVien_BTL_05
{
    public partial class CTPhieuMuon : Form
    {
        public CTPhieuMuon()
        {
            InitializeComponent();
        }
        string strCon = @"Data Source=LAPTOP-CU2RCII0\SQLEXPRESS;Initial Catalog=QuanLyThuVienSach;Integrated Security=True";


        private void CTPhieuMuon_Load(object sender, EventArgs e)
        {
            hienDSCTPM();
            hienSPM();
            hienMaSach();
            dtCTPhieuMuon.Columns[0].Width = 115;
            dtCTPhieuMuon.Columns[1].Width = 140;
            dtCTPhieuMuon.Columns[2].Width = 130;
            dtCTPhieuMuon.Columns[3].Width = 160;
            dtCTPhieuMuon.Columns[4].Width = 130;
            dtCTPhieuMuon.Columns[5].Width = 130;
            dtCTPhieuMuon.Columns[6].Width = 130;
            dtCTPhieuMuon.Columns[7].Width = 130;
            dtCTPhieuMuon.Columns[9].Width = 120;

            dtCTPhieuMuon.Columns[0].HeaderText = "Số phiếu mượn";
            dtCTPhieuMuon.Columns[1].HeaderText = "Tên sinh viên";
            dtCTPhieuMuon.Columns[2].HeaderText = "Tên thủ thư";
            dtCTPhieuMuon.Columns[3].HeaderText = "Tên sách";
            dtCTPhieuMuon.Columns[4].HeaderText = "Ngày mượn";
            dtCTPhieuMuon.Columns[5].HeaderText = "Ngày hẹn trả";
            dtCTPhieuMuon.Columns[6].HeaderText = "Tình trạng";
            dtCTPhieuMuon.Columns[7].HeaderText = "Ngày trả";
            dtCTPhieuMuon.Columns[8].HeaderText = "Mã sách ";
            dtCTPhieuMuon.Columns[9].HeaderText = "Số phiếu mượn";
        }

        private void hienMaSach()
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                if (sqlCon.State == ConnectionState.Closed)
                    return;
                using (SqlCommand sqlCmd = new SqlCommand("pr_SelectSach ", sqlCon))
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd))
                    {
                        DataTable tbl = new DataTable();
                        tbl.Clear();
                        adapter.Fill(tbl);
                        DataView v = new DataView(tbl);
                        cbMaS.ValueMember = "maSach";
                        cbMaS.DataSource = v;
                    }
                }
            }
        }

        private void hienSPM()
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                if (sqlCon.State == ConnectionState.Closed)
                    return;
                using (SqlCommand sqlCmd = new SqlCommand("pr_SelectSoPM", sqlCon))
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd))
                    {
                        DataTable tbl = new DataTable();
                        tbl.Clear();
                        adapter.Fill(tbl);
                        DataView v = new DataView(tbl);
                        cbSoPM.ValueMember = "soPhieuMuon";
                        cbSoPM.DataSource = v;
                    }
                }
            }
        }

        private void hienDSCTPM()
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                if (sqlCon.State == ConnectionState.Closed)
                    return;
                using(SqlCommand sqlCmd = new SqlCommand("pr_SelectCTPM", sqlCon))
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    using(SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd))
                    {
                        DataTable tbl = new DataTable();
                        tbl.Clear();
                        adapter.Fill(tbl);
                        DataView v = new DataView(tbl);
                        dtCTPhieuMuon.DataSource = v;
                    }
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn trở về trang chính ?","Thông báo ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                MainForm frMain = new MainForm();
                frMain.ShowDialog();
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
                using (SqlCommand sqlCmd3pm = new SqlCommand("pr_CheckQua3Muon", sqlCon))
                {
                    sqlCmd3pm.CommandType = CommandType.StoredProcedure;
                    sqlCmd3pm.Parameters.Add(new SqlParameter("@sopm", cbSoPM.Text.Trim()));
                    int count = (int)sqlCmd3pm.ExecuteScalar();
                    if (count > 100)
                    {
                        MessageBox.Show("Mỗi sinh viên chỉ được mượn nhiều nhất 100 cuốn ", "Thông báo ", MessageBoxButtons.OK);
                        txtSoCTPM.Focus();
                    }

                    else
                    {
                        using (SqlCommand sqlCmd = new SqlCommand("pr_CheckSoCTPM", sqlCon))
                        {
                            sqlCmd.CommandType = CommandType.StoredProcedure;
                            sqlCmd.Parameters.Add(new SqlParameter("@soct", txtSoCTPM.Text.Trim()));

                            int countct = (int)sqlCmd.ExecuteScalar();
                            if (countct > 0)
                            {
                                MessageBox.Show("Đã tồn tại số : " + txtSoCTPM.Text + "\n Vui lòng nhập lại ", "Thông báo ", MessageBoxButtons.OK);
                                txtSoCTPM.Focus();
                            }

                            else if (txtSoCTPM.Text.Trim().Length == 0)
                            {
                                MessageBox.Show("Vui lòng nhập số chi tiết phiếu mượn ", "Thông báo ", MessageBoxButtons.OK);
                                txtSoCTPM.Focus();
                            }
                            else if (DateTime.Compare(dateNM.Value, dateNHT.Value) > 0)
                            {
                                MessageBox.Show("Ngày mượn phải nhỏ hơn ngày hẹn trả", "Thông báo", MessageBoxButtons.OK);
                            }
                            else
                            {

                                using (SqlCommand sqlCmdCT = new SqlCommand("pr_InsertCTPM", sqlCon))
                                {
                                    sqlCmdCT.CommandType = CommandType.StoredProcedure;
                                    sqlCmdCT.Parameters.Add(new SqlParameter("@soct", txtSoCTPM.Text.Trim()));
                                    sqlCmdCT.Parameters.Add(new SqlParameter("@sopm", cbSoPM.SelectedValue.ToString()));
                                    sqlCmdCT.Parameters.Add(new SqlParameter("@mas", cbMaS.SelectedValue.ToString()));
                                    sqlCmdCT.Parameters.Add(new SqlParameter
                                    {
                                        ParameterName = "@ngaym",
                                        DbType = System.Data.DbType.DateTime,
                                        SqlDbType = System.Data.SqlDbType.DateTime,
                                        Value = DateTime.Parse(dateNM.Text.Trim())
                                    });
                                    sqlCmdCT.Parameters.Add(new SqlParameter
                                    {
                                        ParameterName = "@ngayht",
                                        DbType = System.Data.DbType.DateTime,
                                        SqlDbType = System.Data.SqlDbType.DateTime,
                                        Value = DateTime.Parse(dateNHT.Text.Trim())
                                    });
                                    sqlCmdCT.ExecuteNonQuery();

                                }
                                MessageBox.Show("Thêm thông tin thành công ", "Thông báo ", MessageBoxButtons.OK);
                                hienDSCTPM();
                                reLoad();

                            }

                        }
                    }
                }
            
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không ?", "Thông báo ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                btnThem.Visible = false;
                btnCapNhat.Visible = true;
                dateNT.Visible = true;
             
            }
            else
            {
                btnThem.Visible = true;
                btnCapNhat.Visible = false;
                dateNT.Visible = false;
                reLoad();
            }
           
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                if (sqlCon.State == ConnectionState.Closed)
                    return;
                using (SqlCommand sqlCmd = new SqlCommand("pr_UpdateCTPhieuMuon", sqlCon))
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    if (DateTime.Compare(dateNM.Value, dateNHT.Value) > 0)
                    {
                        MessageBox.Show("Ngày mượn phải nhỏ hơn ngày hẹn trả", "Thông báo", MessageBoxButtons.OK);
                    }
                    else if (DateTime.Compare(dateNM.Value, dateNT.Value) > 0)
                    {
                        MessageBox.Show("Ngày trả phải lớn hơn ngày mượn", "Thông báo", MessageBoxButtons.OK);
                    }
                    else if (DateTime.Compare(dateNT.Value, dateNHT.Value) > 0)
                    {
                        MessageBox.Show("Sinh viên này đã trả muộn sách", "Thông báo", MessageBoxButtons.OK);
                        using (SqlCommand sqlCmdCT = new SqlCommand("pr_UpdateCTPhieuMuon", sqlCon))
                        {
                            sqlCmdCT.CommandType = CommandType.StoredProcedure;
                            sqlCmdCT.Parameters.Add(new SqlParameter("@soct", txtSoCTPM.Text.Trim()));
                            sqlCmdCT.Parameters.Add(new SqlParameter
                            {
                                ParameterName = "@ngaym",
                                DbType = DbType.DateTime,
                                SqlDbType = SqlDbType.DateTime,
                                Value = dateNM.Value
                            });
                            sqlCmdCT.Parameters.Add(new SqlParameter
                            {
                                ParameterName = "@ngayht",
                                DbType = DbType.DateTime,
                                SqlDbType = SqlDbType.DateTime,
                                Value = dateNHT.Value
                            });
                            sqlCmdCT.Parameters.Add(new SqlParameter
                            {
                                ParameterName = "@ngayt",
                                DbType = DbType.DateTime,
                                SqlDbType = SqlDbType.DateTime,
                                Value = dateNT.Value
                            });
                            sqlCmdCT.ExecuteNonQuery();
                        }
                        MessageBox.Show("Cập nhật thành công ", "Thông báo ", MessageBoxButtons.OK);
                        hienDSCTPM();
                        reLoad();
                    }
                    else
                    {
                        using (SqlCommand sqlCmdCT = new SqlCommand("pr_UpdateCTPhieuMuon", sqlCon))
                        {
                            sqlCmdCT.CommandType = CommandType.StoredProcedure;
                            sqlCmdCT.Parameters.Add(new SqlParameter("@soct", txtSoCTPM.Text.Trim()));
                            sqlCmdCT.Parameters.Add(new SqlParameter
                            {
                                ParameterName = "@ngaym",
                                DbType = DbType.DateTime,
                                SqlDbType = SqlDbType.DateTime,
                                Value = dateNM.Value
                            });
                            sqlCmdCT.Parameters.Add(new SqlParameter
                            {
                                ParameterName = "@ngayht",
                                DbType = DbType.DateTime,
                                SqlDbType = SqlDbType.DateTime,
                                Value = dateNHT.Value
                            });
                            sqlCmdCT.Parameters.Add(new SqlParameter
                            {
                                ParameterName = "@ngayt",
                                DbType = DbType.DateTime,
                                SqlDbType = SqlDbType.DateTime,
                                Value = dateNT.Value
                            });
                            sqlCmdCT.ExecuteNonQuery();
                        }
                        MessageBox.Show("Cập nhật thành công ", "Thông báo ", MessageBoxButtons.OK);
                        hienDSCTPM();
                        reLoad();

                    }

                }
            }
        }
        public void reLoad()
        {
            // Khởi tạo đối tượng DateTime đại diện cho giá trị ngày tháng năm
            DateTime date = new DateTime(2023, 4, 14);
            DateTime date2 = new DateTime(2023, 4, 18);
            // Gán giá trị cho DateTimePicker
            dateNHT.Value = date;
            dateNHT.Value = date2;
            txtSoCTPM.Text = "";
            cbMaS.SelectedIndex = -1;
            cbSoPM.SelectedIndex = -1;
            
        }

        private void Click_CTPM(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow dtctpm = dtCTPhieuMuon.Rows[e.RowIndex];
            txtSoCTPM.Text = dtctpm.Cells[0].Value.ToString();
            string tensv = dtctpm.Cells[1].Value.ToString();
            string tentt = dtctpm.Cells[2].Value.ToString();
            string tensach = dtctpm.Cells[3].Value.ToString();
            dateNM.Text = dtctpm.Cells[4].Value.ToString();
            dateNHT.Text = dtctpm.Cells[5].Value.ToString();
            dateNT.Text = dtctpm.Cells[7].Value.ToString();
            string tinhtrang = dtctpm.Cells[6].Value.ToString();
            cbMaS.Text = dtctpm.Cells[8].Value.ToString();
            cbSoPM.Text = dtctpm.Cells[9].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa chi tiết phiếu mượn này chứ ", "Thông báo ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();
                    if (sqlCon.State == ConnectionState.Closed)
                        return;
                    using(SqlCommand sqlCmd = new SqlCommand("pr_DeleteCTPhieuMuon", sqlCon))
                    {
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@mactpm", txtSoCTPM.Text.Trim());

                        sqlCmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Xóa thành công ", "Thông báo ", MessageBoxButtons.OK);
                    hienDSCTPM();
                    reLoad();

                }
            }
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                if (sqlCon.State == ConnectionState.Closed)
                    return;
                using (SqlCommand sqlCmd = new SqlCommand("pr_SelectCTPM", sqlCon))
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd))
                    {
                        DataTable tbl = new DataTable();
                        tbl.Clear();
                        adapter.Fill(tbl);
                        dtCTPhieuMuon.DataSource = tbl;

                        rptInBaoCaoMuonTra baocao = new rptInBaoCaoMuonTra();
                        baocao.SetDataSource(tbl);
                        frInBaoCaoPhieuMuon frIn = new frInBaoCaoPhieuMuon();
                        frIn.crtInBaoCaoPM.ReportSource = baocao;
                        frIn.ShowDialog();
                        
                    }
                }
            }
        }
    }
}
