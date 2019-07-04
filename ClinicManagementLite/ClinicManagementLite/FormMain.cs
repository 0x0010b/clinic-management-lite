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
        private MaintenanceControllerFactory objMaintenanceFactory = new MaintenanceControllerFactory();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.ShowDialog(this);
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

        private void MenuMaintenanceItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            int index = Convert.ToInt16(item.Tag.ToString());

            FormMaintenance formMaintenance = new FormMaintenance();
            formMaintenance.objMaintenanceController = this.objMaintenanceFactory.getInstance((MaintenanceControllerKey)index);
            formMaintenance.ShowDialog(this);
        }

        private void AcercaDeClinicManagementLiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAboutUs().ShowDialog();
        }
    }

    
}
