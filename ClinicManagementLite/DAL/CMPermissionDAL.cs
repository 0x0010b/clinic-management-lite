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
    public class CMPermissionDAL
    {
        static public void create(CMPermissionBE permission)
        {
            SqlConnection con = new SqlConnection(CMDatabase.getConnection());
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedure.usp_permissionCreate, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@descVal", permission.permission_description);

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
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

        static public void delete(CMPermissionBE permission)
        {
            SqlConnection con = new SqlConnection(CMDatabase.getConnection());
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedure.usp_permissionDelete, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idVal", permission.permission_id);

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
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

        static public DataTable getAll(Sort sort)
        {
            SqlConnection con = new SqlConnection(CMDatabase.getConnection());
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedure.usp_permissionGetAll, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@sort", (int)sort);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds, "Permission");

                return ds.Tables["Permission"];
            }
            catch (SqlException ex)
            {
                throw ex;
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

        static public void update(CMPermissionBE permission)
        {
            SqlConnection con = new SqlConnection(CMDatabase.getConnection());
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedure.usp_permissionUpdate, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idVal", permission.permission_id);
                cmd.Parameters.AddWithValue("@descVal", permission.permission_description);

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
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
