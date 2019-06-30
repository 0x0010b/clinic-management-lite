using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementLite
{
    public interface MaintenanceController
    {
        void setupFormMaintenance(FormMaintenance context);
        void actionDelete(FormMaintenance context);
    }
}
