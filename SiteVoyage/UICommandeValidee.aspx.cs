using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteVoyage
{
    public partial class UICommandeValidee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRetourDefault_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}