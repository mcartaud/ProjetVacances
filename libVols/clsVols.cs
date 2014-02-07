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
            MyC.ConnectionString = "Data Source=CLEMENT\\SQLEXPRESS;Initial Catalog=ENREGISTREMENTS;Integrated Security = true";
            MyC.Open();
            SqlCommand MyCom = new SqlCommand("listVilleD", MyC);
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
            MyC.ConnectionString = "";
            MyC.Open();
            SqlCommand MyCom = new SqlCommand("listVilleA", MyC);
            MyCom.CommandType = CommandType.StoredProcedure;
            MyCom.Parameters.Add("@VILLEDEPART", SqlDbType.Text);
            MyCom.Parameters["@VILLEDEPART"].Value = villeDepart;
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
            MyC.ConnectionString = "";
            MyC.Open();
            SqlCommand MyCom = new SqlCommand("getDateVol", MyC);
            MyCom.CommandType = CommandType.StoredProcedure;
            MyCom.Parameters.Add("@VILLED", SqlDbType.Text);
            MyCom.Parameters["@VILLED"].Value = VilleD;
            MyCom.Parameters.Add("@VILLEA", SqlDbType.Text);
            MyCom.Parameters["@VILLEA"].Value = VilleA;
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

        public SqlDataReader getVols(string VilleD, string VilleA, DateTime Date)
        {
            SqlConnection MyC = new SqlConnection();
            MyC.ConnectionString = "";
            MyC.Open();
            SqlCommand MyCom = new SqlCommand("getDateVol", MyC);
            MyCom.CommandType = CommandType.StoredProcedure;
            MyCom.Parameters.Add("@VILLED", SqlDbType.Text);
            MyCom.Parameters["@VILLED"].Value = VilleD;
            MyCom.Parameters.Add("@VILLEA", SqlDbType.Text);
            MyCom.Parameters["@VILLEA"].Value = VilleA;
            MyCom.Parameters.Add("@DATE", SqlDbType.Date);
            MyCom.Parameters["@DATE"].Value = Date;
            SqlDataReader Reader = MyCom.ExecuteReader();
            return Reader;
        }
    }
}
