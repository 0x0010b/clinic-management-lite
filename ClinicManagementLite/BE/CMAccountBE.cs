using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BE
{
    public class CMAccountBE
    {
        public int account_id { get; set; } = 0;
        public string account_username { get; set; } = "";
        public string account_password { get; set; } = "";
        public CMEmployeeBE account_employee { get; set; } = new CMEmployeeBE();
        public CMPermissionBE account_permission { get; set; } = new CMPermissionBE();
        public DateTime account_createdAt { get; set; } = new DateTime();

        public CMAccountBE() { }
        
        public CMAccountBE(SqlDataReader reader)
        {
            this.account_id         = Convert.ToInt16(reader["account_id"].ToString());
            this.account_username   = reader["account_username"].ToString();
            this.account_password   = reader["account_password"].ToString();
            this.account_employee   = new CMEmployeeBE(reader);
            this.account_permission = new CMPermissionBE(reader);
            this.account_createdAt = Convert.ToDateTime(reader["account_created_at"].ToString());
        }
    }
}
