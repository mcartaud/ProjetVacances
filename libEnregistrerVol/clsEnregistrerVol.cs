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
            MyCom.Parameters["@villeDepart"].Value = vol.villeDepart;

            MyCom.Parameters.Add("@paysDepart", SqlDbType.Text);
            MyCom.Parameters["@paysDepart"].Value = vol.paysDepart;

            MyCom.Parameters.Add("@paysDestination", SqlDbType.Text);
            MyCom.Parameters["@paysDestination"].Value = vol.paysDestination;

            MyCom.Parameters.Add("@villeDestination", SqlDbType.Text);
            MyCom.Parameters["@villeDestination"].Value = vol.villeDestination;

            MyCom.Parameters.Add("@dateDepart", SqlDbType.Date);
            MyCom.Parameters["@dateDepart"].Value = vol.dateDepart;

            MyCom.Parameters.Add("@prixVol", SqlDbType.Int);
            MyCom.Parameters["@prixVol"].Value = vol.prixVol;

            MyCom.Parameters.Add("@id", SqlDbType.Int);
            MyCom.Parameters["@id"].Value = vol.id;


            MyCom.Parameters.Add("@nomUser", SqlDbType.Text);
            MyCom.Parameters["@nomUser"].Value = client.nomUser;

            MyCom.Parameters.Add("@villeUser", SqlDbType.Text);
            MyCom.Parameters["@villeUser"].Value = client.villeUser;

            MyCom.Parameters.Add("@paysUser", SqlDbType.Text);
            MyCom.Parameters["@paysUser"].Value = client.paysUser;

            MyCom.Parameters.Add("@cpUser", SqlDbType.Int);
            MyCom.Parameters["@cpUser"].Value = client.cpUser;

            MyCom.Parameters.Add("@adresseUser", SqlDbType.Text);
            MyCom.Parameters["@adresseUser"].Value = client.adresseUser;

            MyCom.Parameters.Add("@prenomUser", SqlDbType.Text);
            MyCom.Parameters["@prenomUser"].Value = client.prenomUser;

            MyCom.Parameters.Add("@ribUser", SqlDbType.Text);
            MyCom.Parameters["@ribUser"].Value = client.ribUser;

            MyCom.ExecuteScalar();

            MyCom.Dispose();
            MyC.Close();
        }

    }
}
