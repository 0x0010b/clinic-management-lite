using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BL;

namespace ClinicManagementLite
{
    class MaintenanceControllerAccount : MaintenanceController
    {
        public void setupFormMaintenance(FormMaintenance context)
        {
            DataTable dataTable = CMAccountBL.getDataTable();
            context.Text = "Mantenimiento - Cuenta";
            context.lblTitle.Text = $"Cuentas - ({dataTable.Rows.Count})";
            context.dgvList.DataSource = dataTable;
            context.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public void actionDelete(FormMaintenance context)
        {
            int id = int.Parse(context.dgvList.CurrentRow.Cells[0].Value.ToString());
            CMAccountBL.delete(id);
        }
    }
}
