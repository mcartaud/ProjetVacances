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
            SiteVoyage.WebServiceVol.departStructure[] liste = wsVol.getInit();
            string[] listeDepart = new string[liste.Length + 1];
            listeDepart[0] = "indéfini";
            for (int i = 1; i < listeDepart.Length; i++)
            {
                SiteVoyage.WebServiceVol.departStructure depart = liste[i - 1];
                listeDepart[i] = depart.ville + " - " + depart.pays;
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
            SiteVoyage.WebServiceVol.arriveeStructure[] liste = this.wsVol.getVilleArrivee(villeD, paysD);
            string[] listeArrivee = new string[liste.Length];
            for (int i = 0; i < listeArrivee.Length; i++)
            {
                SiteVoyage.WebServiceVol.arriveeStructure arrivee = liste[i];
                listeArrivee[i] = arrivee.ville + " - " + arrivee.pays;
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
            DateTime dateRetour = calHotel.SelectedDate;
            // Un des champs n'a pas été saisi
            if (String.IsNullOrEmpty(villeD) || String.IsNullOrEmpty(villeA) || dateDepart == null || dateRetour == null)
            {
                lblError.Text = "Un des champs n'a pas été rempli";
            }
            else
            {
                DataTable infoVols = this.wsVol.getVols(villeD, paysD, villeA, paysA, dateDepart).Tables[0];
                DataTable infoHotels;
                if (infoVols != null)
                {
                    TimeSpan ts = dateRetour - dateDepart;
                    int duree = ts.Days;
                    infoHotels = this.wsHotel.getHotels(villeA, paysA, duree, dateDepart).Tables[0];
                    gvVols.DataSource = infoVols;
                    gvVols.DataBind();

                    gvHotels.DataSource = infoHotels;
                    gvHotels.DataBind();
                }     
            }
        }

        protected void gvVols_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(GridViewRow row in gvVols.Rows){
                row.BackColor = System.Drawing.Color.White;
            }
            GridViewRow selectedRow = gvVols.SelectedRow;
            selectedRow.BackColor = System.Drawing.Color.Cyan;
        }

        protected void gvHotels_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in gvHotels.Rows)
            {
                row.BackColor = System.Drawing.Color.White;
            }
            GridViewRow selectedRow = gvHotels.SelectedRow;
            selectedRow.BackColor = System.Drawing.Color.Cyan;
        }

        protected void btnValider_Click(object sender, EventArgs e)
        {
            GridViewRow rowVol = null;
            GridViewRow rowHotel = null;
            foreach (GridViewRow row in gvVols.Rows){
                if (row.BackColor == System.Drawing.Color.Cyan) {
                    rowVol = row;
                }
            }
            foreach (GridViewRow row in gvHotels.Rows){
                if (row.BackColor == System.Drawing.Color.Cyan) {
                    rowHotel = row;
                }
            }

            DateTime dateDepart = cldDateDepart.SelectedDate;
            DateTime dateRetour = calHotel.SelectedDate;
            
            if(rowHotel != null && rowVol != null && dateDepart != null && dateRetour != null) {

                Session["vol"] = rowVol;
                Session["hotel"] = rowHotel;
                Session["arrivee"] = dateRetour.ToShortDateString();
                Session["depart"] = dateDepart.ToShortDateString();
                Response.Redirect("UIPaiement.aspx");
            } else {
                lblError.Text = "Veuillez vérifier les vols et hotels choisis";
            }
        }
    }
}