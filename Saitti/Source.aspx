<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Source.aspx.cs" Inherits="Source" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Source -sivu</h1>
        <p>Lähetettävä viesti: <asp:TextBox ID="txtMessage" runat="server" />
            <br />
            <asp:DropDownList ID="ddlMessages" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlMessages_SelectedIndexChanged"></asp:DropDownList>
            <br/>
            <!-- vaihtoehto 1: Query String -->
            <asp:Button ID="btnQueryString" runat="server" Text="Käytä QueryString" OnClick="btnQueryString_Click" />
            <br />
            <!-- vaihtoehto 2: Http post -->
            <asp:Button ID="btnHttpPost" runat="server" Text="Käytä HttpPost" OnClick="btnHttpPost_Click" PostBackUrl="~/Tapa2.aspx" />
            <br />
            <!-- vaihtoehto 3: Session -->
            <asp:Button ID="btnSession" runat="server" Text="Käytä session" OnClick="btnSession_Click" />
            <br />
            <!-- vaihtoehto 4: Cookie -->
            <asp:Button ID="btnCookie" runat="server" Text="Käytä cookieta" OnClick="btnCookie_Click" />
            <br />
            <!-- vaihtoehto 5: Public Property -->
            <asp:Button ID="btnProperty" runat="server" Text="Käytä Public Propertya" OnClick="btnProperty_Click" />
        </p>
    </div>
    </form>
</body>
</html>
