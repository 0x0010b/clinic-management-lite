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
        public CMAreaBE position_area       = new CMAreaBE();
        public DateTime position_createdAt  = new DateTime();

        public CMPositionBE() { }

        public CMPositionBE(SqlDataReader reader)
        {
            this.position_id            = Convert.ToInt16(reader["position_id"].ToString());
            this.position_description   = reader["position_description"].ToString();
            this.position_area          = new CMAreaBE(reader);
            this.position_createdAt     = Convert.ToDateTime(reader["position_created_at"].ToString());
        }
    }
}
