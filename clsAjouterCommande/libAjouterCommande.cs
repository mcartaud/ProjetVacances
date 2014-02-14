using System;
using System.Collections.Generic;
using System.Text;
using System.EnterpriseServices;
using libEnregistrerHotel;
using libEnregistrerVol;

namespace clsAjouterCommande
{
    [Transaction(TransactionOption.Required), ObjectPooling(5, 10), EventTrackingEnabled(), Description("BANK 2014 EMN")]
    public class libAjouterCommande
    {

        public void ajouterCommande(clsEnregistrerHotel hotel, clsEnregistrerVol vol)
        {
            // (new clsEnregistrerHotel()).setHotel(hotel, client);
            // (new clsEnregistrerVol()).setVol(vol, client);
        }

    }
}
