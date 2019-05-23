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
    class FormArea : FormController
    {
        public void actionDelete(Form ctx)
        {
            FormList form = (FormList)ctx;

            int id = int.Parse(form.dgvList.CurrentRow.Cells[0].Value.ToString());
            CMAreaBL.delete(new CMAreaBE(id));
        }

        public void actionInsert(Form ctx)
        {
            FormMaintenance01 form = (FormMaintenance01)ctx;
            CMAreaBL.create(new CMAreaBE(form.txtDescription.Text));
        }

        public void actionUpdate(Form ctx)
        {
            FormMaintenance01 form = (FormMaintenance01)ctx;
            CMAreaBL.update(new CMAreaBE(form.instanceID, form.txtDescription.Text));
        }

        public void setupFormList(Form ctx)
        {
            FormList form = (FormList)ctx;

            DataTable dtList = CMAreaBL.getAll();

            form.Text = "Mantenimiento - Area";
            form.lblTitle.Text = $"Areas - ({dtList.Rows.Count})";

            form.dgvList.DataSource = dtList;
        }

        public void setupFormMaintenance(Form ctx)
        {
            FormMaintenance01 form = (FormMaintenance01)ctx;

            form.Text = form.isEditing ? "Actualizar Area" : "Insertar Area";
            form.btnAction.Text = form.isEditing ? "Actualizar" : "Insertar";
            form.gbPermission.Enabled = false;

            if (form.isEditing)
            {
                try
                {
                    CMAreaBE area = CMAreaBL.get(new CMAreaBE(form.instanceID));
                    form.txtDescription.Text = area.area_description;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message); // TODO: - Fix
                }
            }
        }

    }
}
