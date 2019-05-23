using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using BE;
using System.Data;
using System.Data.SqlClient;
using General;

namespace ClinicManagementLite
{
    class FormPosition : FormController
    {
        public void actionDelete(Form ctx)
        {
            FormList form = (FormList)ctx;

            int id = int.Parse(form.dgvList.CurrentRow.Cells[0].Value.ToString());
            CMPositionBL.delete(new CMPositionBE(id));
        }

        public void actionInsert(Form ctx)
        {
            FormMaintenance01 form = (FormMaintenance01)ctx;
            CMPositionBL.create(new CMPositionBE(form.txtDescription.Text));
        }

        public void actionUpdate(Form ctx)
        {
            FormMaintenance01 form = (FormMaintenance01)ctx;
            CMPositionBL.update(new CMPositionBE(form.instanceID, form.txtDescription.Text));
        }

        public void setupFormList(Form ctx)
        {
            FormList form = (FormList)ctx;

            DataTable dtList = CMPositionBL.getAll();

            form.Text = "Mantenimiento - Cargo";
            form.lblTitle.Text = $"Cargos - ({dtList.Rows.Count})";

            form.dgvList.DataSource = dtList;
        }

        public void setupFormMaintenance(Form ctx)
        {
            FormMaintenance01 form = (FormMaintenance01)ctx;

            form.Text = form.isEditing ? "Actualizar Cargo" : "Insertar Cargo";
            form.btnAction.Text = form.isEditing ? "Actualizar" : "Insertar";
            form.gbPermission.Enabled = false;

            if (form.isEditing)
            {
                try
                {
                    CMPositionBE position = CMPositionBL.get(new CMPositionBE(form.instanceID));
                    form.txtDescription.Text = position.position_description;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message); // TODO: - Fix
                }
            }
        }

    }
}
