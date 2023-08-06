using DTO_QLKS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_QLKS
{
    public class DatabaseConnection
    {
        public string strConnect = @"Data Source = localhost\sqlexpress; Initial Catalog = QLKhachSan; Integrated Security = True";
        SqlConnection conn = new SqlConnection();

        public DatabaseConnection()
        {
            conn.ConnectionString = strConnect;
        }
        public void OpenConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public DataTable GetDataToTable(string sql)
        {

            SqlDataAdapter dap = new SqlDataAdapter();

            dap.SelectCommand = new SqlCommand();
            dap.SelectCommand.Connection = conn;
            dap.SelectCommand.CommandText = sql;

            DataTable table = new DataTable();

            dap.Fill(table);

            dap.Dispose();
            return table;
        }
        //them sua xoa
        public int RunSQL(string sql, CommandType type, SqlParameter[] para)
        {
            SqlCommand cmd = new SqlCommand();
            int data;
            try
            {
                cmd.Connection = conn;
                OpenConnection();
                cmd.CommandType = type;
                cmd.CommandText = sql;
                cmd.Parameters.AddRange(para);
                data = cmd.ExecuteNonQuery();
                CloseConnection();
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //tra ve cau truy van sum,count,max....
        public string TongHop(string strSql)
        {
            string th = "";
            SqlCommand cmd;

            try
            {
                OpenConnection();

                cmd = new SqlCommand(strSql, conn);
                th = cmd.ExecuteScalar().ToString();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    CloseConnection();
                }
            }
            return th;
        }
        //kiem tra khoa
        public bool CheckKey(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            dap.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        protected SqlDataReader Reader(string query, CommandType type = CommandType.Text, params SqlParameter[] p)
        {
            OpenConnection();
            SqlDataReader read;

            try
            {
                SqlCommand cmd = new SqlCommand(query, conn)
                {
                    CommandType = type
                };
                if (type == CommandType.StoredProcedure)
                {
                    cmd.Parameters.AddRange(p);
                }

                read = cmd.ExecuteReader();
                cmd.Dispose();
            }
            catch
            {
                read = null;
            }
            return read;
        }


        public string GetFieldValues(string sql)
        {
            string ma = "";
            OpenConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            CloseConnection();
            return ma;
        }
        public List<DataItem> GetList(string query)
        {
            OpenConnection();
            List<DataItem> list = new List<DataItem>();

            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    DataItem item = new DataItem
                    {
                        Value = read.GetValue(0).ToString(),
                        Name = read.GetValue(1).ToString()
                    };
                    list.Add(item);
                }
                cmd.Dispose();
                read.Close();
            }
            catch
            { }

            conn.Close();
            return list;
        }

        public string taoMaDP()
        {
            string madp = "DP";
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(MaDP) FROM tblDatPhong", conn);

            int i = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            i++;
            if (i < 10)
            {
                madp = madp + "00" + i.ToString();
            }
            else if (i < 100)
            {
                madp = madp + "0" + i.ToString();
            }
            else if (i < 1000)
            {
                madp = madp + i.ToString();
            }
            return madp;
        }
        public string taoMaHD()
        {
            string mahd = "HD";
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(MaTT) FROM tblHoaDon", conn);

            int i = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            i++;
            if (i < 10)
            {
                mahd = mahd + "00" + i.ToString();
            }
            else if (i < 100)
            {
                mahd = mahd + "0" + i.ToString();
            }
            else if (i < 1000)
            {
                mahd = mahd + i.ToString();
            }
            return mahd;
        }
        private string ConvertTimeTo24(string hour)
        {
            string h = "";
            switch (hour)
            {
                case "1":
                    h = "13";
                    break;
                case "2":
                    h = "14";
                    break;
                case "3":
                    h = "15";
                    break;
                case "4":
                    h = "16";
                    break;
                case "5":
                    h = "17";
                    break;
                case "6":
                    h = "18";
                    break;
                case "7":
                    h = "19";
                    break;
                case "8":
                    h = "20";
                    break;
                case "9":
                    h = "21";
                    break;
                case "10":
                    h = "22";
                    break;
                case "11":
                    h = "23";
                    break;
                case "12":
                    h = "0";
                    break;
            }
            return h;
        }
        public void FillCombo(string table, ComboBox cbo, string display, string value)
        {
            DataTable dt = GetDataToTable("SELECT * FROM " + table);

            cbo.DataSource = dt;
            cbo.ValueMember = value; //Trường giá trị
            cbo.DisplayMember = display; //Trường hiển thị
        }

    }
}
