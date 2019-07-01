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

public partial class Views_Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (HttpContext.Current.User.Identity.IsAuthenticated)
        {
            CMEmployeeBE user = CMEmployeeBL.get(User.Identity.Name);
            lblMessageUser.Text = "Bienvenido, " + user.person_name + " " + user.person_lastname;
        }
        if (!IsPostBack)
        {
            
        }
    }


    protected void btnLogout_Click(object sender, EventArgs e)
    {
        //se borra la cookie de autenticacion
        FormsAuthentication.SignOut();

        //se redirecciona al usuario a la pagina de login
        Response.Redirect(Request.UrlReferrer.ToString());
    }

    protected void btnEmployeByAreaPos_Click(object sender, EventArgs e)
    {
        Response.Redirect("QEmployeeByPosArea.aspx");
    }

    protected void btnTotalPerson_Click(object sender, EventArgs e)
    {
        Response.Redirect("QPersonTotal.aspx");
    }

    protected void btnAccountByType_Click(object sender, EventArgs e)
    {
        Response.Redirect("QAccountByPermission.aspx");
    }

    protected void btnPosByArea_Click(object sender, EventArgs e)
    {
        //Response.Redirect("QEmployeeByPosArea.aspx");
    }
} 