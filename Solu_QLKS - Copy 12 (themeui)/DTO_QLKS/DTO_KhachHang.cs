using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_KhachHang
    {
        public string MaKH { get; set; }
        public string HotenKH { get; set; }
        public string Phai { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string CMND { get; set; }

        public DTO_KhachHang(string makh, string hoten, string phai, DateTime ngaysinh, string diachi, string sdt, string cmnd)
        {
            this.MaKH = makh;
            this.HotenKH = hoten;
            this.Phai = phai;
            this.NgaySinh = ngaysinh;
            this.DiaChi = diachi;
            this.SDT = sdt;
            this.CMND = cmnd;
        }
    }
}




