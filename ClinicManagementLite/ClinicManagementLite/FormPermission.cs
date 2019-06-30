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
using General;
using BE;
using BL;

namespace ClinicManagementLite
{
    public partial class FormPermission : Form
    {
        private bool            isEditing;
        private int             permission_id;
        private CMPermissionBE  objPermission = new CMPermissionBE();
        
        public FormPermission(bool isEditing, int permission_id)
        {
            InitializeComponent();

            this.isEditing      = isEditing;
            this.permission_id  = permission_id;
        }

        private void FormMaintenance01_Load(object sender, EventArgs e)
        {
            this.Text           = this.isEditing ? "Actualizar Permiso" : "Insertar Permiso";
            this.btnAction.Text = this.isEditing ? "Actualizar" : "Insertar";

            if (this.isEditing)
            {
                this.objPermission          = CMPermissionBL.get(this.permission_id);
                this.txtDescription.Text    = objPermission.permission_description;
                this.cbxRead.Checked        = objPermission.permission_isRead;
                this.cbxWrite.Checked       = objPermission.permission_isWrite;
            }
        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            this.objPermission.permission_description    = this.txtDescription.Text.Trim();
            this.objPermission.permission_isRead         = this.cbxRead.Checked;
            this.objPermission.permission_isWrite        = this.cbxWrite.Checked;

            try
            {
                if (this.isEditing)
                {
                    CMPermissionBL.update(objPermission);
                }
                else
                {
                    CMPermissionBL.create(objPermission);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, CMMessage.Alert.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextField_OnlyText(object sender, KeyPressEventArgs e)
        {
            Char keypress = e.KeyChar;

            if (!(Char.IsLetter(keypress) || keypress == Convert.ToChar(Keys.Space) || keypress == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
}
