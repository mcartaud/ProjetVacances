<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SiteVoyage._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Réservation d'hotels et de vol</title>
</head>
<body style="height: 391px">
    <form id="form1" runat="server">
        <asp:Label ID="labVilleD" runat="server" Text="Choisissez votre ville de départ: "></asp:Label>
        <asp:DropDownList ID="drpVilleDepart" runat="server" OnSelectedIndexChanged="drpVilleDepart_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:Button ID="btnVilleDepart" runat="server" OnClick="btnVilleDepart_Click" Text="Charger ville arrivee" />
    <div style="height: 17px; margin-top: 20px">
    
        <asp:Label ID="labVilleA" runat="server" Text="Choisissez votre ville d'arrivée: "></asp:Label>
        <asp:DropDownList ID="drpVilleArrivee" runat="server">
        </asp:DropDownList>
    
    </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Date de départ: "></asp:Label>
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        </p>
        <asp:Label ID="Label2" runat="server" Text="Durée du séjour: "></asp:Label>
        <asp:DropDownList ID="listChoixDuree" runat="server">
        </asp:DropDownList>
        <p>
            <asp:Label ID="labChoixVol" runat="server" Text="Choisissez votre vol: "></asp:Label>
            <asp:DropDownList ID="listChoixVol" runat="server">
            </asp:DropDownList>
        </p>
        <asp:Label ID="Label3" runat="server" Text="Choisissez votre hotel: "></asp:Label>
        <asp:DropDownList ID="listChoixHotel" runat="server">
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
