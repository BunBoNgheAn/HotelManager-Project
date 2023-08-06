using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QLKS;
using DTO_QLKS;

namespace BUS_QLKS
{
    public class BUS_DatPhong
    {
        DAL_DatPhong dalDP = new DAL_DatPhong();
        public DataTable getDatPhong()
        {
            return dalDP.getDatPhong();
        }
        public int luuDatPhong(DTO_DatPhong dp)
        {
            return dalDP.luuDatPhong(dp);
        }
        public int suaDatPhong(DTO_DatPhong dp)
        {
            return dalDP.suaDatPhong(dp);
        }
        public int xoaDatPhong(string madp)
        {
            return dalDP.xoaDatPhong(madp);
        }
        public DataTable getCTDP(DateTime From, DateTime To)
        {
            return dalDP.getCTDP(From, To);
        }
        public DataTable getDPtheoMaDP(string maph)
        {
            return dalDP.getDPtheoMaDP(maph);
        }
        public string taomadp()
        {
            return dalDP.taomadp();
        }
    }
}
