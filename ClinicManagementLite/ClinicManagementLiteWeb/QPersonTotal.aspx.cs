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

public partial class QPersonTotal : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                gdvPersons.DataSource = CMPersonBL.getDataTable();
                gdvPersons.DataBind();
            }
            catch (Exception ex)
            {
                lblMessageDanger.Text = ex.Message;
                lblMessageDanger.Visible = true;
            }
        }
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        //se borra la cookie de autenticacion
        FormsAuthentication.SignOut();

        //se redirecciona al usuario a la pagina de login
        Response.Redirect(Request.UrlReferrer.ToString());
    }
}