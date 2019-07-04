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
    public partial class FormClient : Form
    {
        private bool isEditing;
        private string person_dni;
        private CMClientBE objClient = new CMClientBE();

        public FormClient(bool isEditing, string person_dni)
        {
            InitializeComponent();
            this.isEditing = isEditing;
            this.person_dni = person_dni;
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            this.Text = this.isEditing ? "Actualizar Cliente" : "Insertar Cliente";
            this.btnAction.Text = this.isEditing ? "Actualizar" : "Insertar";

            this.pickerDateTime.MinDate = new DateTime(DateTime.Now.Year - 130, DateTime.Now.Month, DateTime.Now.Day);
            this.pickerDateTime.MaxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

            this.cbxGender.SelectedIndex = 0;

            try
            {
                if (this.isEditing)
                {
                    this.objClient = CMClientBL.get(this.person_dni);

                    //person values
                    this.txtDni.Enabled = false;
                    this.txtDni.Text = this.objClient.person_dni;
                    this.txtName.Text = this.objClient.person_name;
                    this.txtLastName.Text = this.objClient.person_lastname;
                    this.txtPhone.Text = this.objClient.person_phone;
                    this.txtAddress.Text = this.objClient.person_address;
                    this.cbxGender.SelectedIndex = this.objClient.person_gender;
                    this.pickerDateTime.Value = this.objClient.person_birthday;

                    //med history values (client)
                    this.txtWheight.Text = this.objClient.client_weight;
                    this.txtHeight.Text = this.objClient.client_height;
                    this.txtBloodType.Text = this.objClient.client_bloodType;
                    this.txtBloodPressure.Text = this.objClient.client_bloodPressure;
                    this.txtAllergies.Text = this.objClient.client_allergies;
                    this.txtPathologies.Text = this.objClient.client_pathologies;
                    this.txtMedicines.Text = this.objClient.client_medicines;
                    this.txtSeizures.Text = this.objClient.client_seizures;
                    this.txtDiabetes.Text = this.objClient.client_diabetes;
                    this.txtCancer.Text = this.objClient.client_cancer;
                    this.txtAids.Text = this.objClient.client_aids;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, CMMessage.Alert.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            //person values
            this.objClient.person_dni = this.txtDni.Text.Trim();
            this.objClient.person_name = this.txtName.Text.Trim();
            this.objClient.person_lastname = this.txtLastName.Text.Trim();
            this.objClient.person_phone = this.txtPhone.Text.Trim();
            this.objClient.person_birthday = this.pickerDateTime.Value;
            this.objClient.person_address = this.txtAddress.Text.Trim();
            this.objClient.person_gender = this.cbxGender.SelectedIndex;

            //client values
            this.objClient.client_weight = this.txtWheight.Text.Trim();
            this.objClient.client_height = this.txtHeight.Text.Trim();
            this.objClient.client_bloodType = this.txtBloodType.Text.Trim();
            this.objClient.client_bloodPressure = this.txtBloodPressure.Text.Trim();
            this.objClient.client_allergies = this.txtAllergies.Text.Trim();
            this.objClient.client_pathologies = this.txtPathologies.Text.Trim();
            this.objClient.client_medicines = this.txtMedicines.Text.Trim();
            this.objClient.client_seizures = this.txtSeizures.Text.Trim();
            this.objClient.client_diabetes = this.txtDiabetes.Text.Trim();
            this.objClient.client_cancer = this.txtCancer.Text.Trim();
            this.objClient.client_aids = this.txtAids.Text.Trim();

            try
            {
                if (this.isEditing)
                {
                    CMClientBL.update(this.objClient);
                }
                else
                {
                    CMClientBL.create(this.objClient);
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
