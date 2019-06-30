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
    public class CMPersonDAL
    {
        static public void create(CMPersonBE person)
        {
            SqlConnection con = new SqlConnection(CMDatabase.getConnection());
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedure.Person.create, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dniVal", person.person_dni);
                cmd.Parameters.AddWithValue("@nameVal", person.person_name);
                cmd.Parameters.AddWithValue("@lnameVal", person.person_lastname);
                cmd.Parameters.AddWithValue("@phoneVal", person.person_phone);
                cmd.Parameters.AddWithValue("@birthVal", person.person_birthday);
                cmd.Parameters.AddWithValue("@addreVal", person.person_address);
                cmd.Parameters.AddWithValue("@gendeVal", person.person_gender);
                cmd.Parameters.AddWithValue("@imgVal", person.person_image);

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

        static public void update(CMPersonBE person)
        {
            SqlConnection con = new SqlConnection(CMDatabase.getConnection());
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedure.Person.update, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dniVal", person.person_dni);
                cmd.Parameters.AddWithValue("@nameVal", person.person_name);
                cmd.Parameters.AddWithValue("@lnameVal", person.person_lastname);
                cmd.Parameters.AddWithValue("@phoneVal", person.person_phone);
                cmd.Parameters.AddWithValue("@birthVal", person.person_birthday);
                cmd.Parameters.AddWithValue("@addreVal", person.person_address);
                cmd.Parameters.AddWithValue("@gendeVal", person.person_gender);
                cmd.Parameters.AddWithValue("@imgVal", person.person_image);

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

        static public List<CMPersonBE> getAll()
        {
            SqlConnection con = new SqlConnection(CMDatabase.getConnection());
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedure.Person.getAll, con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                List<CMPersonBE> persons = new List<CMPersonBE>();

                while (dr.Read())
                {
                    persons.Add(new CMPersonBE(dr));
                }

                return persons;
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
