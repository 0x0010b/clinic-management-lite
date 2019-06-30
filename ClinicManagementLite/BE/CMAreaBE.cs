using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class CMAreaBE
    {
        public int area_id { get; set; } = 0;
        public string area_description { get; set; } = "";
        public DateTime area_createdAt { get; set; } = new DateTime();

        public CMAreaBE() { }

        public CMAreaBE(SqlDataReader reader)
        {
            this.area_id             = Convert.ToInt16(reader["area_id"].ToString());
            this.area_description    = reader["area_description"].ToString();
            this.area_createdAt      = Convert.ToDateTime(reader["area_created_at"].ToString());
        }
    }
}
