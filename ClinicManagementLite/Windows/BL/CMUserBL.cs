using ClinicManagementLite.Windows.DA;
using ClinicManagementLite.Windows.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementLite.Windows.BL
{
    class CMUserBL
    {
        public static void login(string username, string password, Login success, Error error)
        {
            // TODO: - Validaciones
            CMUserDA.login(username, password, success, error);
        }
    }
}
