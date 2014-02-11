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
    public class Service1 : System.Web.Services.WebService
    {
        private libHotels.clsHotels Hotels;
        public Service1()
        {
            this.Hotels = new libHotels.clsHotels();
        }

        [WebMethod]
        public DataSet getHotels(string VilleA, int Duree, DateTime Date)
        {
            return this.Hotels.getHotels(VilleA, Duree, Date);
        }
    }
}