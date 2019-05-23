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

namespace ClinicManagementLite
{
    public partial class FormMaintenance01 : Form
    {
        public bool             isEditing;
        public int              instanceID;
        public FormController   objFormController;

        public FormMaintenance01()
        {
            InitializeComponent();
        }

        private void FormMaintenance01_Load(object sender, EventArgs e)
        {
            this.objFormController.setupFormMaintenance(this);
        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.isEditing)
                {
                    this.objFormController.actionUpdate(this);
                }
                else
                {
                    this.objFormController.actionInsert(this);
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
