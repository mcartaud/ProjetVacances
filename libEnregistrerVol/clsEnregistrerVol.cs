using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using dataEntity;

namespace libEnregistrerVol
{
    public class clsEnregistrerVol
    {

        private string Connection = "Data Source=localhost;Initial Catalog=ENREGISTREMENTS;Persist Security Info=True;User ID=benjamin;Password=benjamin";

        public void setVol(clsVolEntity vol, clsInfoClient client)
        {
            SqlConnection MyC = new SqlConnection();
            MyC.ConnectionString = Connection;
            MyC.Open();

            SqlCommand MyCom = new SqlCommand("dbo.enregistrerHotel", MyC);
            MyCom.CommandType = CommandType.StoredProcedure;
            MyCom.Parameters.Add("@villeDepart", SqlDbType.Text);
            MyCom.Parameters["@VilleDepart"].Value = vol.villeDepart;

            MyCom.Parameters.Add("@villeDestination", SqlDbType.Text);
            MyCom.Parameters["@villeDestination"].Value = vol.villeDestination;

            MyCom.Parameters.Add("@dateDepart", SqlDbType.Date);
            MyCom.Parameters["@dateDepart"].Value = vol.dateDepart;

            MyCom.Parameters.Add("@id", SqlDbType.Int);
            MyCom.Parameters["@id"].Value = vol.id;


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
