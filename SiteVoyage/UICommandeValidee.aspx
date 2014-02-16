<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UICommandeValidee.aspx.cs" Inherits="SiteVoyage.UICommandeValidee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" media="screen" href="foundation.min.css" />
    <title></title>
</head>
<body style="height: 287px">
    <form id="form1" runat="server">
        <br />
        <br />
        <br />
        <br />
    <div class="row">
        <div class="panel">
            <h1 class="title-area; panel; text-center">Commande prise en compte</h1>
        </div>
    </div>
        <div class="row"></div>
    <br />
    <div class="row">
        <p style="text-align: center;">
            <asp:Button ID="btnRetourDefault" runat="server" Height="33px" OnClick="btnRetourDefault_Click" Text="Continuer à naviguer" Width="140px" />
        </p>
    </div>
    </form>
</body>
</html>
