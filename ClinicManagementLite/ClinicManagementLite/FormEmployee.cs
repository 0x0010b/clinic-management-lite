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
    public partial class FormEmployee : Form
    {
        private bool isEditing;
        private string person_dni;
        private CMEmployeeBE objEmployee = new CMEmployeeBE();

        public FormEmployee(bool isEditing, string person_dni)
        {
            InitializeComponent();

            this.isEditing = isEditing;
            this.person_dni = person_dni;
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            this.Text = this.isEditing ? "Actualizar Empleado" : "Insertar Empleado";
            this.btnAction.Text = this.isEditing ? "Actualizar" : "Insertar";

            this.pickerDateTime.MinDate = new DateTime(DateTime.Now.Year - 70, DateTime.Now.Month, DateTime.Now.Day);
            this.pickerDateTime.MaxDate = new DateTime(DateTime.Now.Year - 18, DateTime.Now.Month, DateTime.Now.Day);

            this.cbxGender.SelectedIndex = 0;

            this.cbxPosition.DisplayMember = "position_description";
            this.cbxPosition.ValueMember = "position_id";

            this.cbxArea.DisplayMember = "area_description";
            this.cbxArea.ValueMember = "area_id";
            this.cbxArea.DataSource = CMAreaBL.getAll();

            if (this.isEditing)
            {
                this.txtDni.Enabled = false;
                this.objEmployee = CMEmployeeBL.get(this.person_dni);
                this.txtDni.Text = this.objEmployee.person_dni;
                this.txtName.Text = this.objEmployee.person_name;
                this.txtLastName.Text = this.objEmployee.person_lastname;
                this.txtPhone.Text = this.objEmployee.person_phone;
                this.txtAddress.Text = this.objEmployee.person_address;
                this.cbxGender.SelectedIndex = this.objEmployee.person_gender;
                this.cbxArea.SelectedValue = this.objEmployee.employee_position.position_area.area_id;
                this.cbxPosition.SelectedValue = this.objEmployee.employee_position.position_id;
                this.pickerDateTime.Value = this.objEmployee.person_birthday;
            }
        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            this.objEmployee.person_dni = this.txtDni.Text.Trim();
            this.objEmployee.person_name = this.txtName.Text.Trim();
            this.objEmployee.person_lastname = this.txtLastName.Text.Trim();
            this.objEmployee.person_phone = this.txtPhone.Text.Trim();
            this.objEmployee.person_birthday = this.pickerDateTime.Value;
            this.objEmployee.person_address = this.txtAddress.Text.Trim();
            this.objEmployee.person_gender = this.cbxGender.SelectedIndex;
            this.objEmployee.employee_position.position_id = Convert.ToInt16(this.cbxPosition.SelectedValue);

            // TODO: - FALTA IMAGE

            try
            {
                if (this.isEditing)
                {
                    CMEmployeeBL.update(this.objEmployee);
                }
                else
                {
                    CMEmployeeBL.create(this.objEmployee);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, CMMessage.Alert.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxArea_SelectedValueChanged(object sender, EventArgs e)
        {
            this.cbxPosition.DataSource = CMPositionBL.getAll(Convert.ToInt16(this.cbxArea.SelectedValue));
        }

        private void TextField_OnlyText(object sender, KeyPressEventArgs e)
        {
            Char keypress = e.KeyChar;

            if (!(Char.IsLetter(keypress) || keypress == Convert.ToChar(Keys.Space) || keypress == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void TextField_OnlyNumber(object sender, KeyPressEventArgs e)
        {
            Char keypress = e.KeyChar;

            if (!(Char.IsDigit(keypress) || keypress == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
}
