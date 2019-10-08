<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="5.aspx.cs" Inherits="WebApplication1._5" %>

<%--<%@ Register TagPrefix="ibs" TagName="WebUserControl1" Src="~/new/WebUserControl1.ascx" %>--%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>3-5</title>
</head>
<body>
    <form id="form1" runat="server">
       <ibs:WebUserControl1 runat="server" Surname="Ikonov" Name="Bazil" Fathername="Sergeevich" Input="Otpravit" />
    </form>
</body>
</html>
