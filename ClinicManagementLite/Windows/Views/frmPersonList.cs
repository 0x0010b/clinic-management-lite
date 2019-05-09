using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ClinicManagementLite.Windows.Views
{
    public partial class frmPersonList : Form
    {
        SqlDataAdapter adapter;
        DataSet dts = new DataSet();

        String tblName = "";

        public frmPersonList()
        {
            InitializeComponent();
        }

        private void frmPersonList_Load(object sender, EventArgs e)
        {

            //adapter = new SqlDataAdapter(command);
            //adapter.Fill(dts, "nombre_tabla");

            //dtgPersonList.DataSource = dts.Tables["nombre_tabla"];
        }

        private void btnSeeDetail_Click(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

        }
    }
}
