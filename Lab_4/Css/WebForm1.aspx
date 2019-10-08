<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Css.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="Styles.css"> 
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Button ID="Button1" runat="server"   Text="Button" />
        <p>
            <asp:Label ID="Label1" runat="server"  Text="Some text."></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" CssClass="button" Text="Button" />
        </p>
        <asp:Label ID="Label2" runat="server"  CssClass="text" Text="Another text."></asp:Label>
    </form>
</body>
</html>
