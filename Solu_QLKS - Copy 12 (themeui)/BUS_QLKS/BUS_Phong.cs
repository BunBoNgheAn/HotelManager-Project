using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL_QLKS;
using DTO_QLKS;

namespace BUS_QLKS
{
    public class BUS_Phong
    {
        DAL_Phong dalPH = new DAL_Phong();
        public DataTable getPhong()
        {
            return dalPH.getPhong();
        }
        public int luuPhong(DTO_Phong ph)
        {
            return dalPH.luuPhong(ph);
        }
        public int xoaPhong(string maph)
        {
            return dalPH.xoaPhong(maph);
        }
        public int suaPhong(DTO_Phong ph)
        {
            return dalPH.suaPhong(ph);
        }
        public DataTable getPhongTrong()
        {
            return dalPH.getPhongTrong();
        }
        public DataTable getPhongBooked()
        {
            return dalPH.getPhongBooked();
        }
    }
}
