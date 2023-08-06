using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_SuDungDichVu
    {
        public string MaDP { get; set; }
        public string MaDV { get; set; }
        public DateTime Ngay { get; set; }
        public int SoLuong { get; set; }
        public float DonGia { get; set; }
        public double ThanhTien { get; set; }

        public DTO_SuDungDichVu(string madp, string madv, DateTime ngay, int soluong, float dongia, double thanhtien)
        {
            this.MaDP = madp;
            this.MaDV = madv;
            this.Ngay = ngay;
            this.SoLuong = soluong;
            this.DonGia = dongia;
            this.ThanhTien = thanhtien;
        }
    }
}
