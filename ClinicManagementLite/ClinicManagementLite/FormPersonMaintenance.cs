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
    public partial class FormPersonMaintenance : Form
    {
        public bool isEditing;
        public FormController objFormController;
        public CMClientBE client;
        public CMEmployeeBE employee;
        public CMPersonBE person;
        public PersonType type;

        public FormPersonMaintenance()
        {
            InitializeComponent();
        }

        private void FormPersonMaintenance_Load(object sender, EventArgs e)
        {
            this.objFormController.setupFormMaintenance(this);
        }

        private void btnPersonData_Click(object sender, EventArgs e)
        {
            try
            {
                if (isEditing)
                {
                    updatePerson();
                }
                else
                {
                    insertPerson();
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, CMMessage.Alert.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void insertPerson()
        {
            try
            {
                person = new CMPersonBE();
                person.dni = int.Parse(txtPersonDni.Text);
                person.name = txtPersonName.Text;
                person.lastname = txtPersonLastname.Text;
                person.phone = txtPersonNumber.Text;
                person.birthday = Convert.ToDateTime(dtpPersonBirthday.Text);
                person.address = txtPersonAddress.Text;
                person.gender = cbxPersonGender.SelectedIndex == 0 ? Gender.male : Gender.female;
                person.image = txtPersonImage.Text;

                CMPersonBL.create(person);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, CMMessage.Alert.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updatePerson()
        {
            try
            {
                person = new CMPersonBE();
                person.dni = int.Parse(txtPersonDni.Text);
                person.name = txtPersonName.Text;
                person.lastname = txtPersonLastname.Text;
                person.phone = txtPersonNumber.Text;
                person.birthday = Convert.ToDateTime(dtpPersonBirthday.Text);
                person.address = txtPersonAddress.Text;
                person.gender = cbxPersonGender.SelectedIndex == 0 ? Gender.male : Gender.female;
                person.image = txtPersonImage.Text;

                CMPersonBL.update(person);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, CMMessage.Alert.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void fetchPersonData(int instanceID)
        {
            try
            {
                CMPersonBE person = new CMPersonBE();
                person.dni = instanceID;
                this.person = CMPersonBL.get(person);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, CMMessage.Alert.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void setupPersonData()
        {
            txtPersonDni.Text = person.dni.ToString();
            txtPersonName.Text = person.name;
            txtPersonLastname.Text = person.lastname;
            txtPersonNumber.Text = person.phone;
            dtpPersonBirthday.Value = person.birthday;
            txtPersonAddress.Text = person.address;
            cbxPersonGender.SelectedIndex = (int)person.gender;
            txtPersonImage.Text = person.image;
        }
    }
}
