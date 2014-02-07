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
            SqlCommand MyCom = new SqlCommand("getDuree", MyC);
            MyCom.CommandType = CommandType.StoredProcedure;
            MyCom.Parameters.Add("@VILLEARR", SqlDbType.Text);
            MyCom.Parameters["@VILLEARR"].Value = villeArrivee;
            MyCom.Parameters.Add("@DATE", SqlDbType.Date);
            MyCom.Parameters["@DATE"].Value = date;
            int Res = Convert.ToInt32(MyCom.ExecuteScalar());
            MyCom.Dispose();
            MyC.Close();
            return Res;
        }   
    }
}
