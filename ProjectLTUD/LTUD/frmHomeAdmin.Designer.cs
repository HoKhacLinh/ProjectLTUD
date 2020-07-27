namespace LTUD
{
    partial class frmHomeAdmin
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
            this.lblHoaDonBanHang = new System.Windows.Forms.Label();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnKhoHang = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHoaDonBanHang
            // 
            this.lblHoaDonBanHang.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lblHoaDonBanHang.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoaDonBanHang.Location = new System.Drawing.Point(0, 0);
            this.lblHoaDonBanHang.Name = "lblHoaDonBanHang";
            this.lblHoaDonBanHang.Size = new System.Drawing.Size(473, 54);
            this.lblHoaDonBanHang.TabIndex = 4;
            this.lblHoaDonBanHang.Text = "Trang Chủ";
            this.lblHoaDonBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHoaDon.Location = new System.Drawing.Point(5, 54);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(84, 71);
            this.btnHoaDon.TabIndex = 5;
            this.btnHoaDon.Text = " Hóa Đơn";
            this.btnHoaDon.UseVisualStyleBackColor = false;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnKhoHang
            // 
            this.btnKhoHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnKhoHang.Location = new System.Drawing.Point(95, 54);
            this.btnKhoHang.Name = "btnKhoHang";
            this.btnKhoHang.Size = new System.Drawing.Size(84, 71);
            this.btnKhoHang.TabIndex = 7;
            this.btnKhoHang.Text = "Kho Hàng";
            this.btnKhoHang.UseVisualStyleBackColor = false;
            this.btnKhoHang.Click += new System.EventHandler(this.btnKhoHang_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(291, 224);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Đăng Xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnKhachHang.Location = new System.Drawing.Point(183, 54);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(84, 71);
            this.btnKhachHang.TabIndex = 9;
            this.btnKhachHang.Text = "Khách Hàng";
            this.btnKhachHang.UseVisualStyleBackColor = false;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(273, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 71);
            this.button1.TabIndex = 10;
            this.button1.Text = "Nhân Viên";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Location = new System.Drawing.Point(5, 224);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(75, 23);
            this.btnDoiMK.TabIndex = 11;
            this.btnDoiMK.Text = "Đổi mật khẩu";
            this.btnDoiMK.UseVisualStyleBackColor = true;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // frmHomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(365, 247);
            this.Controls.Add(this.btnDoiMK);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnKhachHang);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnKhoHang);
            this.Controls.Add(this.btnHoaDon);
            this.Controls.Add(this.lblHoaDonBanHang);
            this.Name = "frmHomeAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHoaDonBanHang;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnKhoHang;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDoiMK;
    }
}