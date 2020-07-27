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
    public partial class frmChiTietHoaDon : Form
    {
        DATAPROCESSING DP = new DATAPROCESSING();
        //biến static lấy dữ liệu từ form đăng nhập
        public static String MaHD=String.Empty;
        public static String MaKH = String.Empty;
        public static String MaNV = String.Empty;
        public static String NgayBan = String.Empty;
        public frmChiTietHoaDon()
        {
            InitializeComponent();
            
        }
        private int thanhTien, tongTien;
       //tính tổng tiền
        public String resultTongTien()
        {
            int result = 0;
            for(int i = 0; i < dgvHoaDon.Rows.Count; i++)
            {
                result += int.Parse(dgvHoaDon.Rows[i].Cells[4].Value.ToString());
            }            
            return result.ToString();
        }
        //lấy thông tin 
        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable tableKH = new DataTable();
                dgvHoaDon.DataSource = DP.getCTHDByMaHD(MaHD);
                dgvHoaDon.ReadOnly = true;
                if (MaKH != "")
                {
                     tableKH = DP.getTableByMa("getKHByMaKH", MaKH);
                    txtMaKH.Text = tableKH.Rows[0].ItemArray[0].ToString();
                    txtTenKH.Text = tableKH.Rows[0].ItemArray[1].ToString();
                    txtDiaChi.Text = tableKH.Rows[0].ItemArray[2].ToString();
                    txtPhone.Text = tableKH.Rows[0].ItemArray[3].ToString();
                }
                tableKH = DP.getTableByMa("getNVByMaNV", MaNV);
                txtMaNV.Text = tableKH.Rows[0].ItemArray[0].ToString();
                txtTenNV.Text = tableKH.Rows[0].ItemArray[1].ToString();
                txtNgayLap.Text = NgayBan;
                txtMaHD.Text = dgvHoaDon.Rows[0].Cells[0].Value.ToString();
                txtTongTien.Text = resultTongTien();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        //event changes value số lượng
        private void NUSoLuong_ValueChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = dgvHoaDon.CurrentRow.Cells[3].Value.ToString();
            thanhTien = thanhTien = int.Parse(txtDonGia.Text) * int.Parse(NUSoLuong.Value.ToString());
            txtThanhTien.Text = thanhTien.ToString();
            dgvHoaDon.CurrentRow.Cells[4].Value = thanhTien;
            txtTongTien.Text = resultTongTien();
        }
        //save
        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            if (DP.EditCTHD("sp_updateDataFromCTHD", txtMaHD.Text, txtMaHang.Text, NUSoLuong.Value.ToString(), txtDonGia.Text, txtThanhTien.Text) != -1
                && DP.UpdateTongTien(txtMaHD.Text, txtTongTien.Text) != -1)
            {
                MessageBox.Show("Successfully");
                dgvHoaDon.DataSource = DP.getCTHDByMaHD(MaHD); }
        }
        //thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmHoaDon frm= new frmHoaDon();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
        //xóa sp
        private void btnHuySP_Click(object sender, EventArgs e)
        {            
            if (dgvHoaDon.CurrentRow==null)
                MessageBox.Show("chưa chọn hóa hóa đơn cần xóa");
            else
            {
                if (DP.DelFromCTHD(MaHD, dgvHoaDon.CurrentRow.Cells[1].Value.ToString()) != -1)
                    dgvHoaDon.DataSource = DP.getCTHDByMaHD(MaHD);
                else
                    MessageBox.Show("Lỗi");
                txtTongTien.Text = resultTongTien();

            }
        }
        //tìm sản phẩm theo mã sản phẩm
        private void btnTimHD_Click(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = DP.SearchByKey("sp_findByMaSPDataFromCTHD", txtTimKiem.Text);
            if (dgvHoaDon.Rows.Count == 0)
            {
                dgvHoaDon.DataSource = DP.getCTHDByMaHD(MaHD);
                MessageBox.Show("không tìm thấy kết quả nào cho '" + txtTimKiem.Text + "'");
            }
        }
        
        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            if(txtTimKiem.Text== "nhập vào mã sản phẩm")
            txtTimKiem.Text = "";
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
                txtTimKiem.Text = "nhập vào mã sản phẩm";
        }
        //load lại data
        private void btnReload_Click(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = DP.getCTHDByMaHD(MaHD);
        }
        //chọn hóa đơn
        private void dgvHoaDon_Click(object sender, EventArgs e)
        {
            
            txtMaHang.Text = dgvHoaDon.CurrentRow.Cells[1].Value.ToString();
            NUSoLuong.Value =int.Parse(dgvHoaDon.CurrentRow.Cells[2].Value.ToString());
            txtDonGia.Text = dgvHoaDon.CurrentRow.Cells[3].Value.ToString();
            txtThanhTien.Text = dgvHoaDon.CurrentRow.Cells[4].Value.ToString();
            DataTable DT= DP.getTableByMa("getSPByMaSP", txtMaHang.Text);
            txtTenHang.Text = DT.Rows[0].ItemArray[1].ToString();
        }
    }
}
