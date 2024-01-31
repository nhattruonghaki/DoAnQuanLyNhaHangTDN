namespace PM_QuanLy_NhaHang_TDN
{
    partial class FrmChonBaoCaoTheoMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChonBaoCaoTheoMon));
            this.radNhomTheoLoai = new System.Windows.Forms.RadioButton();
            this.cbbTheoLoai = new System.Windows.Forms.ComboBox();
            this.radTheoLoai = new System.Windows.Forms.RadioButton();
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            this.radTatCa = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radNhomTheoLoai
            // 
            this.radNhomTheoLoai.AutoSize = true;
            this.radNhomTheoLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNhomTheoLoai.Location = new System.Drawing.Point(24, 69);
            this.radNhomTheoLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radNhomTheoLoai.Name = "radNhomTheoLoai";
            this.radNhomTheoLoai.Size = new System.Drawing.Size(197, 33);
            this.radNhomTheoLoai.TabIndex = 9;
            this.radNhomTheoLoai.TabStop = true;
            this.radNhomTheoLoai.Text = "Nhóm theo loại";
            this.radNhomTheoLoai.UseVisualStyleBackColor = true;
            // 
            // cbbTheoLoai
            // 
            this.cbbTheoLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTheoLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTheoLoai.FormattingEnabled = true;
            this.cbbTheoLoai.Items.AddRange(new object[] {
            "Thịt",
            "Hải sản",
            "Rau Củ"});
            this.cbbTheoLoai.Location = new System.Drawing.Point(240, 25);
            this.cbbTheoLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbTheoLoai.Name = "cbbTheoLoai";
            this.cbbTheoLoai.Size = new System.Drawing.Size(188, 37);
            this.cbbTheoLoai.TabIndex = 8;
            // 
            // radTheoLoai
            // 
            this.radTheoLoai.AutoSize = true;
            this.radTheoLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTheoLoai.Location = new System.Drawing.Point(24, 25);
            this.radTheoLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radTheoLoai.Name = "radTheoLoai";
            this.radTheoLoai.Size = new System.Drawing.Size(136, 33);
            this.radTheoLoai.TabIndex = 7;
            this.radTheoLoai.TabStop = true;
            this.radTheoLoai.Text = "Theo loại";
            this.radTheoLoai.UseVisualStyleBackColor = true;
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.BackColor = System.Drawing.Color.GreenYellow;
            this.btnXemBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemBaoCao.Location = new System.Drawing.Point(240, 114);
            this.btnXemBaoCao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(188, 52);
            this.btnXemBaoCao.TabIndex = 6;
            this.btnXemBaoCao.Text = "Xem báo cáo";
            this.btnXemBaoCao.UseVisualStyleBackColor = false;
            this.btnXemBaoCao.Click += new System.EventHandler(this.btnXemBaoCao_Click);
            // 
            // radTatCa
            // 
            this.radTatCa.AutoSize = true;
            this.radTatCa.Checked = true;
            this.radTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTatCa.Location = new System.Drawing.Point(24, 124);
            this.radTatCa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radTatCa.Name = "radTatCa";
            this.radTatCa.Size = new System.Drawing.Size(100, 33);
            this.radTatCa.TabIndex = 5;
            this.radTatCa.TabStop = true;
            this.radTatCa.Text = "Tất cả";
            this.radTatCa.UseVisualStyleBackColor = true;
            // 
            // FrmChonBaoCaoTheoMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(440, 202);
            this.Controls.Add(this.radNhomTheoLoai);
            this.Controls.Add(this.cbbTheoLoai);
            this.Controls.Add(this.radTheoLoai);
            this.Controls.Add(this.btnXemBaoCao);
            this.Controls.Add(this.radTatCa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChonBaoCaoTheoMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn Báo Cáo Theo Món";
            this.Load += new System.EventHandler(this.FrmChonBaoCaoTheoMon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radNhomTheoLoai;
        private System.Windows.Forms.ComboBox cbbTheoLoai;
        private System.Windows.Forms.RadioButton radTheoLoai;
        private System.Windows.Forms.Button btnXemBaoCao;
        private System.Windows.Forms.RadioButton radTatCa;
    }
}