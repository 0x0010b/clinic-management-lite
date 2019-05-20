using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using BE;
using System.Data;

namespace ClinicManagementLite
{
    class FormPermission : FormView
    {
        public void actionDelete(Form ctx)
        {
            FormList form = (FormList)ctx;

            try
            {
                CMPermissionBL.delete(form.getCellId());
                this.setupFormList(form);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void actionInsert(Form ctx)
        {
            
        }

        public void actionUpdate(Form ctx)
        {
            
        }

        public void setupFormList(Form ctx)
        {
            FormList form = (FormList)ctx;

            DataTable dtList = CMPermissionBL.getAll();

            form.Text = "Mantenimiento - Permiso";
            form.lblTitle.Text = $"Permisos - ({dtList.Rows.Count})";

            form.dgvList.DataSource = dtList;
        }

        public void setupFormMaintenance(Form ctx)
        {
            FormMaintenance01 form = (FormMaintenance01)ctx;

            if (form.isEditing)
            {
                // TODO: - Setup for update form
            }
            else
            {
                form.Text = "Insertar Permiso";
                form.btnAction.Text = "Insertar";
                form.gbPermission.Enabled = true;
            }
        }
    }
}
