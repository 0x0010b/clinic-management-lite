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
    public partial class MDIMain : Form
    {
        public MDIMain()
        {
            InitializeComponent();
        }

        //OnCreate

        private void MDIMain_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        

        //Menu actions

        private void stripLogout_Click(object sender, EventArgs e)
        {

        }

        //Users actions

        private void stripUsers_Click(object sender, EventArgs e)
        {

        }

        //Employee actions

        private void stripEmployees_Click(object sender, EventArgs e)
        {

        }

        private void stripPositions_Click(object sender, EventArgs e)
        {

        }

        private void stripAreas_Click(object sender, EventArgs e)
        {

        }

        //Client actions

        private void stripClients_Click(object sender, EventArgs e)
        {

        }

        //Turn actions

        private void stripTurns_Click(object sender, EventArgs e)
        {

        }

        //Help actions

        private void stripHelp_Click(object sender, EventArgs e)
        {

        }

        private void stripAbout_Click(object sender, EventArgs e)
        {

        }
    }
}
