using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BL;
using General;

namespace ClinicManagementLite
{
    public partial class FormArea : Form
    {
        private bool        isEditing;
        private int         area_id;
        private CMAreaBE    objArea = new CMAreaBE();

        public FormArea(bool isEditing, int area_id)
        {
            InitializeComponent();

            this.isEditing  = isEditing;
            this.area_id    = area_id;
        }

        private void FormArea_Load(object sender, EventArgs e)
        {
            this.Text           = this.isEditing ? "Actualizar Area" : "Insertar Area";
            this.btnAction.Text = this.isEditing ? "Actualizar" : "Insertar";

            if (this.isEditing)
            {
                this.objArea        = CMAreaBL.get(this.area_id);
                this.txtDescription.Text = objArea.area_description;
            }
        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            this.objArea.area_description = this.txtDescription.Text;

            try
            {
                if (this.isEditing)
                {
                    CMAreaBL.update(this.objArea);
                }
                else
                {
                    CMAreaBL.create(this.objArea);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, CMMessage.Alert.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
