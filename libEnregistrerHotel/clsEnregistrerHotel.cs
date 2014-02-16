using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using dataEntity;

namespace libEnregistrerHotel
{
    public class clsEnregistrerHotel
    {

        private string Connection = "Data Source=localhost;Initial Catalog=ENREGISTREMENTS;Persist Security Info=True;User ID=benjamin;Password=benjamin";

        public void ajouterHotel(clsHotelEntity hotel, clsInfoClient client)
        {
            SqlConnection MyC = new SqlConnection();
            MyC.ConnectionString = Connection;
            MyC.Open();

            SqlCommand MyCom = new SqlCommand("dbo.enregistrerHotel", MyC);
            MyCom.CommandType = CommandType.StoredProcedure;

            MyCom.Parameters.Add("@id", SqlDbType.Int);
            MyCom.Parameters["@id"].Value = hotel.id;

            MyCom.Parameters.Add("@nomUser", SqlDbType.Text);
            MyCom.Parameters["@nomUser"].Value = client.nomUser;

            MyCom.Parameters.Add("@prenomUser", SqlDbType.Text);
            MyCom.Parameters["@prenomUser"].Value = client.prenomUser;

            MyCom.Parameters.Add("@adresseUser", SqlDbType.Text);
            MyCom.Parameters["@adresseUser"].Value = client.adresseUser;

            MyCom.Parameters.Add("@cpUser", SqlDbType.Int);
            MyCom.Parameters["@cpUser"].Value = client.cpUser;

            MyCom.Parameters.Add("@villeUser", SqlDbType.Text);
            MyCom.Parameters["@villeUser"].Value = client.villeUser;

            MyCom.Parameters.Add("@PAYSUSER", SqlDbType.Text);
            MyCom.Parameters["@PAYSUSER"].Value = client.paysUser;

            MyCom.Parameters.Add("@compteUser", SqlDbType.Text);
            MyCom.Parameters["@compteUser"].Value = client.compteUser;

            MyCom.Parameters.Add("@nomHotel", SqlDbType.Text);
            MyCom.Parameters["@nomHotel"].Value = hotel.nomHotel;

             MyCom.Parameters.Add("@adresseHotel", SqlDbType.Text);
            MyCom.Parameters["@adresseHotel"].Value = hotel.adresseHotel;

            MyCom.Parameters.Add("@cpHotel", SqlDbType.Int);
            MyCom.Parameters["@cpHotel"].Value = hotel.cpHotel;

            MyCom.Parameters.Add("@villeHotel", SqlDbType.Text);
            MyCom.Parameters["@VilleHotel"].Value = hotel.villeHotel;

            MyCom.Parameters.Add("@paysHotel", SqlDbType.Text);
            MyCom.Parameters["@paysHotel"].Value = hotel.paysHotel;

            MyCom.Parameters.Add("@dateArriveeHotel", SqlDbType.Date);
            MyCom.Parameters["@dateArriveeHotel"].Value = hotel.dateArrivee;

            MyCom.Parameters.Add("@dureeSejour", SqlDbType.Int);
            MyCom.Parameters["@dureeSejour"].Value = hotel.duree;

            MyCom.Parameters.Add("@prixHotel", SqlDbType.Int);
            MyCom.Parameters["@prixHotel"].Value = hotel.prixNuit;
       
            MyCom.ExecuteScalar();

            MyCom.Dispose();
            MyC.Close();
        }

    }
}
