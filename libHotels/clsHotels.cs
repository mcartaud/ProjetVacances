using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace libHotels
{
    public class clsHotels
    {
        public int getDureeMax(string villeArrivee, DateTime date)
        {
            SqlConnection MyC = new SqlConnection();
            MyC.ConnectionString = "";
            MyC.Open();
            SqlCommand MyCom = new SqlCommand("dureeHotel", MyC);
            MyCom.CommandType = CommandType.StoredProcedure;
            MyCom.Parameters.Add("@ARRIVEE", SqlDbType.Text);
            MyCom.Parameters["@ARRIVEE"].Value = villeArrivee;
            MyCom.Parameters.Add("@DATE", SqlDbType.Date);
            MyCom.Parameters["@DATE"].Value = date;
            int Res = Convert.ToInt32(MyCom.ExecuteScalar());
            MyCom.Dispose();
            MyC.Close();
            return Res;
        }

        public List<string> getHotels(string VilleA, string Duree, DateTime Date)
        {
            SqlConnection MyC = new SqlConnection();
            MyC.ConnectionString = "Data Source=172.18.92.166;Initial Catalog=SAISIE;Persist Security Info=True;User ID=benjamin;Password=benjamin";
            MyC.Open();
            SqlCommand MyCom = new SqlCommand("listeHotel", MyC);
            MyCom.CommandType = CommandType.StoredProcedure;
            MyCom.Parameters.Add("@DUREE", SqlDbType.Int);
            MyCom.Parameters["@DUREE"].Value = Duree;
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
