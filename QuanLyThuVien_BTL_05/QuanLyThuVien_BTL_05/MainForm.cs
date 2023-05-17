using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien_BTL_05
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

           
        }

     
        private void mnuDMSV_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sinhvien frSinhvien = new Sinhvien();
            frSinhvien.ShowDialog();
            this.Close();
           

        }

        private void mnuHTLogout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn thoát ? " ,"Thông báo",MessageBoxButtons.YesNo) == DialogResult.Yes )
            {
                this.Close();
            }
        }

        private void mnuDMTL_Click(object sender, EventArgs e)
        {
            this.Hide();
            TheLoaiSach frTLSach = new TheLoaiSach();
            frTLSach.ShowDialog();
            this.Close();
        }

        private void mnuDMSach_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sach frSach = new Sach();
            frSach.ShowDialog();
            this.Close();
        }

        private void mnuDMTT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thuthu frThuthu = new Thuthu();
            frThuthu.ShowDialog();
            this.Close();
        }

        private void mnuMTPM_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhieuMuon frphieuMuon = new PhieuMuon();
            frphieuMuon.ShowDialog();
            this.Close();
        }

        private void mnuHTTK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn trở về màn hình đăng nhập", "Thông báo ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                DangNhap frLogin = new DangNhap();
                frLogin.ShowDialog();
                this.Close();
            }
        }

        private void mnuMTCTPM_Click(object sender, EventArgs e)
        {
            this.Hide();
            CTPhieuMuon frctpm = new CTPhieuMuon();
            frctpm.ShowDialog();
            this.Close();
        }
    }
}
