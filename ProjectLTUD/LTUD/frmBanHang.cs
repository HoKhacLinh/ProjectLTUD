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
    public partial class frmBanHang : Form
    {
      
        public static String MaNV = String.Empty;
        public String maHD = String.Empty;
        public frmBanHang()
        {
            InitializeComponent();
        }
        DATAPROCESSING DP = new DATAPROCESSING();
        private void frmBanHang_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime dat = DateTime.Now;
                DataGridviewSP.DataSource = DP.getDataForNV("getDataForNV");
                dataGridViewGioHang.Columns.Add("", "Mã hàng");
                dataGridViewGioHang.Columns.Add("", "Tên hàng");
                dataGridViewGioHang.Columns.Add("", "Giá");
                dataGridViewGioHang.Columns.Add("", "Số Lượng");
                DataTable tableNV = DP.getTableByMa("getNVByMaNV", MaNV);
                txtMaNV.Text = tableNV.Rows[0].ItemArray[0].ToString();
                txtTenNV.Text = tableNV.Rows[0].ItemArray[1].ToString();
                txtNgayBan.Text = dat.ToString("dd/MM/yyyy hh:mm:ss");
                dataGridViewKH.DataSource = DP.GetDataFrom("sp_getDataFromKhachHang");
                txtMaHD.Text = countHD();
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        public String countHD()            
        {  
            
            DataTable DT= DP.getDataForNV("sp_getDataFromHoaDon");
            if (DT.Rows.Count == 0) return "HD1";
            DT = DP.getLastMHD();           
            maHD = DT.Rows[0].ItemArray[0].ToString();
            String[] ar = maHD.Split('D');
            return  "HD" + ((int.Parse(ar[1])) + 1).ToString();       
            
        }
        //xử lý thanh toán
        private void txtThanhToan_Click(object sender, EventArgs e)
        {
            if (dataGridViewGioHang.Rows.Count == 1)
                MessageBox.Show("chưa có gì để tạo hóa đơn");
            else
            {
                for (int j = 0; j < dataGridViewGioHang.Rows.Count - 1; j++)
                {                  
                    for (int i = 0; i < DataGridviewSP.Rows.Count - 1; i++)
                    {
                        if (dataGridViewGioHang.Rows[j].Cells[0].Value.ToString() == DataGridviewSP.Rows[i].Cells[0].Value.ToString())
                        {          
                            //update số lượng hàng
                            int Qty = int.Parse(DataGridviewSP.Rows[i].Cells[2].Value.ToString()) - int.Parse(NumUSoLuong.Value.ToString());
                            DP.SetQty(DataGridviewSP.Rows[i].Cells[0].Value.ToString(), Qty);
                        }
                    }
                }
                //insert hóa đơn mới vào database
                if (txtMaKH.Text == "")
                    DP.InserHDWithouMaKH( txtMaHD.Text, txtMaNV.Text, txtNgayBan.Text, txtTongTien.Text);
                else
                    DP.EditHD("sp_insertDataFromHoaDon", txtMaHD.Text, txtMaKH.Text, txtMaNV.Text, txtNgayBan.Text, txtTongTien.Text);
                for (int i = 0; i < dataGridViewGioHang.Rows.Count - 1; i++)
                {
                    DP.EditCTHD("sp_insertDataFromCTHD", txtMaHD.Text,
                         dataGridViewGioHang.Rows[i].Cells[0].Value.ToString(),
                          dataGridViewGioHang.Rows[i].Cells[3].Value.ToString(),
                           dataGridViewGioHang.Rows[i].Cells[2].Value.ToString(),
                            txtThanhTien.Text);
                }
                //clear dữ liệu trên textbox...
                dataGridViewGioHang.Rows.Clear();
                txtMaHD.Text = countHD();
                clearMen();
                DataGridviewSP.DataSource = DP.GetDataFrom("sp_getDataFromHangHoa");
                dataGridViewKH.DataSource = DP.GetDataFrom("sp_getDataFromKhachHang");
                dataGridViewKH.DataSource = DP.GetDataFrom("sp_getDataFromKhachHang");
                MessageBox.Show("Đã  thanh toán");
                txtMaHD.Text = countHD();
            }
        }
        //hủy chọn khách khách hàng
        private void btnHuy_Click(object sender, EventArgs e)
        {

            txtThanhTien.Text = "";
            txtTongTien.Text = "";
            dataGridViewGioHang.Rows.Clear();
        }
        //đăng xuất
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
            this.Close();
        }
        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomeEmp homeE = new frmHomeEmp();
            homeE.ShowDialog();
            this.Close();
        }   
        //kiểm tra sự tồn tại của 1 sản phẩm trong giỏ hàng
        public bool TonTai(String maHang)
        {
            for (int i = 0; i < dataGridViewGioHang.Rows.Count - 1; i++)
            {
                if (maHang == dataGridViewGioHang.Rows[i].Cells[0].Value.ToString())
                    return true;
            }
            return false;
        }
        //thêm vào giỏ hàng
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (DataGridviewSP.CurrentRow == null)
                MessageBox.Show("Chưa chọn sản phẩm");
            else
            {
                if (int.Parse(DataGridviewSP.CurrentRow.Cells[3].Value.ToString()) <= 0)
                    MessageBox.Show("Sản phẩm đã bán hết");
                else
                {
                    if (TonTai(DataGridviewSP.CurrentRow.Cells[0].Value.ToString())==true)
                        MessageBox.Show("Sản phẩm đã tồn tại");
                    else
                    {
                        NumUSoLuong.Maximum = DP.getQty(DataGridviewSP.CurrentRow.Cells[0].Value.ToString());
                        DataGridViewRow row = (DataGridViewRow)dataGridViewGioHang.Rows[0].Clone();
                        row.Cells[0].Value = DataGridviewSP.CurrentRow.Cells[0].Value;
                        row.Cells[1].Value = DataGridviewSP.CurrentRow.Cells[1].Value;
                        row.Cells[2].Value = DataGridviewSP.CurrentRow.Cells[3].Value;
                        row.Cells[3].Value = "1";                        
                        dataGridViewGioHang.Rows.Add(row);
                        txtThanhTien.Text = dataGridViewGioHang.Rows[0].Cells[2].Value.ToString();
                        tongTien();
                    }
                  
                }
            }
                                  
        }
        //xóa khỏi giỏ hàng
        private void btnRomove_Click(object sender, EventArgs e)
        {
            if (dataGridViewGioHang.CurrentRow == null)
                MessageBox.Show("Chưa chọn sản phẩm nha");
            else
            {                      
                if (dataGridViewGioHang.CurrentRow != dataGridViewGioHang.Rows[dataGridViewGioHang.Rows.Count-1])
                    dataGridViewGioHang.Rows.RemoveAt(dataGridViewGioHang.CurrentRow.Index);
                else
                    MessageBox.Show("Giỏ hàng rỗng");
            }
            tongTien();
            if (dataGridViewGioHang.Rows.Count == 1)
                clearMen();
        }      
        //event changes số lượng
        private void NumUSoLuong_ValueChanged(object sender, EventArgs e)
        {
           
            if (dataGridViewGioHang.CurrentRow == null)
                MessageBox.Show("chưa chọn sản phẩm");
            else
            {                
                int value =int.Parse( NumUSoLuong.Value.ToString());
                dataGridViewGioHang.CurrentRow.Cells[3].Value = NumUSoLuong.Value.ToString();
                txtThanhTien.Text=(int.Parse(NumUSoLuong.Value.ToString())* int.Parse(dataGridViewGioHang.CurrentRow.Cells[2].Value.ToString())).ToString();                                              
            }
            tongTien();
        }
        //tính tổng tiền
        public void tongTien()
        {
            int thanhTien = 0;
            for (int i = 0; i < dataGridViewGioHang.Rows.Count - 1; i++)
            {

                thanhTien += int.Parse(dataGridViewGioHang.Rows[i].Cells[3].Value.ToString())
                    * int.Parse(dataGridViewGioHang.Rows[i].Cells[2].Value.ToString());
                txtTongTien.Text = thanhTien.ToString();
            }           
        }
        //chọn sản phẩm trong trong giỏ hàng
        private void dataGridViewGioHang_Click(object sender, EventArgs e)
        {
            if (dataGridViewGioHang.CurrentRow.Index != dataGridViewGioHang.Rows.Count - 1)
            {
                txtMaHang.Text = dataGridViewGioHang.CurrentRow.Cells[0].Value.ToString();
                txtTenHang.Text = dataGridViewGioHang.CurrentRow.Cells[1].Value.ToString();
                txtDonGia.Text = dataGridViewGioHang.CurrentRow.Cells[2].Value.ToString();
                tongTien();
                NumUSoLuong.Maximum = DP.getQty(dataGridViewGioHang.CurrentRow.Cells[0].Value.ToString());
            }
        }
        //chọn khách hàng trong danh sách khách hàng
        private void dataGridViewKH_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = dataGridViewKH.CurrentRow.Cells[0].Value.ToString();
            txtTenKH.Text = dataGridViewKH.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dataGridViewKH.CurrentRow.Cells[2].Value.ToString();
            txtDienThoai.Text = dataGridViewKH.CurrentRow.Cells[3].Value.ToString();
            
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = txtTenKH.Text = txtDiaChi.Text = txtDienThoai.Text = "";
        }
        public void clearMen()
        {
            txtThanhTien.Text = "";
            txtTongTien.Text = "";
            
            txtMaHang.Text = txtTenHang.Text = txtDonGia.Text = "";
            txtTongTien.Text = txtThanhTien.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbbSearchModeKH.Text == "" || cbbSearchModeKH.SelectedIndex == 0)
                dataGridViewKH.DataSource = DP.SearchByKey("sp_findDataByMaFromKhachHang", txtTimKiemKH.Text);
            else
                dataGridViewKH.DataSource=  DP.SearchByKey("sp_findDataByTenFromKhachHang", txtTimKiemKH.Text);
            if (dataGridViewKH.Rows.Count == 0)
            {
                MessageBox.Show("not found");
                dataGridViewKH.DataSource = DP.GetDataFrom("sp_getDataFromKhachHang");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbbSearchModeSP.Text == "" || cbbSearchModeSP.SelectedIndex == 0)
                DataGridviewSP.DataSource = DP.SearchByKey("sp_findDataByMaFromHangHoa", txtTimKiemKH.Text);
            else
                DataGridviewSP.DataSource = DP.SearchByKey("sp_findDataByTenFromHangHoa", txtTimKiemKH.Text);
            if (DataGridviewSP.Rows.Count == 0)
            {
                MessageBox.Show("not found");
                DataGridviewSP.DataSource = DP.GetDataFrom("sp_getDataFromHangHoa");
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            DataGridviewSP.DataSource = DP.GetDataFrom("sp_getDataFromHangHoa");
            dataGridViewKH.DataSource = DP.GetDataFrom("sp_getDataFromKhachHang");
            dataGridViewKH.DataSource = DP.GetDataFrom("sp_getDataFromKhachHang");
        }
    }
}
