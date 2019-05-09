using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementLite.Windows.General
{
    public enum PermissionType
    {
        admin = 0,
        employee
    }

    public enum Gender
    {
        male = 0,
        female
    }

    public enum ViewType
    {
        account = 0,
        employee,
        client,
        position,
        area
    }
}
