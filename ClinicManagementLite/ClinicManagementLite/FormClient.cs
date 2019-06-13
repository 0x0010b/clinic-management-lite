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
    class FormClient : FormController
    {
        public void actionDelete(Form ctx)
        {
            FormList form = (FormList)ctx;

            int id = int.Parse(form.dgvList.CurrentRow.Cells[0].Value.ToString());
            CMClientBE client = new CMClientBE();
            client.dni = id;
            CMCLientBL.delete(client);
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

            DataTable dtList = CMCLientBL.getAll();

            form.Text = "Mantenimiento - Cliente";
            form.lblTitle.Text = $"Clientes - ({dtList.Rows.Count})";

            form.dgvList.DataSource = dtList;
        }

        public void setupFormMaintenance(Form ctx)
        {
            FormClientMaintenance form = (FormClientMaintenance)ctx;

            form.Text = form.isEditing ? "Actualizar Cliente" : "Insertar Cliente";
            form.btnPersonData.Text = form.isEditing ? "Actualizar" : "Insertar";
            form.gbxMedHistory.Enabled = form.isEditing;

            if (form.isEditing)
            {
                form.fetchClientData();
                form.setupPersonData();
            }
            else
            {

            }
        }
    }
}
