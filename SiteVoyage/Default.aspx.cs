﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace SiteVoyage
{
    public partial class _Default : System.Web.UI.Page
    {
        private WebServiceVol.Service1 wsVol = new WebServiceVol.Service1();
        private WebServiceHotel.Service1 wsHotel = new WebServiceHotel.Service1();

        protected void Page_Init(object sender, EventArgs e)
        {
            string[][] liste = this.wsVol.getInit();
            string[] listeDepart = liste[0];
            for (int i = 0; i < listeDepart.Length; i++)
            {
                listeDepart[i] = listeDepart[i] + " - " + liste[1][i];
            }
            drpVilleDepart.DataSource = listeDepart;
            drpVilleDepart.DataBind();
        }

        protected void drpVilleDepart_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = drpVilleDepart.SelectedItem.ToString();
            string[] selections = selection.Split('-');
            string villeD = selections[0].Trim();
            string paysD = selections[1].Trim();
            string[][] liste= this.wsVol.getVilleArrivee(villeD, paysD);
            string[] listeArrivee = liste[0];
            for (int i = 0; i < listeArrivee.Length; i++)
            {
                listeArrivee[i] = listeArrivee[i] + " - " + liste[1][i];
            }
            ListItem li = new ListItem();
            drpVilleArrivee.Items.Clear();
            drpVilleArrivee.DataSource = listeArrivee;
            drpVilleArrivee.DataBind();
        }

        protected void btnRechercher_Click(object sender, EventArgs e)
        {
            string selection = drpVilleArrivee.SelectedItem.ToString();
            string[] selections = selection.Split('-');
            string villeA = selections[0].Trim();
            string paysA = selections[1].Trim();
            string selectionDep = drpVilleDepart.SelectedItem.ToString();
            string[] selectionsDep = selectionDep.Split('-');
            string villeD = selectionsDep[0].Trim();
            string paysD = selectionsDep[1].Trim();
            DateTime dateDepart = cldDateDepart.SelectedDate;
            // Un des champs n'a pas été saisi
            if (String.IsNullOrEmpty(villeD) || String.IsNullOrEmpty(villeA) || dateDepart == null)
            {
                lblError.Text = "Un des champs n'a pas été rempli";
            }
            else
            {
                DataTable infoVols = this.wsVol.getVols(villeD, paysD, villeA, paysA, dateDepart).Tables[0];
                DataTable infoHotels;
                if (infoVols != null)
                {
                  //  infoHotels = this.wsHotel.getHotels()
                }     
                gvVols.DataSource = infoVols;
                gvVols.DataBind();
              //  gvHotels.DataSource = infoHotels;
               // gvHotels.DataBind();
            }
        }
    }
}