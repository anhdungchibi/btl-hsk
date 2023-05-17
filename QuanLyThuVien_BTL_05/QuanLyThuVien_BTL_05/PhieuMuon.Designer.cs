
namespace QuanLyThuVien_BTL_05
{
    partial class PhieuMuon
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
            this.dtPhieumuon = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbmaTT = new System.Windows.Forms.ComboBox();
            this.cbmaSV = new System.Windows.Forms.ComboBox();
            this.txtMaPM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchPM = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPhieumuon)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtPhieumuon);
            this.groupBox1.Location = new System.Drawing.Point(36, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(850, 322);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu mượn ";
            // 
            // dtPhieumuon
            // 
            this.dtPhieumuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPhieumuon.Location = new System.Drawing.Point(8, 25);
            this.dtPhieumuon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtPhieumuon.Name = "dtPhieumuon";
            this.dtPhieumuon.RowHeadersWidth = 51;
            this.dtPhieumuon.RowTemplate.Height = 24;
            this.dtPhieumuon.Size = new System.Drawing.Size(836, 290);
            this.dtPhieumuon.TabIndex = 0;
            this.dtPhieumuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Cell_PM);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHome);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.cbmaTT);
            this.groupBox2.Controls.Add(this.cbmaSV);
            this.groupBox2.Controls.Add(this.txtMaPM);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(44, 411);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(836, 192);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập thông tin phiếu mượn ";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(682, 102);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(124, 46);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(483, 102);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 46);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(235, 102);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(124, 46);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(33, 102);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(124, 46);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbmaTT
            // 
            this.cbmaTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmaTT.FormattingEnabled = true;
            this.cbmaTT.Location = new System.Drawing.Point(411, 44);
            this.cbmaTT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbmaTT.Name = "cbmaTT";
            this.cbmaTT.Size = new System.Drawing.Size(129, 27);
            this.cbmaTT.TabIndex = 5;
            // 
            // cbmaSV
            // 
            this.cbmaSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmaSV.FormattingEnabled = true;
            this.cbmaSV.Location = new System.Drawing.Point(683, 44);
            this.cbmaSV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbmaSV.Name = "cbmaSV";
            this.cbmaSV.Size = new System.Drawing.Size(120, 27);
            this.cbmaSV.TabIndex = 4;
            // 
            // txtMaPM
            // 
            this.txtMaPM.Location = new System.Drawing.Point(162, 44);
            this.txtMaPM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaPM.Name = "txtMaPM";
            this.txtMaPM.Size = new System.Drawing.Size(105, 27);
            this.txtMaPM.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã thủ thư : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sinh viên : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu mượn :";
            // 
            // txtSearchPM
            // 
            this.txtSearchPM.Location = new System.Drawing.Point(204, 31);
            this.txtSearchPM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchPM.Name = "txtSearchPM";
            this.txtSearchPM.Size = new System.Drawing.Size(470, 27);
            this.txtSearchPM.TabIndex = 2;
            this.txtSearchPM.TextChanged += new System.EventHandler(this.txtSearchPM_TextChanged);
            // 
            // PhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 618);
            this.Controls.Add(this.txtSearchPM);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PhieuMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Phiếu mượn";
            this.Load += new System.EventHandler(this.PhieuMuon_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtPhieumuon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtPhieumuon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbmaTT;
        private System.Windows.Forms.ComboBox cbmaSV;
        private System.Windows.Forms.TextBox txtMaPM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchPM;
    }
}