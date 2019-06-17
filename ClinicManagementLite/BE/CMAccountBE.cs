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
        public int account_id                       = 0;
        public string account_username              = "";
        public string account_password              = "";
        public CMEmployeeBE account_employee        = new CMEmployeeBE();
        public CMPermissionBE account_permission    = new CMPermissionBE();
        public DateTime account_createdAt           = new DateTime();

        public CMAccountBE() { }

        public CMAccountBE(String username, String password)
        {
            this.account_username = username;
            this.account_password = password;
        }

        public CMAccountBE(SqlDataReader reader)
        {
            this.account_id         = Convert.ToInt16(reader["account_id"].ToString());
            this.account_username   = reader["account_username"].ToString();
            this.account_password   = reader["account_password"].ToString();
            this.account_createdAt  = Convert.ToDateTime(reader["account_created_at"].ToString());
            this.account_employee   = new CMEmployeeBE(reader);
            this.account_permission = new CMPermissionBE(reader);
        }
    }
}
