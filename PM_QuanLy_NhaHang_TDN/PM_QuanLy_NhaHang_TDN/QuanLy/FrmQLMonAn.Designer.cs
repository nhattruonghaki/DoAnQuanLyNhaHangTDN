namespace PM_QuanLy_NhaHang_TDN
{
    partial class FrmQLMonAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQLMonAn));
            this.panel4 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radNuoc = new System.Windows.Forms.RadioButton();
            this.radAll = new System.Windows.Forms.RadioButton();
            this.radRauCu = new System.Windows.Forms.RadioButton();
            this.radHaiSan = new System.Windows.Forms.RadioButton();
            this.radThit = new System.Windows.Forms.RadioButton();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.cbbLoaiMonAn = new System.Windows.Forms.ComboBox();
            this.icbtnThemAnh = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.cbbTimKiem = new System.Windows.Forms.ComboBox();
            this.picHinhAnh = new System.Windows.Forms.PictureBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtTenMonAn = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtMaMonAn = new System.Windows.Forms.TextBox();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.dgvDSMonAn = new System.Windows.Forms.DataGridView();
            this.dgvMaMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSLTonKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHinhAnh = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvMaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Controls.Add(this.label16);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1676, 68);
            this.panel4.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.DimGray;
            this.label16.Font = new System.Drawing.Font("Monotype Corsiva", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Yellow;
            this.label16.Location = new System.Drawing.Point(716, 5);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(364, 60);
            this.label16.TabIndex = 0;
            this.label16.Text = "Quản Lý Món Ăn";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBox2.Controls.Add(this.radNuoc);
            this.groupBox2.Controls.Add(this.radAll);
            this.groupBox2.Controls.Add(this.radRauCu);
            this.groupBox2.Controls.Add(this.radHaiSan);
            this.groupBox2.Controls.Add(this.radThit);
            this.groupBox2.Controls.Add(this.txtSL);
            this.groupBox2.Controls.Add(this.cbbLoaiMonAn);
            this.groupBox2.Controls.Add(this.icbtnThemAnh);
            this.groupBox2.Controls.Add(this.iconButton4);
            this.groupBox2.Controls.Add(this.cbbTimKiem);
            this.groupBox2.Controls.Add(this.picHinhAnh);
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Controls.Add(this.button11);
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtDonGia);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.txtTenMonAn);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtMaMonAn);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 765);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Món Ăn";
            // 
            // radNuoc
            // 
            this.radNuoc.AutoSize = true;
            this.radNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNuoc.Location = new System.Drawing.Point(289, 170);
            this.radNuoc.Name = "radNuoc";
            this.radNuoc.Size = new System.Drawing.Size(84, 30);
            this.radNuoc.TabIndex = 18;
            this.radNuoc.TabStop = true;
            this.radNuoc.Text = "Nước";
            this.radNuoc.UseVisualStyleBackColor = true;
            this.radNuoc.CheckedChanged += new System.EventHandler(this.radNuoc_CheckedChanged);
            // 
            // radAll
            // 
            this.radAll.AutoSize = true;
            this.radAll.Checked = true;
            this.radAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAll.Location = new System.Drawing.Point(50, 134);
            this.radAll.Name = "radAll";
            this.radAll.Size = new System.Drawing.Size(97, 30);
            this.radAll.TabIndex = 3;
            this.radAll.TabStop = true;
            this.radAll.Text = "Tất Cả";
            this.radAll.UseVisualStyleBackColor = true;
            this.radAll.CheckedChanged += new System.EventHandler(this.radAll_CheckedChanged);
            // 
            // radRauCu
            // 
            this.radRauCu.AutoSize = true;
            this.radRauCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRauCu.Location = new System.Drawing.Point(160, 170);
            this.radRauCu.Name = "radRauCu";
            this.radRauCu.Size = new System.Drawing.Size(107, 30);
            this.radRauCu.TabIndex = 5;
            this.radRauCu.Text = "Rau Củ";
            this.radRauCu.UseVisualStyleBackColor = true;
            this.radRauCu.CheckedChanged += new System.EventHandler(this.radRauCu_CheckedChanged);
            // 
            // radHaiSan
            // 
            this.radHaiSan.AutoSize = true;
            this.radHaiSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHaiSan.Location = new System.Drawing.Point(160, 134);
            this.radHaiSan.Name = "radHaiSan";
            this.radHaiSan.Size = new System.Drawing.Size(111, 30);
            this.radHaiSan.TabIndex = 4;
            this.radHaiSan.Text = "Hải Sản";
            this.radHaiSan.UseVisualStyleBackColor = true;
            this.radHaiSan.CheckedChanged += new System.EventHandler(this.radHaiSan_CheckedChanged);
            // 
            // radThit
            // 
            this.radThit.AutoSize = true;
            this.radThit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radThit.Location = new System.Drawing.Point(289, 134);
            this.radThit.Name = "radThit";
            this.radThit.Size = new System.Drawing.Size(68, 30);
            this.radThit.TabIndex = 6;
            this.radThit.Text = "Thịt";
            this.radThit.UseVisualStyleBackColor = true;
            this.radThit.CheckedChanged += new System.EventHandler(this.radThit_CheckedChanged);
            // 
            // txtSL
            // 
            this.txtSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.Location = new System.Drawing.Point(218, 620);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(191, 34);
            this.txtSL.TabIndex = 11;
            this.txtSL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSL_KeyPress);
            // 
            // cbbLoaiMonAn
            // 
            this.cbbLoaiMonAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoaiMonAn.FormattingEnabled = true;
            this.cbbLoaiMonAn.Location = new System.Drawing.Point(218, 451);
            this.cbbLoaiMonAn.Name = "cbbLoaiMonAn";
            this.cbbLoaiMonAn.Size = new System.Drawing.Size(191, 37);
            this.cbbLoaiMonAn.TabIndex = 8;
            // 
            // icbtnThemAnh
            // 
            this.icbtnThemAnh.AutoSize = true;
            this.icbtnThemAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtnThemAnh.IconChar = FontAwesome.Sharp.IconChar.Images;
            this.icbtnThemAnh.IconColor = System.Drawing.Color.Black;
            this.icbtnThemAnh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnThemAnh.IconSize = 30;
            this.icbtnThemAnh.Location = new System.Drawing.Point(164, 395);
            this.icbtnThemAnh.Name = "icbtnThemAnh";
            this.icbtnThemAnh.Size = new System.Drawing.Size(144, 38);
            this.icbtnThemAnh.TabIndex = 7;
            this.icbtnThemAnh.Text = "Thêm Ảnh";
            this.icbtnThemAnh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtnThemAnh.UseVisualStyleBackColor = true;
            this.icbtnThemAnh.Click += new System.EventHandler(this.icbtnThemAnh_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.AutoSize = true;
            this.iconButton4.Enabled = false;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 30;
            this.iconButton4.Location = new System.Drawing.Point(76, 35);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(54, 38);
            this.iconButton4.TabIndex = 17;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // cbbTimKiem
            // 
            this.cbbTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTimKiem.FormattingEnabled = true;
            this.cbbTimKiem.Items.AddRange(new object[] {
            "Tên Món Ăn",
            "Mã Món Ăn"});
            this.cbbTimKiem.Location = new System.Drawing.Point(146, 39);
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Size = new System.Drawing.Size(194, 34);
            this.cbbTimKiem.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cbbTimKiem, "Chọn mã hoặc tên món ăn");
            // 
            // picHinhAnh
            // 
            this.picHinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHinhAnh.Location = new System.Drawing.Point(114, 206);
            this.picHinhAnh.Name = "picHinhAnh";
            this.picHinhAnh.Size = new System.Drawing.Size(247, 183);
            this.picHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHinhAnh.TabIndex = 7;
            this.picHinhAnh.TabStop = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(146, 87);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(194, 32);
            this.txtTimKiem.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtTimKiem, "Nhập mã hoặc tên món ăn");
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // button11
            // 
            this.button11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button11.BackgroundImage")));
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button11.Enabled = false;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(355, 82);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(54, 46);
            this.button11.TabIndex = 0;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.BackgroundImage")));
            this.btnLamMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(384, 683);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 61);
            this.btnLamMoi.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btnLamMoi, "Làm mới");
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(263, 683);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 61);
            this.btnXoa.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btnXoa, "Xoá món");
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(144, 683);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 61);
            this.btnSua.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnSua, "Sửa món");
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(39, 683);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 61);
            this.btnThem.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnThem, "Thêm món");
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(45, 511);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(141, 26);
            this.label18.TabIndex = 1;
            this.label18.Text = "Tên Món Ăn :";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(218, 565);
            this.txtDonGia.Multiline = true;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(191, 30);
            this.txtDonGia.TabIndex = 10;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(45, 454);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(146, 26);
            this.label21.TabIndex = 0;
            this.label21.Text = "Loại Món Ăn :";
            // 
            // txtTenMonAn
            // 
            this.txtTenMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMonAn.Location = new System.Drawing.Point(218, 508);
            this.txtTenMonAn.Multiline = true;
            this.txtTenMonAn.Name = "txtTenMonAn";
            this.txtTenMonAn.Size = new System.Drawing.Size(191, 30);
            this.txtTenMonAn.TabIndex = 9;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(45, 625);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(138, 26);
            this.label19.TabIndex = 1;
            this.label19.Text = "SL Tồn Kho :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(45, 568);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 26);
            this.label17.TabIndex = 1;
            this.label17.Text = "Đơn Giá :";
            // 
            // txtMaMonAn
            // 
            this.txtMaMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMonAn.Location = new System.Drawing.Point(439, 620);
            this.txtMaMonAn.Multiline = true;
            this.txtMaMonAn.Name = "txtMaMonAn";
            this.txtMaMonAn.Size = new System.Drawing.Size(47, 34);
            this.txtMaMonAn.TabIndex = 2;
            this.txtMaMonAn.Visible = false;
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "ofdFile";
            // 
            // dgvDSMonAn
            // 
            this.dgvDSMonAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMonAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaMonAn,
            this.dgvTenMonAn,
            this.dgvDonGia,
            this.dgvSLTonKho,
            this.dgvTenLoai,
            this.dgvHinhAnh,
            this.dgvMaLoai});
            this.dgvDSMonAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSMonAn.Location = new System.Drawing.Point(505, 68);
            this.dgvDSMonAn.Name = "dgvDSMonAn";
            this.dgvDSMonAn.ReadOnly = true;
            this.dgvDSMonAn.RowHeadersWidth = 51;
            this.dgvDSMonAn.RowTemplate.Height = 24;
            this.dgvDSMonAn.Size = new System.Drawing.Size(1171, 765);
            this.dgvDSMonAn.TabIndex = 21;
            this.dgvDSMonAn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSMonAn_CellContentClick);
            // 
            // dgvMaMonAn
            // 
            this.dgvMaMonAn.DataPropertyName = "MaMonAn";
            this.dgvMaMonAn.HeaderText = "Mã Món Ăn";
            this.dgvMaMonAn.MinimumWidth = 6;
            this.dgvMaMonAn.Name = "dgvMaMonAn";
            this.dgvMaMonAn.ReadOnly = true;
            // 
            // dgvTenMonAn
            // 
            this.dgvTenMonAn.DataPropertyName = "TenMonAn";
            this.dgvTenMonAn.HeaderText = "Tên Món Ăn";
            this.dgvTenMonAn.MinimumWidth = 6;
            this.dgvTenMonAn.Name = "dgvTenMonAn";
            this.dgvTenMonAn.ReadOnly = true;
            // 
            // dgvDonGia
            // 
            this.dgvDonGia.DataPropertyName = "DonGia";
            this.dgvDonGia.HeaderText = "Đơn Giá";
            this.dgvDonGia.MinimumWidth = 6;
            this.dgvDonGia.Name = "dgvDonGia";
            this.dgvDonGia.ReadOnly = true;
            // 
            // dgvSLTonKho
            // 
            this.dgvSLTonKho.DataPropertyName = "SLTonKho";
            this.dgvSLTonKho.HeaderText = "SL Tồn Kho";
            this.dgvSLTonKho.MinimumWidth = 6;
            this.dgvSLTonKho.Name = "dgvSLTonKho";
            this.dgvSLTonKho.ReadOnly = true;
            // 
            // dgvTenLoai
            // 
            this.dgvTenLoai.DataPropertyName = "TenLoai";
            this.dgvTenLoai.HeaderText = "Loại Món Ăn";
            this.dgvTenLoai.MinimumWidth = 6;
            this.dgvTenLoai.Name = "dgvTenLoai";
            this.dgvTenLoai.ReadOnly = true;
            // 
            // dgvHinhAnh
            // 
            this.dgvHinhAnh.DataPropertyName = "HinhAnh";
            this.dgvHinhAnh.HeaderText = "Hình Ảnh";
            this.dgvHinhAnh.MinimumWidth = 6;
            this.dgvHinhAnh.Name = "dgvHinhAnh";
            this.dgvHinhAnh.ReadOnly = true;
            this.dgvHinhAnh.Visible = false;
            // 
            // dgvMaLoai
            // 
            this.dgvMaLoai.DataPropertyName = "MaLoai";
            this.dgvMaLoai.HeaderText = "Mã Loại";
            this.dgvMaLoai.MinimumWidth = 6;
            this.dgvMaLoai.Name = "dgvMaLoai";
            this.dgvMaLoai.ReadOnly = true;
            this.dgvMaLoai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMaLoai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvMaLoai.Visible = false;
            // 
            // FrmQLMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1676, 833);
            this.Controls.Add(this.dgvDSMonAn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmQLMonAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQLMonAn";
            this.Load += new System.EventHandler(this.FrmQLMonAn_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMonAn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.ComboBox cbbLoaiMonAn;
        private FontAwesome.Sharp.IconButton icbtnThemAnh;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.ComboBox cbbTimKiem;
        private System.Windows.Forms.PictureBox picHinhAnh;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtTenMonAn;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtMaMonAn;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.DataGridView dgvDSMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSLTonKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenLoai;
        private System.Windows.Forms.DataGridViewImageColumn dgvHinhAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaLoai;
        private System.Windows.Forms.RadioButton radThit;
        private System.Windows.Forms.RadioButton radRauCu;
        private System.Windows.Forms.RadioButton radHaiSan;
        private System.Windows.Forms.RadioButton radAll;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RadioButton radNuoc;
    }
}