<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UIPaiement.aspx.cs" Inherits="SiteVoyage.UIPaiement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <div align="center"><h1>Confirmation de commande</h1></div>

        <asp:Label ID="lblError" runat="server" EnableTheming="True" Font-Size="X-Large" ForeColor="Red" Visible="False"></asp:Label>

        <br />

        <h3>Récapitulatif de la commande</h3>
        <table>
            <tr>
                <td>
                    Vols :
                </td>
                <td>
                    <asp:Label ID="lblRecapVol" runat="server"></asp:Label>
                </td>
            </tr>
                        <tr>
                <td>
                    Date de départ :
                </td>
                <td>
                    <asp:Label ID="lblRecapDepart" runat="server"></asp:Label>
                </td>
            </tr>
                        <tr>
                <td>
                    Date d&#39;arrivée :
                </td>
                <td>
                    <asp:Label ID="lblRecapArrivee" runat="server"></asp:Label>
                </td>
            </tr>
                        <tr>
                <td>
                    Hôtel réservé :
                </td>
                <td>
                    <asp:Label ID="lblRecapHotel" runat="server"></asp:Label>
                </td>
            </tr>
        </table>        
    
        <h2>Coordonnée de contact :</h2>
        <table>
            <tr>
                <td>
                    Nom :&nbsp;
                </td>
                <td>

                    <asp:TextBox ID="txtNom" runat="server"></asp:TextBox>

                </td>
            </tr>
                        <tr>
                <td>
                    Prénom :</td>
                <td>

                    <asp:TextBox ID="txtPrenom" runat="server"></asp:TextBox>

                </td>
            </tr>
                        <tr>
                <td>
                    Age :</td>
                <td>

                    <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>

                </td>
            </tr>
                        
                        <tr>
                <td>
                    Nationalité :</td>
                <td>

                    <asp:TextBox ID="txtNationalite" runat="server"></asp:TextBox>

                </td>
            </tr>
            
                        <tr>
                <td>
                    Ville :</td>
                <td>

                    <asp:TextBox ID="txtVille" runat="server"></asp:TextBox>
                </td>
            </tr>
            
                        <tr>
                <td>
                    Code Postal :</td>
                <td>

                    <asp:TextBox ID="txtCp" runat="server"></asp:TextBox>

                </td>
            </tr>

                        <tr>
                <td>
                    Adresse :</td>
                <td>

                    <asp:TextBox ID="txtAdresse" runat="server"></asp:TextBox>

                </td>
            </tr>

                        <tr>
                <td>
                    Téléphone :</td>
                <td>

                    <asp:TextBox ID="txtTelephone" runat="server"></asp:TextBox>
                    <asp:CompareValidator ID="cv" runat="server" ControlToValidate="txtTelephone" Type="Integer"
   Operator="DataTypeCheck" ErrorMessage="Veuillez entrer un nombre !" />
                </td>
            </tr>

        </table>
        <br />
       <h2> Coordonnée bancaire :</h2>
        <table>
            <tr>
                <td>
                    Numéro carte :
                </td>
                <td>

                    <asp:TextBox ID="txtNumCarte" runat="server"></asp:TextBox>
                     <asp:CompareValidator ID="Cv1" runat="server" ControlToValidate="txtNumCarte" Type="Integer"
   Operator="DataTypeCheck" ErrorMessage="Veuillez entrer un nombre !" />
                </td>
            </tr>
                        <tr>
                <td>
                    Cryptogramme :
                </td>
                <td>

                    <asp:TextBox ID="txtCryptogramme" runat="server"></asp:TextBox>
                     <asp:CompareValidator ID="Cv2" runat="server" ControlToValidate="txtCryptogramme" Type="Integer"
   Operator="DataTypeCheck" ErrorMessage="Veuillez entrer un nombre !" />
                </td>
            </tr>
                        <tr>
                <td>
                    Date d&#39;expiration :
                </td>
                <td>
                     <asp:TextBox ID="txtDateExp" runat="server"></asp:TextBox>
                    <asp:CompareValidator ID="Cv3" runat="server" ControlToValidate="txtDateExp" Type="Date"
   Operator="DataTypeCheck" ErrorMessage="Veuillez entrer une date valide (dd/mm/yyyy) !" />
                </td>
                
            </tr>
        </table>
        <br />
        <asp:Button ID="btnValider" runat="server" Text="Valider" OnClick="Button_valider_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnAnnuler" runat="server" Text="Annuler" />
    
    </div>
    </form>
</body>
</html>
