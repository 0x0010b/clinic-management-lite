using ClinicManagementLite.Windows.BE;
using ClinicManagementLite.Windows.BL;
using ClinicManagementLite.Windows.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementLite.Windows.Controllers
{
    public partial class Login : Form
    {

        public MDIMain parent;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                CMAccountBE objAccount = CMAccountBL.login(tbxUsername.Text, txtPassword.Text);
                CMUserSessionBL.shared.saveSession(objAccount);
                this.parent.setInitialInformation();
                this.Close();
            } catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (CMUserSessionBL.shared.getSession() == null)
            {
                Application.Exit();
            }
        }

        private void tbxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char delete = (Char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != delete;
            
        }
    }
}
