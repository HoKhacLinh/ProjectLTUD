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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        DATAPROCESSING DP = new DATAPROCESSING();
        //kiểm tra đăng nhập
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" || txtTK.Text == "")
                MessageBox.Show("vui lòng nhập đầy đủ tài khoản và mật khẩu");
            else
            {
                String role = DP.login(txtTK.Text, txtPassword.Text);
                if (role=="ADMIN")
                {
                    frmChangePassword.TK = txtTK.Text;
                    frmChangePassword.MK = txtPassword.Text;
                    frmDanhMucKhachHang.role= frmKhoHang.Role = frmHoaDon.TKDN = "ADMIN";
                    this.Hide();
                    frmHomeAdmin hh = new frmHomeAdmin();                    
                    hh.ShowDialog();
                    this.Close();
                   
                }
                else if(role == "NV")
                {
                    frmChangePassword.MK = txtPassword.Text;
                    frmChangePassword.TK = txtTK.Text;
                    frmDanhMucKhachHang.role = frmKhoHang.Role = frmHoaDon.TKDN = "NV";
                    frmBanHang.MaNV = txtTK.Text;
                    this.Hide();
                    frmHomeEmp hh = new frmHomeEmp();
                    hh.ShowDialog();
                    this.Close();                    
                }
                else
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
            }
        }
        //sự kiện enter
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
        //thoát form
        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Thoát?", "", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == DR)
                this.Close();
        }
    }
}
