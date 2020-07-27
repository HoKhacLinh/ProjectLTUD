namespace LTUD
{
    partial class frmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.dtgvTimHoaDon = new System.Windows.Forms.DataGridView();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.lblTimKiemHoaDon = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.combbSearchMode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnXoaHD = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTimHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvTimHoaDon
            // 
            this.dtgvTimHoaDon.AllowUserToAddRows = false;
            this.dtgvTimHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTimHoaDon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtgvTimHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTimHoaDon.Location = new System.Drawing.Point(4, 92);
            this.dtgvTimHoaDon.MultiSelect = false;
            this.dtgvTimHoaDon.Name = "dtgvTimHoaDon";
            this.dtgvTimHoaDon.ReadOnly = true;
            this.dtgvTimHoaDon.RowHeadersVisible = false;
            this.dtgvTimHoaDon.Size = new System.Drawing.Size(563, 178);
            this.dtgvTimHoaDon.TabIndex = 1;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(471, 66);
            this.btnTim.Name = "btnTim";
            this.btnTim.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnTim.Size = new System.Drawing.Size(91, 21);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Tìm Kiếm";
            this.btnTim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.Red;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(478, 284);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(84, 33);
            this.btnDong.TabIndex = 8;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // lblTimKiemHoaDon
            // 
            this.lblTimKiemHoaDon.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lblTimKiemHoaDon.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiemHoaDon.Location = new System.Drawing.Point(3, 2);
            this.lblTimKiemHoaDon.Name = "lblTimKiemHoaDon";
            this.lblTimKiemHoaDon.Size = new System.Drawing.Size(568, 50);
            this.lblTimKiemHoaDon.TabIndex = 6;
            this.lblTimKiemHoaDon.Text = "Quản Lý Hóa Đơn";
            this.lblTimKiemHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(341, 67);
            this.txttimkiem.Multiline = true;
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(129, 22);
            this.txttimkiem.TabIndex = 9;
            // 
            // combbSearchMode
            // 
            this.combbSearchMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combbSearchMode.FormattingEnabled = true;
            this.combbSearchMode.Items.AddRange(new object[] {
            "Mã HD",
            "Mã KH",
            "Mã NV"});
            this.combbSearchMode.Location = new System.Drawing.Point(263, 67);
            this.combbSearchMode.Name = "combbSearchMode";
            this.combbSearchMode.Size = new System.Drawing.Size(76, 21);
            this.combbSearchMode.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Tìm kiếm theo";
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(8, 288);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(75, 23);
            this.btnDetail.TabIndex = 50;
            this.btnDetail.Text = "View Detail";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnXoaHD
            // 
            this.btnXoaHD.Location = new System.Drawing.Point(90, 287);
            this.btnXoaHD.Name = "btnXoaHD";
            this.btnXoaHD.Size = new System.Drawing.Size(75, 23);
            this.btnXoaHD.TabIndex = 51;
            this.btnXoaHD.Text = "Xóa HD";
            this.btnXoaHD.UseVisualStyleBackColor = true;
            this.btnXoaHD.Click += new System.EventHandler(this.btnXoaHD_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(172, 287);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 52;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(574, 323);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnXoaHD);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combbSearchMode);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.lblTimKiemHoaDon);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dtgvTimHoaDon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Hóa Đơn";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTimHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgvTimHoaDon;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label lblTimKiemHoaDon;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.ComboBox combbSearchMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnXoaHD;
        private System.Windows.Forms.Button btnReload;
    }
}