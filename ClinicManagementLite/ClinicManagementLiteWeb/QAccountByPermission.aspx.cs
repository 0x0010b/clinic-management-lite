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

public partial class QAccountByPermission : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                List<CMPermissionBE> areas = CMPermissionBL.getAll();
                dropPermission.DataSource = areas;
                dropPermission.DataValueField = "permission_id";
                dropPermission.DataTextField = "permission_description";
                dropPermission.DataBind();

                gdvAccounts.DataSource = CMAccountBL.getDataTable();
                gdvAccounts.DataBind();
            }
            catch (Exception ex)
            {
                lblMessageDanger.Text = ex.Message;
                lblMessageDanger.Visible = true;
            }
        }
    }

    protected void dropPermission_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (dropPermission.SelectedValue != "-1")
            {
                gdvAccounts.DataSource = CMAccountBL.getDataTable(int.Parse(dropPermission.SelectedValue));
                gdvAccounts.DataBind();
            }
            else
            {
                lblMessageWarning.Text = "Seleccione un valor correcto.";
                lblMessageWarning.Visible = true;
            }
        }
        catch (Exception ex)
        {
            lblMessageDanger.Text = ex.Message;
            lblMessageDanger.Visible = true;
        }
    }
}