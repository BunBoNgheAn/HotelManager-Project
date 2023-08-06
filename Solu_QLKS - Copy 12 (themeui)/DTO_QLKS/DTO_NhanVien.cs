using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_NhanVien
    {     
        public string Manv { get; set; } 
        public string Hoten { get; set; }
        public string Phai { get; set; }
        public DateTime Ngaysinh { get; set; }
        public string Chucvu { get; set; }
        public string Diachi { get; set; }
        public string CMND { get; set; }
        public string SDT { get; set; }
        public DTO_NhanVien()
        {

        }

        public DTO_NhanVien(string manv, string hoten, string phai, DateTime ngaysinh, string chucvu, string diachi, string cmnd, string sdt)
        {
            this.Manv = manv;
            this.Hoten = hoten;
            this.Phai = phai;
            this.Ngaysinh = ngaysinh;
            this.Chucvu = chucvu;
            this.Diachi = diachi;
            this.CMND = cmnd;
            this.SDT = sdt;
        }
    }


}
