<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BBB.aspx.cs" Inherits="PIS_Lab_3B.BBB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Фамилия: 
            <asp:TextBox ID="TextBox1" runat="server" ValidationGroup="G1"></asp:TextBox>
            Имя:
            <asp:TextBox ID="TextBox2" runat="server" ValidationGroup="G1"></asp:TextBox>
            Отчество:
            <asp:TextBox ID="TextBox3" runat="server" ValidationGroup="G1"></asp:TextBox>
            <br />
            Дата Рождения:
            <asp:TextBox ID="TextBox4" runat="server" ValidationGroup="G1"></asp:TextBox>
            Текущая Дата:
            <asp:TextBox ID="TextBox5" runat="server" ValidationGroup="G1"></asp:TextBox>
            <br />
            Mail:
            <asp:TextBox ID="TextBox6" runat="server" ValidationGroup="G1"></asp:TextBox>
            <br />
            Сумма:
            <asp:TextBox ID="TextBox7" runat="server" ValidationGroup="G1"></asp:TextBox>
            Пароль:
            <asp:TextBox ID="TextBox8" TextMode="Password" runat="server" ValidationGroup="G1"></asp:TextBox>


            <asp:Button ID="Button1" runat="server" Text="Button" ValidationGroup="G1" />
            <br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage=" (Фамилия) Не верный формат (А-я)" ValidationGroup="G1" ControlToValidate="TextBox1" ValidationExpression="[а-яА-я]"></asp:RegularExpressionValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage=" (Имя) Не верный формат (А-я)" ValidationGroup="G1" ControlToValidate="TextBox1" ValidationExpression="[а-яА-я]"></asp:RegularExpressionValidator>
            <br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage=" (Отчество) Не верный формат (А-я)" ValidationGroup="G1" ControlToValidate="TextBox1" ValidationExpression="[а-яА-я]"></asp:RegularExpressionValidator>
            <br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ErrorMessage="Не коректный Email" ValidationGroup="G1" ControlToValidate="TextBox6" ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"></asp:RegularExpressionValidator>
            <br />
            <asp:CompareValidator ID="CompareValidator1" runat="server"  ErrorMessage="CompareValidator"  ValidationGroup="G1" Text="Дата больше чем текущая" Type="Date" ControlToCompare="TextBox4" ControlToValidate="TextBox5" Operator="GreaterThan"></asp:CompareValidator>
            <br />
            <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="RangeValidator" ValidationGroup="G1" Text="Сумма в пределах (1000,2000)" ControlToValidate="TextBox7" MinimumValue="1000" MaximumValue="2000" Type="Integer"></asp:RangeValidator>
            <br />
            <asp:RequiredFieldValidator runat="server" Display="None" ErrorMessage="Ошибка в пароле" ValidationGroup="G1" ControlToValidate="TextBox8"></asp:RequiredFieldValidator>
            <asp:CustomValidator runat="server" Display="None" ErrorMessage="Ошибка в пароле" ValidationGroup="G1" ControlToValidate="TextBox8" OnServerValidate="OnServerValidate"></asp:CustomValidator>
            <br />
            <asp:ValidationSummary ValidationGroup="G1" ID="ValidationSummary1" runat="server"  />
        </div>
    </form>
</body>
</html>
