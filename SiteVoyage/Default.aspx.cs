using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteVoyage
{
    public partial class _Default : System.Web.UI.Page
    {
        private WebServiceVol.Service1 wsVol = new WebServiceVol.Service1();

        protected void Page_Load(object sender, EventArgs e)
        {
            drpVilleDepart.DataSource = this.wsVol.getVilleDepart();
            drpVilleDepart.DataBind();
        }

        protected void drpVilleDepart_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine("pute");
            //drpVilleDepart.Text = drpVilleDepart.Text;
            //drpVilleArrivee.DataSource = this.wsVol.getVilleArrivee(drpVilleDepart.SelectedItem.ToString());
            //drpVilleArrivee.DataBind();
        }

        protected void btnVilleDepart_Click(object sender, EventArgs e)
        {
            drpVilleArrivee.DataSource = this.wsVol.getVilleArrivee(drpVilleDepart.Text);
            drpVilleArrivee.DataBind();
        }

    }
}