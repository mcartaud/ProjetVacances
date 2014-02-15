using System;
using System.Collections.Generic;
using System.Text;
using dataEntity;
using libEnregistrerVol;
using libEnregistrerHotel;
using System.EnterpriseServices;

namespace TraitementCommandeLibrary
{
    [Transaction(TransactionOption.Required), ObjectPooling(5, 10), EventTrackingEnabled(), Description("BANK 2014 EMN")]
    public class libTraitementCommande : ServicedComponent
    {
        public bool ajouterCommande(dataEntity.clsHotelEntity hotel, dataEntity.clsVolEntity vol, clsInfoClient client)
        {
            bool R = true;
            try
            {
                (new clsEnregistrerHotel()).setHotel(hotel, client);
                (new clsEnregistrerVol()).setVol(vol, client);
            }
            catch(SystemException e)
            {
                Console.WriteLine(e);
                R = false;
            }
            return R;
            
        }
    }
}
