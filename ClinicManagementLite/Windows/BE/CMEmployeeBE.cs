using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementLite.Windows.BE
{
    class CMEmployeeBE : CMPersonBE
    {
        public int employee_id                  = 0;
        public CMPositionBE employee_position   = new CMPositionBE();
        public CMAreaBE employee_area           = new CMAreaBE();
    }
}
