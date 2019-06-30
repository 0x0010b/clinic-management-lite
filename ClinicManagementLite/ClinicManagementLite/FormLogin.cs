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
        private bool closeLogin = false;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
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
                CMAccountBE account = CMAccountBL.login(this.txtUsername.Text.Trim(), this.txtPassword.Text.Trim());

                CMUserSession.shared.saveSession(account);
                CMUserSession.shared.setRememberUser(this.cbxRememberUser.Checked ? account.account_username : String.Empty);

                this.closeLogin = true;
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, CMMessage.Alert.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.closeLogin == false)
            {
                Application.Exit();
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
