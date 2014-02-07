<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SiteVoyage._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 230px;
        }
    </style>
</head>
<body style="height: 391px">
    <form id="form1" runat="server">
        <asp:Label ID="labVilleD" runat="server" Text="Choisissez votre ville de départ: "></asp:Label>
        <asp:DropDownList ID="listVilleD" runat="server" style="margin-left: 36px">
        </asp:DropDownList>
    <div style="height: 17px; margin-top: 20px">
    
        <asp:Label ID="labVilleA" runat="server" Text="Choisissez votre ville d'arrivée: "></asp:Label>
        <asp:DropDownList ID="listVilleA" runat="server" style="margin-left: 42px">
        </asp:DropDownList>
    
    </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Date de départ: "></asp:Label>
            <asp:DropDownList ID="listDateDepart" runat="server" style="margin-left: 133px">
            </asp:DropDownList>
        </p>
        <asp:Label ID="Label2" runat="server" Text="Durée du séjour: "></asp:Label>
        <asp:DropDownList ID="listChoixDuree" runat="server" style="margin-left: 127px">
        </asp:DropDownList>
        <p>
            <asp:Label ID="labChoixVol" runat="server" Text="Choisissez votre vol: "></asp:Label>
            <asp:DropDownList ID="listChoixVol" runat="server" style="margin-left: 106px">
            </asp:DropDownList>
        </p>
        <asp:Label ID="Label3" runat="server" Text="Choisissez votre hotel: "></asp:Label>
        <asp:DropDownList ID="listChoixHotel" runat="server" style="margin-left: 93px">
        </asp:DropDownList>
    </form>
</body>
</html>
