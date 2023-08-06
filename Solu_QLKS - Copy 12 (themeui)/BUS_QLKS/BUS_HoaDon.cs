using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLKS;
using DTO_QLKS;
using System.Data;

namespace BUS_QLKS
{
    public class BUS_HoaDon
    {
        DAL_HoaDon dalHD = new DAL_HoaDon();
        public DataTable getHoaDon(DateTime from, DateTime to)
        {
            return dalHD.getHoaDon(from, to);
        }
        public int luuHoaDon(DTO_HoaDon hd)
        {
            return dalHD.luuHoaDon(hd);
        }
        public int suaHoaDon(DTO_HoaDon hd)
        {
            return dalHD.suaHoaDon(hd);
        }
        public int xoaHoaDon(string mahd)
        {
            return dalHD.xoaHoaDon(mahd);
        }
        public string taomahd()
        {
            return dalHD.taoMaHD();
        }
    }
}
