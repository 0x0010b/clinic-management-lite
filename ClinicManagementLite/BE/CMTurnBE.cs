using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class CMTurnBE
    {
        public int turn_id                  = 0;
        public string turn_description      = "";
        public int turn_day                 = 0;
        public DateTime turn_entryHour      = new DateTime();
        public DateTime turn_departureHour  = new DateTime();
        public DateTime turn_createdAt      = new DateTime();

        public CMTurnBE() { }

        public CMTurnBE(SqlDataReader reader)
        {
            this.turn_id            = Convert.ToInt16(reader["turn_id"].ToString());
            this.turn_description   = reader["turn_description"].ToString();
            this.turn_day           = Convert.ToInt16(reader["turn_day"].ToString());
            this.turn_entryHour     = Convert.ToDateTime(reader["turn_entry_hour"].ToString());
            this.turn_departureHour = Convert.ToDateTime(reader["turn_departuree_hour"].ToString());
            this.turn_createdAt     = Convert.ToDateTime(reader["turn_created_at"].ToString());
        }
    }
}
