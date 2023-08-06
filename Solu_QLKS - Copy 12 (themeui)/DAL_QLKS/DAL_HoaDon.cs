using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLKS;
using System.Windows.Forms;

namespace DAL_QLKS
{
    public class DAL_HoaDon : DatabaseConnection
    {
        public DataTable getHoaDon(DateTime from, DateTime to)
        {
            return GetDataToTable("SELECT MaHD, MaDP, MaNV, NgayTT, TienPhong, TienDichVu, TongTien "
                                + "FROM dbo.tblHoaDon "
                                + "WHERE NgayTT BETWEEN '" + from + "' AND '" + to + "'");
        }
        public int luuHoaDon(DTO_HoaDon hd)
        {
            SqlParameter[] paraLuu = new SqlParameter[7];
            paraLuu[0] = new SqlParameter("@mahd", hd.MaHD);
            paraLuu[1] = new SqlParameter("@ngay", hd.Ngay);
            paraLuu[2] = new SqlParameter("@tienph", hd.TienPH);
            paraLuu[3] = new SqlParameter("@tiendv", hd.TienDV);
            paraLuu[4] = new SqlParameter("@tongtien", hd.TongTien);
            paraLuu[5] = new SqlParameter("@madp", hd.MaDP);
            paraLuu[6] = new SqlParameter("@manv", hd.MaNV);
            string sql = "SELECT MaHD FROM tblHoaDon WHERE MaHD = @mahd";
            if (CheckKey(sql))
            {
                MessageBox.Show("Mã hoá đơn đã tồn tại.\n Vui lòng nhập mã khác!!");
                return 0;
            }
            else
            {
                sql = "INSERT INTO tblHoaDon VALUES (@mahd, @ngay, @tienph, @tiendv, @tongtien, @madp, @manv)";
                return RunSQL(sql, CommandType.Text, paraLuu);
            }
        }
        public int suaHoaDon(DTO_HoaDon hd)
        {
            SqlParameter[] paraSua = new SqlParameter[7];
            paraSua[0] = new SqlParameter("@mahd", hd.MaHD);
            paraSua[1] = new SqlParameter("@ngay", hd.Ngay);
            paraSua[2] = new SqlParameter("@tienph", hd.TienPH);
            paraSua[3] = new SqlParameter("@tiendv", hd.TienDV);
            paraSua[4] = new SqlParameter("@tongtien", hd.TongTien);
            paraSua[5] = new SqlParameter("@madp", hd.MaDP);
            paraSua[6] = new SqlParameter("@manv", hd.MaNV);

            string sql = "UPDATE tblHoaDon SET NgayTT = @ngay, TienPhong = @tienph, TienDichVu = @tiendv, TongTien = @tongtien, MaDP = @madp, MaNV = @manv WHERE MaHD = @mahd";
            return RunSQL(sql, CommandType.Text, paraSua);
        }
        public int xoaHoaDon(string mahd)
        {
            SqlParameter[] paraXoa = new SqlParameter[1];
            paraXoa[0] = new SqlParameter("@mahd", mahd);

            string sql = "DELETE FROM tblHoaDon WHERE MaHD = @mahd";
            return RunSQL(sql, CommandType.Text, paraXoa);
        }
        public string taomahd()
        {
            return taoMaHD();
        }
    }
}
