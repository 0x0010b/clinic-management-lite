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
    public partial class FormSchedule : Form
    {
        private CMScheduleBE objSchedule = new CMScheduleBE();

        public FormSchedule()
        {
            InitializeComponent();
        }

        private void FormSchedule_Load(object sender, EventArgs e)
        {
            this.cbxEmployee.DisplayMember = "employee_nameAndDni";
            this.cbxEmployee.ValueMember = "person_dni";

            this.cbxTurn.DisplayMember = "turn_description";
            this.cbxTurn.ValueMember = "turn_id";

            try
            {
                this.cbxEmployee.DataSource = CMEmployeeBL.getAll();
                this.cbxTurn.DataSource = CMTurnBL.getAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, CMMessage.Alert.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            this.objSchedule.schedule_employee.person_dni = this.cbxEmployee.SelectedValue.ToString();
            this.objSchedule.schedule_turn.turn_id = Convert.ToInt16(this.cbxTurn.SelectedValue);

            try
            {
                CMScheduleBL.create(this.objSchedule);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, CMMessage.Alert.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
