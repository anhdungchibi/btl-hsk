
namespace QuanLyThuVien_BTL_05
{
    partial class TheLoaiSach
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
            this.dtTheLoaiS = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTimKiemLS = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnXoaLS = new System.Windows.Forms.Button();
            this.btnSuaLS = new System.Windows.Forms.Button();
            this.btnThemLS = new System.Windows.Forms.Button();
            this.txtTenLS = new System.Windows.Forms.TextBox();
            this.txtMaLS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTheLoaiS)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtTheLoaiS);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(469, 480);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thể loại sách";
            // 
            // dtTheLoaiS
            // 
            this.dtTheLoaiS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtTheLoaiS.Location = new System.Drawing.Point(8, 38);
            this.dtTheLoaiS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtTheLoaiS.Name = "dtTheLoaiS";
            this.dtTheLoaiS.RowHeadersWidth = 51;
            this.dtTheLoaiS.RowTemplate.Height = 24;
            this.dtTheLoaiS.Size = new System.Drawing.Size(455, 442);
            this.dtTheLoaiS.TabIndex = 0;
            this.dtTheLoaiS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtTheLoaiS_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTimKiemLS);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(557, 56);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(381, 126);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm thể loại";
            // 
            // txtTimKiemLS
            // 
            this.txtTimKiemLS.Location = new System.Drawing.Point(19, 43);
            this.txtTimKiemLS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiemLS.Name = "txtTimKiemLS";
            this.txtTimKiemLS.Size = new System.Drawing.Size(355, 27);
            this.txtTimKiemLS.TabIndex = 0;
            this.txtTimKiemLS.TextChanged += new System.EventHandler(this.txtTimKiemLS_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnHome);
            this.groupBox3.Controls.Add(this.btnXoaLS);
            this.groupBox3.Controls.Add(this.btnSuaLS);
            this.groupBox3.Controls.Add(this.btnThemLS);
            this.groupBox3.Controls.Add(this.txtTenLS);
            this.groupBox3.Controls.Add(this.txtMaLS);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(557, 200);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(381, 321);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhập thông tin thể loại";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(244, 245);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(130, 42);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnXoaLS
            // 
            this.btnXoaLS.Location = new System.Drawing.Point(28, 245);
            this.btnXoaLS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoaLS.Name = "btnXoaLS";
            this.btnXoaLS.Size = new System.Drawing.Size(130, 42);
            this.btnXoaLS.TabIndex = 6;
            this.btnXoaLS.Text = "Xóa";
            this.btnXoaLS.UseVisualStyleBackColor = true;
            this.btnXoaLS.Click += new System.EventHandler(this.btnXoaLS_Click);
            // 
            // btnSuaLS
            // 
            this.btnSuaLS.Location = new System.Drawing.Point(244, 171);
            this.btnSuaLS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSuaLS.Name = "btnSuaLS";
            this.btnSuaLS.Size = new System.Drawing.Size(130, 42);
            this.btnSuaLS.TabIndex = 5;
            this.btnSuaLS.Text = "Sửa";
            this.btnSuaLS.UseVisualStyleBackColor = true;
            this.btnSuaLS.Click += new System.EventHandler(this.btnSuaLS_Click);
            // 
            // btnThemLS
            // 
            this.btnThemLS.Location = new System.Drawing.Point(28, 171);
            this.btnThemLS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemLS.Name = "btnThemLS";
            this.btnThemLS.Size = new System.Drawing.Size(130, 42);
            this.btnThemLS.TabIndex = 4;
            this.btnThemLS.Text = "Thêm";
            this.btnThemLS.UseVisualStyleBackColor = true;
            this.btnThemLS.Click += new System.EventHandler(this.btnThemLS_Click);
            // 
            // txtTenLS
            // 
            this.txtTenLS.Location = new System.Drawing.Point(138, 104);
            this.txtTenLS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenLS.Name = "txtTenLS";
            this.txtTenLS.Size = new System.Drawing.Size(236, 27);
            this.txtTenLS.TabIndex = 3;
            // 
            // txtMaLS
            // 
            this.txtMaLS.Location = new System.Drawing.Point(138, 52);
            this.txtMaLS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaLS.Name = "txtMaLS";
            this.txtMaLS.Size = new System.Drawing.Size(236, 27);
            this.txtMaLS.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên loại sách : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại sách :";
            // 
            // TheLoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 534);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TheLoaiSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thể Loại Sách";
            this.Load += new System.EventHandler(this.TheLoaiSach_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtTheLoaiS)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtTheLoaiS;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTimKiemLS;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnXoaLS;
        private System.Windows.Forms.Button btnSuaLS;
        private System.Windows.Forms.Button btnThemLS;
        private System.Windows.Forms.TextBox txtTenLS;
        private System.Windows.Forms.TextBox txtMaLS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}