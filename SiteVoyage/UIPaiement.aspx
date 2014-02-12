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
        <h3>Récapitulatif de la commande</h3>
        <table>
            <tr>
                <td>
                    Vols :
                </td>
                <td>
                    <asp:Label ID="label_recap_vol" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
                        <tr>
                <td>
                    Date de départ :
                </td>
                <td>
                    <asp:Label ID="label_recap_depart" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
                        <tr>
                <td>
                    Date d&#39;arrivée :
                </td>
                <td>
                    <asp:Label ID="label_recap_arrivee" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
                        <tr>
                <td>
                    Hôtel réservé :
                </td>
                <td>
                    <asp:Label ID="label_recap_hotel" runat="server" Text="Label"></asp:Label>
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

                    <asp:TextBox ID="TextBox_nom" runat="server"></asp:TextBox>

                </td>
            </tr>
                        <tr>
                <td>
                    Prénom :</td>
                <td>

                    <asp:TextBox ID="TextBox_prenom" runat="server"></asp:TextBox>

                </td>
            </tr>
                        <tr>
                <td>
                    Age :</td>
                <td>

                    <asp:TextBox ID="TextBox_age" runat="server"></asp:TextBox>

                </td>
            </tr>
                        
                        <tr>
                <td>
                    Nationalité :</td>
                <td>

                    <asp:TextBox ID="TextBox_nationalite" runat="server"></asp:TextBox>

                </td>
            </tr>
            
                        <tr>
                <td>
                    Ville :</td>
                <td>

                    <asp:TextBox ID="TextBox_ville" runat="server"></asp:TextBox>

                </td>
            </tr>
            
                        <tr>
                <td>
                    Code Postal :</td>
                <td>

                    <asp:TextBox ID="TextBox_cp" runat="server"></asp:TextBox>

                </td>
            </tr>

                        <tr>
                <td>
                    Adresse :</td>
                <td>

                    <asp:TextBox ID="TextBox_adresse" runat="server"></asp:TextBox>

                </td>
            </tr>

                        <tr>
                <td>
                    Téléphone :</td>
                <td>

                    <asp:TextBox ID="TextBox_telephone" runat="server"></asp:TextBox>
                    <asp:CompareValidator ID="cv" runat="server" ControlToValidate="TextBox_telephone" Type="Integer"
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

                    <asp:TextBox ID="TextBox_numCarte" runat="server"></asp:TextBox>
                     <asp:CompareValidator ID="Cv1" runat="server" ControlToValidate="TextBox_numCarte" Type="Integer"
   Operator="DataTypeCheck" ErrorMessage="Veuillez entrer un nombre !" />
                </td>
            </tr>
                        <tr>
                <td>
                    Cryptogramme :
                </td>
                <td>

                    <asp:TextBox ID="TextBox_cryptogramme" runat="server"></asp:TextBox>
                     <asp:CompareValidator ID="Cv2" runat="server" ControlToValidate="TextBox_cryptogramme" Type="Integer"
   Operator="DataTypeCheck" ErrorMessage="Veuillez entrer un nombre !" />
                </td>
            </tr>
                        <tr>
                <td>
                    Date d&#39;expiration :
                </td>
                <td>
                     <input id="expirationDate" type="date" value="2014-02-17"/>
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="Button_valider" runat="server" Text="Valider" OnClick="Button_valider_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button_annuler" runat="server" Text="Annuler" />
    
    </div>
    </form>
</body>
</html>
