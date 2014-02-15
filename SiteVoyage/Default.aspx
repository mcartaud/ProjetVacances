﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SiteVoyage._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Réservation d'hotels et de vol</title>
    <link rel="stylesheet" media="screen" href="App_Data/foundation.min.css" />
    <link rel="stylesheet" media="screen" href="App_Data/default.css" />
</head>
<body>
    <div class="panel">
        <h1 class="title-area; panel; text-center">Réservation de vols et d'hôtels</h1>
    </div>
    <form id="form1" runat="server">
        <div class="large-12 columns">
            <div class="row">
                <div class="alert-box warning radius">
                    <asp:Label ID="lblError" runat="server"></asp:Label>
                </div>
            </div>
            <div class="row">
                <asp:Label ID="labVilleD" runat="server" Text="Choisissez votre ville de départ: "></asp:Label>
                <asp:DropDownList ID="drpVilleDepart" runat="server" OnSelectedIndexChanged="drpVilleDepart_SelectedIndexChanged" AutoPostBack="True">
                </asp:DropDownList>
            </div>
            <div class="row">
                <asp:Label ID="labVilleA" runat="server" Text="Choisissez votre ville d'arrivée: "></asp:Label>
                <asp:DropDownList ID="drpVilleArrivee" runat="server">
                </asp:DropDownList>
            </div>
            <div class="row">
                <asp:Label ID="Label1" runat="server" Text="Date de départ:"></asp:Label>
                <asp:Label ID="Label2" runat="server" Text="Date de retour:"></asp:Label>
                <asp:Calendar ID="cldDateDepart" runat="server" Width="42%"></asp:Calendar>
                <asp:Calendar ID="calHotel" runat="server"></asp:Calendar>
            </div>
            <div class="row">
                <asp:Button ID="btnRechercher" runat="server" Text="Rechercher" OnClick="btnRechercher_Click" Width="100%"/>
            </div>
            <div class="row">
                <asp:Label ID="lblListeVol" runat="server" Text="Liste des vols :"></asp:Label>
            </div>
            <asp:GridView ID="gvVols" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gvVols_SelectedIndexChanged">
            </asp:GridView>
            Liste des hotels :<asp:GridView ID="gvHotels" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gvHotels_SelectedIndexChanged">
            </asp:GridView>
        </div>
        <asp:Button ID="btnValider" runat="server" OnClick="btnValider_Click" Text="Valider" />
    </form>
</body>
</html>
