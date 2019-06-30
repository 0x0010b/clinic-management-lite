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
            int selected_id = int.Parse(this.dgvList.CurrentRow.Cells[0].Value.ToString());

            if (this.objMaintenanceController is MaintenanceControllerPermission)
            {
                new FormPermission(isEditing, selected_id).ShowDialog();
            }
            else if (this.objMaintenanceController is MaintenanceControllerArea)
            {
                new FormArea(isEditing, selected_id).ShowDialog();
            }
            else if (this.objMaintenanceController is MaintenanceControllerPosition)
            {
                new FormPosition(isEditing, selected_id).ShowDialog();
            }

            this.objMaintenanceController.setupFormMaintenance(this);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
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
