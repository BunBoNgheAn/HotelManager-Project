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
    public class BUS_SuDungDichVu
    {
        DAL_SuDungDichVu dalSDDV = new DAL_SuDungDichVu();
        public DataTable getSDDV(string madp)
        {
            return dalSDDV.getSDDV(madp);
        }
        public int luuSDDV(DTO_SuDungDichVu sd)
        {
            return dalSDDV.luuSDDV(sd);
        }
        public int suaSDDV(DTO_SuDungDichVu sd)
        {
            return dalSDDV.suaSDDV(sd);
        }
        public int xoaSDDV(string maph)
        {
            return dalSDDV.xoaSDDV(maph);
        }
    }
}
