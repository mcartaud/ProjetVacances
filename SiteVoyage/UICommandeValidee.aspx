<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UICommandeValidee.aspx.cs" Inherits="SiteVoyage.UICommandeValidee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblPriseEnCompte" runat="server" Text="Commande prise en compte"></asp:Label>
    
    </div>
        <asp:Button ID="btnRetourDefault" runat="server" OnClick="btnRetourDefault_Click" Text="Continuer à naviguer" />
    </form>
</body>
</html>
