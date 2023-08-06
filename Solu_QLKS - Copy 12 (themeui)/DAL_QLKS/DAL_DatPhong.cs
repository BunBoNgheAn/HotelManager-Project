using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO_QLKS;
using System.Windows.Forms;

namespace DAL_QLKS
{
    public class DAL_DatPhong : DatabaseConnection
    {
        public DataTable getDatPhong()
        {
            return GetDataToTable("SELECT * FROM tblDatPhong");
        }
        public int luuDatPhong(DTO_DatPhong dp)
        {
            SqlParameter[] paraLuu = new SqlParameter[5];
            paraLuu[0] = new SqlParameter("@madp", dp.MaDP);
            paraLuu[1] = new SqlParameter("@makh", dp.MaKH);
            paraLuu[2] = new SqlParameter("@maph", dp.MaPH);
            paraLuu[3] = new SqlParameter("@ngayvao", dp.NgayVao);
            paraLuu[4] = new SqlParameter("@ngayra", dp.NgayRa);
            string sql = "SELECT MaDP FROM tblDatPhong WHERE MaDP = @madp";
            if (CheckKey(sql))
            {
                MessageBox.Show("Mã đặt phòng đã tồn tại.\n Vui lòng nhập mã khác!!");
                return 0;
            }
            else
            {
                sql = "INSERT INTO tblDatPhong VALUES (@madp, @makh, @maph, @ngayvao, @ngayra)";
                return RunSQL(sql, CommandType.Text, paraLuu);
            }           
        }
        public int suaDatPhong(DTO_DatPhong dp)
        {
            SqlParameter[] paraSua = new SqlParameter[5];
            paraSua[0] = new SqlParameter("@madp", dp.MaDP);
            paraSua[1] = new SqlParameter("@makh", dp.MaKH);
            paraSua[2] = new SqlParameter("@maph", dp.MaPH);
            paraSua[3] = new SqlParameter("@ngayvao", dp.NgayVao);
            paraSua[4] = new SqlParameter("@ngayra", dp.NgayRa);

            string sql = "UPDATE tblDatPhong SET MaKH = @makh, MaPH = @maph, NgayVao = @ngayvao, NgayRa = @ngayra WHERE MaDP = @madp";
            return RunSQL(sql, CommandType.Text, paraSua);
        }
        public int xoaDatPhong(string madp)
        {
            SqlParameter[] paraXoa = new SqlParameter[1];
            paraXoa[0] = new SqlParameter("@madp", madp);

            string sql = "DELETE FROM tblDatPhong WHERE MaDP = @madp";
            return RunSQL(sql, CommandType.Text, paraXoa);
        }
        public DataTable getCTDP(DateTime ngayvao, DateTime ngayra)
        {
            //return GetDataToTable("SELECT MaDP, MaKH, MaPH, NgayVao, NgayRa "
            //                    + "FROM dbo.tblDatPhong "
            //                    + "WHERE NgayVao BETWEEN '" + ngayvao + "' AND '" + ngayra + "' ");
            return GetDataToTable("SELECT tblDatPhong.MaDP, tblKhachHang.MaKH, tblKhachHang.HotenKH, tblPhong.MaPH, tblPhong.LoaiPhong, tblDatPhong.NgayVao, tblDatPhong.NgayRa, DATEDIFF(DAY,NgayVao,NgayRa) AS SoDem, tblPhong.GiaPhong, (DATEDIFF(DAY,NgayVao,NgayRa) * GiaPhong) as TienPhong"
                                + " FROM tblDatPhong INNER JOIN tblPhong ON tblDatPhong.MaPH = tblPhong.MaPH INNER JOIN tblKhachHang ON tblDatPhong.MaKH = tblKhachHang.MaKH"
                                + " WHERE NgayVao BETWEEN '" + ngayvao + "' AND '" + ngayra + "'");
        }
        public DataTable getDPtheoMaDP(string maph)
        {
            return GetDataToTable("SELECT tblDatPhong.MaDP, tblPhong.MaPH, tblPhong.LoaiPhong, tblPhong.SoNgToiDa, tblPhong.GiaPhong "
                                + " FROM tblDatPhong INNER JOIN tblPhong ON tblDatPhong.MaPH = tblPhong.MaPH "
                                + " WHERE MaDP = '" + maph + "'");
        }
        public string taomadp()
        {
            return taoMaDP();
        } 
    }
}
