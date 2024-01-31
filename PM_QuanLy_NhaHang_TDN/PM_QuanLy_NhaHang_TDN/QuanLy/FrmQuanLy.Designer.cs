namespace PM_QuanLy_NhaHang_TDN
{
    partial class FrmQuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLy));
            this.msQuanLy = new System.Windows.Forms.MenuStrip();
            this.TSM_QLNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_QLTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_QLMonAn = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_QLBan = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_VeTrangChu = new System.Windows.Forms.ToolStripMenuItem();
            this.msQuanLy.SuspendLayout();
            this.SuspendLayout();
            // 
            // msQuanLy
            // 
            this.msQuanLy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.msQuanLy, "msQuanLy");
            this.msQuanLy.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msQuanLy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_QLNhanVien,
            this.TSM_QLTaiKhoan,
            this.TSM_QLMonAn,
            this.TSM_QLBan,
            this.TSM_VeTrangChu});
            this.msQuanLy.Name = "msQuanLy";
            this.msQuanLy.ShowItemToolTips = true;
            // 
            // TSM_QLNhanVien
            // 
            this.TSM_QLNhanVien.AutoToolTip = true;
            this.TSM_QLNhanVien.Checked = true;
            this.TSM_QLNhanVien.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TSM_QLNhanVien.Name = "TSM_QLNhanVien";
            resources.ApplyResources(this.TSM_QLNhanVien, "TSM_QLNhanVien");
            this.TSM_QLNhanVien.Click += new System.EventHandler(this.TSM_QLNhanVien_Click);
            // 
            // TSM_QLTaiKhoan
            // 
            this.TSM_QLTaiKhoan.AutoToolTip = true;
            this.TSM_QLTaiKhoan.Name = "TSM_QLTaiKhoan";
            resources.ApplyResources(this.TSM_QLTaiKhoan, "TSM_QLTaiKhoan");
            this.TSM_QLTaiKhoan.Click += new System.EventHandler(this.TSM_QLTaiKhoan_Click);
            // 
            // TSM_QLMonAn
            // 
            this.TSM_QLMonAn.AutoToolTip = true;
            this.TSM_QLMonAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TSM_QLMonAn.Name = "TSM_QLMonAn";
            resources.ApplyResources(this.TSM_QLMonAn, "TSM_QLMonAn");
            this.TSM_QLMonAn.Click += new System.EventHandler(this.TSM_QLMonAn_Click);
            // 
            // TSM_QLBan
            // 
            this.TSM_QLBan.AutoToolTip = true;
            this.TSM_QLBan.Name = "TSM_QLBan";
            resources.ApplyResources(this.TSM_QLBan, "TSM_QLBan");
            this.TSM_QLBan.Click += new System.EventHandler(this.TSM_QLBan_Click);
            // 
            // TSM_VeTrangChu
            // 
            this.TSM_VeTrangChu.AutoToolTip = true;
            resources.ApplyResources(this.TSM_VeTrangChu, "TSM_VeTrangChu");
            this.TSM_VeTrangChu.Name = "TSM_VeTrangChu";
            this.TSM_VeTrangChu.Click += new System.EventHandler(this.TSM_VeTrangChu_Click);
            // 
            // FrmQuanLy
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.msQuanLy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msQuanLy;
            this.Name = "FrmQuanLy";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.FrmQuanLy_Load);
            this.msQuanLy.ResumeLayout(false);
            this.msQuanLy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msQuanLy;
        private System.Windows.Forms.ToolStripMenuItem TSM_QLNhanVien;
        private System.Windows.Forms.ToolStripMenuItem TSM_QLTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem TSM_QLMonAn;
        private System.Windows.Forms.ToolStripMenuItem TSM_QLBan;
        private System.Windows.Forms.ToolStripMenuItem TSM_VeTrangChu;
    }
}