using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        btnInicio.Visible = HttpContext.Current.User.Identity.IsAuthenticated;
        btnClients.Visible = HttpContext.Current.User.Identity.IsAuthenticated;
        btnEmployees.Visible = HttpContext.Current.User.Identity.IsAuthenticated;
        btnAreas.Visible = HttpContext.Current.User.Identity.IsAuthenticated;
        btnPermission.Visible = HttpContext.Current.User.Identity.IsAuthenticated;
        btnPosition.Visible = HttpContext.Current.User.Identity.IsAuthenticated;
        btnLogout.Visible = HttpContext.Current.User.Identity.IsAuthenticated;
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        //se borra la cookie de autenticacion
        FormsAuthentication.SignOut();

        //se redirecciona al usuario a la pagina de login
        Response.Redirect(Request.UrlReferrer.ToString());
    }
}
