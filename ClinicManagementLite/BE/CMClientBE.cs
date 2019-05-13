using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BE
{
    public class CMClientBE : CMPersonBE
    {
        public string client_weight         = "";
        public string client_height         = "";
        public string client_bloodType      = "";
        public string client_bloodPressure  = "";
        public string client_allergies      = "";
        public string client_pathologies    = "";
        public string client_medicines      = "";
        public string client_seizures       = "";
        public string client_diabetes       = "";
        public string client_cholesterol    = "";
        public string client_cancer         = "";
        public string client_aids           = "";

        public CMClientBE(SqlDataReader reader)
        {
            // TODO: - Implement parsing
        }
    }
}
