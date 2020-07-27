namespace LTUD
{
    partial class frmKhoHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhoHang));
            this.txtDGN = new System.Windows.Forms.TextBox();
            this.btnThemmoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.dtgvHang = new System.Windows.Forms.DataGridView();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.lblTenKhach = new System.Windows.Forms.Label();
            this.lblmaKH = new System.Windows.Forms.Label();
            this.lblQuanLyNhanVien = new System.Windows.Forms.Label();
            this.txtDGB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownSL = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.combbSearchMode = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSL)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDGN
            // 
            this.txtDGN.Location = new System.Drawing.Point(385, 97);
            this.txtDGN.Name = "txtDGN";
            this.txtDGN.Size = new System.Drawing.Size(83, 20);
            this.txtDGN.TabIndex = 26;
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemmoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThemmoi.Image")));
            this.btnThemmoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemmoi.Location = new System.Drawing.Point(5, 352);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnThemmoi.Size = new System.Drawing.Size(125, 33);
            this.btnThemmoi.TabIndex = 15;
            this.btnThemmoi.Text = "Thêm Mới";
            this.btnThemmoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemmoi.UseVisualStyleBackColor = true;
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(608, 351);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(84, 33);
            this.btnThoat.TabIndex = 25;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(270, 352);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 33);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(153, 352);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 33);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(69, 103);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(111, 20);
            this.txtTenHang.TabIndex = 13;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(69, 56);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(111, 20);
            this.txtMaHang.TabIndex = 12;
            // 
            // dtgvHang
            // 
            this.dtgvHang.AllowUserToAddRows = false;
            this.dtgvHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHang.Location = new System.Drawing.Point(14, 135);
            this.dtgvHang.Name = "dtgvHang";
            this.dtgvHang.ReadOnly = true;
            this.dtgvHang.RowHeadersVisible = false;
            this.dtgvHang.Size = new System.Drawing.Size(678, 180);
            this.dtgvHang.TabIndex = 24;
            this.dtgvHang.Click += new System.EventHandler(this.dtgvHang_Click);
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblDiaChi.Location = new System.Drawing.Point(186, 62);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(61, 14);
            this.lblDiaChi.TabIndex = 19;
            this.lblDiaChi.Text = "Số Lượng";
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDienThoai.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblDienThoai.Location = new System.Drawing.Point(349, 100);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(30, 14);
            this.lblDienThoai.TabIndex = 20;
            this.lblDienThoai.Text = "ĐGN";
            // 
            // lblTenKhach
            // 
            this.lblTenKhach.AutoSize = true;
            this.lblTenKhach.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKhach.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblTenKhach.Location = new System.Drawing.Point(4, 109);
            this.lblTenKhach.Name = "lblTenKhach";
            this.lblTenKhach.Size = new System.Drawing.Size(67, 14);
            this.lblTenKhach.TabIndex = 21;
            this.lblTenKhach.Text = "Tên Hàng : ";
            // 
            // lblmaKH
            // 
            this.lblmaKH.AutoSize = true;
            this.lblmaKH.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaKH.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblmaKH.Location = new System.Drawing.Point(9, 59);
            this.lblmaKH.Name = "lblmaKH";
            this.lblmaKH.Size = new System.Drawing.Size(65, 14);
            this.lblmaKH.TabIndex = 18;
            this.lblmaKH.Text = "Mã  Hàng : ";
            // 
            // lblQuanLyNhanVien
            // 
            this.lblQuanLyNhanVien.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lblQuanLyNhanVien.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyNhanVien.Location = new System.Drawing.Point(0, -1);
            this.lblQuanLyNhanVien.Name = "lblQuanLyNhanVien";
            this.lblQuanLyNhanVien.Size = new System.Drawing.Size(705, 49);
            this.lblQuanLyNhanVien.TabIndex = 17;
            this.lblQuanLyNhanVien.Text = "KHO HÀNG";
            this.lblQuanLyNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDGB
            // 
            this.txtDGB.Location = new System.Drawing.Point(253, 97);
            this.txtDGB.Name = "txtDGB";
            this.txtDGB.Size = new System.Drawing.Size(83, 20);
            this.txtDGB.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(186, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 14);
            this.label2.TabIndex = 29;
            this.label2.Text = "ĐGB";
            // 
            // numericUpDownSL
            // 
            this.numericUpDownSL.Location = new System.Drawing.Point(253, 56);
            this.numericUpDownSL.Name = "numericUpDownSL";
            this.numericUpDownSL.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownSL.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(412, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 14);
            this.label3.TabIndex = 33;
            this.label3.Text = "Ghi chú";
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(474, 56);
            this.txtGhichu.Multiline = true;
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(222, 61);
            this.txtGhichu.TabIndex = 34;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(253, 321);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 37;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // combbSearchMode
            // 
            this.combbSearchMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combbSearchMode.FormattingEnabled = true;
            this.combbSearchMode.Items.AddRange(new object[] {
            "Mã Hàng",
            "Tên Hàng"});
            this.combbSearchMode.Location = new System.Drawing.Point(12, 322);
            this.combbSearchMode.Name = "combbSearchMode";
            this.combbSearchMode.Size = new System.Drawing.Size(72, 21);
            this.combbSearchMode.TabIndex = 36;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(90, 321);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(157, 22);
            this.txtTimKiem.TabIndex = 35;
            // 
            // frmKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(708, 392);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.combbSearchMode);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.txtGhichu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownSL);
            this.Controls.Add(this.txtDGB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDGN);
            this.Controls.Add(this.btnThemmoi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.txtMaHang);
            this.Controls.Add(this.dtgvHang);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblDienThoai);
            this.Controls.Add(this.lblTenKhach);
            this.Controls.Add(this.lblmaKH);
            this.Controls.Add(this.lblQuanLyNhanVien);
            this.Name = "frmKhoHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kho Hàng";
            this.Load += new System.EventHandler(this.frmKhoHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDGN;
        private System.Windows.Forms.Button btnThemmoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.DataGridView dtgvHang;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Label lblTenKhach;
        private System.Windows.Forms.Label lblmaKH;
        private System.Windows.Forms.Label lblQuanLyNhanVien;
        private System.Windows.Forms.TextBox txtDGB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownSL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox combbSearchMode;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}