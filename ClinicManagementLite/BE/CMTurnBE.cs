using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    class CMTurnBE
    {
        public int turn_id                  = 0;
        public DayOfWeek turn_day           = DayOfWeek.Sunday;
        public TimeSpan turn_entryHour      = new TimeSpan();
        public TimeSpan turn_departureHour  = new TimeSpan();

        public CMTurnBE(SqlDataReader reader)
        {
            // TODO: - Implement parsing
        }
    }
}
