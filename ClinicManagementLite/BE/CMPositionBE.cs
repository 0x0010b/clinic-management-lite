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
        public int position_id { get; set; } = 0;
        public string position_description { get; set; } = "";
        public CMAreaBE position_area { get; set; } = new CMAreaBE();
        public DateTime position_createdAt { get; set; } = new DateTime();

        public CMPositionBE() { }

        public CMPositionBE(int id, string description)
        {
            this.position_id = id;
            this.position_description = description;
        }

        public CMPositionBE(SqlDataReader reader)
        {
            this.position_id            = Convert.ToInt16(reader["position_id"].ToString());
            this.position_description   = reader["position_description"].ToString();
            this.position_area          = new CMAreaBE(reader);
            this.position_createdAt     = Convert.ToDateTime(reader["position_created_at"].ToString());
        }
    }
}
