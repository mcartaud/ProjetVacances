﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Diagnostics;

namespace SiteVoyage
{
    public partial class _Default : System.Web.UI.Page
    {
        private WebServiceVol.Service1 wsVol = new WebServiceVol.Service1();

        protected void Page_Init(object sender, EventArgs e)
        {
            string[][] listeDepart = this.wsVol.getVilleDepart();
            string[] liste = listeDepart[0];
            for (int i = 0; i < liste.Length; i++)
            {
                liste[i] = liste[i] + " - " + listeDepart[1][i];
            }
            drpVilleDepart.DataSource = liste;
            drpVilleDepart.DataBind();
        }

        protected void drpVilleDepart_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = drpVilleDepart.SelectedItem.ToString();
            string[] selections = selection.Split('-');
            string villeDepart = selections[0].Trim();
            string paysDepart = selections[1].Trim();
            string[][] listeArrivee = this.wsVol.getVilleArrivee(villeDepart, paysDepart);
            string[] liste = listeArrivee[0];
            for (int i = 0; i < liste.Length; i++)
            {
                liste[i] = liste[i] + " - " + listeArrivee[1][i];
            }
            ListItem li = new ListItem();
            drpVilleArrivee.Items.Clear();
            for (int i = 0; i < liste.Length; i++)
            {
                li.Text = liste[i];
                li.Value = liste[i];
                drpVilleArrivee.Items.Add(li);
            }
        }

        protected void btnRechercher_Click(object sender, EventArgs e)
        {
            string villeDepart = drpVilleDepart.Text;
            string villeArrivee = drpVilleArrivee.Text;
            DateTime dateDepart = cldDateDepart.SelectedDate;
            // Un des champs n'a pas été saisi
            if (String.IsNullOrEmpty(villeDepart) || String.IsNullOrEmpty(villeArrivee) || dateDepart == null)
            {
                lblError.Text = "Un des champs n'a pas été rempli";
            }
            else
            {
                drpVols.DataSource = this.wsVol.getVols(villeDepart, villeArrivee, dateDepart).Tables[0];
                drpVols.DataTextField = "villeDepartVol";
                drpVols.DataBind();
            }
        }
    }
}