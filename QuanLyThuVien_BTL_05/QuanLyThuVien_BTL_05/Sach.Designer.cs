
namespace QuanLyThuVien_BTL_05
{
    partial class Sach
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
            this.dtSach = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnXoaS = new System.Windows.Forms.Button();
            this.btnSuaS = new System.Windows.Forms.Button();
            this.btnThemS = new System.Windows.Forms.Button();
            this.cbMaLS = new System.Windows.Forms.ComboBox();
            this.txtSoL = new System.Windows.Forms.TextBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.txtTenS = new System.Windows.Forms.TextBox();
            this.txtMaS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchS = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtSach)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtSach);
            this.groupBox1.Location = new System.Drawing.Point(30, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(858, 298);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sách";
            // 
            // dtSach
            // 
            this.dtSach.ColumnHeadersHeight = 29;
            this.dtSach.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dtSach.Location = new System.Drawing.Point(22, 27);
            this.dtSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtSach.Name = "dtSach";
            this.dtSach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtSach.RowHeadersWidth = 51;
            this.dtSach.RowTemplate.Height = 24;
            this.dtSach.Size = new System.Drawing.Size(814, 255);
            this.dtSach.TabIndex = 0;
            this.dtSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtSach_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHome);
            this.groupBox2.Controls.Add(this.btnXoaS);
            this.groupBox2.Controls.Add(this.btnSuaS);
            this.groupBox2.Controls.Add(this.btnThemS);
            this.groupBox2.Controls.Add(this.cbMaLS);
            this.groupBox2.Controls.Add(this.txtSoL);
            this.groupBox2.Controls.Add(this.txtTacGia);
            this.groupBox2.Controls.Add(this.txtTenS);
            this.groupBox2.Controls.Add(this.txtMaS);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(94, 350);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(737, 198);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập thông tin sách";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(602, 139);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(107, 46);
            this.btnHome.TabIndex = 13;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnXoaS
            // 
            this.btnXoaS.Location = new System.Drawing.Point(411, 139);
            this.btnXoaS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoaS.Name = "btnXoaS";
            this.btnXoaS.Size = new System.Drawing.Size(107, 46);
            this.btnXoaS.TabIndex = 12;
            this.btnXoaS.Text = "Xóa";
            this.btnXoaS.UseVisualStyleBackColor = true;
            this.btnXoaS.Click += new System.EventHandler(this.btnXoaS_Click);
            // 
            // btnSuaS
            // 
            this.btnSuaS.Location = new System.Drawing.Point(210, 139);
            this.btnSuaS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSuaS.Name = "btnSuaS";
            this.btnSuaS.Size = new System.Drawing.Size(107, 46);
            this.btnSuaS.TabIndex = 11;
            this.btnSuaS.Text = "Sửa";
            this.btnSuaS.UseVisualStyleBackColor = true;
            this.btnSuaS.Click += new System.EventHandler(this.btnSuaS_Click);
            // 
            // btnThemS
            // 
            this.btnThemS.Location = new System.Drawing.Point(21, 139);
            this.btnThemS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemS.Name = "btnThemS";
            this.btnThemS.Size = new System.Drawing.Size(107, 46);
            this.btnThemS.TabIndex = 10;
            this.btnThemS.Text = "Thêm";
            this.btnThemS.UseVisualStyleBackColor = true;
            this.btnThemS.Click += new System.EventHandler(this.btnThemS_Click);
            // 
            // cbMaLS
            // 
            this.cbMaLS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaLS.FormattingEnabled = true;
            this.cbMaLS.Location = new System.Drawing.Point(581, 72);
            this.cbMaLS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMaLS.Name = "cbMaLS";
            this.cbMaLS.Size = new System.Drawing.Size(103, 27);
            this.cbMaLS.TabIndex = 9;
            // 
            // txtSoL
            // 
            this.txtSoL.Location = new System.Drawing.Point(364, 90);
            this.txtSoL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoL.Name = "txtSoL";
            this.txtSoL.Size = new System.Drawing.Size(143, 27);
            this.txtSoL.TabIndex = 8;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(364, 39);
            this.txtTacGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(143, 27);
            this.txtTacGia.TabIndex = 7;
            // 
            // txtTenS
            // 
            this.txtTenS.Location = new System.Drawing.Point(111, 90);
            this.txtTenS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenS.Name = "txtTenS";
            this.txtTenS.Size = new System.Drawing.Size(143, 27);
            this.txtTenS.TabIndex = 6;
            // 
            // txtMaS
            // 
            this.txtMaS.Location = new System.Drawing.Point(111, 39);
            this.txtMaS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaS.Name = "txtMaS";
            this.txtMaS.Size = new System.Drawing.Size(143, 27);
            this.txtMaS.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(584, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã loại sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tác giả :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sách :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách :";
            // 
            // txtSearchS
            // 
            this.txtSearchS.Location = new System.Drawing.Point(204, 10);
            this.txtSearchS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchS.Name = "txtSearchS";
            this.txtSearchS.Size = new System.Drawing.Size(464, 27);
            this.txtSearchS.TabIndex = 2;
            this.txtSearchS.Text = "\r\n\r\n";
            this.txtSearchS.TextChanged += new System.EventHandler(this.txtSearchS_TextChanged);
            // 
            // Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 560);
            this.Controls.Add(this.txtSearchS);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Sach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sách ";
            this.Load += new System.EventHandler(this.Sach_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtSach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtSach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThemS;
        private System.Windows.Forms.TextBox txtSoL;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.TextBox txtTenS;
        private System.Windows.Forms.TextBox txtMaS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnXoaS;
        private System.Windows.Forms.Button btnSuaS;
        private System.Windows.Forms.ComboBox cbMaLS;
        private System.Windows.Forms.TextBox txtSearchS;
    }
}