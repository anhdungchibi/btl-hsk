
namespace QuanLyThuVien_BTL_05
{
    partial class frInBaoCaoPhieuMuon
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
            this.crtInBaoCaoPM = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crtInBaoCaoPM
            // 
            this.crtInBaoCaoPM.ActiveViewIndex = -1;
            this.crtInBaoCaoPM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crtInBaoCaoPM.Cursor = System.Windows.Forms.Cursors.Default;
            this.crtInBaoCaoPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crtInBaoCaoPM.Location = new System.Drawing.Point(0, 0);
            this.crtInBaoCaoPM.Name = "crtInBaoCaoPM";
            this.crtInBaoCaoPM.Size = new System.Drawing.Size(800, 450);
            this.crtInBaoCaoPM.TabIndex = 0;
            // 
            // frInBaoCaoPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crtInBaoCaoPM);
            this.Name = "frInBaoCaoPhieuMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frInBaoCaoPhieuMuon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crtInBaoCaoPM;
    }
}