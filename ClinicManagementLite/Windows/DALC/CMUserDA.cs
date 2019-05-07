using ClinicManagementLite.Windows.BL;
using ClinicManagementLite.Windows.General;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementLite.Windows.DA
{
    class CMUserDA
    {
        public static void login(string username, string password)
        {
            try
            {
                // TODO: -
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
