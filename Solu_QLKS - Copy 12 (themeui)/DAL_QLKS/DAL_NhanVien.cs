using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using DTO_QLKS;

namespace DAL_QLKS
{
    public class DAL_NhanVien : DatabaseConnection
    {
        public DataTable getNhanVien()
        {
            return GetDataToTable("SELECT * FROM tblNhanVien");
        }
        public int luuNhanVien(DTO_NhanVien nv)
        {
            
            SqlParameter[] paraLuu = new SqlParameter[7];
            paraLuu[0] = new SqlParameter("@hoten", nv.Hoten);
            paraLuu[1] = new SqlParameter("@phai", nv.Phai);
            paraLuu[2] = new SqlParameter("@ngaysinh", nv.Ngaysinh);
            paraLuu[3] = new SqlParameter("@chucvu", nv.Chucvu);
            paraLuu[4] = new SqlParameter("@diachi", nv.Diachi);
            paraLuu[5] = new SqlParameter("@cmnd", nv.CMND);
            paraLuu[6] = new SqlParameter("@sdt", nv.SDT);

            string sql = "sp_them_nv";
            return RunSQL(sql, CommandType.StoredProcedure, paraLuu);
        }
        public int suaNhanVien(DTO_NhanVien nv)
        {
            SqlParameter[] paraSua = new SqlParameter[8];
            paraSua[0] = new SqlParameter("@manv", nv.Manv);
            paraSua[1] = new SqlParameter("@hoten", nv.Hoten);
            paraSua[2] = new SqlParameter("@phai", nv.Phai);
            paraSua[3] = new SqlParameter("@ngaysinh", nv.Ngaysinh);
            paraSua[4] = new SqlParameter("@chucvu", nv.Chucvu);
            paraSua[5] = new SqlParameter("@diachi", nv.Diachi);
            paraSua[6] = new SqlParameter("@cmnd", nv.CMND);
            paraSua[7] = new SqlParameter("@sdt", nv.SDT);

            string sql = "sp_sua_nv";

            return RunSQL(sql, CommandType.StoredProcedure, paraSua);
        }
        public int xoaNhanVien(string manv)
        {
            SqlParameter[] paraXoa = new SqlParameter[1];
            paraXoa[0] = new SqlParameter("@manv", manv);

            string sql = "DELETE FROM tblNhanVien WHERE MaNV = @manv";
            return RunSQL(sql, CommandType.Text, paraXoa);
        }
        public DataTable timNhanVien(string hoten)
        {
            return GetDataToTable("SELECT * FROM tblNhanVien WHERE HotenNV LIKE N'%" + hoten + "%'");
        }
    }
}
