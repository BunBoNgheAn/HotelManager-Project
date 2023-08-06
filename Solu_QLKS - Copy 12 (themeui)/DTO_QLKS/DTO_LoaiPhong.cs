using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_LoaiPhong
    {
        public string MaLP { get; set; }
        public string TenLP { get; set; }
        public int SoNgToiDa { get; set; }
        public float GiaPhong { get; set; }

        public DTO_LoaiPhong(string malp, string tenlp, int songtoida, float giaphong)
        {
            this.MaLP = malp;
            this.TenLP = tenlp;
            this.SoNgToiDa = songtoida;
            this.GiaPhong = giaphong;
        }
    }
}
