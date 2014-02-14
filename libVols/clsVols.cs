using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace libVols
{
    public class clsVols
    {

        private string Connection = "Data Source=" + Environment.MachineName + "\\SQLEXPRESS;Initial Catalog=SAISIE;Integrated Security = true";

        public List<List<string>> getInit()
        {
            SqlConnection MyC = new SqlConnection();
            MyC.ConnectionString = Connection;
            MyC.Open();
            SqlCommand MyCom = new SqlCommand("init", MyC);
            MyCom.CommandType = CommandType.StoredProcedure;
            List<string> listeVilleDepart = new List<string>();
            List<string> listePaysDepart = new List<string>();
            SqlDataReader reader = MyCom.ExecuteReader();
            while (reader.Read())
            {
                listeVilleDepart.Add(reader.GetString(0));
                listePaysDepart.Add(reader.GetString(1));
            }
            List<List<string>> liste = new List<List<string>>();
            liste.Add(listeVilleDepart);
            liste.Add(listePaysDepart);
            MyCom.Dispose();
            MyC.Close();
            return liste;
        }

        public List<List<string>> getVilleArrivee(string villeDepart, string paysDepart)
        {
            SqlConnection MyC = new SqlConnection();
            MyC.ConnectionString = Connection;
            MyC.Open();
            SqlCommand MyCom = new SqlCommand("listeVilleArrivee", MyC);
            MyCom.CommandType = CommandType.StoredProcedure;
            MyCom.Parameters.Add("@DEPART", SqlDbType.Text);
            MyCom.Parameters.Add("@PAYSDEPART", SqlDbType.Text);
            MyCom.Parameters["@DEPART"].Value = villeDepart;
            MyCom.Parameters["@PAYSDEPART"].Value = paysDepart;
            List<string> listeVilleArrivee = new List<string>();
            List<string> listePaysArrivee = new List<string>();
            SqlDataReader reader = MyCom.ExecuteReader();
            while (reader.Read())
            {
                listeVilleArrivee.Add(reader.GetString(0));
                listePaysArrivee.Add(reader.GetString(1));
            }
            List<List<string>> listeArrivee = new List<List<string>>();
            listeArrivee.Add(listeVilleArrivee);
            listeArrivee.Add(listePaysArrivee);
            MyCom.Dispose();
            MyC.Close();
            return listeArrivee;
        }

        public DataSet getVols(string VilleD, string PaysD, string VilleA, string PaysA, DateTime Date)
        {
            SqlConnection MyC = new SqlConnection();
            MyC.ConnectionString = Connection;
            MyC.Open();
            SqlDataAdapter MyCom = new SqlDataAdapter("listeVol", MyC);
            MyCom.SelectCommand.CommandType = CommandType.StoredProcedure;
            MyCom.SelectCommand.Parameters.Add("@DEPART", SqlDbType.Text);
            MyCom.SelectCommand.Parameters["@DEPART"].Value = VilleD;
            MyCom.SelectCommand.Parameters.Add("@PAYSDEPART", SqlDbType.Text);
            MyCom.SelectCommand.Parameters["@PAYSDEPART"].Value = PaysD;
            MyCom.SelectCommand.Parameters.Add("@ARRIVEE", SqlDbType.Text);
            MyCom.SelectCommand.Parameters["@ARRIVEE"].Value = VilleA;
            MyCom.SelectCommand.Parameters.Add("@PAYSARRIVEE", SqlDbType.Text);
            MyCom.SelectCommand.Parameters["@PAYSARRIVEE"].Value = PaysA;
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
