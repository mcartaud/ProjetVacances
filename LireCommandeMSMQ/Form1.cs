using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Messaging;
using TraitementCommandeLibrary;
using dataEntity;

namespace LireCommandeMSMQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLire_Click(object sender, EventArgs e)
        {
            MessageQueue mqVols = new MessageQueue(@".\private$\cmdvols");
            MessageQueue mqHotels = new MessageQueue(@".\private$\cmdhotels");
            mqVols.Formatter = new XmlMessageFormatter(new Type[] { typeof(clsVolEntity) });
            mqHotels.Formatter = new XmlMessageFormatter(new Type[] { typeof(clsHotelEntity) });
            var messageVol = (clsVolEntity)mqVols.Peek().Body;
            var messageHotel = (clsHotelEntity)mqHotels.Peek().Body;

            clsVolEntity vol = new clsVolEntity();
            vol.dateDepart = messageVol.dateDepart;
            vol.villeDepart = messageVol.villeDepart;
            vol.paysDepart = messageVol.paysDepart;
            vol.villeDestination = messageVol.villeDestination;
            vol.paysDestination = messageVol.paysDestination;
            vol.prixVol = messageVol.prixVol;
            vol.infoClient = messageVol.infoClient;

            clsHotelEntity hotel = new clsHotelEntity();
            hotel.nomHotel = messageHotel.nomHotel;
            hotel.adresseHotel = messageHotel.adresseHotel;
            hotel.cpHotel = messageHotel.cpHotel;
            hotel.villeHotel = messageHotel.villeHotel;
            hotel.paysHotel = messageHotel.paysHotel;
            hotel.dateArrivee = messageHotel.dateArrivee;
            hotel.duree = messageHotel.duree;
            hotel.infoClient = messageHotel.infoClient;

            clsInfoClient client = vol.infoClient;

            // Enregistrement en mode transactionnel
            bool resEnregistrement = new TraitementCommandeLibrary.libTraitementCommande().ajouterCommande(hotel, vol, client);

            // Transaction OK
            if (resEnregistrement == true)
            {
                txtListe.AppendText("Enregistrement du vol " + vol.villeDepart + " - " + vol.villeDestination + " et l'hotel " + hotel.nomHotel);
                mqVols.Receive();
                mqHotels.Receive();
            }
            // Transaction KO
            else
            {
                txtListe.AppendText("Impossible d'enregsitrer le vol " + vol.villeDepart + " - " + vol.villeDestination + " et l'hotel " + hotel.nomHotel);
            }
            mqVols.Close();
            mqHotels.Close();
        }
    }
}
