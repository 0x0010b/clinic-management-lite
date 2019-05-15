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
                SqlCommand cmd = new SqlCommand(CMProcedure.usp_permissionGetAll, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idVal", permission.permission_id); // TODO: - Fix

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

        static public List<CMPermissionBE> getAll(Sort sort)
        {
            SqlConnection con = new SqlConnection(CMDatabase.getConnection());
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedure.usp_permissionGetAll, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@sort", (int)sort);

                SqlDataReader dr = cmd.ExecuteReader();

                List<CMPermissionBE> arrayPermissions = new List<CMPermissionBE>();

                if (dr.Read())
                {
                    arrayPermissions.Add(new CMPermissionBE(dr));
                }

                return arrayPermissions;
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

                cmd.Parameters.AddWithValue("@idVal", permission.permission_id); // TODO: - Fix
                cmd.Parameters.AddWithValue("@descVal", permission.permission_description);

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
