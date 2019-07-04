using BL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementLite
{
    class MaintenanceControllerClient : MaintenanceController
    {
        public void setupFormMaintenance(FormMaintenance context)
        {
            DataTable dataTable = CMClientBL.getDataTable();
            context.Text = "Mantenimiento - Cliente";
            context.lblTitle.Text = $"Clientes - ({dataTable.Rows.Count})";
            context.dgvList.DataSource = dataTable;
            context.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public void actionDelete(FormMaintenance context)
        {
            string id = context.dgvList.CurrentRow.Cells[0].Value.ToString();
            CMClientBL.delete(id);
        }
    }
}
