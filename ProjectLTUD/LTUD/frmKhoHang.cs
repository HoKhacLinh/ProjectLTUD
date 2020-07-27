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
    public partial class frmKhoHang : Form
    {
        public static String Role = String.Empty;
        public frmKhoHang()
        {
            InitializeComponent();
        }
        DATAPROCESSING DP = new DATAPROCESSING();
        //thêm hàng 
        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            if (txtDGB.Text == "" || txtDGN.Text == "" || txtGhichu.Text == "" || txtMaHang.Text == "" || txtTenHang.Text == "")
                MessageBox.Show("vui lòng nhập đầy đủ thông tin");
            else
            {
                if (DP.EditHangHoa("sp_insertDataFromHangHoa", txtMaHang.Text, txtTenHang.Text, numericUpDownSL.Value.ToString(), txtDGN.Text, txtDGB.Text, txtGhichu.Text) != -1)
                {
                    MessageBox.Show("successfully");
                    dtgvHang.DataSource = DP.GetDataFrom("sp_getDataFromHangHoa");
                }
                }
        }
        //xóa hàng
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvHang.CurrentRow == null)
                MessageBox.Show("chưa chọn sản phẩm cần xóa");
            else
            {
                DP.DelFrom("sp_deleteDataFromHangHoa", dtgvHang.CurrentRow.Cells[0].Value.ToString());
                dtgvHang.DataSource = DP.GetDataFrom("sp_getDataFromHangHoa");
            }
        }
        //sửa hàng
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtDGB.Text == "" || txtDGN.Text == "" || txtGhichu.Text == "" || txtMaHang.Text == "" || txtTenHang.Text == "")
                MessageBox.Show("vui lòng nhập đầy đủ thông tin");
            else
            {
                if (DP.EditHangHoa("sp_updateDataFromHangHoa", txtMaHang.Text, txtTenHang.Text, numericUpDownSL.Value.ToString(), txtDGN.Text, txtDGB.Text, txtGhichu.Text) != -1)
                {
                    MessageBox.Show("successfully");
                    dtgvHang.DataSource = DP.GetDataFrom("sp_getDataFromHangHoa");
                }
            }
        }
        //xóa dữ liệu textbox
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtGhichu.Text = txtDGB.Text = txtDGN.Text = txtMaHang.Text = txtTenHang.Text = "";           
        }
        //thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (Role == "ADMIN")
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
        private void frmKhoHang_Load(object sender, EventArgs e)
        {
            dtgvHang.DataSource = DP.GetDataFrom("sp_getDataFromHangHoa");
        }
        //lấy dữ liệu hàng hóa
        private void dtgvHang_Click(object sender, EventArgs e)
        {
            txtMaHang.Text = dtgvHang.CurrentRow.Cells[0].Value.ToString();
            txtTenHang.Text = dtgvHang.CurrentRow.Cells[1].Value.ToString();
            numericUpDownSL.Text = dtgvHang.CurrentRow.Cells[2].Value.ToString();
            txtDGN.Text = dtgvHang.CurrentRow.Cells[3].Value.ToString();
            txtDGB.Text = dtgvHang.CurrentRow.Cells[4].Value.ToString();
            txtGhichu.Text = dtgvHang.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
                MessageBox.Show("vui lòng nhập dữ liệu vào ô tìm kiếm, ok?");
            else
            {
                if (combbSearchMode.SelectedItem == null || combbSearchMode.SelectedIndex == 0)
                    dtgvHang.DataSource = DP.SearchByKey("sp_findDataByMaFromHangHoa", txtTimKiem.Text);
                else
                    dtgvHang.DataSource = DP.SearchByKey("sp_findDataByTenFromHangHoa", txtTimKiem.Text);
                if (dtgvHang.Rows.Count == 0)
                {
                    dtgvHang.DataSource = DP.GetDataFrom("sp_getDataFromHangHoa");
                    MessageBox.Show("not found");
                }
                

            }
        }
    }
}
