using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Voyage
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebServiceVol.Service1 ws = new WebServiceVol.Service1();
            drpVilleDepart.DataSource = ws.getVilleDepart();
            drpVilleDepart.DataBind();
        }

        protected void drpVilleDepart_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = "On change";
            // Label4.Text = "On Change !";
            // WebServiceVol.Service1 ws2 = new WebServiceVol.Service1();
            // drpVilleArrivee.DataSource = ws2.getVilleArrivee(drpVilleDepart.Text);
            //drpVilleArrivee.DataBind();
            Console.WriteLine("hello");
        }
    }
}