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

public partial class QPersonMedHistory : System.Web.UI.Page
{
    CMClientBE client = new CMClientBE();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                gdvCLients.DataSource = CMClientBL.getDataTable();
                gdvCLients.DataBind();
            }
            catch (Exception ex)
            {
                lblMessageDanger.Text = ex.Message;
                lblMessageDanger.Visible = true;
            }
        }
    }

    protected void gdvCLients_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = gdvCLients.SelectedRow;
        string dni = row.Cells[1].Text;
        client = CMClientBL.get(dni);
        populatePopup();
        popupClient.Show();
    }

    private void populatePopup()
    {
        imgClient.ImageUrl = client.person_image;
        lblName.Text = "Nombre: " + client.person_name;
        lblAge.Text = "Edad: " + calculateAge().ToString();
        lblDni.Text = "Dni: " + client.person_dni;

        txtBloodType.Text = client.client_bloodType;
        txtHeight.Text = client.client_height + "cm";
        txtAllergies.Text = client.client_allergies;
        txtMedicines.Text = client.client_medicines;
        txtPathologies.Text = client.client_pathologies;
        txtSeizures.Text = client.client_seizures;
        txtAids.Text = client.client_aids;
        txtBloodPressure.Text = client.client_bloodPressure;
        txtCancer.Text = client.client_cancer;
        txtCholesterol.Text = client.client_weight + "kg";
    } 

    private int calculateAge()
    {
        int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
        int dob = int.Parse(client.person_birthday.ToString("yyyyMMdd"));
        int age = (now - dob) / 10000;
        return age;
    }
}