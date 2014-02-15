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
            lblRecapVol.Text = Session["vol"].ToString();
            lblRecapHotel.Text = Session["hotel"].ToString();
            lblRecapArrivee.Text = Session["arrivee"].ToString();
            lblRecapDepart.Text = Session["depart"].ToString();
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
            int cp = Convert.ToInt32(txtCp.Text);
            string adresse = txtAdresse.Text;
            int tel = Convert.ToInt32(txtTelephone.Text);
            int numCarte = Convert.ToInt32(txtNumCarte.Text);
            int crypto = Convert.ToInt32(txtCryptogramme.Text);
            DateTime dateExp = Convert.ToDateTime(txtDateExp.Text);

            // Verification de remplissable des champs
            if (!String.IsNullOrEmpty(nom) && !String.IsNullOrEmpty(prenom) &&
                !String.IsNullOrEmpty(age) && !String.IsNullOrEmpty(nationalite) &&
                !String.IsNullOrEmpty(ville) && !String.IsNullOrEmpty(cp.ToString()) &&
                !String.IsNullOrEmpty(adresse) && !String.IsNullOrEmpty(tel.ToString())&&
                !String.IsNullOrEmpty(numCarte.ToString()) && !String.IsNullOrEmpty(crypto.ToString()) 
                && dateExp != null)
            {
                // Informations client
                clsInfoClient client = new clsInfoClient();
                client.nomUser = nom;
                client.prenomUser = prenom;
                client.age = age;
                client.nationalite = nationalite;
                client.villeUser = ville;
                client.cpUser = cp;
                client.adresseUser = adresse;
                client.tel = tel;
                client.compteUser = numCarte.ToString() + ' ' + crypto.ToString();
                client.dateExp = dateExp;
                
                // Recuperation du vol et de l'hotel
                clsVolEntity vol = new clsVolEntity();
                clsHotelEntity hotel = new clsHotelEntity();
                vol = (clsVolEntity) Session["vol"];
                hotel = (clsHotelEntity) Session["hotel"];
                vol.infoClient = client;
                hotel.infoClient = client;

                // Ajout a la file d'attente
                MessageQueue mqVols = new MessageQueue(@".\private$\cmdvols");
                MessageQueue mqHotels = new MessageQueue(@".\private$\cmdhotels");
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