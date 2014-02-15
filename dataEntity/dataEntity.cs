using System;
using System.Collections.Generic;
using System.Text;

namespace dataEntity
{
    public class clsVolEntity
    {
        public int id;
        public DateTime dateDepart { get; set; }
        public string villeDepart { get; set; }
        public string paysDepart { get; set; }
        public string villeDestination { get; set; }
        public string paysDestination { get; set; }
        public int prixVol { get; set; }

        public clsInfoClient infoClient {get; set; }
    }

    public class clsHotelEntity
    {
        public int id;
        public string nomHotel { get; set; }
        public string adresseHotel { get; set; }
        public int cpHotel { get; set; }
        public string villeHotel { get; set; }
        public string paysHotel { get; set; }
        public DateTime dateArrivee { get; set; }
        public int duree { get; set; }
        public int prixHotel { get; set; }
        public clsInfoClient infoClient { get; set; }
    }

    public class clsInfoClient
    {
        public int id { get; set; }
        public string nomUser { get; set; }
        public string prenomUser { get; set; }
        public string age { get; set; }
        public string nationalite { get; set; }
        public string adresseUser { get; set; }
        public int cpUser { get; set; }
        public string villeUser { get; set; }
        public int tel { get; set; }
        public string compteUser { get; set; }
        public string paysUser { get; set; }
        public DateTime dateExp { get; set; }
    }

    public class departStructure
    {
        public string ville;
        public string pays;
    }

    public class arriveeStructure
    {
        public string ville;
        public string pays;
    }
}
