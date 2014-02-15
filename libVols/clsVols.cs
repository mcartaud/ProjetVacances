using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using dataEntity;

namespace libVols
{
    public class clsVols
    {

        private string Connection = "Data Source=" + Environment.MachineName + "\\SQLEXPRESS;Initial Catalog=SAISIE;Integrated Security = true";

        public List<departStructure> getInit()
        {
            SqlConnection MyC = new SqlConnection();
            MyC.ConnectionString = Connection;
            MyC.Open();
            SqlCommand MyCom = new SqlCommand("init", MyC);
            MyCom.CommandType = CommandType.StoredProcedure;
            List<departStructure> listDepart = new List<departStructure>();
            SqlDataReader reader = MyCom.ExecuteReader();
            while (reader.Read())
            {
                departStructure depart = new departStructure();
                depart.ville = reader.GetString(0);
                depart.pays = reader.GetString(1);
                listDepart.Add(depart);
            }
            MyCom.Dispose();
            MyC.Close();
            return listDepart;
        }

        public List<arriveeStructure> getVilleArrivee(string villeDepart, string paysDepart)
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
            List<arriveeStructure> listArrivee = new List<arriveeStructure>();
            SqlDataReader reader = MyCom.ExecuteReader();
            while (reader.Read())
            {
                arriveeStructure arrivee = new arriveeStructure();
                arrivee.ville = reader.GetString(0);
                arrivee.pays = reader.GetString(1);
                listArrivee.Add(arrivee);
            }
            MyCom.Dispose();
            MyC.Close();
            return listArrivee;
        }

        public DataSet getVols(string VilleD, string PaysD, string VilleA, string PaysA, DateTime Date, DateTime FinDate)
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
            MyCom.SelectCommand.Parameters.Add("@DATEFIN", SqlDbType.Date);
            MyCom.SelectCommand.Parameters["@DATEFIN"].Value = FinDate;
            DataSet DataSet = new DataSet();
            MyCom.Fill(DataSet, "LISTE_VOLS");
            MyCom.Dispose();
            MyC.Close();
            return DataSet;
        }
    }
}
