<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SiteVoyage._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Réservation d'hotels et de vol</title>
    <link rel="stylesheet" media="screen" href="foundation.min.css" />
    <link rel="stylesheet" media="screen" href="default.css" />
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
                <div class="medium-5 columns">
                    <label>Date de départ:</label>
                    <asp:Calendar ID="cldDateDepart" runat="server"></asp:Calendar>
                </div>
                <div class="medium-5 columns">
                    <label>Date de retour:</label>
                    <asp:Calendar ID="calHotel" runat="server"></asp:Calendar>
                </div>    
            </div>
            <div class="row">
                <asp:Button ID="btnRechercher" runat="server" Text="Rechercher" OnClick="btnRechercher_Click" Width="100%"/>
            </div>
            <div class="row"></div>
            <div class="row"></div>
            <div class="row">
                <asp:Label ID="lblListeVol" runat="server" Text="Liste des vols :"></asp:Label>
            </div>
            <asp:GridView ID="gvVols" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gvVols_SelectedIndexChanged" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="villeDepartVol" HeaderText="Ville de départ" SortExpression="villeDepartVol" />
                    <asp:BoundField DataField="paysDepartVol" HeaderText="Pays de départ" SortExpression="paysDepartVol" />
                    <asp:BoundField DataField="villeDestinationVol" HeaderText="Ville d'arrivée" SortExpression="villeDestinationVol" />
                    <asp:BoundField DataField="paysDestinationVol" HeaderText="Pays d'arrivée" SortExpression="paysDestinationVol" />
                    <asp:BoundField DataField="dateDepartVol" HeaderText="date de départ" SortExpression="dateDepartVol" />
                    <asp:BoundField DataField="prixVol" HeaderText="Prix du vol" SortExpression="prixVol" />
                </Columns>
            </asp:GridView>
            <div class="row"></div>
            <div class="row">
                <asp:Label ID="lblHotel" runat="server" Text="Liste des hotels :"></asp:Label>
            </div>
            <asp:GridView ID="gvHotels" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gvHotels_SelectedIndexChanged" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="nomHotel" HeaderText="Nom de l'hotel" SortExpression="nomHotel" />
                    <asp:BoundField DataField="adresseHotel" HeaderText="Adresse" SortExpression="adresseHotel" />
                    <asp:BoundField DataField="cpHotel" HeaderText="Code postal" SortExpression="cpHotel" />
                    <asp:BoundField DataField="villeHotel" HeaderText="Ville" SortExpression="villeHotel" />
                    <asp:BoundField DataField="paysHotel" HeaderText="Pays" SortExpression="paysHotel" />
                    <asp:BoundField DataField="prixHotel" HeaderText="Prix de la nuit" SortExpression="prixHotel" />
                    <asp:BoundField DataField="etoileHotel" HeaderText="Nombre d'étoiles" SortExpression="etoileHotel" />
                    <asp:BoundField DataField="dateArriveeHotel" HeaderText="Date d'arrivée possible" SortExpression="dateArriveeHotel" />
                </Columns>
            </asp:GridView>
        </div>
        <div class="row"></div>
        <asp:Button ID="btnValider" runat="server" OnClick="btnValider_Click" Text="Valider" />
    </form>
</body>
</html>
