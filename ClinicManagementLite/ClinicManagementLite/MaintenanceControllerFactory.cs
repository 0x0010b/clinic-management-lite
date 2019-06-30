using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using General;

namespace ClinicManagementLite
{
    public class MaintenanceControllerFactory
    {
        public MaintenanceController getInstance(MaintenanceControllerKey key)
        {
            switch(key)
            {
                case MaintenanceControllerKey.permission:
                    return new MaintenanceControllerPermission();

                case MaintenanceControllerKey.area:
                    return new MaintenanceControllerArea();

                case MaintenanceControllerKey.position:
                    return new MaintenanceControllerPosition();

                default:
                    return null;
            }
        }
    }
}
