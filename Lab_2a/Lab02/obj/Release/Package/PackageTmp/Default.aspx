<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab02._Default" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<!DOCTYPE HTML>
<html lang="en">
    <head >
        <title> мое приложение ASP.NET</title>
        <meta http-equiv="content-type" content="text/html" charset="utf-8" />
        <meta name="Access-Control-Allow-Origin" content="*" />
        <meta name="Access-Control-Allow-Headers" content="X-Requested-With" />
    </head>
        <body>    
            <script type="text/javascript">
                 function sum() {
            let oReq = new XMLHttpRequest();
            let x = document.getElementById("x").value;
            let y = document.getElementById("y").value;
            let data = new FormData();
            data.append('x', x);
            data.append('y', y);
            let sUrl = "http://localhost:8092/Lab02/test.maxik";
            oReq.open("POST", sUrl, true);
            oReq.send(data);
            oReq.onreadystatechange = function () {
                if (oReq.readyState == 4 && oReq.status == 200) {
                    document.getElementById("z").value = oReq.response;
                }
            }            
        }
            </script>
       <form id="form1" runat="server">
             <div>
                <asp:Button runat="server" ID="GetButton" Text="GetButton"  OnClick="GetButton_Click" /> <br />
                <asp:Button runat="server" ID="PostButton" Text="PostButton" OnClick="PostButton_Click" /> <br />
                <asp:Button runat="server" ID="PutButton" Text="PutButton"  OnClick="PutButton_Click" /> <br />
                <asp:Button runat="server" ID="ErrorButton" Text="Test" OnClick="ErrorButton_Click" /> <br>

                 <asp:TextBox runat ="server" ID="x" ClientIDMode="Static"></asp:TextBox>
                 <asp:TextBox runat ="server" ID="y" ClientIDMode="Static"></asp:TextBox>
                 <asp:TextBox runat ="server" ID="z" ReadOnly="true" ClientIDMode="Static"></asp:TextBox>                 
                 <input type="button" value="Посчитать" onclick="sum()" id="ButtonAjax" />

            </div>
           </form>
    </body>
</html>
    </asp:Content>