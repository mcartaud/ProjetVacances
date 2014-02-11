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
        public string villeDestination { get; set; }
    }

    public class clsHotelEntity
    {
        public int id;
        public string nom { get; set; }
        public string ville { get; set; }
        public DateTime dateArrivee { get; set; }
        public int duree { get; set; }
    }

    public class clsInfoClient
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string adresse { get; set; }
        public int rib { get; set; }
    }
}
