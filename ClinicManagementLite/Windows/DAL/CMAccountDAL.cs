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
        public static CMAccountBE login(string username, string password)
        {
            SqlConnection con = new SqlConnection(CMDatabase.connection);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedures.usp_accountLogin, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nameVal", username);
                cmd.Parameters.AddWithValue("@passVal", password);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return CMAccountBE.parse(dr);
                }
                else
                    throw new Exception(CMMessage.Login.accountNotFound);
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

        public static bool create(CMAccountBE account)
        {
            SqlConnection con = new SqlConnection(CMDatabase.connection);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedures.usp_accountCreate, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nameVal", account.account_username);
                cmd.Parameters.AddWithValue("@passVal", account.account_password);
                cmd.Parameters.AddWithValue("@permVal", (int) account.account_permission.permission_type);
                cmd.Parameters.AddWithValue("@emplVal", account.account_employeeId);
                cmd.ExecuteNonQuery();
                return true;
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
        
        public static List<CMAccountBE> getAll()
        {
            return new List<CMAccountBE>();
            // TODO: - Terminar
        }

        public static bool update(CMAccountBE account)
        {
            SqlConnection con = new SqlConnection(CMDatabase.connection);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedures.usp_accountUpdate, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idVal", account.account_id);
                cmd.Parameters.AddWithValue("@nameVal", account.account_username);
                cmd.Parameters.AddWithValue("@passVal", account.account_password);
                cmd.Parameters.AddWithValue("@permVal", (int)account.account_permission.permission_type);
                cmd.Parameters.AddWithValue("@emplVal", account.account_employeeId);
                cmd.ExecuteNonQuery();
                return true;
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

        public static bool delete(CMAccountBE account)
        {
            SqlConnection con = new SqlConnection(CMDatabase.connection);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedures.usp_accountDelete, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idVal", account.account_id);
                cmd.ExecuteNonQuery();
                return true;
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
    }
}
