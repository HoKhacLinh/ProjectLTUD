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
    public partial class frmDanhMucKhachHang : Form
    {
        //biến tính lấy dữ liệu từ form đăng nhập
        public static String role = String.Empty;
        public frmDanhMucKhachHang()
        {
            InitializeComponent();
        }
        DATAPROCESSING DP = new DATAPROCESSING();
        private void frmDanhMucKhachHang_Load(object sender, EventArgs e)
        {
            dtgvKhachHang.DataSource = DP.GetDataFrom("sp_getDataFromKhachHang");
        }
        //thêm khách hàng
        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            if ((txtMaKH.Text == "" || txtTenKH.Text == "" || txtDiaChi.Text == "" || txtPhone.Text == ""))
                MessageBox.Show
                    ("vui lòng nhập đầy đủ thông tin");
            else
            {
                if (DP.EditKhachHang("sp_insertDataFromKhachHang", txtMaKH.Text, txtTenKH.Text, txtDiaChi.Text, txtPhone.Text, txtDiemThuong.Text) != -1)
                    MessageBox.Show("successfully");
            }
        }
        //xóa khách hàng
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvKhachHang.CurrentRow == null)
                MessageBox.Show("chưa chọn khách hàng cần xóa");
            else
            {
                DP.DelFrom("sp_deleteDataFromKhachHang", dtgvKhachHang.CurrentRow.Cells[0].Value.ToString());
                dtgvKhachHang.DataSource = DP.GetDataFrom("sp_getDataFromKhachHang");
            }
        }
        //sửa khách hàng
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if ((txtMaKH.Text == "" || txtTenKH.Text == "" || txtDiaChi.Text == "" || txtPhone.Text == ""))
                MessageBox.Show
                    ("vui lòng nhập đầy đủ thông tin");
            else
            {
                if (DP.EditKhachHang("sp_updateDataFromKhachHang", txtMaKH.Text, txtTenKH.Text, txtDiaChi.Text, txtPhone.Text, txtDiemThuong.Text) != -1)
                    MessageBox.Show("successfully");
            }
        }
        //thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (role == "ADMIN")
            {
                frmHomeAdmin frm = new frmHomeAdmin();
                frm.ShowDialog();
            }
            else
            {
                frmHomeEmp frm = new frmHomeEmp();
                frm.ShowDialog();
            }
            this.Close();
        }
        //lây dữ liệu khách hàng
        private void dtgvKhachHang_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = dtgvKhachHang.CurrentRow.Cells[0].Value.ToString();
            txtTenKH.Text = dtgvKhachHang.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dtgvKhachHang.CurrentRow.Cells[2].Value.ToString();
            txtPhone.Text = dtgvKhachHang.CurrentRow.Cells[3].Value.ToString();
            txtDiemThuong.Text = dtgvKhachHang.CurrentRow.Cells[4].Value.ToString();
        }
        //tìm kiêm theo tên và theo mã KH
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbbSearchModeKH.Text == "" || cbbSearchModeKH.SelectedIndex == 0)
                dtgvKhachHang.DataSource = DP.SearchByKey("sp_findDataByMaFromKhachHang", txtTimKiemKH.Text);
            else
                dtgvKhachHang.DataSource = DP.SearchByKey("sp_findDataByTenFromKhachHang", txtTimKiemKH.Text);
            if (dtgvKhachHang.Rows.Count == 0)
            {
                MessageBox.Show("not found");
                dtgvKhachHang.DataSource = DP.GetDataFrom("sp_getDataFromKhachHang");
            }
        }
    }
}
