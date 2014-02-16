﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using dataEntity;

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

            drpVilleDepart.Items.Add(new ListItem("indéfini"));

            for (int i = 1; i < listeDepart.Length; i++)
            {
                SiteVoyage.WebServiceVol.departStructure depart = liste[i - 1];
                listeDepart[i] = depart.ville + " - " + depart.pays;
                if(!drpVilleDepart.Items.Contains(new ListItem(listeDepart[i]))){
                    drpVilleDepart.Items.Add(new ListItem(listeDepart[i]));
                }
            }
        }

        protected void drpVilleDepart_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = drpVilleDepart.SelectedItem.ToString();
            string[] selections = selection.Split('-');
            string villeD = selections[0].Trim();
            string paysD = selections[1].Trim();
            SiteVoyage.WebServiceVol.arriveeStructure[] liste = this.wsVol.getVilleArrivee(villeD, paysD);
            string[] listeArrivee = new string[liste.Length];

            drpVilleArrivee.Items.Clear();
            for (int i = 0; i < listeArrivee.Length; i++)
            {
                SiteVoyage.WebServiceVol.arriveeStructure arrivee = liste[i];
                listeArrivee[i] = arrivee.ville + " - " + arrivee.pays;
                if (!drpVilleArrivee.Items.Contains(new ListItem(listeArrivee[i])))
                {
                    drpVilleArrivee.Items.Add(new ListItem(listeArrivee[i]));
                }
            }
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
            DateTime dateFinDepart = cldDateDepart.SelectedDate;
            dateFinDepart = dateFinDepart.AddDays(1.0);
            DateTime dateRetour = calHotel.SelectedDate;
            // Un des champs n'a pas été saisi
            if (String.IsNullOrEmpty(villeD) || String.IsNullOrEmpty(villeA) || dateDepart == null || dateRetour == null)
            {
                lblError.Text = "Un des champs n'a pas été rempli";
            }
            else
            {
                DataTable infoVols = this.wsVol.getVols(villeD, paysD, villeA, paysA, dateDepart, dateFinDepart).Tables[0];
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
            foreach(GridViewRow row in gvVols.Rows)
            {
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
            GridViewRow rowVol = gvVols.SelectedRow;
            GridViewRow rowHotel = gvHotels.SelectedRow;

            DateTime dateDepart = cldDateDepart.SelectedDate;
            DateTime dateRetour = calHotel.SelectedDate;
            clsVolEntity volEntity = new clsVolEntity();
            clsHotelEntity hotelEntity = new clsHotelEntity();

            if(rowHotel != null && rowVol != null && dateDepart != null && dateRetour != null)
            {
                TimeSpan ts = dateRetour - dateDepart;
                int duree = ts.Days;

                volEntity.dateDepart = Convert.ToDateTime(rowVol.Cells[5].Text);
                volEntity.villeDepart = rowVol.Cells[1].Text;
                volEntity.paysDepart = rowVol.Cells[2].Text;
                volEntity.villeDestination = rowVol.Cells[3].Text;
                volEntity.paysDestination = rowVol.Cells[4].Text;
                volEntity.prixVol = Convert.ToInt32(rowVol.Cells[6].Text);

                hotelEntity.nomHotel = rowHotel.Cells[1].Text;
                hotelEntity.adresseHotel = rowHotel.Cells[2].Text;
                hotelEntity.cpHotel = Convert.ToInt32(rowHotel.Cells[3].Text);
                hotelEntity.villeHotel = rowHotel.Cells[4].Text;
                hotelEntity.paysHotel = rowHotel.Cells[5].Text;
                hotelEntity.dateArrivee = Convert.ToDateTime(rowHotel.Cells[8].Text);
                hotelEntity.duree = duree;
                hotelEntity.prixNuit = Convert.ToInt32(rowHotel.Cells[6].Text);

                Session["vol"] = volEntity;
                Session["hotel"] = hotelEntity;
                Session["arrivee"] = dateRetour.ToShortDateString();
                Session["depart"] = dateDepart.ToShortDateString();
                Response.Redirect("UIPaiement.aspx");
            } else {
                lblError.Text = "Veuillez vérifier les vols et hotels choisis";
            }
        }
    }
}