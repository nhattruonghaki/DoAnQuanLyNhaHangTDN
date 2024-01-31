namespace PM_QuanLy_NhaHang_TDN
{
    partial class FrmThongKeTheoMon
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.radHaiSan = new System.Windows.Forms.RadioButton();
            this.radRauCu = new System.Windows.Forms.RadioButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cbbTimKiem = new System.Windows.Forms.ComboBox();
            this.radThit = new System.Windows.Forms.RadioButton();
            this.radTatCa = new System.Windows.Forms.RadioButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.dgvDSMonAn = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.radNuoc = new System.Windows.Forms.RadioButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1676, 70);
            this.panel2.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(598, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(530, 60);
            this.label2.TabIndex = 2;
            this.label2.Text = "THỐNG KÊ THEO MÓN";
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.Location = new System.Drawing.Point(1106, 83);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(122, 88);
            this.btnBaoCao.TabIndex = 6;
            this.btnBaoCao.Text = "Báo cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // radHaiSan
            // 
            this.radHaiSan.AutoSize = true;
            this.radHaiSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHaiSan.Location = new System.Drawing.Point(694, 44);
            this.radHaiSan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radHaiSan.Name = "radHaiSan";
            this.radHaiSan.Size = new System.Drawing.Size(121, 33);
            this.radHaiSan.TabIndex = 2;
            this.radHaiSan.Text = "Hải sản";
            this.radHaiSan.UseVisualStyleBackColor = true;
            this.radHaiSan.CheckedChanged += new System.EventHandler(this.radHaiSan_CheckedChanged);
            // 
            // radRauCu
            // 
            this.radRauCu.AutoSize = true;
            this.radRauCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRauCu.Location = new System.Drawing.Point(901, 44);
            this.radRauCu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radRauCu.Name = "radRauCu";
            this.radRauCu.Size = new System.Drawing.Size(114, 33);
            this.radRauCu.TabIndex = 3;
            this.radRauCu.Text = "Rau củ";
            this.radRauCu.UseVisualStyleBackColor = true;
            this.radRauCu.CheckedChanged += new System.EventHandler(this.radRauCu_CheckedChanged);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(694, 110);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(247, 34);
            this.txtTimKiem.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtTimKiem, "Nhập mã hoặc tên món ăn");
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // cbbTimKiem
            // 
            this.cbbTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTimKiem.FormattingEnabled = true;
            this.cbbTimKiem.Items.AddRange(new object[] {
            "Mã món ăn",
            "Tên món ăn"});
            this.cbbTimKiem.Location = new System.Drawing.Point(404, 110);
            this.cbbTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Size = new System.Drawing.Size(247, 37);
            this.cbbTimKiem.TabIndex = 4;
            this.toolTip1.SetToolTip(this.cbbTimKiem, "Chọn mã hoặc tên món ăn");
            // 
            // radThit
            // 
            this.radThit.AutoSize = true;
            this.radThit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radThit.Location = new System.Drawing.Point(517, 44);
            this.radThit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radThit.Name = "radThit";
            this.radThit.Size = new System.Drawing.Size(79, 33);
            this.radThit.TabIndex = 1;
            this.radThit.Text = "Thịt";
            this.radThit.UseVisualStyleBackColor = true;
            this.radThit.CheckedChanged += new System.EventHandler(this.radThit_CheckedChanged);
            // 
            // radTatCa
            // 
            this.radTatCa.AutoSize = true;
            this.radTatCa.Checked = true;
            this.radTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTatCa.Location = new System.Drawing.Point(329, 44);
            this.radTatCa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radTatCa.Name = "radTatCa";
            this.radTatCa.Size = new System.Drawing.Size(106, 33);
            this.radTatCa.TabIndex = 0;
            this.radTatCa.TabStop = true;
            this.radTatCa.Text = "Tất cả";
            this.radTatCa.UseVisualStyleBackColor = true;
            this.radTatCa.CheckedChanged += new System.EventHandler(this.radTatCa_CheckedChanged);
            // 
            // iconButton1
            // 
            this.iconButton1.AutoSize = true;
            this.iconButton1.Enabled = false;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(317, 101);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(67, 48);
            this.iconButton1.TabIndex = 41;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.radNuoc);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.btnBaoCao);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.radHaiSan);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.radRauCu);
            this.panel1.Controls.Add(this.radTatCa);
            this.panel1.Controls.Add(this.radThit);
            this.panel1.Controls.Add(this.cbbTimKiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1676, 213);
            this.panel1.TabIndex = 42;
            // 
            // iconButton2
            // 
            this.iconButton2.Enabled = false;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(961, 101);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(67, 53);
            this.iconButton2.TabIndex = 42;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // dgvDSMonAn
            // 
            this.dgvDSMonAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMonAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvDSMonAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSMonAn.Location = new System.Drawing.Point(0, 283);
            this.dgvDSMonAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSMonAn.Name = "dgvDSMonAn";
            this.dgvDSMonAn.RowHeadersWidth = 62;
            this.dgvDSMonAn.RowTemplate.Height = 28;
            this.dgvDSMonAn.Size = new System.Drawing.Size(1676, 550);
            this.dgvDSMonAn.TabIndex = 43;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAMONAN";
            this.Column1.HeaderText = "Mã món ăn";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MALOAI";
            this.Column2.HeaderText = "Mã loại";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TENMONAN";
            this.Column3.HeaderText = "Tên món ăn";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SLTONKHO";
            this.Column4.HeaderText = "Số lượng";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DONGIA";
            this.Column5.HeaderText = "Đơn giá";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // radNuoc
            // 
            this.radNuoc.AutoSize = true;
            this.radNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNuoc.Location = new System.Drawing.Point(1097, 45);
            this.radNuoc.Name = "radNuoc";
            this.radNuoc.Size = new System.Drawing.Size(95, 33);
            this.radNuoc.TabIndex = 43;
            this.radNuoc.TabStop = true;
            this.radNuoc.Text = "Nước";
            this.radNuoc.UseVisualStyleBackColor = true;
            this.radNuoc.CheckedChanged += new System.EventHandler(this.radNuoc_CheckedChanged);
            // 
            // FrmThongKeTheoMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1676, 833);
            this.Controls.Add(this.dgvDSMonAn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmThongKeTheoMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmThongKeTheoMon";
            this.Load += new System.EventHandler(this.FrmThongKeTheoMon_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMonAn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.RadioButton radHaiSan;
        private System.Windows.Forms.RadioButton radRauCu;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cbbTimKiem;
        private System.Windows.Forms.RadioButton radThit;
        private System.Windows.Forms.RadioButton radTatCa;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDSMonAn;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RadioButton radNuoc;
    }
}