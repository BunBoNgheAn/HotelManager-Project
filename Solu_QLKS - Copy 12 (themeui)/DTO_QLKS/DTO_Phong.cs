using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_Phong
    {
        public string MaPH { get; set; }
        public string LoaiPhong { get; set; }
        public int SoNgMax { get; set; }
        public float GiaPhong { get; set; }
        public string TinhTrang { get; set; }

        public DTO_Phong(string maph, string loaiphong, int songmax, float giaphong, string tinhtrang)
        {
            this.MaPH = maph;
            this.LoaiPhong = loaiphong;
            this.SoNgMax = songmax;
            this.GiaPhong = giaphong;
            this.TinhTrang = tinhtrang;
        }
    }
}
