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
                case "ClinicManagementLite.FormPermission":
                case "ClinicManagementLite.FormArea":
                case "ClinicManagementLite.FormPosition":

                    FormMaintenance01 form = new FormMaintenance01();

                    form.objFormController = this.objFormController;
                    form.isEditing = false;
                    form.ShowDialog(this);

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
                case "ClinicManagementLite.FormPermission":
                case "ClinicManagementLite.FormArea":
                case "ClinicManagementLite.FormPosition":

                    FormMaintenance01 form = new FormMaintenance01();

                    form.objFormController = this.objFormController;
                    form.instanceID = int.Parse(dgvList.CurrentRow.Cells[0].Value.ToString());
                    form.isEditing = true;
                    form.ShowDialog(this);

                    this.objFormController.setupFormList(this);
                    break;

                default:
                    break;
            }
        }
    }
}
