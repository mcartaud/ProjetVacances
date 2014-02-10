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
    public class webServiceVol : System.Web.Services.WebService
    {
        private libVols.clsVols Vols;
        [WebMethod]
        public DataSet getVols(string VilleD, string VilleA, DateTime Date)
        {
            return this.Vols.getVols(VilleD, VilleA, Date);
        }
    }
}