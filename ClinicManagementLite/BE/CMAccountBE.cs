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
        public string account_employeeID            = "";
        public CMPermissionBE account_permission    = new CMPermissionBE();
        public DateTime account_createdAt           = new DateTime();

        public CMAccountBE(SqlDataReader reader)
        {
            // TODO: - Implement parsing
        }
    }
}
