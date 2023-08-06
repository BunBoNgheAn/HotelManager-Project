using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_DatPhong
    {
        public string MaDP { get; set; }
        public string MaKH { get; set; }
        public string MaPH { get; set; }
        public DateTime NgayVao { get; set; }
        public DateTime NgayRa { get; set; }

        public DTO_DatPhong(string madp, string makh, string maph, DateTime ngayvao, DateTime ngayra)
        {
            this.MaDP = madp;
            this.MaKH = makh;
            this.MaPH = maph;
            this.NgayVao = ngayvao;
            this.NgayRa = ngayra;
        }
    }
}
