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

        // Initialisation des mois et de l'année pour le champ date d'expiration de la carte
        protected void DateExpiration_Init()
        {
            for (int mois = 1; mois <= 12; mois++)
            {
                drpMoisExpiration.Items.Add(mois.ToString());
            }
            
            int anneeCourante = DateTime.Now.Year;
            for (int annee = anneeCourante; annee < anneeCourante + 10; annee++)
            {
                drpAnneeExpiration.Items.Add(annee.ToString());
            }
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            DateExpiration_Init();
            lblError.Text = "";
            // donnée à init
            clsVolEntity volEntity = (clsVolEntity)Session["vol"];
            clsHotelEntity hotelEntity = (clsHotelEntity)Session["hotel"];
            string vol = "départ: " + volEntity.villeDepart + "/" + volEntity.paysDepart + ", destination: " + volEntity.villeDestination + "/" + volEntity.paysDestination + ", le: " + volEntity.dateDepart + ", à: " + volEntity.prixVol + "€";
            string hotel = hotelEntity.nomHotel + ", nombre de nuits: " + hotelEntity.duree + ", prix total: " + hotelEntity.prixNuit * hotelEntity.duree + "€";

            lblRecapVol.Text = vol;
            lblRecapHotel.Text = hotel;
            lblRecapArrivee.Text = Session["arrivee"].ToString();
            lblRecapDepart.Text = Session["depart"].ToString();
            lblPrixTotal.Text = volEntity.prixVol + (hotelEntity.duree * hotelEntity.prixNuit) + " €";
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
            string tel = txtTelephone.Text;
            Int64 numCarte = Convert.ToInt64(txtNumCarte.Text);
            int crypto = Convert.ToInt32(txtCryptogramme.Text);
            // date d'expiration de la carte
            DateTime dateExp = new DateTime(Convert.ToInt32(drpAnneeExpiration.SelectedValue), 
                Convert.ToInt32(drpMoisExpiration.SelectedValue),  1);

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
                client.paysUser = nationalite;
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
                Response.Redirect("UICommandeValidee.aspx");
            }
            else
            {
                lblError.Text = "Veuillez remplir les champs !";
                lblError.Visible = true;
            }

        }
    }
}