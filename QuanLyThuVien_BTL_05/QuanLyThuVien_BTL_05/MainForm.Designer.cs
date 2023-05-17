
namespace QuanLyThuVien_BTL_05
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Menutrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDanhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDMSV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDMTL = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDMSach = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDMTT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMuonTra = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMTPM = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMTCTPM = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHTTK = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHTLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Menutrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Menutrip1
            // 
            this.Menutrip1.GripMargin = new System.Windows.Forms.Padding(2, 20, 0, 2);
            this.Menutrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menutrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDanhmuc,
            this.mnuMuonTra,
            this.mnuHeThong});
            this.Menutrip1.Location = new System.Drawing.Point(0, 0);
            this.Menutrip1.Name = "Menutrip1";
            this.Menutrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.Menutrip1.Size = new System.Drawing.Size(1003, 37);
            this.Menutrip1.TabIndex = 0;
            this.Menutrip1.Text = "menuStrip1";
            // 
            // mnuDanhmuc
            // 
            this.mnuDanhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDMSV,
            this.mnuDMTL,
            this.mnuDMSach,
            this.mnuDMTT});
            this.mnuDanhmuc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDanhmuc.Name = "mnuDanhmuc";
            this.mnuDanhmuc.Size = new System.Drawing.Size(131, 31);
            this.mnuDanhmuc.Text = "Danh mục ";
            // 
            // mnuDMSV
            // 
            this.mnuDMSV.Name = "mnuDMSV";
            this.mnuDMSV.Size = new System.Drawing.Size(187, 32);
            this.mnuDMSV.Text = "Sinh viên";
            this.mnuDMSV.Click += new System.EventHandler(this.mnuDMSV_Click);
            // 
            // mnuDMTL
            // 
            this.mnuDMTL.Name = "mnuDMTL";
            this.mnuDMTL.Size = new System.Drawing.Size(187, 32);
            this.mnuDMTL.Text = "Thể loại";
            this.mnuDMTL.Click += new System.EventHandler(this.mnuDMTL_Click);
            // 
            // mnuDMSach
            // 
            this.mnuDMSach.Name = "mnuDMSach";
            this.mnuDMSach.Size = new System.Drawing.Size(187, 32);
            this.mnuDMSach.Text = "Sách";
            this.mnuDMSach.Click += new System.EventHandler(this.mnuDMSach_Click);
            // 
            // mnuDMTT
            // 
            this.mnuDMTT.Name = "mnuDMTT";
            this.mnuDMTT.Size = new System.Drawing.Size(187, 32);
            this.mnuDMTT.Text = "Thủ thư";
            this.mnuDMTT.Click += new System.EventHandler(this.mnuDMTT_Click);
            // 
            // mnuMuonTra
            // 
            this.mnuMuonTra.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMTPM,
            this.mnuMTCTPM});
            this.mnuMuonTra.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMuonTra.Name = "mnuMuonTra";
            this.mnuMuonTra.Size = new System.Drawing.Size(172, 31);
            this.mnuMuonTra.Text = "Mượn trả sách ";
            // 
            // mnuMTPM
            // 
            this.mnuMTPM.Name = "mnuMTPM";
            this.mnuMTPM.Size = new System.Drawing.Size(290, 32);
            this.mnuMTPM.Text = "Phiếu mượn";
            this.mnuMTPM.Click += new System.EventHandler(this.mnuMTPM_Click);
            // 
            // mnuMTCTPM
            // 
            this.mnuMTCTPM.Name = "mnuMTCTPM";
            this.mnuMTCTPM.Size = new System.Drawing.Size(290, 32);
            this.mnuMTCTPM.Text = "Chi tiết phiếu mượn";
            this.mnuMTCTPM.Click += new System.EventHandler(this.mnuMTCTPM_Click);
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHTTK,
            this.mnuHTLogout});
            this.mnuHeThong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(114, 31);
            this.mnuHeThong.Text = "Hệ thống";
            // 
            // mnuHTTK
            // 
            this.mnuHTTK.Name = "mnuHTTK";
            this.mnuHTTK.Size = new System.Drawing.Size(194, 32);
            this.mnuHTTK.Text = "Tài khoản";
            this.mnuHTTK.Click += new System.EventHandler(this.mnuHTTK_Click);
            // 
            // mnuHTLogout
            // 
            this.mnuHTLogout.Name = "mnuHTLogout";
            this.mnuHTLogout.Size = new System.Drawing.Size(194, 32);
            this.mnuHTLogout.Text = "Thoát";
            this.mnuHTLogout.Click += new System.EventHandler(this.mnuHTLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(975, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 559);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Menutrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.Menutrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý mượn trả sách tại thư viện ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Menutrip1.ResumeLayout(false);
            this.Menutrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menutrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhmuc;
        private System.Windows.Forms.ToolStripMenuItem mnuDMSV;
        private System.Windows.Forms.ToolStripMenuItem mnuMuonTra;
        private System.Windows.Forms.ToolStripMenuItem mnuDMTL;
        private System.Windows.Forms.ToolStripMenuItem mnuDMSach;
        private System.Windows.Forms.ToolStripMenuItem mnuDMTT;
        private System.Windows.Forms.ToolStripMenuItem mnuMTPM;
        private System.Windows.Forms.ToolStripMenuItem mnuMTCTPM;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuHTTK;
        private System.Windows.Forms.ToolStripMenuItem mnuHTLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}