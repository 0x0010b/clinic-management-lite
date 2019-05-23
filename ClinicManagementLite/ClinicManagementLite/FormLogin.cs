using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BL;
using General;

namespace ClinicManagementLite
{
    public partial class FormLogin : Form
    {
        private bool isExit = false;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

            Console.WriteLine("CONCHATUMARE" + CMUserSession.shared.getRememberUser());

            if (CMUserSession.shared.getRememberUser() != String.Empty)
            {
                this.txtUsername.Text = CMUserSession.shared.getRememberUser();
                this.cbxRememberUser.Checked = true;
                this.txtPassword.Select();
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                CMAccountBE account =  CMAccountBL.login(new CMAccountBE(this.txtUsername.Text, this.txtPassword.Text));

                CMUserSession.shared.saveSession(account);
                CMUserSession.shared.setRememberUser(this.cbxRememberUser.Checked ? account.account_username : String.Empty);

                this.isExit = true;
                this.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message, CMMessage.Alert.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, CMMessage.Alert.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnlyNumbersValidation(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsNumber(e.KeyChar) || e.KeyChar == 8 ? false : true;
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.isExit)
            {
                Application.Exit();
            }
        }
    }
}
