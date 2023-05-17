
namespace QuanLyThuVien_BTL_05
{
    partial class CTPhieuMuon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtCTPhieuMuon = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dateNT = new System.Windows.Forms.DateTimePicker();
            this.dateNHT = new System.Windows.Forms.DateTimePicker();
            this.dateNM = new System.Windows.Forms.DateTimePicker();
            this.cbMaS = new System.Windows.Forms.ComboBox();
            this.cbSoPM = new System.Windows.Forms.ComboBox();
            this.txtSoCTPM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtCTPhieuMuon)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtCTPhieuMuon);
            this.groupBox1.Location = new System.Drawing.Point(30, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1353, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phiếu mượn chi tiết ";
            // 
            // dtCTPhieuMuon
            // 
            this.dtCTPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCTPhieuMuon.Location = new System.Drawing.Point(7, 27);
            this.dtCTPhieuMuon.Name = "dtCTPhieuMuon";
            this.dtCTPhieuMuon.RowHeadersWidth = 51;
            this.dtCTPhieuMuon.RowTemplate.Height = 24;
            this.dtCTPhieuMuon.Size = new System.Drawing.Size(1338, 264);
            this.dtCTPhieuMuon.TabIndex = 0;
            this.dtCTPhieuMuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Click_CTPM);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBaoCao);
            this.groupBox2.Controls.Add(this.btnHome);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnCapNhat);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.dateNT);
            this.groupBox2.Controls.Add(this.dateNHT);
            this.groupBox2.Controls.Add(this.dateNM);
            this.groupBox2.Controls.Add(this.cbMaS);
            this.groupBox2.Controls.Add(this.cbSoPM);
            this.groupBox2.Controls.Add(this.txtSoCTPM);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(184, 339);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1105, 232);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập thông tin chi tiết phiếu mượn ";
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(812, 154);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(102, 52);
            this.btnBaoCao.TabIndex = 17;
            this.btnBaoCao.Text = "In báo cáo ";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(982, 154);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(102, 52);
            this.btnHome.TabIndex = 16;
            this.btnHome.Text = "Home ";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(625, 154);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 52);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(426, 154);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(102, 52);
            this.btnCapNhat.TabIndex = 14;
            this.btnCapNhat.Text = "Cập nhật ";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Visible = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(229, 154);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(102, 52);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(32, 154);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 52);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dateNT
            // 
            this.dateNT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNT.Location = new System.Drawing.Point(861, 84);
            this.dateNT.Name = "dateNT";
            this.dateNT.Size = new System.Drawing.Size(107, 27);
            this.dateNT.TabIndex = 11;
            this.dateNT.Value = new System.DateTime(2023, 4, 17, 0, 0, 0, 0);
            this.dateNT.Visible = false;
            // 
            // dateNHT
            // 
            this.dateNHT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNHT.Location = new System.Drawing.Point(549, 86);
            this.dateNHT.Name = "dateNHT";
            this.dateNHT.Size = new System.Drawing.Size(120, 27);
            this.dateNHT.TabIndex = 10;
            // 
            // dateNM
            // 
            this.dateNM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNM.Location = new System.Drawing.Point(186, 84);
            this.dateNM.Name = "dateNM";
            this.dateNM.Size = new System.Drawing.Size(114, 27);
            this.dateNM.TabIndex = 9;
            // 
            // cbMaS
            // 
            this.cbMaS.FormattingEnabled = true;
            this.cbMaS.Location = new System.Drawing.Point(861, 41);
            this.cbMaS.Name = "cbMaS";
            this.cbMaS.Size = new System.Drawing.Size(107, 27);
            this.cbMaS.TabIndex = 8;
            // 
            // cbSoPM
            // 
            this.cbSoPM.FormattingEnabled = true;
            this.cbSoPM.Location = new System.Drawing.Point(549, 39);
            this.cbSoPM.Name = "cbSoPM";
            this.cbSoPM.Size = new System.Drawing.Size(120, 27);
            this.cbSoPM.TabIndex = 7;
            // 
            // txtSoCTPM
            // 
            this.txtSoCTPM.Location = new System.Drawing.Point(186, 40);
            this.txtSoCTPM.Name = "txtSoCTPM";
            this.txtSoCTPM.Size = new System.Drawing.Size(114, 27);
            this.txtSoCTPM.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(777, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày trả : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày hẹn trả : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày mượn : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(777, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã sách : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số phiếu mượn :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số CTPM : ";
            // 
            // CTPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 635);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CTPhieuMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết phiếu mượn ";
            this.Load += new System.EventHandler(this.CTPhieuMuon_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtCTPhieuMuon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtCTPhieuMuon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dateNT;
        private System.Windows.Forms.DateTimePicker dateNHT;
        private System.Windows.Forms.DateTimePicker dateNM;
        private System.Windows.Forms.ComboBox cbMaS;
        private System.Windows.Forms.ComboBox cbSoPM;
        private System.Windows.Forms.TextBox txtSoCTPM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBaoCao;
    }
}