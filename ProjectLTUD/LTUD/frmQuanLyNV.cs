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
    public partial class frmQuanLyNV : Form
    {
        public frmQuanLyNV()
        {
            InitializeComponent();
        }
        DATAPROCESSING DP = new DATAPROCESSING();
        private void frmQuanLyNV_Load(object sender, EventArgs e)
        {
            grdNhanVien.DataSource = DP.GetDataFrom("sp_getDataFromTaiKhoan");
        }
        //thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmHomeAdmin frm = new frmHomeAdmin();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
        //sửa nhân viên
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "" || txtDienThoai.Text == "" || txtHoTen.Text == "" || txtMaNV.Text == "" || txtMK.Text == "" ||
                txtNgaySinh.Text == "" || rbBNam.Checked == false && rdBNu.Checked == false)
                MessageBox.Show("vui lòng cung cấp đầy đủ thông tin");
            else
            {
                String GT;
                if (rbBNam.Checked == true)
                    GT = "NAM";
                else
                    GT = "NU";
                if (DP.Edit("sp_updateDataFromTaiKhoan", txtMaNV.Text, "NV", txtHoTen.Text,
                    txtMK.Text, GT, txtDienThoai.Text, txtDiaChi.Text, txtNgaySinh.Text) != -1)
                {
                    MessageBox.Show("updated");
                    grdNhanVien.DataSource = DP.GetDataFrom("sp_getDataFromTaiKhoan");

                }
                else
                    MessageBox.Show("Lỗi");
            }
        }
        //xóa nhân viên
        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (grdNhanVien.CurrentRow==null)
                MessageBox.Show("chưa chọn nhân viên cần xóa");
            else
           {  
                if(DP.DelFrom("sp_deleteDataFromTaiKhoan", grdNhanVien.CurrentRow.Cells[0].Value.ToString())!=-1)
                    grdNhanVien.DataSource = DP.GetDataFrom("sp_getDataFromTaiKhoan");
            }
        }
        //thêm nhân viên
        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "" || txtDienThoai.Text == "" || txtHoTen.Text == "" || txtMaNV.Text == "" || txtMK.Text == "" ||
                 txtNgaySinh.Text == "" ||( rbBNam.Checked == false && rdBNu.Checked == false))
                MessageBox.Show("vui lòng cung cấp đầy đủ thông tin");
            else
            {
                String GT;
                if (rbBNam.Checked == true)
                    GT = "NAM";
                else
                    GT = "NU";
                if (DP.Edit("sp_insertDataFromTaiKhoan", txtMaNV.Text, "NV", txtHoTen.Text,
                    txtMK.Text, GT, txtDienThoai.Text, txtDiaChi.Text, txtNgaySinh.Text) != -1)
                {
                    MessageBox.Show("Added");
                    grdNhanVien.DataSource = DP.GetDataFrom("sp_getDataFromTaiKhoan");

                }              
            }
        }
        //lấy dữ liệu nhân viên
        private void grdNhanVien_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = grdNhanVien.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = grdNhanVien.CurrentRow.Cells[1].Value.ToString();
            txtMK.Text = grdNhanVien.CurrentRow.Cells[3].Value.ToString();
            if (grdNhanVien.CurrentRow.Cells[4].Value.ToString() == "NAM")
            {
                rbBNam.Checked = true;
            }
            else
            {
                rbBNam.Checked = false;
                rdBNu.Checked = true;
            }
               

            txtDiaChi.Text = grdNhanVien.CurrentRow.Cells[5].Value.ToString();
            txtDienThoai.Text = grdNhanVien.CurrentRow.Cells[6].Value.ToString();
            txtNgaySinh.Text = grdNhanVien.CurrentRow.Cells[7].Value.ToString();
        }
        //tìm hóa đơn theo mã và tên, nếu không chọn gì mặc định tìm theo mã
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
                MessageBox.Show("vui lòng nhập dữ liệu vào ô tìm kiếm, ok?");
            {
                if (combbSearchMode.SelectedItem == null || combbSearchMode.SelectedIndex == 0)
                    grdNhanVien.DataSource = DP.SearchByKey("sp_findDataByMaTKFromTaiKhoan", txtTimKiem.Text);
                else
                    grdNhanVien.DataSource = DP.SearchByKey("sp_findDataByTenTKFromTaiKhoan", txtTimKiem.Text);               
                if(grdNhanVien.Rows.Count==0)
                    grdNhanVien.DataSource = DP.GetDataFrom("sp_getDataFromTaiKhoan");
            }
        }

   
    }
}
