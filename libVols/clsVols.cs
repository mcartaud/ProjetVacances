using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace libVols
{
    public class clsVols
    {

        private string Connection = "Data Source=localhost;Initial Catalog=SAISIE;Persist Security Info=True;User ID=benjamin;Password=benjamin";

        public List<string> getVilleDepart()
        {
            SqlConnection MyC = new SqlConnection();
            MyC.ConnectionString = Connection;
            MyC.Open();
            SqlCommand MyCom = new SqlCommand("listeVilleDepart", MyC);
            MyCom.CommandType = CommandType.StoredProcedure;
            List<string> listeVilleDepart = new List<string>();
            SqlDataReader reader = MyCom.ExecuteReader();
            while (reader.Read())
            {
                listeVilleDepart.Add(reader.GetString(0));
            }
            MyCom.Dispose();
            MyC.Close();
            return listeVilleDepart;
        }
        public List<string> getVilleArrivee(string villeDepart)
        {
            SqlConnection MyC = new SqlConnection();
            MyC.ConnectionString = Connection;
            MyC.Open();
            SqlCommand MyCom = new SqlCommand("listeVilleArrivee", MyC);
            MyCom.CommandType = CommandType.StoredProcedure;
            MyCom.Parameters.Add("@DEPART", SqlDbType.Text);
            MyCom.Parameters["@DEPART"].Value = villeDepart;
            List<string> listeVilleArrivee = new List<string>();
            SqlDataReader reader = MyCom.ExecuteReader();
            while (reader.Read())
            {
                listeVilleArrivee.Add(reader.GetString(0));
            }
            MyCom.Dispose();
            MyC.Close();
            return listeVilleArrivee;
        }

        public DataSet getDateVol(string VilleD, string VilleA)
        {
            SqlConnection MyC = new SqlConnection();
            MyC.ConnectionString = Connection;
            MyC.Open();
            SqlDataAdapter MyCom = new SqlDataAdapter("listeDateVol", MyC);
            MyCom.SelectCommand.CommandType = CommandType.StoredProcedure;
            MyCom.SelectCommand.Parameters.Add("@DEPART", SqlDbType.Text);
            MyCom.SelectCommand.Parameters["@DEPART"].Value = VilleD;
            MyCom.SelectCommand.Parameters.Add("@ARRIVEE", SqlDbType.Text);
            MyCom.SelectCommand.Parameters["@ARRIVEE"].Value = VilleA;
            DataSet DataSet = new DataSet();
            MyCom.Fill(DataSet, "LISTE_DATE_VOL");
            MyCom.Dispose();
            MyC.Close();
            return DataSet;
        }

        public DataSet getVols(string VilleD, string VilleA, DateTime Date)
        {
            SqlConnection MyC = new SqlConnection();
            MyC.ConnectionString = Connection;
            MyC.Open();
            SqlDataAdapter MyCom = new SqlDataAdapter("listeVol", MyC);
            MyCom.SelectCommand.CommandType = CommandType.StoredProcedure;
            MyCom.SelectCommand.Parameters.Add("@DEPART", SqlDbType.Text);
            MyCom.SelectCommand.Parameters["@DEPART"].Value = VilleD;
            MyCom.SelectCommand.Parameters.Add("@ARRIVEE", SqlDbType.Text);
            MyCom.SelectCommand.Parameters["@ARRIVEE"].Value = VilleA;
            MyCom.SelectCommand.Parameters.Add("@DATE", SqlDbType.Date);
            MyCom.SelectCommand.Parameters["@DATE"].Value = Date;
            DataSet DataSet = new DataSet();
            MyCom.Fill(DataSet, "LISTE_VOLS");
            MyCom.Dispose();
            MyC.Close();
            return DataSet;
        }
    }
}
