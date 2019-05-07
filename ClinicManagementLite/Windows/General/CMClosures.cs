using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementLite.Windows.General
{
    delegate void Success();
    delegate void Error(string errorMessage);
    delegate void Login(bool status, int id, PermissionType permission);
}
