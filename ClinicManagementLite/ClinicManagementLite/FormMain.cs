using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using BE;
using General;

namespace ClinicManagementLite
{
    public partial class FormMain : Form
    {
        private FormControllerFactory formFactory = new FormControllerFactory();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (CMUserSession.shared.getUserInformation() == null)
            {
                FormLogin login = new FormLogin();
                login.ShowDialog(this);
            }
        }

        private void CerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall) { return; }

            DialogResult result = MessageBox.Show(CMMessage.Session.logout, CMMessage.Alert.title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                CMUserSession.shared.deleteSession();
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void PermisosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormList permission = new FormList();
            permission.objFormController = this.formFactory.getInstance(FormControllerKey.permission);
            permission.Show(this);
        }

        private void CargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormList position = new FormList();
            position.objFormController = this.formFactory.getInstance(FormControllerKey.position);
            position.Show(this);
        }

        private void AreaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormList area = new FormList();
            area.objFormController = this.formFactory.getInstance(FormControllerKey.area);
            area.Show(this);
        }

        private void TodosLosAfiliadosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormList person = new FormList();
            person.objFormController = this.formFactory.getInstance(FormControllerKey.person);
            person.Show(this);
        }
    }
}
