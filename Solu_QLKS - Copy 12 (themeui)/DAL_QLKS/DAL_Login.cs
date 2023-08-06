using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DAL_QLKS
{
    public class DAL_Login : DatabaseConnection
    {
        public bool Login(string id, string pass)
        {
            
            string strID = "select ID from tblLogin where ID = '" + id + "'";
            string strPass = "SELECT Pass FROM tblLogin WHERE Pass = '" + pass + "'";         

            string ten = GetFieldValues(strID);
            string mk = GetFieldValues(strPass);

            if (ten.Equals(id) && mk.Equals(pass))
            {
                return true;
            }
            else
            {
                return false;     
            }
        }    
    }
}
