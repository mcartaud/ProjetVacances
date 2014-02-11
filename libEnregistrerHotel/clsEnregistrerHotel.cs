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

        public void setHotel(clsHotelEntity hotel, clsInfoClient client)
        {
            SqlConnection MyC = new SqlConnection();
            MyC.ConnectionString = Connection;
            MyC.Open();

            SqlCommand MyCom = new SqlCommand("dbo.enregistrerHotel", MyC);
            MyCom.CommandType = CommandType.StoredProcedure;
            MyCom.Parameters.Add("@ville", SqlDbType.Text);
            MyCom.Parameters["@Ville"].Value = hotel.ville;

            MyCom.Parameters.Add("@nom", SqlDbType.Text);
            MyCom.Parameters["@nom"].Value = hotel.nom;

            MyCom.Parameters.Add("@dateArrivee", SqlDbType.Date);
            MyCom.Parameters["@dateArrivee"].Value = hotel.dateArrivee;

            MyCom.Parameters.Add("@duree", SqlDbType.Int);
            MyCom.Parameters["@duree"].Value = hotel.duree;

            MyCom.Parameters.Add("@id", SqlDbType.Int);
            MyCom.Parameters["@id"].Value = hotel.id;


            MyCom.Parameters.Add("@nom", SqlDbType.Text);
            MyCom.Parameters["@nom"].Value = client.nom;

            MyCom.Parameters.Add("@adresse", SqlDbType.Text);
            MyCom.Parameters["@adresse"].Value = client.adresse;

            MyCom.Parameters.Add("@prenom", SqlDbType.Text);
            MyCom.Parameters["@prenom"].Value = client.prenom;

            MyCom.Parameters.Add("@rib", SqlDbType.Int);
            MyCom.Parameters["@rib"].Value = client.rib;

            MyCom.ExecuteScalar();

            MyCom.Dispose();
            MyC.Close();
        }

    }
}
