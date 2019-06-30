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
    public partial class FormPosition : Form
    {
        private bool isEditing;
        private int position_id;
        private CMPositionBE objPosition = new CMPositionBE();

        public FormPosition(bool isEditing, int position_id)
        {
            InitializeComponent();

            this.isEditing = isEditing;
            this.position_id = position_id;
        }

        private void FormPosition_Load(object sender, EventArgs e)
        {
            this.Text = this.isEditing ? "Actualizar Cargo" : "Insertar Cargo";
            this.btnAction.Text = this.isEditing ? "Actualizar" : "Insertar";

            this.cbxArea.DataSource = CMAreaBL.getAll();
            this.cbxArea.DisplayMember = "area_description";
            this.cbxArea.ValueMember = "area_id";

            if (this.isEditing)
            {
                this.objPosition = CMPositionBL.get(this.position_id);
                this.txtDescription.Text = this.objPosition.position_description;
                this.cbxArea.SelectedValue = this.objPosition.position_area.area_id;
            }
        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            this.objPosition.position_description = this.txtDescription.Text;
            this.objPosition.position_area.area_id = Convert.ToInt16(this.cbxArea.SelectedValue.ToString());

            try
            {
                if (this.isEditing)
                {
                    CMPositionBL.update(this.objPosition);
                }
                else
                {
                    CMPositionBL.create(this.objPosition);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, CMMessage.Alert.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextField_OnlyTextNumber(object sender, KeyPressEventArgs e)
        {
            Char keypress = e.KeyChar;

            if (!(Char.IsLetterOrDigit(keypress) || keypress == Convert.ToChar(Keys.Space) || keypress == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
}
