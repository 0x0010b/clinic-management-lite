using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            if (CMUserSession.shared.getRememberUser() != String.Empty)
            {
                this.txtUsername.Text = CMUserSession.shared.getRememberUser();
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                CMAccountBE account =  CMAccountBL.login(new CMAccountBE(this.txtUsername.Text, this.txtPassword.Text));
                CMUserSession.shared.saveSession(account);

                if (this.cbxRememberUser.Checked)
                {
                    CMUserSession.shared.setRememberUser(account.account_username);
                }

                MessageBox.Show("Login correcto!", CMMessage.Alert.title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                // TODO: - Continuar con el flujo
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
    }
}
