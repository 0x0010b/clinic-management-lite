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
        public int area_id              = 0;
        public string area_description  = "";
        public DateTime area_createdAt  = new DateTime();

        public CMAreaBE() { }

        public CMAreaBE(String description)
        {
            this.area_description = description;
        }

        public CMAreaBE(int id)
        {
            this.area_id = id;
        }

        public CMAreaBE(SqlDataReader reader)
        {
            this.area_id             = int.Parse(reader["area_id"].ToString());
            this.area_description    = reader["area_description"].ToString();
            this.area_createdAt      = Convert.ToDateTime(reader["area_created_at"].ToString());
        }
    }
}
