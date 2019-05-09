using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementLite.Windows.BE
{
    class CMTurnBE
    {
        public int turn_id                  = 0;
        public DayOfWeek turn_day           = DayOfWeek.Sunday;
        public TimeSpan turn_entryHour      = new TimeSpan();
        public TimeSpan turn_departureHour  = new TimeSpan();
    }
}