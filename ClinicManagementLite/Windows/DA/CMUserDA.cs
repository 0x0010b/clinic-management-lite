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
        public static void login(string username, string password, Login success, Error error)
        {
            try
            {
                CMConnection objConnection = CMConnectionManager.getConnection(Procedures.usp_userLogin);

                objConnection.cnn.Open();

                objConnection.cmd.Parameters.AddWithValue("@nameVal", username);
                objConnection.cmd.Parameters.AddWithValue("@passVal", password);

                SqlDataReader reader = objConnection.cmd.ExecuteReader();

                reader.Close();
                objConnection.cnn.Close();

                success(true, 0, PermissionType.admin);
            }
            catch (SqlException ex)
            {
                error(ex.Message);
            }
        }
    }
}
