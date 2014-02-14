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
            Response.Write("test2");
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("test");
            Response.Write("test3");
        }
        protected void Button_valider_Click(object sender, EventArgs e)
        {
            dataEntity.clsVolEntity vol = new dataEntity.clsVolEntity();
            dataEntity.clsHotelEntity hotel = new dataEntity.clsHotelEntity();

            MessageQueue MyMQ = new MessageQueue(@".\private$\bankemn");
            // Juste pour montrer qu'on peut le faire ! MyMQ.BasePriority = 1;
            MyMQ.Send(vol, "Commande vol");
            MyMQ.Send(hotel, "Commande hotel");
            MyMQ.Close();

            
            // vol.nom
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
            //string dateExp = 

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}