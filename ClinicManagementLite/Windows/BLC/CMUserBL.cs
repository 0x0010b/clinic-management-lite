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
    class CMUserBL
    {
        public static void login(string username, string password)
        {
            try
            {
                if (username.Length < 8)
                {
                    throw new Exception(CMMessage.Login.emptyUsername);
                }
                else if (password.Length < 6)
                {
                    throw new Exception(CMMessage.Login.emptyPassword);
                }
                else
                {
                    CMUserDA.login(username, password); ;
                }
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
