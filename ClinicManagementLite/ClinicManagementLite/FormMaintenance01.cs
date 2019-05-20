using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public bool isEditing;
        public FormView objFormView;

        public FormMaintenance01()
        {
            InitializeComponent();
        }

        private void FormOperation01_Load(object sender, EventArgs e)
        {
            this.objFormView.setupFormMaintenance(this);
        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            
        }
    }
}
