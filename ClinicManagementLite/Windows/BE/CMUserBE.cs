using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicManagementLite.Windows.General;
using System.Data.SqlClient;

namespace ClinicManagementLite.Windows.BE
{
    class CMUserBE
    {
        public int user_id                      = 0;
        public string user_username             = "";
        public string user_password             = "";
        public int user_employeeId              = 0;
        public CMPermissionBE user_permission   = new CMPermissionBE();

        public static CMUserBE parse(SqlDataReader reader)
        {
            CMUserBE objBE = new CMUserBE();
            
            objBE.user_id           = reader["id"].intValue();
            objBE.user_username     = reader["username"].stringValue();
            objBE.user_password     = reader["password"].stringValue();
            objBE.user_employeeId   = reader["employee_id"].intValue();
            objBE.user_permission   = CMPermissionBE.parse(reader);

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

            objBE.permission_type           = (PermissionType)reader["id"].intValue();
            objBE.permission_description    = reader["description"].stringValue();

            return objBE;
        }
    }
}
