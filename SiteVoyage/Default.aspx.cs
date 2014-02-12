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

        protected void Page_Init(object sender, EventArgs e)
        {
            drpVilleDepart.DataSource = this.wsVol.getVilleDepart();
            drpVilleDepart.DataBind();
        }

        protected void drpVilleDepart_SelectedIndexChanged(object sender, EventArgs e)
        {
            drpVilleArrivee.DataSource = this.wsVol.getVilleArrivee(drpVilleDepart.SelectedItem.ToString());
            drpVilleArrivee.DataBind();
        }

        protected void btnRechercher_Click(object sender, EventArgs e)
        {
            string villeDepart = drpVilleDepart.Text;
            string villeArrivee = drpVilleArrivee.Text;
            DateTime dateDepart = cldDateDepart.SelectedDate;
            // Un des champs n'a pas été saisi
            if(String.IsNullOrEmpty(villeDepart) || String.IsNullOrEmpty(villeArrivee) || dateDepart == null)
            {
                lblError.Text = "Un des champs n'a pas été rempli";
            }
            else
            {
                drpVols.DataSource = this.wsVol.getVols(villeDepart, villeArrivee, dateDepart).Tables[0];
                drpVols.DataTextField = "villeDepart";
                drpVols.DataBind();
            }
        }
    }
}