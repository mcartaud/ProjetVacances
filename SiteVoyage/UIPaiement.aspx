<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UIPaiement.aspx.cs" Inherits="SiteVoyage.UIPaiement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" media="screen" href="foundation.min.css" />
    <title>Paiement</title>
    <style type="text/css">
        .auto-style1 {
            height: 22px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="panel">
            <h1 class="title-area; panel; text-center">Confirmation de la commande</h1>
        </div>
        <div class="medium-12 columns">
            <asp:Label ID="lblError" runat="server" EnableTheming="True" Font-Size="X-Large" ForeColor="Red" Visible="False"></asp:Label>

            <div class="row">
                <h2>Récapitulatif de la commande</h2>
            </div>
            <div>
                <div class="row">
                    Vols : <asp:Label ID="lblRecapVol" runat="server"></asp:Label>
                </div>
                <div class="row">
                    Date de départ : <asp:Label ID="lblRecapDepart" runat="server"></asp:Label>
                </div>
               <div class="row">
                    Date d&#39;arrivée : <asp:Label ID="lblRecapArrivee" runat="server"></asp:Label>
                </div>
                <div class="row">
                    Hôtel réservé : <asp:Label ID="lblRecapHotel" runat="server"></asp:Label>
                </div>
                <div class="row">
                    Prix total : <asp:Label ID="lblPrixTotal" runat="server"></asp:Label>
                </div>
            </div>
           <div class="row">
                <h2>Coordonnées de contact :</h2>
           </div>
           <div>
                <div class="row">
                    Nom : <asp:TextBox ID="txtNom" runat="server"></asp:TextBox>
                </div>
                <div class="row">
                    Prénom : <asp:TextBox ID="txtPrenom" runat="server"></asp:TextBox>
                </div>
                <div class="row">
                    Age : <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
                </div>

               <div class="row">
                    Nationalité : <asp:TextBox ID="txtNationalite" runat="server"></asp:TextBox>
                </div>
                <div class="row">
                    Ville : <asp:TextBox ID="txtVille" runat="server"></asp:TextBox>
                </div>

                <div class="row">
                    Code Postal : <asp:TextBox ID="txtCp" runat="server"></asp:TextBox>
                </div>

                <div class="row">
                    Adresse : <asp:TextBox ID="txtAdresse" runat="server"></asp:TextBox>
                </div>

                <div class="row">
                    Téléphone : 
                    <asp:TextBox ID="txtTelephone" runat="server"></asp:TextBox>
                    <asp:CompareValidator ID="cv" runat="server" ControlToValidate="txtTelephone" Type="Integer"
                            Operator="DataTypeCheck" ErrorMessage="Veuillez entrer un nombre !" />
                </div>

            </div>
            <div class="row">
                <h2>Coordonnées bancaire :</h2>
            </div>
            <div>
                <div class="row">
                    Numéro carte : <asp:TextBox ID="txtNumCarte" runat="server"></asp:TextBox>
                        <asp:CompareValidator ID="Cv1" runat="server" ControlToValidate="txtNumCarte" Type="Integer"
                            Operator="DataTypeCheck" ErrorMessage="Veuillez entrer un nombre !" />
                </div>
                <div class="row">
                    Cryptogramme : <asp:TextBox ID="txtCryptogramme" runat="server"></asp:TextBox>
                        <asp:CompareValidator ID="Cv2" runat="server" ControlToValidate="txtCryptogramme" Type="Integer"
                            Operator="DataTypeCheck" ErrorMessage="Veuillez entrer un nombre !" />
                </div>
                <div class="row">
                    Date d&#39;expiration :
                    <asp:DropDownList ID="drpMoisExpiration" runat="server">
                    </asp:DropDownList>
                    <asp:DropDownList ID="drpAnneeExpiration" runat="server">
                    </asp:DropDownList>
                </div>
            </div>
            <div class="row">
                <div class="medium-2 columns">
                    <asp:Button ID="btnAnnuler" runat="server" Text="Annuler" Class="button"/>
                </div>
                <asp:Button ID="btnValider" runat="server" Text="Valider" OnClick="Button_valider_Click" Class="button"/>
            </div>
        </div>
    </form>
</body>
</html>
