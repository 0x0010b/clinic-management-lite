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

public partial class Views_Login : System.Web.UI.Page
{
    private const string warning = "w";
    private const string danger  = "d";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (HttpContext.Current.User.Identity.IsAuthenticated)
            {
                Response.Redirect("Index.aspx");
            }
        }
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        try
        {
            if (isEmptyOrAllSpaces(txtUsername.Text))
            {
                //lblMessage.Text = CMMessage.Login.correctInfo;
                showErrorMessage("Ingrese datos correctos.", warning);
            }
            else if (isEmptyOrAllSpaces(txtPassword.Text))
            {
                //lblMessage.Text = CMMessage.Login.correctInfo;
                showErrorMessage("Ingrese datos correctos.", warning);
            }
            else
            {
                CMAccountBE logAccount = CMAccountBL.login(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                FormsAuthentication.RedirectFromLoginPage(logAccount.account_username, cbxRemember.Checked);
            }
        }
        catch (Exception ex)
        {
            showErrorMessage(ex.Message, danger);
        }
    }

    private void showErrorMessage(string msg, string type)
    {
        lblMessageWarning.Visible = false;
        lblMessageDanger.Visible = false;

        switch (type)
        {
            case warning:
                {
                    lblMessageWarning.Text = msg;
                    lblMessageWarning.Visible = true;
                    break;
                }
            case danger:
                {
                    
                    lblMessageDanger.Text = msg;
                    lblMessageDanger.Visible = true;
                    break;
                }
        }
    }

    private static bool isEmptyOrAllSpaces(string text)
    {
        return null != text && text.All(c => c.Equals(' '));
    }
}