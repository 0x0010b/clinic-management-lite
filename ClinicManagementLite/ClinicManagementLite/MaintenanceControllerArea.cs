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
    class MaintenanceControllerArea : MaintenanceController
    {
        public void setupFormMaintenance(FormMaintenance context)
        {
            DataTable dataTable         = CMAreaBL.getDataTable();
            context.Text                = "Mantenimiento - Area";
            context.lblTitle.Text       = $"Areas - ({dataTable.Rows.Count})";
            context.dgvList.DataSource  = dataTable;
        }

        public void actionDelete(FormMaintenance context)
        {
            int id = int.Parse(context.dgvList.CurrentRow.Cells[0].Value.ToString());
            CMAreaBL.delete(id);
        }
    }
}
