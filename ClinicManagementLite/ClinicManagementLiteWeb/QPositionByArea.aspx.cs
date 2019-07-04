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

public partial class QPositionByArea : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                List<CMAreaBE> areas = new List<CMAreaBE>();
                areas.Add(new CMAreaBE(0, "-- Ver todos --"));
                areas.AddRange(CMAreaBL.getAll());
                dropAreas.DataSource = areas;
                dropAreas.DataValueField = "area_id";
                dropAreas.DataTextField = "area_description";
                dropAreas.DataBind();

                gdvPositions.DataSource = CMPositionBL.getDataTable();
                gdvPositions.DataBind();
            }
            catch (Exception ex)
            {
                lblMessageDanger.Text = ex.Message;
                lblMessageDanger.Visible = true;
            }
        }
    }

    protected void dropAreas_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            gdvPositions.DataSource = CMPositionBL.getDataTable(int.Parse(dropAreas.SelectedValue));
            gdvPositions.DataBind();
        }
        catch (Exception ex)
        {
            lblMessageDanger.Text = ex.Message;
            lblMessageDanger.Visible = true;
        }
    }
}