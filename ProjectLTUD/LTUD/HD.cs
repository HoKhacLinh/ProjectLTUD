using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTUD
{
     public  class HD
    {
        private String maHD, ngayLapHD, tenNV, maNV, maKH;
        public HD(String maHD, String ngayLapHD, String tenNV, String maNV, String maKH)
        {
            this.maHD = maHD;
            this.ngayLapHD = ngayLapHD;
            this.tenNV = tenNV;
            this.maNV = maNV;
            this.maKH = maKH;
        }
        public HD()
        {
            this.maHD = "";
            this.ngayLapHD = "";
            this.tenNV = "";
            this.maNV = "";
            this.maKH = "";
        }
        public String[] getHD()
        {
            String[] array = new String[5];
            array[0] = maHD;
            array[1] = ngayLapHD;
            array[2] = tenNV;
            array[3] = maNV;
            array[4] = maKH;
            return array;
        }
    }
}
