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
        public int permission_isRead            = 0;
        public int permission_isWrite           = 0;
        public DateTime permission_createdAt    = new DateTime();

        public CMPermissionBE() { }

        public CMPermissionBE(SqlDataReader reader)
        {
            this.permission_id          = Convert.ToInt16(reader["permission_id"].ToString());
            this.permission_description = reader["permission_description"].ToString();
            this.permission_isRead      = Convert.ToInt16(reader["permission_is_read"]);
            this.permission_isWrite     = Convert.ToInt16(reader["permission_is_write"]);
            this.permission_createdAt   = Convert.ToDateTime(reader["permission_created_at"].ToString());
        }
    }
}
