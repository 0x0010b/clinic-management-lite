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

        public CMAreaBE(SqlDataReader reader)
        {
            // TODO: - Implement parsing
        }
    }
}
