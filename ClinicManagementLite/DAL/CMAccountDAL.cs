using BE;
using General;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CMAccountDAL
    {
        static public CMAccountBE login(CMAccountBE account)
        {
            SqlConnection con = new SqlConnection(CMDatabase.connection);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedure.usp_accountLogin);

                cmd.Parameters.AddWithValue("@nameVal", account.account_username);
                cmd.Parameters.AddWithValue("@passVal", account.account_password);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return new CMAccountBE(dr);
                }
                else
                {
                    throw new Exception(CMMessage.Login.accountNotFound);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
        }

        static public void create(CMAccountBE account)
        {
            SqlConnection con = new SqlConnection(CMDatabase.connection);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedure.usp_accountCreate, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nameVal", account.account_username);
                cmd.Parameters.AddWithValue("@passVal", account.account_password);
                cmd.Parameters.AddWithValue("@permVal", account.account_permission.permission_id); // TODO: - fix
                cmd.Parameters.AddWithValue("@emplVal", account.account_employeeID);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
        }

        static public void delete(CMAccountBE account)
        {
            SqlConnection con = new SqlConnection(CMDatabase.connection);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedure.usp_accountDelete);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idVal", account.account_id);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
        }

        static public List<CMAccountBE> getAll(Sort sort)
        {
            SqlConnection con = new SqlConnection(CMDatabase.connection);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedure.usp_accountGetAll, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@sort", (int) sort);

                SqlDataReader dr = cmd.ExecuteReader();

                List<CMAccountBE> arrayAccounts = new List<CMAccountBE>();

                if (dr.Read())
                {
                    arrayAccounts.Add(new CMAccountBE(dr));
                }

                return arrayAccounts;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
        }

        static public void update(CMAccountBE account)
        {
            SqlConnection con = new SqlConnection(CMDatabase.connection);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedure.usp_accountUpdate, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idVal", account.account_id);
                cmd.Parameters.AddWithValue("@nameVal", account.account_username);
                cmd.Parameters.AddWithValue("@passVal", account.account_password);
                cmd.Parameters.AddWithValue("@permVal", account.account_permission.permission_id); // TODO: - fix
                cmd.Parameters.AddWithValue("@emplVal", account.account_employeeID);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
        }
    }
}
