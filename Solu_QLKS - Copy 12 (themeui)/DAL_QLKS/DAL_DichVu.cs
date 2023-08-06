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
    public class DAL_DichVu : DatabaseConnection
    {
        public DataTable getDichVu()
        {
            return GetDataToTable("SELECT * FROM tblDichVu");
        }

        public int luuDichVu(DTO_DichVu dv)
        {
            SqlParameter[] paraLuu = new SqlParameter[3];
            paraLuu[0] = new SqlParameter("@loaidv", dv.LoaiDV);
            paraLuu[1] = new SqlParameter("@tendv", dv.TenDV);
            paraLuu[2] = new SqlParameter("@dongia", dv.DonGia);

            string sql = "sp_them_dv";
            return RunSQL(sql, CommandType.StoredProcedure, paraLuu);
        }

        public int suaDichVu(DTO_DichVu dv)
        {
            SqlParameter[] paraSua = new SqlParameter[4];
            paraSua[0] = new SqlParameter("@madv", dv.MaDV);
            paraSua[1] = new SqlParameter("@loaidv", dv.LoaiDV);
            paraSua[2] = new SqlParameter("@tendv", dv.TenDV);
            paraSua[3] = new SqlParameter("@dongia", dv.DonGia);

            string sql = "sp_sua_dv";
            return RunSQL(sql, CommandType.StoredProcedure, paraSua);
        }

        public int xoaDichVu(string madv)
        {
            SqlParameter[] paraXoa = new SqlParameter[1];
            paraXoa[0] = new SqlParameter("@madv", madv);

            string sql = "DELETE FROM tblDichVu WHERE MaDV = @madv";
            return RunSQL(sql, CommandType.Text, paraXoa); 
        }
    }
}
