using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;

namespace ClinicManagementLite
{
    class MaintenanceControllerTurn : MaintenanceController
    {
        public void setupFormMaintenance(FormMaintenance context)
        {
            DataTable dataTable = CMTurnBL.getDataTable();
            context.Text = "Mantenimiento - Turno";
            context.lblTitle.Text = $"Turnos - ({dataTable.Rows.Count})";
            context.dgvList.DataSource = dataTable;
        }

        public void actionDelete(FormMaintenance context)
        {
            int id = int.Parse(context.dgvList.CurrentRow.Cells[0].Value.ToString());
            CMTurnBL.delete(id);
        }
    }
}
