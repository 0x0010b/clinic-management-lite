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
        public frmDetail()
        {
            InitializeComponent();
        }

        private void UserInfo_Load(object sender, EventArgs e)
        {
            lblName.Text = "";
            lblLastname.Text = "";

        }
    }
}
