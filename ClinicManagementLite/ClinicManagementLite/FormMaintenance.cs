using ClinicManagementLite;
using General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementLite
{
    public partial class FormMaintenance : Form
    {
        public MaintenanceController objMaintenanceController;
        
        public FormMaintenance()
        {
            InitializeComponent();
        }

        private void FormList_Load(object sender, EventArgs e)
        {
            this.objMaintenanceController.setupFormMaintenance(this);
        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            Button button   = sender as Button;
            bool isEditing  = Convert.ToBoolean(Convert.ToInt16(button.Tag));
            string selected_id = "0";

            if (this.dgvList.Rows.Count == 0 && isEditing)
            {
                return;
            }

            if (isEditing)
            {
                selected_id = this.dgvList.CurrentRow.Cells[0].Value.ToString();
            }

            if (this.objMaintenanceController is MaintenanceControllerPermission)
            {
                new FormPermission(isEditing, int.Parse(selected_id)).ShowDialog();
            }
            else if (this.objMaintenanceController is MaintenanceControllerArea)
            {
                new FormArea(isEditing, int.Parse(selected_id)).ShowDialog();
            }
            else if (this.objMaintenanceController is MaintenanceControllerPosition)
            {
                new FormPosition(isEditing, int.Parse(selected_id)).ShowDialog();
            }
            else if (this.objMaintenanceController is MaintenanceControllerEmployee)
            {
                new FormEmployee(isEditing, selected_id).ShowDialog();
            }
            else if (this.objMaintenanceController is MaintenanceControllerAccount)
            {
                new FormAccount(isEditing, int.Parse(selected_id)).ShowDialog();
            }
            else if (this.objMaintenanceController is MaintenanceControllerTurn)
            {
                new FormTurn(isEditing, int.Parse(selected_id)).ShowDialog();
            }
            else if (this.objMaintenanceController is MaintenanceControllerSchedule)
            {
                new FormSchedule().ShowDialog();
            }
            else if (this.objMaintenanceController is MaintenanceControllerClient)
            {
                new FormClient(isEditing, selected_id).ShowDialog();
            }

            this.objMaintenanceController.setupFormMaintenance(this);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0)
            {
                return;
            }

            DialogResult result = MessageBox.Show(CMMessage.Maintenance.deleteInstance, CMMessage.Alert.title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No) { return; }

            try
            {
                this.objMaintenanceController.actionDelete(this);
                this.objMaintenanceController.setupFormMaintenance(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, CMMessage.Alert.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
