using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using General;

namespace DAL
{
    public class CMClientDAL
    {
        static public void create(CMClientBE client)
        {
            SqlConnection con = new SqlConnection(CMDatabase.getConnection());
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedure.usp_clientCreate, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dniVal", client.person_dni);
                cmd.Parameters.AddWithValue("@wheightVal", client.wheight);
                cmd.Parameters.AddWithValue("@heightVal", client.height);
                cmd.Parameters.AddWithValue("@bTypeVal", client.bloodType);
                cmd.Parameters.AddWithValue("@bPressVal", client.bloodPressure);
                cmd.Parameters.AddWithValue("@allergVal", client.allergies);
                cmd.Parameters.AddWithValue("@patholVal", client.pathologies);
                cmd.Parameters.AddWithValue("@medVal", client.medicines);
                cmd.Parameters.AddWithValue("@seizuVal", client.seizures);
                cmd.Parameters.AddWithValue("@diabeVal", client.diabetes);
                cmd.Parameters.AddWithValue("@cholesVal", client.cholesterol);
                cmd.Parameters.AddWithValue("@cancerVal", client.cancer);
                cmd.Parameters.AddWithValue("@aidsVal", client.aids);

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

        static public void delete(CMClientBE client)
        {
            SqlConnection con = new SqlConnection(CMDatabase.getConnection());
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedure.usp_clientDelete, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dniVal", client.person_dni);

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

        static public void update(CMClientBE client)
        {
            SqlConnection con = new SqlConnection(CMDatabase.getConnection());
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedure.usp_clientUpdate, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dniVal", client.person_dni);
                cmd.Parameters.AddWithValue("@wheightVal", client.wheight);
                cmd.Parameters.AddWithValue("@heightVal", client.height);
                cmd.Parameters.AddWithValue("@bTypeVal", client.bloodType);
                cmd.Parameters.AddWithValue("@bPressVal", client.bloodPressure);
                cmd.Parameters.AddWithValue("@allergVal", client.allergies);
                cmd.Parameters.AddWithValue("@patholVal", client.pathologies);
                cmd.Parameters.AddWithValue("@medVal", client.medicines);
                cmd.Parameters.AddWithValue("@seizuVal", client.seizures);
                cmd.Parameters.AddWithValue("@diabeVal", client.diabetes);
                cmd.Parameters.AddWithValue("@cholesVal", client.cholesterol);
                cmd.Parameters.AddWithValue("@cancerVal", client.cancer);
                cmd.Parameters.AddWithValue("@aidsVal", client.aids);

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

        static public CMClientBE get(CMClientBE client)
        {
            SqlConnection con = new SqlConnection(CMDatabase.getConnection());
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedure.usp_clientGet, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idVal", client.dni);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return new CMClientBE(new CMPersonBE(dr), dr);
                }
                else
                {
                    throw new Exception(CMMessage.Maintenance.notFoundInstance);
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
                SqlCommand cmd = new SqlCommand(CMProcedure.usp_clientGetAll, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@sort", (int)sort);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds, "Client");

                return ds.Tables["Client"];
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
