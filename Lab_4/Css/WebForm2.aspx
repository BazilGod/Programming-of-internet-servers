<%@ Page Language="C#" AutoEventWireup="true" Theme="Skin1" CodeBehind="WebForm2.aspx.cs" Inherits="Css.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <p>
            <asp:Label ID="Label1" runat="server" Text="Some text."></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button2" SkinID="AnotherButton" runat="server" Text="AnotherButton" />
        <asp:Button ID="Button3" EnableTheming="false" runat="server" Text="NoTheming" />
    </form>
</body>
</html>
