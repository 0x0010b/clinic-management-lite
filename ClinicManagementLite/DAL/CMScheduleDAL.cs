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
    class CMScheduleDAL
    {
        static public void create(CMScheduleBE schedule)
        {
            SqlConnection con = new SqlConnection(CMDatabase.getConnection());
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedure.Schedule.create, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dniVal", schedule.schedule_employee.person_dni);
                cmd.Parameters.AddWithValue("@idVal", schedule.schedule_turn.turn_id);

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

        static public List<CMScheduleBE> getAll()
        {
            SqlConnection con = new SqlConnection(CMDatabase.getConnection());
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedure.Schedule.getAll, con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                List<CMScheduleBE> schedules = new List<CMScheduleBE>();

                if (dr.Read())
                {
                    schedules.Add(new CMScheduleBE(dr));
                }

                return schedules;
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

        static public void delete(string person_dni, int turn_id)
        {
            SqlConnection con = new SqlConnection(CMDatabase.getConnection());
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedure.Schedule.delete, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dniVal", person_dni);
                cmd.Parameters.AddWithValue("@idVal", turn_id);

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

        static public List<CMScheduleBE> filterByTurn(int turn_id)
        {
            SqlConnection con = new SqlConnection(CMDatabase.getConnection());
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedure.Schedule.filterByTurn, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@turnId", turn_id);

                SqlDataReader dr = cmd.ExecuteReader();

                List<CMScheduleBE> schedules = new List<CMScheduleBE>();

                if (dr.Read())
                {
                    schedules.Add(new CMScheduleBE(dr));
                }

                return schedules;
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

        static public List<CMScheduleBE> filterByEmployee(string person_dni)
        {
            SqlConnection con = new SqlConnection(CMDatabase.getConnection());
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedure.Schedule.filterByEmployee, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dniVal", person_dni);

                SqlDataReader dr = cmd.ExecuteReader();

                List<CMScheduleBE> schedules = new List<CMScheduleBE>();

                if (dr.Read())
                {
                    schedules.Add(new CMScheduleBE(dr));
                }

                return schedules;
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

        static public List<CMScheduleBE> filterByDay(int day)
        {
            SqlConnection con = new SqlConnection(CMDatabase.getConnection());
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedure.Schedule.filterByDay, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@day", day);

                SqlDataReader dr = cmd.ExecuteReader();

                List<CMScheduleBE> schedules = new List<CMScheduleBE>();

                if (dr.Read())
                {
                    schedules.Add(new CMScheduleBE(dr));
                }

                return schedules;
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
