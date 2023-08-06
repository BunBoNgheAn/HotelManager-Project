using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL_QLKS;
using DTO_QLKS;
using System.Windows.Forms;

namespace BUS_QLKS
{
    public class BUS_NhanVien
    {
        DAL_NhanVien dalNV = new DAL_NhanVien();

        public DataTable getNhanVien()
        {
            return dalNV.getNhanVien();
        }

        public int luuNhanVien(DTO_NhanVien nv)
        {
            return dalNV.luuNhanVien(nv);
        }

        public int xoaNhanVien(string manv)
        {
            return dalNV.xoaNhanVien(manv);
        }

        public int suaNhanVien(DTO_NhanVien nv)
        {
            return dalNV.suaNhanVien(nv);
        }
        public DataTable timNhanVien(string hoten)
        {
            return dalNV.timNhanVien(hoten);
        }
    }
}
