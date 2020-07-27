using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTUD
{
    public partial class frmHomeAdmin : Form
    {
        public frmHomeAdmin()
        {            
            InitializeComponent();
        }
        //chuyển sang giao diện quản lý hóa đơn
        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            frmHoaDon hodon = new frmHoaDon();
            this.Hide();
            hodon.ShowDialog();
            this.Close();
        }
        //chuyển sang giao diện quản kho hàng
        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            frmKhoHang frm = new frmKhoHang();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
        //chuyển sang giao diện quản lý khách hàng
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            frmDanhMucKhachHang frm = new frmDanhMucKhachHang();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
        //Đăng xuất
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
            this.Close();
        }
        //chuyển sang giao diện quản lý nhân viên
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyNV frm = new frmQuanLyNV();
            frm.ShowDialog();
            this.Close();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
