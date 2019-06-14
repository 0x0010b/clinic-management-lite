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
    class FormPerson : FormController
    {
        public void actionDelete(Form ctx)
        {
            FormList form = (FormList)ctx;

            int id = int.Parse(form.dgvList.CurrentRow.Cells[0].Value.ToString());
            CMPersonBE person = new CMPersonBE();
            person.dni = id;
            CMPersonBL.delete(person);
        }

        public void actionInsert(Form ctx)
        {
            // TODO - Pending implementation 
        }

        public void actionUpdate(Form ctx)
        {
            // TODO - Pending implementation 
        }

        public void setupFormList(Form ctx)
        {
            FormList form = (FormList)ctx;

            DataTable dtList = CMPersonBL.getAll();

            form.Text = "Mantenimiento - Persona";
            form.lblTitle.Text = $"Personas - ({dtList.Rows.Count})";

            form.dgvList.DataSource = dtList;
        }

        public void setupFormMaintenance(Form ctx)
        {
            FormPersonMaintenance form = (FormPersonMaintenance)ctx;

            form.Text = form.isEditing ? "Actualizar Persona" : "Insertar Persona";
            form.btnPersonData.Text = form.isEditing ? "Actualizar" : "Insertar";

            if (form.isEditing)
            {
                form.setupPersonData();
            }
            else
            {

            }
        }
    }
}
