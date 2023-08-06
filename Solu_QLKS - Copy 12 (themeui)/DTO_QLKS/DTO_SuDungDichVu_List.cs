using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_SuDungDichVu_List
    {
        public string MaDP { get; set; }
        public string MaDV { get; set; }
        public string TenDV { get; set; }
        public DateTime Ngay { get; set; }
        public int SoLuong { get; set; }
        public float DonGia { get; set; }
        public double ThanhTien { get; set; }
    }
}
