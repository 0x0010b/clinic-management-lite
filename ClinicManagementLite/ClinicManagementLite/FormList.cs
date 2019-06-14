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
    public partial class FormList : Form
    {
        public FormController objFormController;

        public FormList()
        {
            InitializeComponent();
        }

        private void FormList_Load(object sender, EventArgs e)
        {
            this.objFormController.setupFormList(this);

            enableMaintenanceActions();
        }

        private void enableMaintenanceActions()
        {
            switch (this.objFormController.GetType().ToString())
            {
                case CMForms.formPerson:
                    gbxMaintenance.Enabled = true;
                    break;
                default:
                    gbxMaintenance.Enabled = true;
                    break;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(CMMessage.Maintenance.deleteInstance, CMMessage.Alert.title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No) { return; }

            try
            {
                this.objFormController.actionDelete(this);
                this.objFormController.setupFormList(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, CMMessage.Alert.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            switch(this.objFormController.GetType().ToString())
            {
                case CMForms.formPermission:
                case CMForms.formArea:
                case CMForms.formPosition:

                    FormMaintenance01 form = new FormMaintenance01();

                    form.objFormController = this.objFormController;
                    form.isEditing = false;
                    form.ShowDialog(this);

                    this.objFormController.setupFormList(this);
                    break;

                case CMForms.formClient:
                    FormClientMaintenance formClient = new FormClientMaintenance();

                    formClient.objFormController = this.objFormController;
                    formClient.isEditing = false;
                    formClient.ShowDialog(this);

                    this.objFormController.setupFormList(this);
                    break;
                case CMForms.formPerson:
                    FormPersonMaintenance formPerson = new FormPersonMaintenance();

                    formPerson.objFormController = this.objFormController;
                    formPerson.isEditing = false;
                    formPerson.ShowDialog(this);

                    this.objFormController.setupFormList(this);
                    break;

                default:
                    break;
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            switch (this.objFormController.GetType().ToString())
            {
                case CMForms.formPermission:
                case CMForms.formArea:
                case CMForms.formPosition:

                    FormMaintenance01 formMaintenance = new FormMaintenance01();

                    formMaintenance.objFormController = this.objFormController;
                    formMaintenance.instanceID = int.Parse(dgvList.CurrentRow.Cells[0].Value.ToString());
                    formMaintenance.isEditing = true;
                    formMaintenance.ShowDialog(this);

                    this.objFormController.setupFormList(this);
                    break;

                case CMForms.formClient:
                    FormClientMaintenance formClient = new FormClientMaintenance();

                    formClient.objFormController = this.objFormController;
                    formClient.instanceID = int.Parse(dgvList.CurrentRow.Cells[0].Value.ToString());
                    formClient.isEditing = true;
                    formClient.ShowDialog(this);

                    this.objFormController.setupFormList(this);
                    break;

                case CMForms.formPerson:
                    FormPersonMaintenance formPerson = new FormPersonMaintenance();

                    formPerson.objFormController = this.objFormController;
                    formPerson.isEditing = true;
                    formPerson.fetchPersonData(int.Parse(dgvList.CurrentRow.Cells[0].Value.ToString()));
                    formPerson.ShowDialog(this);

                    this.objFormController.setupFormList(this);
                    break;

                default:
                    break;
            }
        }
    }
}
