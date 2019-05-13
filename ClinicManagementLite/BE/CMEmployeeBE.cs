using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BE
{
    public class CMEmployeeBE : CMPersonBE
    {
        public CMAreaBE area            = new CMAreaBE();
        public CMPositionBE position    = new CMPositionBE();

        public CMEmployeeBE() { }

        public CMEmployeeBE(SqlDataReader reader)
        {
            // TODO: - Implement parsing
        }
    }
}
