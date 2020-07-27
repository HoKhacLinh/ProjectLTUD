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
   
    public partial class frmHoaDon : Form
    {        
        DATAPROCESSING DP = new DATAPROCESSING();
        public static String TKDN = String.Empty;
        public frmHoaDon()
        {
            InitializeComponent();
        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                if (DP.GetDataFrom("sp_getDataFromHoaDon").Rows.Count == 0)
                {
                    MessageBox.Show("Chưa có hóa đơn nào cả");
                    this.Hide();
                    if (TKDN == "ADMIN")
                    {
                        frmHomeAdmin frm = new frmHomeAdmin();
                        frm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        frmHomeEmp frm = new frmHomeEmp();
                        frm.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    dtgvTimHoaDon.DataSource = DP.GetDataFrom("sp_getDataFromHoaDon");
                    dtgvTimHoaDon.ReadOnly = true;
                }
            }catch
            {
                
            }
        }   
        //  thoát
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (TKDN == "ADMIN")
            {
                frmHomeAdmin frm = new frmHomeAdmin();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                frmHomeEmp frm = new frmHomeEmp();
                frm.ShowDialog();
                this.Close();
            }
        }
        //xem thông tin chi tiết hóa đơn
        private void btnDetail_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmChiTietHoaDon CTHD = new frmChiTietHoaDon();
            frmChiTietHoaDon.MaHD = dtgvTimHoaDon.CurrentRow.Cells[0].Value.ToString();
            frmChiTietHoaDon.MaKH = dtgvTimHoaDon.CurrentRow.Cells[1].Value.ToString();
            frmChiTietHoaDon.MaNV = dtgvTimHoaDon.CurrentRow.Cells[2].Value.ToString();
            frmChiTietHoaDon.NgayBan = dtgvTimHoaDon.CurrentRow.Cells[3].Value.ToString();
            CTHD.ShowDialog();
            this.Close();
        }
        //xóa hóa đơn
        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            if (dtgvTimHoaDon.CurrentRow == null)
                MessageBox.Show("chưa chọn hóa đơn cần xóa");
            else
            {
                if (DP.DelFrom("sp_deleteDataFromHoaDon", dtgvTimHoaDon.CurrentRow.Cells[0].Value.ToString()) != -1)
                    dtgvTimHoaDon.DataSource = DP.GetDataFrom("sp_getDataFromHoaDon");
                else
                    MessageBox.Show("Lỗi");                    
            }
        }
        //tìm hóa đơn theo mã và tên, nếu không chọn gì mặc định tìm theo mã
        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "")
                MessageBox.Show("vui lòng nhập thông tin vào ô tìm kiếm, ok?");
            else
            {
                if (combbSearchMode.SelectedItem == null || combbSearchMode.SelectedIndex == 0)                
                    dtgvTimHoaDon.DataSource = DP.SearchByKey("sp_findDataByMaHDFromHoaDon", txttimkiem.Text);                                    
                else if(combbSearchMode.SelectedIndex == 1)                
                    dtgvTimHoaDon.DataSource = DP.SearchByKey("sp_findDataByMaKHFromHoaDon", txttimkiem.Text);
                else if (combbSearchMode.SelectedIndex == 2)
                    dtgvTimHoaDon.DataSource = DP.SearchByKey("sp_findDataByMaNVFromHoaDon", txttimkiem.Text);
                if (dtgvTimHoaDon.Rows.Count == 0)
                {
                    dtgvTimHoaDon.DataSource = DP.GetDataFrom("sp_getDataFromHoaDon");
                    MessageBox.Show("không tìm thấy kết quả cho '" + txttimkiem.Text + "'");
                }
            }
        }
        //load lại dữ liệu
        private void btnReload_Click(object sender, EventArgs e)
        {
            dtgvTimHoaDon.DataSource = DP.GetDataFrom("sp_getDataFromHoaDon");
        }

        
    }
}
