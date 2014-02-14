using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Messaging;

namespace SiteVoyage
{
    public partial class UIPaiement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            // donnée à init
            /*label_recap_vol.Text = Session["vol"].ToString();
            label_recap_hotel.Text = Session["hotel"].ToString();
            label_recap_arrivee.Text = Session["arrivee"].ToString();
            label_recap_depart.Text = Session["depart"].ToString();*/
        }
        protected void Button_valider_Click(object sender, EventArgs e)
        {
            // vol.nom
            // Donnée à envoyer
            string nom = TextBox_nom.Text;
            string prenom = TextBox_prenom.Text;
            string age = TextBox_age.Text;
            string nationalite = TextBox_nationalite.Text;
            string ville = TextBox_ville.Text;
            string cp = TextBox_cp.Text;
            string adresse = TextBox_adresse.Text;
            string tel = TextBox_telephone.Text;
            string numCarte = TextBox_numCarte.Text;
            string crypto = TextBox_cryptogramme.Text;
            string dateExp = TextBox_dateExp.Text;

            if (!String.IsNullOrEmpty(nom) && !String.IsNullOrEmpty(prenom) &&
                !String.IsNullOrEmpty(age) && !String.IsNullOrEmpty(nationalite) &&
                !String.IsNullOrEmpty(ville) && !String.IsNullOrEmpty(cp) &&
                !String.IsNullOrEmpty(adresse) && !String.IsNullOrEmpty(tel) &&
                !String.IsNullOrEmpty(numCarte) && !String.IsNullOrEmpty(crypto) &&
                !String.IsNullOrEmpty(dateExp))
            {
                // MSMQ
                dataEntity.clsVolEntity vol = new dataEntity.clsVolEntity();
                dataEntity.clsHotelEntity hotel = new dataEntity.clsHotelEntity();
                vol = (dataEntity.clsVolEntity) Session["vol"];
                hotel = (dataEntity.clsHotelEntity) Session["hotel"];
                MessageQueue mqVols = new MessageQueue(@".\private$\cmdvols");
                MessageQueue mqHotels = new MessageQueue(@".\private$\cmdhotels");
                // Ajout dans la file d'attente
                mqVols.Send(vol, "Commande vol");
                mqHotels.Send(hotel, "Commande hotel");
                mqVols.Close();
                mqHotels.Close();
            }
            else
            {
                Label_error.Text = "Veuillez remplir les champs !";   
            }

        }
    }
}