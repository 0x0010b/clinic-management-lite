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
    public partial class FormClientMaintenance : Form
    {
        public bool             isEditing;
        public int              instanceID;
        public FormController   objFormController;
        private CMClientBE      client;

        private FormControllerFactory formFactory = new FormControllerFactory();

        public FormClientMaintenance()
        {
            InitializeComponent();
        }

        private void FormClientMaintenance_Load(object sender, EventArgs e)
        {
            this.objFormController.setupFormMaintenance(this);
        }

        private void BtnPersonData_Click(object sender, EventArgs e)
        {
            if (this.isEditing)
            {
                FormPersonMaintenance formPerson = new FormPersonMaintenance();

                formPerson.objFormController = this.formFactory.getInstance(FormControllerKey.person);
                formPerson.isEditing = true;
                formPerson.client = this.client;
                formPerson.ShowDialog(this);

                this.fetchClientData();
                this.setupPersonData();
            }
            else
            {
                FormPersonMaintenance formPerson = new FormPersonMaintenance();

                formPerson.objFormController = this.formFactory.getInstance(FormControllerKey.person);
                formPerson.isEditing = false;
                formPerson.ShowDialog(this);

                //this.fetchClientData();
                //this.setupPersonData();
                //gbxMedHistory.Enabled = true;
            }
        }

        public void fetchClientData()
        {
            try
            {
                CMClientBE client = new CMClientBE();
                client.dni = instanceID;
                this.client = CMCLientBL.get(client);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, CMMessage.Alert.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void setupPersonData()
        {
            lblPersonDni.Text = client.dni.ToString();
            lblPersonName.Text = client.name;
            lblPersonLastname.Text = client.lastname;
            lblPersonNumber.Text = client.phone;
            lblPersonBirthday.Text = client.birthday.ToString("MM/dd/yyyy");
            lblPersonAddress.Text = client.address;
            lblPersonGenre.Text = client.gender.GetType().Name;
            lblPersonImage.Text = client.image;
        }
    }
}
