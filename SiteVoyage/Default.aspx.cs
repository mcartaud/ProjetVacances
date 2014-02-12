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
            WebServiceVol.Service1 ws = new WebServiceVol.Service1();
            cmbVilleDepart.DataSource = ws.getVilleDepart();
            cmbVilleDepart.DataBind();

            WebServiceVol.Service1 ws2 = new WebServiceVol.Service1();
            cmbVilleArrivee.DataSource = ws2.getVilleArrivee(cmbVilleDepart.Text);
            cmbVilleArrivee.DataBind();
        }

        protected void listVilleA_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}