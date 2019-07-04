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
    public class CMClientDAL
    {
        static public void create(CMClientBE client)
        {
            SqlConnection con = new SqlConnection(CMDatabase.getConnection());
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedure.Client.create, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dniVal", client.person_dni);
                cmd.Parameters.AddWithValue("@wheight", client.client_weight);
                cmd.Parameters.AddWithValue("@height", client.client_height);
                cmd.Parameters.AddWithValue("@blood_type", client.client_bloodType);
                cmd.Parameters.AddWithValue("@blood_pressure", client.client_bloodPressure);
                cmd.Parameters.AddWithValue("@allergies", client.client_allergies);
                cmd.Parameters.AddWithValue("@pathologies", client.client_pathologies);
                cmd.Parameters.AddWithValue("@medicines", client.client_medicines);
                cmd.Parameters.AddWithValue("@seizures", client.client_seizures);
                cmd.Parameters.AddWithValue("@diabetes", client.client_diabetes);
                cmd.Parameters.AddWithValue("@cancer", client.client_cancer);
                cmd.Parameters.AddWithValue("@aids", client.client_aids);

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

        static public List<CMClientBE> getAll()
        {
            SqlConnection con = new SqlConnection(CMDatabase.getConnection());
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedure.Client.getAll, con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                List<CMClientBE> clients = new List<CMClientBE>();

                while (dr.Read())
                {
                    clients.Add(new CMClientBE(dr));
                }

                return clients;
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

        static public CMClientBE get(string person_dni)
        {
            SqlConnection con = new SqlConnection(CMDatabase.getConnection());
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedure.Client.get, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dniVal", person_dni);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return new CMClientBE(dr);
                }
                else
                {
                    throw new Exception(CMMessage.Maintenance.notFoundInstance);
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

        static public void update(CMClientBE client)
        {
            SqlConnection con = new SqlConnection(CMDatabase.getConnection());
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedure.Client.update, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dniVal", client.person_dni);
                cmd.Parameters.AddWithValue("@wheight", client.client_weight);
                cmd.Parameters.AddWithValue("@height", client.client_height);
                cmd.Parameters.AddWithValue("@blood_type", client.client_bloodType);
                cmd.Parameters.AddWithValue("@blood_pressure", client.client_bloodPressure);
                cmd.Parameters.AddWithValue("@allergies", client.client_allergies);
                cmd.Parameters.AddWithValue("@pathologies", client.client_pathologies);
                cmd.Parameters.AddWithValue("@medicines", client.client_medicines);
                cmd.Parameters.AddWithValue("@seizures", client.client_seizures);
                cmd.Parameters.AddWithValue("@diabetes", client.client_diabetes);
                cmd.Parameters.AddWithValue("@cancer", client.client_cancer);
                cmd.Parameters.AddWithValue("@aids", client.client_aids);

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

        static public void delete(string person_dni)
        {
            SqlConnection con = new SqlConnection(CMDatabase.getConnection());
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedure.Client.delete, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dniVal", person_dni);

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
