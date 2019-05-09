using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementLite.Windows.Controllers
{
    public partial class frmDetail : Form
    {

        Boolean isEmployee = true;
        Boolean isClient = true;
        
        public frmDetail()
        {
            InitializeComponent();
        }

        private void frmDetail_Load(object sender, EventArgs e)
        {

            lblName.Text = "-";
            lblLastname.Text = "-";
            lblPhone.Text = "-";
            lblGender.Text = "-";
            lblBirthday.Text = "-";
            lblDni.Text = "-";
            lblAddress.Text = "-";
            lblActive.Text = "-";

            gbxEmployeeInfo.Visible = isEmployee;
            btnMedHistory.Visible = isClient;
        }

        private void btnMedHistory_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
