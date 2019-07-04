using BL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementLite
{
    class MaintenanceControllerEmployee : MaintenanceController
    {
        public void setupFormMaintenance(FormMaintenance context)
        {
            DataTable dataTable = CMEmployeeBL.getDataTable();
            context.Text = "Mantenimiento - Empleado";
            context.lblTitle.Text = $"Empleados - ({dataTable.Rows.Count})";
            context.dgvList.DataSource = dataTable;
            context.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public void actionDelete(FormMaintenance context)
        {
            string id = context.dgvList.CurrentRow.Cells[0].Value.ToString();
            CMEmployeeBL.delete(id);
        }
    }
}
