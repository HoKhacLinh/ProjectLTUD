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
    public partial class frmChangePassword : Form
    {
        public static String TK;
        public static String MK;
        public frmChangePassword()
        {
            InitializeComponent();
        }
        DATAPROCESSING DP = new DATAPROCESSING();
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMKC.Text == MK)
            {
                if (txtMK1.Text == txtPasss.Text)
                {
                    DP.chagePassAdmin(TK, txtMK1.Text);
                    MessageBox.Show("đổi mật khẩu thành công");
                    frmLogin frm = new frmLogin();
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("hai mật khẩu không trùng nhau");
            }
            else
                MessageBox.Show("mật khẩu cũ không chính xác");
        }
    }

      
}
