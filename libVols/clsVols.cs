using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace libVols
{
    public class clsVols
    {

        public List<string> getVilleDepart()
        {
            SqlConnection MyC = new SqlConnection();
            MyC.ConnectionString = "Data Source=172.18.92.166;Initial Catalog=SAISIE;Persist Security Info=True;User ID=benjamin;Password=benjamin";
            MyC.Open();
            SqlCommand MyCom = new SqlCommand("listeVilleDepart", MyC);
            MyCom.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = MyCom.ExecuteReader();
            List<string> Res = new List<string>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Res.Add(reader.GetString(0));
                }
            }
            MyCom.Dispose();
            MyC.Close();
            return Res;
        }
        public List<string> getVilleArrivee(string villeDepart)
        {
            SqlConnection MyC = new SqlConnection();
            MyC.ConnectionString = "Data Source=172.18.92.166;Initial Catalog=SAISIE;Persist Security Info=True;User ID=benjamin;Password=benjamin";
            MyC.Open();
            SqlCommand MyCom = new SqlCommand("listeVilleArrivee", MyC);
            MyCom.CommandType = CommandType.StoredProcedure;
            MyCom.Parameters.Add("@DEPART", SqlDbType.Text);
            MyCom.Parameters["@DEPART"].Value = villeDepart;
            SqlDataReader reader = MyCom.ExecuteReader();
            List<string> Res = new List<string>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Res.Add(reader.GetString(0));
                }
            }
            MyCom.Dispose();
            MyC.Close();
            return Res;
        }

        public List<DateTime> getDateVol(string VilleD, string VilleA)
        {
            SqlConnection MyC = new SqlConnection();
            MyC.ConnectionString = "Data Source=172.18.92.166;Initial Catalog=SAISIE;Persist Security Info=True;User ID=benjamin;Password=benjamin";
            MyC.Open();
            SqlCommand MyCom = new SqlCommand("listeDateVol", MyC);
            MyCom.CommandType = CommandType.StoredProcedure;
            MyCom.Parameters.Add("@DEPART", SqlDbType.Text);
            MyCom.Parameters["@DEPART"].Value = VilleD;
            MyCom.Parameters.Add("@ARRIVEE", SqlDbType.Text);
            MyCom.Parameters["@ARRIVEE"].Value = VilleA;
            SqlDataReader reader = MyCom.ExecuteReader();
            List<DateTime> Res = new List<DateTime>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Res.Add(reader.GetDateTime(0));
                }
            }
            MyCom.Dispose();
            MyC.Close();
            return Res;
        }

        public List<string> getVols(string VilleD, string VilleA, DateTime Date)
        {
            SqlConnection MyC = new SqlConnection();
            MyC.ConnectionString = "Data Source=172.18.92.166;Initial Catalog=SAISIE;Persist Security Info=True;User ID=benjamin;Password=benjamin";
            MyC.Open();
            SqlCommand MyCom = new SqlCommand("listeVol", MyC);
            MyCom.CommandType = CommandType.StoredProcedure;
            MyCom.Parameters.Add("@DEPART", SqlDbType.Text);
            MyCom.Parameters["@DEPART"].Value = VilleD;
            MyCom.Parameters.Add("@ARRIVEE", SqlDbType.Text);
            MyCom.Parameters["@ARRIVEE"].Value = VilleA;
            MyCom.Parameters.Add("@DATE", SqlDbType.Date);
            MyCom.Parameters["@DATE"].Value = Date;
            SqlDataReader reader = MyCom.ExecuteReader();
            List<string> Res = new List<string>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Res.Add(reader.GetString(0) + ";" + reader.GetString(1) + ";" + reader.GetDateTime(2));
                }
            }
            MyCom.Dispose();
            MyC.Close();
            return Res;
        }
    }
}
