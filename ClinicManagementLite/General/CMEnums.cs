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

    public enum FormControllerKey
    {
        account = 0,
        permission,
        area,
        position,
        person,
        employee,
        client
    }
}
