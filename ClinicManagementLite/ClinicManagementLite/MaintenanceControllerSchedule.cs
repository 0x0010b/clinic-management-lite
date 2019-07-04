using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;

namespace ClinicManagementLite
{
    class MaintenanceControllerSchedule : MaintenanceController
    {
        public void setupFormMaintenance(FormMaintenance context)
        {
            DataTable dataTable = CMScheduleBL.getDataTable();
            context.Text = "Mantenimiento - Horario";
            context.lblTitle.Text = $"Horarios - ({dataTable.Rows.Count})";
            context.dgvList.DataSource = dataTable;
            context.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public void actionDelete(FormMaintenance context)
        {
            int id = int.Parse(context.dgvList.CurrentRow.Cells[0].Value.ToString());
            CMAreaBL.delete(id);
        }
    }
}
