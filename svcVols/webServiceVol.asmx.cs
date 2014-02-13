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
        public DataSet getVols(string VilleD, string VilleA, DateTime Date)
        {
            return this.Vols.getVols(VilleD, VilleA, Date);
        }


        [WebMethod]
        public List<string> getVilleDepart()
        {
            return this.Vols.getVilleDepart();
        }

//        [WebMethod]
 //       public List<string> getPaysDepart()
 //       {
  //          return this.Vols.getPaysDepart();
   ///     }

        [WebMethod]
        public List<string> getVilleArrivee(string VilleDepart)
        {
            return this.Vols.getVilleArrivee(VilleDepart);
        }

//        [WebMethod]
//        public List<string> getPaysArrivee()
//        {
 //        //   return this.Vols.getPaysArrivee();
 //       }

    }
}