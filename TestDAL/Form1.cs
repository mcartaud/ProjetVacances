using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using libHotels;
using libVols;

namespace TestDAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsHotels hotels = new clsHotels();
            clsVols vols = new clsVols();
            label1.Text = hotels.getHotels("Paris", 5, new DateTime(2014,02,07)).Tables[0].Rows[0].ItemArray[0].ToString();
             label1.Text = vols.getDateVol("Nantes", "Paris").Tables[0].Rows[0].ItemArray[0].ToString();
           label1.Text = vols.getVilleArrivee("Nantes").Tables[0].Rows[0].ItemArray[0].ToString();
           // label1.Text = vols.getVilleDepart().Tables[0].Rows[0].ItemArray[0].ToString();
            label1.Text = vols.getVols("Nantes", "Paris", new DateTime(2014, 01, 01)).Tables[0].Rows[0].ItemArray[0].ToString();
        }
    }
}
