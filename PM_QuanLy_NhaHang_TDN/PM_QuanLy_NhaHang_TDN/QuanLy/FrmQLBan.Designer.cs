namespace PM_QuanLy_NhaHang_TDN
{
    partial class FrmQLBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQLBan));
            this.panel5 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radBanTrong = new System.Windows.Forms.RadioButton();
            this.radPhucVu = new System.Windows.Forms.RadioButton();
            this.radTatCa = new System.Windows.Forms.RadioButton();
            this.radBanMoi = new System.Windows.Forms.RadioButton();
            this.radBanCu = new System.Windows.Forms.RadioButton();
            this.label27 = new System.Windows.Forms.Label();
            this.txtTenBan = new System.Windows.Forms.TextBox();
            this.cbbTimKiem = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtMaBan = new System.Windows.Forms.TextBox();
            this.dgvDSBan = new System.Windows.Forms.DataGridView();
            this.dgvMaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSoGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTrangThaiBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.Controls.Add(this.label20);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1676, 68);
            this.panel5.TabIndex = 14;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.DimGray;
            this.label20.Font = new System.Drawing.Font("Monotype Corsiva", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Yellow;
            this.label20.Location = new System.Drawing.Point(707, 5);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(285, 60);
            this.label20.TabIndex = 0;
            this.label20.Text = "Quản Lý Bàn";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBox3.Controls.Add(this.iconButton2);
            this.groupBox3.Controls.Add(this.iconButton4);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.radBanMoi);
            this.groupBox3.Controls.Add(this.radBanCu);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.txtTenBan);
            this.groupBox3.Controls.Add(this.cbbTimKiem);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.txtTimKiem);
            this.groupBox3.Controls.Add(this.btnLamMoi);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.txtMaBan);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(0, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(505, 765);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Bàn";
            // 
            // iconButton2
            // 
            this.iconButton2.Enabled = false;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(308, 120);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(63, 49);
            this.iconButton2.TabIndex = 31;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton4
            // 
            this.iconButton4.AutoSize = true;
            this.iconButton4.Enabled = false;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 30;
            this.iconButton4.Location = new System.Drawing.Point(308, 51);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(57, 46);
            this.iconButton4.TabIndex = 30;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radBanTrong);
            this.panel1.Controls.Add(this.radPhucVu);
            this.panel1.Controls.Add(this.radTatCa);
            this.panel1.Location = new System.Drawing.Point(157, 187);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 127);
            this.panel1.TabIndex = 29;
            // 
            // radBanTrong
            // 
            this.radBanTrong.AutoSize = true;
            this.radBanTrong.Location = new System.Drawing.Point(10, 46);
            this.radBanTrong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radBanTrong.Name = "radBanTrong";
            this.radBanTrong.Size = new System.Drawing.Size(122, 33);
            this.radBanTrong.TabIndex = 4;
            this.radBanTrong.Text = "Bàn mới";
            this.radBanTrong.UseVisualStyleBackColor = true;
            this.radBanTrong.CheckedChanged += new System.EventHandler(this.radBanTrong_CheckedChanged);
            // 
            // radPhucVu
            // 
            this.radPhucVu.AutoSize = true;
            this.radPhucVu.Location = new System.Drawing.Point(10, 79);
            this.radPhucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radPhucVu.Name = "radPhucVu";
            this.radPhucVu.Size = new System.Drawing.Size(107, 33);
            this.radPhucVu.TabIndex = 5;
            this.radPhucVu.Text = "Bàn cũ";
            this.radPhucVu.UseVisualStyleBackColor = true;
            this.radPhucVu.CheckedChanged += new System.EventHandler(this.radPhucVu_CheckedChanged);
            // 
            // radTatCa
            // 
            this.radTatCa.AutoSize = true;
            this.radTatCa.Checked = true;
            this.radTatCa.Location = new System.Drawing.Point(10, 12);
            this.radTatCa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radTatCa.Name = "radTatCa";
            this.radTatCa.Size = new System.Drawing.Size(100, 33);
            this.radTatCa.TabIndex = 3;
            this.radTatCa.TabStop = true;
            this.radTatCa.Text = "Tất cả";
            this.radTatCa.UseVisualStyleBackColor = true;
            this.radTatCa.CheckedChanged += new System.EventHandler(this.radTatCa_CheckedChanged);
            // 
            // radBanMoi
            // 
            this.radBanMoi.AutoSize = true;
            this.radBanMoi.Checked = true;
            this.radBanMoi.Location = new System.Drawing.Point(242, 468);
            this.radBanMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radBanMoi.Name = "radBanMoi";
            this.radBanMoi.Size = new System.Drawing.Size(122, 33);
            this.radBanMoi.TabIndex = 8;
            this.radBanMoi.TabStop = true;
            this.radBanMoi.Text = "Bàn mới";
            this.radBanMoi.UseVisualStyleBackColor = true;
            // 
            // radBanCu
            // 
            this.radBanCu.AutoSize = true;
            this.radBanCu.Location = new System.Drawing.Point(242, 522);
            this.radBanCu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radBanCu.Name = "radBanCu";
            this.radBanCu.Size = new System.Drawing.Size(107, 33);
            this.radBanCu.TabIndex = 9;
            this.radBanCu.Text = "Bàn cũ";
            this.radBanCu.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(75, 468);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(143, 29);
            this.label27.TabIndex = 28;
            this.label27.Text = "Trạng Thái :";
            // 
            // txtTenBan
            // 
            this.txtTenBan.Location = new System.Drawing.Point(200, 406);
            this.txtTenBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(191, 34);
            this.txtTenBan.TabIndex = 7;
            // 
            // cbbTimKiem
            // 
            this.cbbTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTimKiem.FormattingEnabled = true;
            this.cbbTimKiem.Items.AddRange(new object[] {
            "Mã bàn",
            "Tên bàn"});
            this.cbbTimKiem.Location = new System.Drawing.Point(106, 61);
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Size = new System.Drawing.Size(182, 37);
            this.cbbTimKiem.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cbbTimKiem, "Chọn mã hoặc tên bàn");
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(274, 599);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 58);
            this.btnXoa.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnXoa, "Xoá bàn");
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(106, 124);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(182, 34);
            this.txtTimKiem.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtTimKiem, "Nhập mã hoặc tên bàn");
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.BackgroundImage")));
            this.btnLamMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(388, 599);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(80, 58);
            this.btnLamMoi.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnLamMoi, "Làm mới");
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(157, 599);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 58);
            this.btnSua.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnSua, "Sửa bàn");
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(42, 599);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 58);
            this.btnThem.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnThem, "Thêm bàn");
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(75, 348);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(106, 29);
            this.label24.TabIndex = 0;
            this.label24.Text = "Mã Bàn :";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(75, 409);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(108, 29);
            this.label26.TabIndex = 1;
            this.label26.Text = "Tên bàn:";
            // 
            // txtMaBan
            // 
            this.txtMaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBan.Location = new System.Drawing.Point(200, 348);
            this.txtMaBan.Name = "txtMaBan";
            this.txtMaBan.ReadOnly = true;
            this.txtMaBan.Size = new System.Drawing.Size(191, 34);
            this.txtMaBan.TabIndex = 6;
            // 
            // dgvDSBan
            // 
            this.dgvDSBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaBan,
            this.dgvSoGhe,
            this.dgvTrangThaiBan,
            this.Column1});
            this.dgvDSBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSBan.Location = new System.Drawing.Point(505, 68);
            this.dgvDSBan.Name = "dgvDSBan";
            this.dgvDSBan.RowHeadersWidth = 51;
            this.dgvDSBan.RowTemplate.Height = 24;
            this.dgvDSBan.Size = new System.Drawing.Size(1171, 765);
            this.dgvDSBan.TabIndex = 18;
            this.dgvDSBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSBan_CellClick);
            this.dgvDSBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSBan_CellContentClick);
            // 
            // dgvMaBan
            // 
            this.dgvMaBan.DataPropertyName = "MABAN";
            this.dgvMaBan.HeaderText = "Mã Bàn";
            this.dgvMaBan.MinimumWidth = 6;
            this.dgvMaBan.Name = "dgvMaBan";
            this.dgvMaBan.ReadOnly = true;
            // 
            // dgvSoGhe
            // 
            this.dgvSoGhe.DataPropertyName = "TENBAN";
            this.dgvSoGhe.HeaderText = "Tên bàn";
            this.dgvSoGhe.MinimumWidth = 6;
            this.dgvSoGhe.Name = "dgvSoGhe";
            this.dgvSoGhe.ReadOnly = true;
            // 
            // dgvTrangThaiBan
            // 
            this.dgvTrangThaiBan.DataPropertyName = "TRANGTHAI";
            this.dgvTrangThaiBan.HeaderText = "Trạng Thái";
            this.dgvTrangThaiBan.MinimumWidth = 6;
            this.dgvTrangThaiBan.Name = "dgvTrangThaiBan";
            this.dgvTrangThaiBan.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Xóa";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // FrmQLBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1676, 833);
            this.Controls.Add(this.dgvDSBan);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmQLBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQLBan";
            this.Load += new System.EventHandler(this.FrmQLBan_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radBanMoi;
        private System.Windows.Forms.RadioButton radBanCu;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.RadioButton radTatCa;
        private System.Windows.Forms.RadioButton radPhucVu;
        private System.Windows.Forms.RadioButton radBanTrong;
        private System.Windows.Forms.TextBox txtTenBan;
        private System.Windows.Forms.ComboBox cbbTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtMaBan;
        private System.Windows.Forms.DataGridView dgvDSBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSoGhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTrangThaiBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}