using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.Services;
using libVols;
namespace svcVols
{
    /// <summary>
    /// Description résumée de Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class Service1 : System.Web.Services.WebService
    {
        private libVols.clsVols Vols;

        public Service1()
        {
            this.Vols = new libVols.clsVols();
        }

        [WebMethod]
        public DataSet getVols(string VilleD, string PaysD, string VilleA, string PaysA, DateTime Date)
        {
            return this.Vols.getVols(VilleD, PaysD, VilleA, PaysA, Date);
        }


        [WebMethod]
        public List<List<string>> getInit()
        {
            return this.Vols.getInit();
        }

        [WebMethod]
        public List<List<string>> getVilleArrivee(string VilleDepart, string paysDepart)
        {
            return this.Vols.getVilleArrivee(VilleDepart, paysDepart);
        }
    }
}