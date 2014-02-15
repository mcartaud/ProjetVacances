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
            vol.id = messageVol.id;
            vol.dateDepart = messageVol.dateDepart;
            vol.villeDepart = messageVol.villeDepart;
            vol.paysDepart = messageVol.paysDepart;
            vol.villeDestination = messageVol.villeDestination;
            vol.paysDestination = messageVol.paysDestination;
            vol.prixVol = messageVol.prixVol;

            clsHotelEntity hotel = new clsHotelEntity();
            hotel.id = messageHotel.id;
            hotel.nomHotel = messageHotel.nomHotel;
            hotel.adresseHotel = messageHotel.adresseHotel;
            hotel.cpHotel = messageHotel.cpHotel;
            hotel.villeHotel = messageHotel.villeHotel;
            hotel.paysHotel = messageHotel.paysHotel;
            hotel.dateArrivee = messageHotel.dateArrivee;
            hotel.duree = messageHotel.duree;

            // TODO clsInfoClient client = new clsInfoClient();

            // Enregistrement en mode transactionnel
            bool resEnregistrement = new TraitementCommandeLibrary.libTraitementCommande().ajouterCommande(hotel, vol,null);

            // Transaction OK
            if (resEnregistrement == true)
            {
                //txtListe.AppendText("Transfert de " + message.Montant + " du compte " + message.CC + " vers " + message.CD + " \n");
                mqVols.Receive();
                mqHotels.Receive();
            }
            // Transaction KO
            else
            {
                // txtListe.AppendText("Impossible de transférer " + message.Montant + " du compte " + message.CC + " vers " + message.CD);
            }
            mqVols.Close();
            mqHotels.Close();
        }
    }
}
