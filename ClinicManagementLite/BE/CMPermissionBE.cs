using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BE
{
    public class CMPermissionBE
    {
        public int permission_id                = 0;
        public string permission_description    = "";
        public DateTime permission_createdAt    = new DateTime();

        public CMPermissionBE() { }

        public CMPermissionBE(SqlDataReader reader)
        {
            this.permission_id          = int.Parse(reader["permission_id"].ToString());
            this.permission_description = reader["permission_description"].ToString();
        }
    }
}
