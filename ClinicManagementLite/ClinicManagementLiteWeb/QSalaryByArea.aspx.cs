using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using BL;
using BE;
using General;

public partial class QSalaryByArea : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                string progress = CMAreaBL.getAreasWithSalary();
                litSalaries.Text = progress;
            }
            catch (Exception ex)
            {
                lblMessageDanger.Text = ex.Message;
                lblMessageDanger.Visible = true;
            }
        }
    }
}