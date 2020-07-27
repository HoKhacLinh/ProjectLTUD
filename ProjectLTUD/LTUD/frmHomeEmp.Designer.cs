namespace LTUD
{
    partial class frmHomeEmp
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.lblHoaDonBanHang = new System.Windows.Forms.Label();
            this.btnKhoSach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(289, 193);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(70, 23);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Đăng Xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Location = new System.Drawing.Point(184, 57);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(84, 71);
            this.btnHoaDon.TabIndex = 12;
            this.btnHoaDon.Text = "Hóa Đơn";
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Location = new System.Drawing.Point(94, 57);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(84, 71);
            this.btnKhachHang.TabIndex = 11;
            this.btnKhachHang.Text = "Khách Hàng";
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.Location = new System.Drawing.Point(4, 57);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(84, 71);
            this.btnBanHang.TabIndex = 10;
            this.btnBanHang.Text = "Bán Hàng";
            this.btnBanHang.UseVisualStyleBackColor = true;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // lblHoaDonBanHang
            // 
            this.lblHoaDonBanHang.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lblHoaDonBanHang.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoaDonBanHang.Location = new System.Drawing.Point(0, 0);
            this.lblHoaDonBanHang.Name = "lblHoaDonBanHang";
            this.lblHoaDonBanHang.Size = new System.Drawing.Size(357, 54);
            this.lblHoaDonBanHang.TabIndex = 9;
            this.lblHoaDonBanHang.Text = "Trang Chủ";
            this.lblHoaDonBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKhoSach
            // 
            this.btnKhoSach.Location = new System.Drawing.Point(274, 57);
            this.btnKhoSach.Name = "btnKhoSach";
            this.btnKhoSach.Size = new System.Drawing.Size(84, 71);
            this.btnKhoSach.TabIndex = 14;
            this.btnKhoSach.Text = "Kho Hàng";
            this.btnKhoSach.UseVisualStyleBackColor = true;
            this.btnKhoSach.Click += new System.EventHandler(this.btnKhoSach_Click);
            // 
            // frmHomeEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(357, 216);
            this.Controls.Add(this.btnKhoSach);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnHoaDon);
            this.Controls.Add(this.btnKhachHang);
            this.Controls.Add(this.btnBanHang);
            this.Controls.Add(this.lblHoaDonBanHang);
            this.Name = "frmHomeEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Label lblHoaDonBanHang;
        private System.Windows.Forms.Button btnKhoSach;
    }
}