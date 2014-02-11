using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteVoyage
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // WebServiceVol webServiceVol = new WebServiceVol();
            WebServiceVol.Service1 ws = new WebServiceVol.Service1();
            cmbVilleDepart.DataValueField = "villeDepart";
            cmbVilleDepart.DataSource = ws.getVilleDepart().Tables[0];
            cmbVilleDepart.DataBind();

            WebServiceVol.Service1 ws2 = new WebServiceVol.Service1();
            cmbVilleArrivee.DataValueField = "villeDestination";
            cmbVilleArrivee.DataSource = ws2.getVilleArrivee(cmbVilleDepart.Text).Tables[0];
            cmbVilleArrivee.DataBind();
        }

        protected void listVilleA_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}