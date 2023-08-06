using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_HoaDon
    {
        public string MaHD { get; set; }
        public DateTime Ngay { get; set; }
        public float TienPH { get; set; }
        public float TienDV { get; set; }
        public double TongTien { get; set; }
        public string MaDP { get; set; }
        public string MaNV { get; set; }

        public DTO_HoaDon(string mahd, DateTime ngay, float tienph, float tiendv, double tongtien, string madp, string manv)
        {
            this.MaHD = mahd;         
            this.Ngay = ngay;
            this.TienPH = tienph;
            this.TienDV = tiendv;
            this.TongTien = tongtien;
            this.MaDP = madp;
            this.MaNV = manv;
        }
    }
}
