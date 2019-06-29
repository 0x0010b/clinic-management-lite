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
    class CMTurnDAL
    {
        static public void create(CMTurnBE turn)
        {
            SqlConnection con = new SqlConnection(CMDatabase.getConnection());
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedure.Turn.create, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@day", turn.turn_day);
                cmd.Parameters.AddWithValue("@desc", turn.turn_description);
                cmd.Parameters.AddWithValue("@entryHour", turn.turn_entryHour);
                cmd.Parameters.AddWithValue("@departureHour", turn.turn_departureHour);

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

        static public List<CMTurnBE> getAll()
        {
            SqlConnection con = new SqlConnection(CMDatabase.getConnection());
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedure.Turn.getAll, con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                List<CMTurnBE> turns = new List<CMTurnBE>();

                if (dr.Read())
                {
                    turns.Add(new CMTurnBE(dr));
                }

                return turns;
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

        static public CMTurnBE get(int turn_id)
        {
            SqlConnection con = new SqlConnection(CMDatabase.getConnection());
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedure.Turn.get, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idVal", turn_id);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return new CMTurnBE(dr);
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

        static public void update(CMTurnBE turn)
        {
            SqlConnection con = new SqlConnection(CMDatabase.getConnection());
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedure.Turn.update, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idVal", turn.turn_id);
                cmd.Parameters.AddWithValue("@day", turn.turn_day);
                cmd.Parameters.AddWithValue("@desc", turn.turn_description);
                cmd.Parameters.AddWithValue("@entryHour", turn.turn_entryHour);
                cmd.Parameters.AddWithValue("@departureHour", turn.turn_departureHour);

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

        static public void delete(int turn_id)
        {
            SqlConnection con = new SqlConnection(CMDatabase.getConnection());
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(CMProcedure.Turn.delete, con);
                cmd.CommandType = CommandType.StoredProcedure;

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
    }
}
