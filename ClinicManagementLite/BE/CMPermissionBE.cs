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
        public int permission_id { get; set; } = 0;
        public string permission_description { get; set; } = "";
        public bool permission_isRead { get; set; } = false;
        public bool permission_isWrite { get; set; } = false;
        public DateTime permission_createdAt { get; set; } = new DateTime();

        public CMPermissionBE() { }

        public CMPermissionBE(SqlDataReader reader)
        {
            this.permission_id          = Convert.ToInt16(reader["permission_id"].ToString());
            this.permission_description = reader["permission_description"].ToString();
            this.permission_isRead      = Convert.ToBoolean(reader["permission_is_read"]);
            this.permission_isWrite     = Convert.ToBoolean(reader["permission_is_write"]);
            this.permission_createdAt   = Convert.ToDateTime(reader["permission_created_at"].ToString());
        }
    }
}
