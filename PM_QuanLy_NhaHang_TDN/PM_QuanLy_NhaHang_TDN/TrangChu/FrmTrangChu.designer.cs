namespace PM_QuanLy_NhaHang_TDN
{
    partial class FrmTrangChu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrangChu));
            this.panel4 = new System.Windows.Forms.Panel();
            this.time_NVonline = new System.Windows.Forms.Label();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picTDN = new System.Windows.Forms.PictureBox();
            this.icbtnTrangChu = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.icbtnDangXuat = new FontAwesome.Sharp.IconButton();
            this.icbtnDoiMatKhau = new FontAwesome.Sharp.IconButton();
            this.icbtnThongKe = new FontAwesome.Sharp.IconButton();
            this.icbtnQuanLy = new FontAwesome.Sharp.IconButton();
            this.icbtnBanHang = new FontAwesome.Sharp.IconButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.trangChu1 = new PM_QuanLy_NhaHang_TDN.TrangChu();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTDN)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Controls.Add(this.time_NVonline);
            this.panel4.Controls.Add(this.lblThoiGian);
            this.panel4.Controls.Add(this.lblTenNV);
            this.panel4.ForeColor = System.Drawing.Color.Yellow;
            this.panel4.Location = new System.Drawing.Point(1368, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(309, 78);
            this.panel4.TabIndex = 12;
            // 
            // time_NVonline
            // 
            this.time_NVonline.AutoSize = true;
            this.time_NVonline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_NVonline.ForeColor = System.Drawing.Color.Yellow;
            this.time_NVonline.Location = new System.Drawing.Point(134, 39);
            this.time_NVonline.Name = "time_NVonline";
            this.time_NVonline.Size = new System.Drawing.Size(105, 20);
            this.time_NVonline.TabIndex = 0;
            this.time_NVonline.Text = "00 : 00 : 00";
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGian.ForeColor = System.Drawing.Color.Yellow;
            this.lblThoiGian.Location = new System.Drawing.Point(12, 39);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(102, 20);
            this.lblThoiGian.TabIndex = 0;
            this.lblThoiGian.Text = "Thời Gian: ";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNV.ForeColor = System.Drawing.Color.Yellow;
            this.lblTenNV.Location = new System.Drawing.Point(12, 9);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(107, 20);
            this.lblTenNV.TabIndex = 0;
            this.lblTenNV.Text = "Nhân Viên: ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(466, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(848, 60);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chào Mừng Bạn Đến Với Nhà Hàng TDN";
            // 
            // picTDN
            // 
            this.picTDN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picTDN.BackgroundImage")));
            this.picTDN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picTDN.Dock = System.Windows.Forms.DockStyle.Left;
            this.picTDN.Location = new System.Drawing.Point(0, 0);
            this.picTDN.Name = "picTDN";
            this.picTDN.Size = new System.Drawing.Size(226, 117);
            this.picTDN.TabIndex = 14;
            this.picTDN.TabStop = false;
            // 
            // icbtnTrangChu
            // 
            this.icbtnTrangChu.AutoSize = true;
            this.icbtnTrangChu.BackColor = System.Drawing.Color.DimGray;
            this.icbtnTrangChu.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbtnTrangChu.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtnTrangChu.ForeColor = System.Drawing.Color.White;
            this.icbtnTrangChu.IconChar = FontAwesome.Sharp.IconChar.Hotel;
            this.icbtnTrangChu.IconColor = System.Drawing.Color.DeepPink;
            this.icbtnTrangChu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnTrangChu.IconSize = 50;
            this.icbtnTrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtnTrangChu.Location = new System.Drawing.Point(0, 0);
            this.icbtnTrangChu.Name = "icbtnTrangChu";
            this.icbtnTrangChu.Rotation = -3D;
            this.icbtnTrangChu.Size = new System.Drawing.Size(226, 69);
            this.icbtnTrangChu.TabIndex = 0;
            this.icbtnTrangChu.Text = "Trang Chủ";
            this.icbtnTrangChu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtnTrangChu.UseVisualStyleBackColor = false;
            this.icbtnTrangChu.Click += new System.EventHandler(this.icbtnTrangChu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.picTDN);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1680, 117);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.icbtnDangXuat);
            this.panel2.Controls.Add(this.icbtnDoiMatKhau);
            this.panel2.Controls.Add(this.icbtnThongKe);
            this.panel2.Controls.Add(this.icbtnQuanLy);
            this.panel2.Controls.Add(this.icbtnBanHang);
            this.panel2.Controls.Add(this.icbtnTrangChu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 763);
            this.panel2.TabIndex = 17;
            // 
            // icbtnDangXuat
            // 
            this.icbtnDangXuat.AutoSize = true;
            this.icbtnDangXuat.BackColor = System.Drawing.Color.DimGray;
            this.icbtnDangXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbtnDangXuat.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtnDangXuat.ForeColor = System.Drawing.Color.White;
            this.icbtnDangXuat.IconChar = FontAwesome.Sharp.IconChar.SignIn;
            this.icbtnDangXuat.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.icbtnDangXuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnDangXuat.IconSize = 50;
            this.icbtnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtnDangXuat.Location = new System.Drawing.Point(0, 345);
            this.icbtnDangXuat.Name = "icbtnDangXuat";
            this.icbtnDangXuat.Rotation = -3D;
            this.icbtnDangXuat.Size = new System.Drawing.Size(226, 69);
            this.icbtnDangXuat.TabIndex = 9;
            this.icbtnDangXuat.Text = "Đăng Xuất";
            this.icbtnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtnDangXuat.UseVisualStyleBackColor = false;
            this.icbtnDangXuat.Click += new System.EventHandler(this.icbtnDangXuat_Click);
            // 
            // icbtnDoiMatKhau
            // 
            this.icbtnDoiMatKhau.AutoSize = true;
            this.icbtnDoiMatKhau.BackColor = System.Drawing.Color.DimGray;
            this.icbtnDoiMatKhau.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbtnDoiMatKhau.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtnDoiMatKhau.ForeColor = System.Drawing.Color.White;
            this.icbtnDoiMatKhau.IconChar = FontAwesome.Sharp.IconChar.UserShield;
            this.icbtnDoiMatKhau.IconColor = System.Drawing.Color.Fuchsia;
            this.icbtnDoiMatKhau.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnDoiMatKhau.IconSize = 50;
            this.icbtnDoiMatKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtnDoiMatKhau.Location = new System.Drawing.Point(0, 276);
            this.icbtnDoiMatKhau.Name = "icbtnDoiMatKhau";
            this.icbtnDoiMatKhau.Rotation = -3D;
            this.icbtnDoiMatKhau.Size = new System.Drawing.Size(226, 69);
            this.icbtnDoiMatKhau.TabIndex = 6;
            this.icbtnDoiMatKhau.Text = "Đổi MK";
            this.icbtnDoiMatKhau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtnDoiMatKhau.UseVisualStyleBackColor = false;
            this.icbtnDoiMatKhau.Click += new System.EventHandler(this.icbtnDoiMatKhau_Click);
            // 
            // icbtnThongKe
            // 
            this.icbtnThongKe.AutoSize = true;
            this.icbtnThongKe.BackColor = System.Drawing.Color.DimGray;
            this.icbtnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbtnThongKe.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtnThongKe.ForeColor = System.Drawing.Color.White;
            this.icbtnThongKe.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.icbtnThongKe.IconColor = System.Drawing.Color.Lime;
            this.icbtnThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnThongKe.IconSize = 50;
            this.icbtnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtnThongKe.Location = new System.Drawing.Point(0, 207);
            this.icbtnThongKe.Name = "icbtnThongKe";
            this.icbtnThongKe.Rotation = -3D;
            this.icbtnThongKe.Size = new System.Drawing.Size(226, 69);
            this.icbtnThongKe.TabIndex = 3;
            this.icbtnThongKe.Text = "Thống Kê";
            this.icbtnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtnThongKe.UseVisualStyleBackColor = false;
            this.icbtnThongKe.Click += new System.EventHandler(this.icbtnThongKe_Click);
            // 
            // icbtnQuanLy
            // 
            this.icbtnQuanLy.AutoSize = true;
            this.icbtnQuanLy.BackColor = System.Drawing.Color.DimGray;
            this.icbtnQuanLy.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbtnQuanLy.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtnQuanLy.ForeColor = System.Drawing.Color.White;
            this.icbtnQuanLy.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            this.icbtnQuanLy.IconColor = System.Drawing.Color.Aqua;
            this.icbtnQuanLy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnQuanLy.IconSize = 50;
            this.icbtnQuanLy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtnQuanLy.Location = new System.Drawing.Point(0, 138);
            this.icbtnQuanLy.Name = "icbtnQuanLy";
            this.icbtnQuanLy.Rotation = -3D;
            this.icbtnQuanLy.Size = new System.Drawing.Size(226, 69);
            this.icbtnQuanLy.TabIndex = 2;
            this.icbtnQuanLy.Text = "Quản Lý";
            this.icbtnQuanLy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtnQuanLy.UseVisualStyleBackColor = false;
            this.icbtnQuanLy.Click += new System.EventHandler(this.icbtnQuanLy_Click);
            // 
            // icbtnBanHang
            // 
            this.icbtnBanHang.AutoSize = true;
            this.icbtnBanHang.BackColor = System.Drawing.Color.DimGray;
            this.icbtnBanHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbtnBanHang.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtnBanHang.ForeColor = System.Drawing.Color.White;
            this.icbtnBanHang.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.icbtnBanHang.IconColor = System.Drawing.Color.Yellow;
            this.icbtnBanHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnBanHang.IconSize = 50;
            this.icbtnBanHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtnBanHang.Location = new System.Drawing.Point(0, 69);
            this.icbtnBanHang.Name = "icbtnBanHang";
            this.icbtnBanHang.Rotation = -3D;
            this.icbtnBanHang.Size = new System.Drawing.Size(226, 69);
            this.icbtnBanHang.TabIndex = 1;
            this.icbtnBanHang.Text = "Bán Hàng";
            this.icbtnBanHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtnBanHang.UseVisualStyleBackColor = false;
            this.icbtnBanHang.Click += new System.EventHandler(this.icbtnBanHang_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // trangChu1
            // 
            this.trangChu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trangChu1.Location = new System.Drawing.Point(226, 117);
            this.trangChu1.Name = "trangChu1";
            this.trangChu1.Size = new System.Drawing.Size(1454, 763);
            this.trangChu1.TabIndex = 19;
            // 
            // FrmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1680, 880);
            this.Controls.Add(this.trangChu1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FrmTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTrangChu";
            this.Load += new System.EventHandler(this.FrmTrangChu_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTDN)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label time_NVonline;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.PictureBox picTDN;
        private FontAwesome.Sharp.IconButton icbtnTrangChu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton icbtnThongKe;
        private FontAwesome.Sharp.IconButton icbtnQuanLy;
        private FontAwesome.Sharp.IconButton icbtnBanHang;
        private System.Windows.Forms.Timer timer;
        private FontAwesome.Sharp.IconButton icbtnDoiMatKhau;
        private FontAwesome.Sharp.IconButton icbtnDangXuat;
        private TrangChu trangChu1;
    }
}