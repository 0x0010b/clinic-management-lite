using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    public enum Gender
    {
        male = 0,
        female
    }

    public enum Sort
    {
        name = 0,
        oldest,
        recent
    }

    public enum Permission
    {
        admin = 0,
        employee
    }

    public enum View
    {
        account = 0,
        permission,
        employee,
        client,
        position,
        area
    }
}
