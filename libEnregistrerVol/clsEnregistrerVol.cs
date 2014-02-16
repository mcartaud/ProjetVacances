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

        public void ajouterVol(clsVolEntity vol, clsInfoClient client)
        {
            SqlConnection MyC = new SqlConnection();
            MyC.ConnectionString = Connection;
            MyC.Open();

            SqlCommand MyCom = new SqlCommand("dbo.enregistrerHotel", MyC);
            MyCom.CommandType = CommandType.StoredProcedure;

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

            MyCom.Parameters.Add("@paysUser", SqlDbType.Text);
            MyCom.Parameters["@paysUser"].Value = client.paysUser;

            MyCom.Parameters.Add("@compteUser", SqlDbType.Text);
            MyCom.Parameters["@compteUser"].Value = client.compteUser;

            MyCom.Parameters.Add("@villeDepartVol", SqlDbType.Text);
            MyCom.Parameters["@villeDepartVol"].Value = vol.villeDepart;

            MyCom.Parameters.Add("@paysDepartVol", SqlDbType.Text);
            MyCom.Parameters["@paysDepartVol"].Value = vol.paysDepart;

            MyCom.Parameters.Add("@villeDestinationVol", SqlDbType.Text);
            MyCom.Parameters["@villeDestinationVol"].Value = vol.villeDestination;

            MyCom.Parameters.Add("@paysDestinationVol", SqlDbType.Text);
            MyCom.Parameters["@paysDestinationVol"].Value = vol.paysDestination;

            MyCom.Parameters.Add("@dateDepartVol", SqlDbType.Date);
            MyCom.Parameters["@dateDepartVol"].Value = vol.dateDepart;

            MyCom.Parameters.Add("@prixVol", SqlDbType.Int);
            MyCom.Parameters["@prixVol"].Value = vol.prixVol;

            MyCom.ExecuteScalar();

            MyCom.Dispose();
            MyC.Close();
        }

    }
}
