using ClinicManagementLite.Windows.BE;
using ClinicManagementLite.Windows.BL;
using ClinicManagementLite.Windows.General;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementLite.Windows.DA
{
    class CMUserDAL
    {
        public static CMUserBE login(CMUserBE objUser)
        {
            SqlConnection con = new SqlConnection(CMDatabase.connection);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedures.usp_userLogin, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nameVal", objUser.user_username);
                cmd.Parameters.AddWithValue("@passVal", objUser.user_password);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return CMUserBE.parse(dr);
                }
                else
                    throw new Exception("No se encontró usuario.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public static void create()
        {

        }
        
        public static void getAll()
        {

        }

        public static void get()
        {

        }

        public static void update()
        {

        }

        public static void delete()
        {

        }
    }
}
