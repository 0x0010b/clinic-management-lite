using ClinicManagementLite.Windows.BE;
using ClinicManagementLite.Windows.DA;
using ClinicManagementLite.Windows.General;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementLite.Windows.BL
{
    class CMUserBL
    {
        public static CMUserBE login(CMUserBE objUser)
        {
            try
            {
                return CMUserDAL.login(objUser);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
