using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO_QLKS;
using DAL_QLKS;

namespace BUS_QLKS
{
    public class BUS_DichVu
    {
        DAL_DichVu dalDV = new DAL_DichVu();
        public DataTable getDichVu()
        {
            return dalDV.getDichVu();
        }
        public int luuDichVu(DTO_DichVu kh)
        {
            return dalDV.luuDichVu(kh);
        }
        public int xoaDichVu(string makh)
        {
            return dalDV.xoaDichVu(makh);
        }
        public int suaDichVu(DTO_DichVu kh)
        {
            return dalDV.suaDichVu(kh);
        }
    }
}
