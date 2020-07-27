using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Collections;
using System.Security.Cryptography;

namespace LTUD
{
    
    class DATAPROCESSING
    {
        SqlConnection connectDB = new SqlConnection("Data Source=DESKTOP-54IL4BE;Initial Catalog=QUANLYBH;Integrated Security=True");
        public DATAPROCESSING()
        {
            try
            {
                connectDB.Open();
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
                connectDB.Close();
            }
        }      
        //xử lý đăng nhập
        public String login(String userName, String password)
        {
            DataTable DT = new DataTable();
            SqlCommand cmd = new SqlCommand("getInfoTK", connectDB);
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maTK", userName);
                cmd.Parameters.AddWithValue("@matKhau", password);
                SqlDataReader SDR = cmd.ExecuteReader();                
                if (SDR.Read()==true)
                {
                    SDR.Close();
                    cmd = new SqlCommand("isAdmin", connectDB);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maTK", userName);
                    SDR = cmd.ExecuteReader();                    
                    if (SDR.Read() == true)
                        return "ADMIN";
                    return "NV";
                }
                SDR.Close();
            }
            catch (Exception ex)
            {                
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            return "F";
        }
        //lấy dữ liệu từ 1 table nào đó
        public DataTable GetDataFrom(String spName)
        {
            DataTable DT = new DataTable();
            try
            {               
                SqlCommand cmd = new SqlCommand(spName, connectDB);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter SA = new SqlDataAdapter(cmd);
                SA.Fill(DT);
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            return DT;
        }
        //lấy dữ liệu dành cho NhanVien
       public DataTable getDataForNV(String spName)
        {
            DataTable DT = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(spName, connectDB);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter SA = new SqlDataAdapter(cmd);
                SA.Fill(DT);
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            return DT;
        }
        //Lấy chi tiết hóa đơn bằng mã hóa đơn
        public DataTable getCTHDByMaHD(String maHD)
        {
            DataTable DT = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("getCTHDByMaHD", connectDB);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@keyword", maHD);
                SqlDataAdapter SA = new SqlDataAdapter(cmd);
                SA.Fill(DT);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            return DT;
        }
        //lấy 1 table nào đó bằng 1 mã/khóa chính
        public DataTable getTableByMa(String spName,String Keyword)
        {
            DataTable DT = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(spName, connectDB);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@keyword", Keyword);
                SqlDataAdapter SA = new SqlDataAdapter(cmd);
                SA.Fill(DT);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            return DT;
        }
        //Chỉnh sửa chi tiết hóa đơn(thêm, sửa)
        public int EditCTHD(String spName,  String maHD , String maHang , String soLuong , String donGia , String thanhTien )
        {
            float fDonGia = float.Parse(donGia);
            float fthanhTien = float.Parse(thanhTien);
            float fsoLuong= float.Parse(soLuong);
            SqlCommand cmd = new SqlCommand(spName, connectDB);
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maHD", maHD);
                cmd.Parameters.AddWithValue("@maHang", maHang);
                cmd.Parameters.AddWithValue("@soLuong", soLuong);
                cmd.Parameters.AddWithValue("@donGia", donGia);
                cmd.Parameters.AddWithValue("@thanhTien", thanhTien);
                if (cmd.ExecuteNonQuery() > 0)
                {                  
                    return 1;
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            return -1;
        }
        //cập nhật tổng tiền
        public int UpdateTongTien(String maHD, String tongTien)
        {
            
            SqlCommand cmd = new SqlCommand("UpdateTotalByMaHD", connectDB);
            try
            {
                float fTongTien = float.Parse(tongTien);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maHD", maHD);
                cmd.Parameters.AddWithValue("@TongTien", fTongTien);

                if (cmd.ExecuteNonQuery() > 0)                                   
                    return 1;                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            return -1;
        }
        //xóa dữ liệu từ 1 table nào đó bằng mã/khóa chính
        public int DelFrom(String spName, String keyword)
        {
            SqlCommand cmd = new SqlCommand(spName, connectDB);
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@keyword", keyword);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Deleted");
                    return 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            return -1;
        }
        //xóa chi tiết hóa đơn bằng mã hóa đơn và mã sản phẩm
        public int DelFromCTHD(String maHD, String maHang)
        {
            SqlCommand cmd = new SqlCommand("sp_deleteDataFromCTHD", connectDB);
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maHD", maHD);
                cmd.Parameters.AddWithValue("@maHang", maHang);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Deleted");
                    return 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            return -1;
        }
        //tìm kiếm trong 1 table nào đó bằng mã, tên....
        public DataTable SearchByKey(String spName, String keyword)
        {
            DataTable DT = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(spName, connectDB);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@keyword", keyword);
                SqlDataAdapter SA = new SqlDataAdapter(cmd);
                SA.Fill(DT);               
            }catch(Exception ex)
            {
                MessageBox.Show("lỗi: " + ex.Message);
            }
            return DT;
        }
        //chỉnh sửa tài khoản nhân viên (thêm, sửa)
        public int Edit(String spName, String maTK, String Quyen, String tenTK , String matKhau ,
            String gioiTinh  ,String diaChi ,String sdt,String ngaySinh )
        {            
            try
            {
                SqlCommand cmd = new SqlCommand(spName, connectDB);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maTK", maTK);
                cmd.Parameters.AddWithValue("@tenTK", tenTK);
                cmd.Parameters.AddWithValue("@matKhau", matKhau);
                cmd.Parameters.AddWithValue("@gioiTinh", gioiTinh);
                cmd.Parameters.AddWithValue("@diaChi", diaChi);
                cmd.Parameters.AddWithValue("@sdt", sdt);
                cmd.Parameters.AddWithValue("@Quyen", Quyen);
                cmd.Parameters.AddWithValue("@ngaySinh", ngaySinh);
                if (cmd.ExecuteNonQuery() > 0)
                    return 1;                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return -1;
        }
        //lấy mã hóa đơn thêm vào sau cùng của table hóa đơn
        public DataTable getLastMHD()
        {
            DataTable DT = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("GetLastMaHD", connectDB);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter SA = new SqlDataAdapter(cmd);
                SA.Fill(DT);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return DT;
        }
        //chỉnh sửa hóa đơn (thêm, sửa)
        public int EditHD(String spName, String maHD , String maKH , String maNV, String ngayLap , String tongTien )
        {
            try
            {
                float fTongtien = float.Parse(tongTien);
                SqlCommand cmd = new SqlCommand(spName, connectDB);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maHD", maHD);
                cmd.Parameters.AddWithValue("@maKH", maKH);
                cmd.Parameters.AddWithValue("@maNV", maNV);
                cmd.Parameters.AddWithValue("@ngayLap", ngayLap);
                cmd.Parameters.AddWithValue("@tongTien", fTongtien);
                if (cmd.ExecuteNonQuery() > 0)
                    return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return -1;
        }
        //thêm 1 hóa đơn không có mã khách hàng
        public int InserHDWithouMaKH(String maHD, String maNV, String ngayLap, String tongTien)
        {
            try
            {
                float fTongtien = float.Parse(tongTien);
                SqlCommand cmd = new SqlCommand("InserHDWithouMaKH", connectDB);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maHD", maHD);                
                cmd.Parameters.AddWithValue("@maNV", maNV);
                cmd.Parameters.AddWithValue("@ngayLap", ngayLap);
                cmd.Parameters.AddWithValue("@tongTien", fTongtien);
                if (cmd.ExecuteNonQuery() > 0)
                    return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return -1;
        }
        //chỉnh sửa khách hàng(thêm, sửa)
        public int EditKhachHang(String spName, String maKH, String tenKH  , String diaChi, String sdt , String diemThuong)
        {
            try
            {
                int iDiemThuong = int.Parse(diemThuong);
                SqlCommand cmd = new SqlCommand(spName, connectDB);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maKH", maKH);
                cmd.Parameters.AddWithValue("@diaChi", diaChi);
                cmd.Parameters.AddWithValue("@tenKH", tenKH);
                cmd.Parameters.AddWithValue("@sdt", sdt);
                cmd.Parameters.AddWithValue("@diemThuong", iDiemThuong);
                if (cmd.ExecuteNonQuery() > 0)
                    return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            return -1;
        }
        //chỉnh sủa hàng hóa(thêm, sửa)
        public int EditHangHoa(String spName, String maHang , String tenHang, String soLuong , String donGiaNhap , String donGiaBan , String ghiChu){
            try
            {
                float fDonGiaNhap = int.Parse(donGiaNhap);
                float fDonGiaBan = int.Parse(donGiaBan);
                SqlCommand cmd = new SqlCommand(spName, connectDB);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maHang", maHang);
                cmd.Parameters.AddWithValue("@tenHang", tenHang);
                cmd.Parameters.AddWithValue("@soLuong", soLuong);
                cmd.Parameters.AddWithValue("@donGiaNhap", fDonGiaNhap);
                cmd.Parameters.AddWithValue("@donGiaBan", fDonGiaBan);
                cmd.Parameters.AddWithValue("@ghiChu", ghiChu);
                if (cmd.ExecuteNonQuery() > 0)
                    return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            return -1;
        }
       
      
        //lấy số lượng  1 sản phẩm
        public int getQty(String maHang)
        {
            DataTable DT = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("getQty", connectDB);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maHang", maHang);
                SqlDataAdapter SA = new SqlDataAdapter(cmd);                
                SA.Fill(DT);
                return int.Parse(DT.Rows[0].ItemArray[2].ToString());
            }catch(Exception ex)
            {
                
            }
            return -1;
        }
        //cập nhật số lượng 1 sản phẩm
        public int SetQty(String MaHang, int Qty)
        {
            try
            {                
                SqlCommand cmd = new SqlCommand("SetQty", connectDB);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maHang", MaHang);
                cmd.Parameters.AddWithValue("@Qty", Qty);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
            }
            return -1;
        }
        public int chagePassAdmin(String MaTK, String password)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("chagePassAdmin", connectDB);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaTK", MaTK);
                cmd.Parameters.AddWithValue("@password", password);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
            }
            return -1;
        }
    }
}
