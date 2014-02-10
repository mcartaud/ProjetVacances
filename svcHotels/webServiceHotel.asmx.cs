using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Data;

namespace svcHotels
{
    /// <summary>
    /// Description résumée de Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class WebServiceHotel : System.Web.Services.WebService
    {
        private libHotels.clsHotels Hotels;

        [WebMethod]
        public DataSet getHotels(string VilleA, string Duree, DateTime Date)
        {
            return this.Hotels.getHotels(VilleA, Duree, Date);
        }
    }
}