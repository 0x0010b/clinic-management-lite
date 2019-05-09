using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementLite.Windows.Views
{
    public partial class frmCreatePerson : Form
    {
        public frmCreatePerson()
        {
            InitializeComponent();
        }

        private void frmCreatePerson_Load(object sender, EventArgs e)
        {
            dtpBirthday.Format = DateTimePickerFormat.Custom;
            dtpBirthday.CustomFormat = "dd-MM-yyyy";
            

        }
    }
}
