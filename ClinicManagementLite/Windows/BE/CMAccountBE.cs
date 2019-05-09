using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicManagementLite.Windows.General;
using System.Data.SqlClient;

namespace ClinicManagementLite.Windows.BE
{
    class CMAccountBE
    {
        public int account_id                       = 0;
        public string account_username              = "";
        public string account_password              = "";
        public string account_employeeId            = "";
        public CMPermissionBE account_permission    = new CMPermissionBE();

        public static CMAccountBE parse(SqlDataReader reader)
        {
            CMAccountBE objBE = new CMAccountBE();
            
            objBE.account_id            = reader["account_id"].intValue();
            objBE.account_username      = reader["account_username"].stringValue();
            objBE.account_password      = reader["account_password"].stringValue();
            objBE.account_employeeId    = reader["employee_id"].stringValue();
            objBE.account_permission    = CMPermissionBE.parse(reader);

            return objBE;
        }
    }

    class CMPermissionBE
    {
        public PermissionType permission_type   = PermissionType.employee;
        public string permission_description    = "";

        public static CMPermissionBE parse(SqlDataReader reader)
        {
            CMPermissionBE objBE = new CMPermissionBE();

            objBE.permission_type           = (PermissionType)reader["permission_id"].intValue();
            objBE.permission_description    = reader["permission_description"].stringValue();

            return objBE;
        }
    }
}
