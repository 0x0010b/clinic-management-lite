using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace DAL
{
    public class CMDatabase
    {
        static public string getConnection()
        {
            string con = ConfigurationManager.ConnectionStrings["Ventas"].ConnectionString;
            return object.ReferenceEquals(con, String.Empty) ? String.Empty : con;
        }
    }
}
