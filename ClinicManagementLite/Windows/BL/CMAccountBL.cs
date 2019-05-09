using ClinicManagementLite.Windows.BE;
using ClinicManagementLite.Windows.DA;
using ClinicManagementLite.Windows.General;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementLite.Windows.BL
{
    class CMAccountBL
    {
        public static CMAccountBE login(string username, string password)
        {
            try
            {
                return CMUserDAL.login(username, password);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
