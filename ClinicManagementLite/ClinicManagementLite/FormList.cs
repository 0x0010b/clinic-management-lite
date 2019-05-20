using ClinicManagementLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementLite
{
    public partial class FormList : Form
    {
        public FormView objFormView;

        public FormList()
        {
            InitializeComponent();
        }

        public int getCellId()
        {
            return int.Parse(this.dgvList.CurrentRow.Cells[0].Value.ToString());
        }

        private void FormList_Load(object sender, EventArgs e)
        {
            this.objFormView.setupFormList(this);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            this.objFormView.actionDelete(this);
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            // TODO: - Fix validation
            // TODO: - Add SqlException in all methods
            if (this.objFormView.GetType().ToString() == "ClinicManagementLite.FormPermission")
            {
                FormMaintenance01 form = new FormMaintenance01();

                form.objFormView = this.objFormView;
                form.isEditing = false;

                form.Show();
            }
            else
            {
                Console.WriteLine("MIERDA");
            }
        }
    }
}
