using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_DichVu
    {
        public string MaDV { get; set; }
        public string LoaiDV { get; set; }
        public string TenDV { get; set; }
        public float DonGia { get; set; }

        public DTO_DichVu(string madv, string loaidv, string tendv, float dongia)
        {
            this.MaDV = madv;
            this.LoaiDV = loaidv;
            this.TenDV = tendv;
            this.DonGia = dongia;
        }
    }
}
