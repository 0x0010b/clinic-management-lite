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


public partial class Views_QEmployeeByPosArea : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                List<CMAreaBE> areas = CMAreaBL.getAll();
                dropArea.DataSource = areas;
                dropArea.DataValueField = "area_id";
                dropArea.DataTextField = "area_description";
                dropArea.DataBind();

                gdvClients.DataSource = CMEmployeeBL.getDataTable(1, 1);
                gdvClients.DataBind();
            }
            catch (Exception ex)
            {
                lblMessageDanger.Text = ex.Message;
                lblMessageDanger.Visible = true;
            }
        }
    }

    

    protected void dropPosition_SelectedIndexChanged1(object sender, EventArgs e)
    {
        if (dropPosition.SelectedValue == "-1")
        {
            lblMessageWarning.Text = "Seleccione un valor correcto.";
            lblMessageWarning.Visible = true;
        }
    }

    protected void dropArea_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            List<CMPositionBE> positions = CMPositionBL.getAll(int.Parse(dropArea.SelectedValue));
            dropPosition.DataSource = positions;
            dropPosition.DataValueField = "position_id";
            dropPosition.DataTextField = "position_description";
            dropPosition.DataBind();
        }
        catch (Exception ex)
        {
            lblMessageDanger.Text = ex.Message;
            lblMessageDanger.Visible = true;
        }
    }

    protected void btnQuery_Click(object sender, EventArgs e)
    {
        try
        {
            if (dropPosition.SelectedValue != "-1" && dropArea.SelectedValue != "-1")
            {
                gdvClients.DataSource = CMEmployeeBL.getDataTable(int.Parse(dropArea.SelectedValue), int.Parse(dropPosition.SelectedValue));
                gdvClients.DataBind();
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