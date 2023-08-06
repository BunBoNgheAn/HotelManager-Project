using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO_QLKS;
using DAL_QLKS;
using System.Windows.Forms;

namespace BUS_QLKS
{
    public class BUS_KhachHang
    {
        DAL_KhachHang dalKH = new DAL_KhachHang();

        public DataTable getKhachHang()
        {
            return dalKH.getKhachHang();
        }

        public int luuKhachHang(DTO_KhachHang kh)
        {
            return dalKH.luuKhachHang(kh);
        }
        public int xoaKhachHang(string makh)
        {
            return dalKH.xoaKhachHang(makh);
        }
        public int suaKhachHang(DTO_KhachHang kh)
        {
            return dalKH.suaKhachHang(kh);
        }
        public DataTable timKhachHang(string hoten)
        {
            return dalKH.timKhachHang(hoten);
        }
        public DataTable getKHnotinDP()
        {
            return dalKH.getKHnotinDP();
        }
        public DataTable getKHdaDatPHong()
        {
            return dalKH.getKHdaDatPhong();
        }
    }
}
