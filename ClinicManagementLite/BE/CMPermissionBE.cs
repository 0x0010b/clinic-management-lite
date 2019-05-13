using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BE
{
    class CMPermissionBE
    {
        public int permission_id                = 0;
        public string permission_description    = "";
        public DateTime permission_createdAt    = new DateTime();

        public CMPermissionBE(SqlDataReader reader)
        {
            // TODO: - Implement parsing
        }
    }
}
