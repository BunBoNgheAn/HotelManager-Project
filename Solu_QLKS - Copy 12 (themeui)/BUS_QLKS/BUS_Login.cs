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
    public class BUS_Login
    {
        DAL_Login dalLogin = new DAL_Login();
        public bool login(string id, string pass)
        {
            return dalLogin.Login(id,pass);
        }
    }
}
