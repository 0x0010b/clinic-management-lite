using BE;
using BL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementLite
{
    class MaintenanceControllerPermission : MaintenanceController
    {
        public void setupFormMaintenance(FormMaintenance context)
        {
            DataTable dataTable         = CMPermissionBL.getDataTable();
            context.Text                = "Mantenimiento - Permiso";
            context.lblTitle.Text       = $"Permisos - ({dataTable.Rows.Count})";
            context.dgvList.DataSource  = dataTable;
        }

        public void actionDelete(FormMaintenance context)
        {
            int id = int.Parse(context.dgvList.CurrentRow.Cells[0].Value.ToString());
            CMPermissionBL.delete(id);
        }
    }
}
