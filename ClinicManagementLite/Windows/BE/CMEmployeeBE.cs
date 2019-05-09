using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementLite.Windows.BE
{
    class CMEmployeeBE : CMPersonBE
    {
        public CMPositionBE employee_position   = new CMPositionBE();
        public CMAreaBE employee_area           = new CMAreaBE();
    }
}
