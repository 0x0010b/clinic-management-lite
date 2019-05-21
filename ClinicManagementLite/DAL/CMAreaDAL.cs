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
    public class CMAreaDAL
    {
        static public void create(CMAreaBE area)
        {
            SqlConnection con = new SqlConnection(CMDatabase.getConnection());
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedure.usp_areaCreate, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@descVal", area.area_description);

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

        static public void delete(CMAreaBE area)
        {
            SqlConnection con = new SqlConnection(CMDatabase.getConnection());
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedure.usp_areaDelete, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idVal", area.area_id);

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
                SqlCommand cmd = new SqlCommand(CMProcedure.usp_areaGetAll, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@sort", (int)sort);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds, "Area");

                return ds.Tables["Area"];
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

        static public void update(CMAreaBE area)
        {
            SqlConnection con = new SqlConnection(CMDatabase.getConnection());
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedure.usp_areaUpdate, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idVal", area.area_id);
                cmd.Parameters.AddWithValue("@descVal", area.area_description);

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
