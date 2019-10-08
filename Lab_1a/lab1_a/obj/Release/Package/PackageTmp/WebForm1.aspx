<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="lab1_a.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="StyleSheet1.css" type="text/css"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" Height="20" Width="100" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Height="30" Width="50" onclick="Button1_Click" Text="OK"/>
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Checkbox"/>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Enabled="true" Text="one" Value="1"></asp:ListItem>
                <asp:ListItem Text="two" Value="2"></asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
