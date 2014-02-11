<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Paiement.aspx.cs" Inherits="SiteVoyage.Paiement" %>

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
       Vols :
        <asp:Label ID="label_recap_vol" runat="server" Text="Label"></asp:Label>
        <br />
        Date de départ
        :
        <asp:Label ID="label_recap_vol0" runat="server" Text="Label"></asp:Label>
        <br />
        Date d&#39;arrivée :
        <asp:Label ID="label_recap_vol1" runat="server" Text="Label"></asp:Label>
        <br />
        Hôtel réservé :
        <asp:Label ID="label_recap_vol2" runat="server" Text="Label"></asp:Label>
        <h2>Coordonnée de contact :</h2>
        <table>
            <tr>
                <td>
                    Nom :&nbsp;
                </td>
                <td>

                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

                </td>
            </tr>
                        <tr>
                <td>
                    Prénom :</td>
                <td>

                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

                </td>
            </tr>
                        <tr>
                <td>
                    Age :</td>
                <td>

                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

                </td>
            </tr>
                        
                        <tr>
                <td>
                    Nationalité :</td>
                <td>

                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>

                </td>
            </tr>
            
                        <tr>
                <td>
                    Ville :</td>
                <td>

                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>

                </td>
            </tr>
            
                        <tr>
                <td>
                    Code Postal :</td>
                <td>

                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>

                </td>
            </tr>

                        <tr>
                <td>
                    Adresse :</td>
                <td>

                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>

                </td>
            </tr>

                        <tr>
                <td>
                    Téléphone :</td>
                <td>

                    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>

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

                    <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>

                </td>
            </tr>
                        <tr>
                <td>
                    Cryptogramme :
                </td>
                <td>

                    <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>

                </td>
            </tr>
                        <tr>
                <td>
                    Date d&#39;expiration :
                </td>
                <td>

                    <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>

                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Valider" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Annuler" />
    
    </div>
    </form>
</body>
</html>
