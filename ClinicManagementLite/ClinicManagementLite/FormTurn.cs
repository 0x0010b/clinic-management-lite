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
    public partial class FormTurn : Form
    {
        private bool isEditing;
        private int turn_id;
        private CMTurnBE objTurn = new CMTurnBE();

        public FormTurn(bool isEditing, int turn_id)
        {
            InitializeComponent();

            this.isEditing = isEditing;
            this.turn_id = turn_id;
        }

        private void FormTurn_Load(object sender, EventArgs e)
        {
            this.Text = this.isEditing ? "Actualizar Turno" : "Insertar Turno";
            this.btnAction.Text = this.isEditing ? "Actualizar" : "Insertar";

            this.cbxDay.SelectedIndex = 0;

            try
            {
                if (this.isEditing)
                {
                    this.objTurn = CMTurnBL.get(this.turn_id);

                    this.txtDescription.Text = this.objTurn.turn_description;
                    this.cbxDay.SelectedIndex = this.objTurn.turn_day;
                    this.pickerEntryHour.Value = this.objTurn.turn_entryHour;
                    this.pickerDepartureHour.Value = this.objTurn.turn_departureHour;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, CMMessage.Alert.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            this.objTurn.turn_description = this.txtDescription.Text.Trim();
            this.objTurn.turn_day = this.cbxDay.SelectedIndex;
            this.objTurn.turn_entryHour = this.pickerEntryHour.Value;
            this.objTurn.turn_departureHour = this.pickerDepartureHour.Value;

            try
            {
                if (this.isEditing)
                {
                    CMTurnBL.update(this.objTurn);
                }
                else
                {
                    CMTurnBL.create(this.objTurn);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, CMMessage.Alert.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextField_OnlyTextNumber(object sender, KeyPressEventArgs e)
        {
            Char keypress = e.KeyChar;

            if (!(Char.IsLetterOrDigit(keypress) || keypress == Convert.ToChar(Keys.Space) || keypress == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
}
