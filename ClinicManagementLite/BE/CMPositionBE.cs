using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class CMPositionBE
    {
        public int position_id              = 0;
        public string position_description  = "";
        public DateTime position_createdAt  = new DateTime();

        public CMPositionBE() { }

        public CMPositionBE(SqlDataReader reader)
        {
            // TODO: - Implement parsing
        }
    }
}
