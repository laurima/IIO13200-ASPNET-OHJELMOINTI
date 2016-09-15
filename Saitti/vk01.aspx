﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="vk01.aspx.cs" Inherits="vk01" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>IIO13200 VKtehtävä 01</title>
    
    <link href="http://www.w3schools.com/lib/w3.css" rel="stylesheet" type="text/css" />
    
</head>
<body>
    <form id="form1" runat="server">
    <div class="w3-container w3-light-green">
        <h2>Ikkunan dimensiot</h2>
        <table>
            <tr>
                <td>Leveys (L)</td>
                <td><asp:TextBox ID="txtLeveys" runat="server"></asp:TextBox></td>
                <td>mm</td>
            </tr>
            <tr>
                <td>Korkeus (H)</td>
                <td><asp:TextBox ID="txtKorkeus" runat="server"></asp:TextBox></td>
                <td>mm</td>
            </tr>
            <tr>
                <td>Karmin leveys (W)</td>
                <td><asp:TextBox ID="txtKarminLeveys" runat="server"></asp:TextBox></td>
                <td>mm</td>
            </tr>
        </table>
        <asp:Button class="w3-btn w3-blue" ID="btnLaske" runat="server" Text="Laske tarjoushinta" OnClick="btnLaske_Click"/>
        <table>
            <tr>
                <td>Ikkunan pinta-ala</td>
                <td><asp:Label ID="lblPintaala" runat="server"></asp:Label></td>
                <td>m2</td>
            </tr>
            <tr>
                <td>Karmin piiri</td>
                <td><asp:Label ID="lblKarminPiiri" runat="server"></asp:Label></td>
                <td>m</td>
            </tr>
            <tr>
                <td>Tarjoushinta (ilman ALV)</td>
                <td><asp:Label ID="lblHinta" runat="server"></asp:Label></td>
                <td></td>
            </tr>
        </table>
    </div>
        <!-- Ilmoitukset käyttäjälle -->
        <div id="footer">
            <asp:Label ID="lblMessages" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
