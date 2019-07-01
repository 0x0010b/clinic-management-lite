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
    public partial class FormAccount : Form
    {
        private bool isEditing;
        private int account_id;
        private CMAccountBE objAccount = new CMAccountBE();

        public FormAccount(bool isEditing, int account_id)
        {
            InitializeComponent();

            this.isEditing = isEditing;
            this.account_id = account_id;
        }

        private void FormAccount_Load(object sender, EventArgs e)
        {
            this.Text = this.isEditing ? "Actualizar Cuenta" : "Insertar Cuenta";
            this.btnAction.Text = this.isEditing ? "Actualizar" : "Insertar";

            this.cbxPermission.DisplayMember = "permission_description";
            this.cbxPermission.ValueMember = "permission_id";

            this.cbxEmployee.DisplayMember = "employee_nameAndDni";
            this.cbxEmployee.ValueMember = "person_dni";

            try
            {
                this.cbxPermission.DataSource = CMPermissionBL.getAll();
                this.cbxEmployee.DataSource = CMEmployeeBL.getAll();

                if (this.isEditing)
                {
                    this.objAccount = CMAccountBL.get(this.account_id);

                    this.txtUsername.Text = this.objAccount.account_username;
                    this.txtPassword.Text = this.objAccount.account_password;
                    this.cbxPermission.SelectedValue = this.objAccount.account_permission.permission_id;
                    this.cbxEmployee.SelectedValue = this.objAccount.account_employee.person_dni;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, CMMessage.Alert.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            this.objAccount.account_username = this.txtUsername.Text.Trim();
            this.objAccount.account_password = this.txtPassword.Text.Trim();
            this.objAccount.account_permission.permission_id = Convert.ToInt16(this.cbxPermission.SelectedValue);
            this.objAccount.account_employee.person_dni = this.cbxEmployee.SelectedValue.ToString();

            try
            {
                if (this.isEditing)
                {
                    CMAccountBL.update(this.objAccount);
                }
                else
                {
                    CMAccountBL.create(this.objAccount);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, CMMessage.Alert.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextField_OnlyTextNumbers(object sender, KeyPressEventArgs e)
        {
            Char keypress = e.KeyChar;

            if (!(Char.IsLetterOrDigit(keypress) || keypress == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
}
