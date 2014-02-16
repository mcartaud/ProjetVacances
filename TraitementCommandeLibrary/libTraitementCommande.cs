using System;
using System.Collections.Generic;
using System.Text;
using dataEntity;
using libEnregistrerVol;
using libEnregistrerHotel;
using System.EnterpriseServices;
using System.Data.SqlClient;

namespace TraitementCommandeLibrary
{
    
    public class libTraitementCommande
    {
        public libTraitementCommande()
        {

        }

        [AutoComplete]
        public bool ajouterCommande(clsHotelEntity hotel, clsVolEntity vol, clsInfoClient client)
        {
            bool R = true;
            try
            {
                (new clsEnregistrerHotel()).ajouterHotel(hotel, client);
                (new clsEnregistrerVol()).ajouterVol(vol, client);
            }
            catch(SqlException e)
            {
                Console.WriteLine(e);
                R = false;
            }
            return R;
            
        }
    }
}
