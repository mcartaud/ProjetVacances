using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Messaging;
using dataEntity;

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
            /*lblRecapVol.Text = Session["vol"].ToString();
            lblRecapHotel.Text = Session["hotel"].ToString();
            lblRecapArrivee.Text = Session["arrivee"].ToString();
            lblRecapDepart.Text = Session["depart"].ToString();*/
        }
        protected void Button_valider_Click(object sender, EventArgs e)
        {
            // vol.nom
            // Donnée à envoyer
            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;
            string age = txtAge.Text;
            string nationalite = txtNationalite.Text;
            string ville = txtVille.Text;
            string cp = txtCp.Text;
            string adresse = txtAdresse.Text;
            string tel = txtTelephone.Text;
            string numCarte = txtNumCarte.Text;
            string crypto = txtCryptogramme.Text;
            string dateExp = txtDateExp.Text;

            if (!String.IsNullOrEmpty(nom) && !String.IsNullOrEmpty(prenom) &&
                !String.IsNullOrEmpty(age) && !String.IsNullOrEmpty(nationalite) &&
                !String.IsNullOrEmpty(ville) && !String.IsNullOrEmpty(cp) &&
                !String.IsNullOrEmpty(adresse) && !String.IsNullOrEmpty(tel) &&
                !String.IsNullOrEmpty(numCarte) && !String.IsNullOrEmpty(crypto) &&
                !String.IsNullOrEmpty(dateExp))
            {
                // MSMQ
                clsInfoClient client = new clsInfoClient();
                client.nomUser = txtNom.Text;
                client.prenomUser = txtPrenom.Text;
                client.age = txtAge.Text;
                client.nationalite = txtNationalite.Text;
                client.villeUser = txtVille.Text;
                client.cpUser = Convert.ToInt32(txtCp.Text);
                client.adresseUser = txtAdresse.Text;
                client.tel = txtTelephone.Text;
                client.numCarte = Convert.ToInt32(txtNumCarte.Text);
                client.crypto = Convert.ToInt32(txtCryptogramme.Text);
                client.dateExp = Convert.ToDateTime(txtDateExp.Text);
                

                
                clsVolEntity vol = new clsVolEntity();
                clsHotelEntity hotel = new clsHotelEntity();
                // vol = (clsVolEntity) Request.Form["vol"];
                // hotel = (clsHotelEntity) Request.Form["hotel"];
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
                lblError.Text = "Veuillez remplir les champs !";
                lblError.Visible = true;
            }

        }
    }
}