using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO_QLKS;
using System.Windows.Forms;

namespace DAL_QLKS
{
    public class DAL_KhachHang : DatabaseConnection
    {
        public DataTable getKhachHang()
        {
            return GetDataToTable("SELECT * FROM tblKhachHang");
        }

        public int luuKhachHang(DTO_KhachHang kh)
        {
            SqlParameter[] paraLuu = new SqlParameter[6];
            paraLuu[0] = new SqlParameter("@hoten", kh.HotenKH);
            paraLuu[1] = new SqlParameter("@phai", kh.Phai);
            paraLuu[2] = new SqlParameter("@ngaysinh", kh.NgaySinh);
            paraLuu[3] = new SqlParameter("@diachi", kh.DiaChi);
            paraLuu[4] = new SqlParameter("@sdt", kh.SDT);
            paraLuu[5] = new SqlParameter("@cmnd", kh.CMND);

            string sql = "sp_them_kh";
            return RunSQL(sql, CommandType.StoredProcedure, paraLuu);
        }
        public int suaKhachHang(DTO_KhachHang kh)
        {
            SqlParameter[] paraSua = new SqlParameter[7];
            paraSua[0] = new SqlParameter("@makh", kh.MaKH);
            paraSua[1] = new SqlParameter("@hoten", kh.HotenKH);
            paraSua[2] = new SqlParameter("@phai", kh.Phai);
            paraSua[3] = new SqlParameter("@ngaysinh", kh.NgaySinh);
            paraSua[4] = new SqlParameter("@diachi", kh.DiaChi);
            paraSua[5] = new SqlParameter("@sdt", kh.SDT);
            paraSua[6] = new SqlParameter("@cmnd", kh.CMND);

            string sql = "sp_sua_kh";
            return RunSQL(sql, CommandType.StoredProcedure, paraSua);
        }
        public int xoaKhachHang(string makh)
        {
            SqlParameter[] paraXoa = new SqlParameter[1];
            paraXoa[0] = new SqlParameter("@makh", makh);

            string sql = "DELETE FROM tblKhachHang WHERE MaKH = @makh";
            return RunSQL(sql, CommandType.Text, paraXoa);
        }

        public DataTable timKhachHang(string hoten)
        {
            return GetDataToTable("SELECT * FROM tblKhachHang WHERE HotenKH LIKE N'%" + hoten + "%'");
        }
        public DataTable getKHnotinDP()
        {
            return GetDataToTable("SELECT * FROM tblKhachHang WHERE NOT EXISTS (SELECT MaKH FROM tblDatPhong WHERE tblKhachHang.MaKH = tblDatPhong.MaKH)");
        }      
        public DataTable getKHdaDatPhong()
        {
            return GetDataToTable("SELECT * FROM tblKhachHang WHERE EXISTS (SELECT MaKH FROM tblDatPhong WHERE tblKhachHang.MaKH = tblDatPhong.MaKH)");
        }
    }
}
