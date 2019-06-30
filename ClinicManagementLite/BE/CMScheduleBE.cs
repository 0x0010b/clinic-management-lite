using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class CMScheduleBE
    {
        public CMEmployeeBE schedule_employee { get; set; } = new CMEmployeeBE();
        public CMTurnBE schedule_turn { get; set; } = new CMTurnBE();
        public DateTime schedule_created_at { get; set; } = new DateTime();

        public CMScheduleBE() { }

        public CMScheduleBE(SqlDataReader reader)
        {
            this.schedule_employee      = new CMEmployeeBE(reader);
            this.schedule_turn          = new CMTurnBE(reader);
            this.schedule_created_at    = Convert.ToDateTime(reader["schedule_created_at"].ToString());
        }
    }
}
