using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO_QLKS;

namespace DAL_QLKS
{
    public class DAL_Phong : DatabaseConnection
    {
        public DataTable getPhong()
        {
            return GetDataToTable("SELECT * FROM tblPhong");
        }

        public int luuPhong(DTO_Phong ph)
        {
            SqlParameter[] paraLuu = new SqlParameter[4];
            paraLuu[0] = new SqlParameter("@loaiphong", ph.LoaiPhong);
            paraLuu[1] = new SqlParameter("@songmax", ph.SoNgMax);
            paraLuu[2] = new SqlParameter("@giaphong",ph.GiaPhong);
            paraLuu[3] = new SqlParameter("@tinhtrang", ph.TinhTrang);


            string sql = "sp_them_ph";
            return RunSQL(sql, CommandType.StoredProcedure, paraLuu);
        }

        public int xoaPhong(string maph)
        {
            SqlParameter[] paraXoa = new SqlParameter[1];
            paraXoa[0] = new SqlParameter("@maph", maph);

            string sql = "DELETE FROM tblPhong WHERE MaPH = @maph";
            return RunSQL(sql, CommandType.Text, paraXoa);
        }

        public int suaPhong(DTO_Phong ph)
        {
            SqlParameter[] paraSua = new SqlParameter[5];
            paraSua[0] = new SqlParameter("@malp", ph.MaPH);
            paraSua[1] = new SqlParameter("@loaiphong", ph.LoaiPhong);
            paraSua[2] = new SqlParameter("@songmax", ph.SoNgMax);
            paraSua[3] = new SqlParameter("@giaphong", ph.GiaPhong);
            paraSua[4] = new SqlParameter("@tinhtrang", ph.TinhTrang);

            string sql = "sp_sua_ph";
            return RunSQL(sql, CommandType.StoredProcedure, paraSua);
        }

        public DataTable getPhongTrong()
        {
            return GetDataToTable("SELECT * FROM tblPhong WHERE NOT EXISTS (SELECT MaPH FROM tblDatPhong WHERE tblPhong.MaPH = tblDatPhong.MaPH)");
        }

        public DataTable getPhongBooked()
        {
            return GetDataToTable("SELECT * FROM tblPhong WHERE TinhTrang = 'Booked'");
        }
    }
}
