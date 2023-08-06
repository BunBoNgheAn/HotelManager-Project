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
    public class DAL_SuDungDichVu : DatabaseConnection
    {
        public DataTable getSDDV(string madp)
        {
            return GetDataToTable("SELECT tblSuDungDichVu.MaDP, tblDichVu.MaDV, tblDichVu.LoaiDV, tblDichVu.TenDV, tblSuDungDichVu.Ngay"
                                +", tblSuDungDichVu.SoLuong, tblSuDungDichVu.DonGia, tblSuDungDichVu.ThanhTien "
                                + " FROM tblSuDungDichVu INNER JOIN tblDichVu ON tblSuDungDichVu.MaDV = tblDichVu.MaDV"
                                + " WHERE MaDP = '" + madp + "'");
        }
        public int luuSDDV(DTO_SuDungDichVu sd)
        {
            SqlParameter[] paraLuu = new SqlParameter[6];
            paraLuu[0] = new SqlParameter("@madp", sd.MaDP);
            paraLuu[1] = new SqlParameter("@madv", sd.MaDV);
            paraLuu[2] = new SqlParameter("@ngay", sd.Ngay);
            paraLuu[3] = new SqlParameter("@soluong", sd.SoLuong);
            paraLuu[4] = new SqlParameter("@dongia", sd.DonGia);
            paraLuu[5] = new SqlParameter("@thanhtien", sd.ThanhTien);

            string sql = "INSERT INTO tblSuDungDichVu VALUES (@madp, @madv, @ngay, @soluong, @dongia, @thanhtien)";
            return RunSQL(sql, CommandType.Text, paraLuu);
        }
        public int suaSDDV(DTO_SuDungDichVu sd)
        {
            SqlParameter[] paraSua = new SqlParameter[6];
            paraSua[0] = new SqlParameter("@madp", sd.MaDP);
            paraSua[1] = new SqlParameter("@madv", sd.MaDV);       
            paraSua[2] = new SqlParameter("@ngay", sd.Ngay);
            paraSua[3] = new SqlParameter("@soluong", sd.SoLuong);
            paraSua[4] = new SqlParameter("@dongia", sd.DonGia);
            paraSua[5] = new SqlParameter("@thanhtien", sd.ThanhTien);

            string sql = "UPDATE tblSuDungDichVu SET MaDV = @madv, Ngay = @ngay, SoLuong = @soluong, DonGia = @dongia, ThanhTien = @thanhtien WHERE MaDP = @madp";
            return RunSQL(sql, CommandType.Text, paraSua);
        }
        public int xoaSDDV(string madp)
        {
            SqlParameter[] paraXoa = new SqlParameter[1];
            paraXoa[0] = new SqlParameter("@madp", madp);

            string sql = "DELETE FROM tblSuDungDichVu WHERE MaDP = @madp ";
            return RunSQL(sql, CommandType.Text, paraXoa);
        }
    }
}
