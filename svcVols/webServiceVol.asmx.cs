using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;

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

        [WebMethod]
        public void getVols(string Ville)
        {
            return 
        }
    }
}