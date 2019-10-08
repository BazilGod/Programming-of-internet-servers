<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AAA.aspx.cs" Inherits="PIS_Lab_3B.AAA" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script type="text/javascript">
        function ValidFun(c, args) {
            console.log(c);
            console.log(args);
            debugger;
            args.IsValid = true;
            for (var i = 2; i < (args.Value); i++) {
                if ((int.Parse(args.Value) % i == 0) && (args.Value) != 1 && (args.Value) != 1) {
                    args.IsValid = false;
                    break;
                }
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" ValidationGroup="G1"></asp:TextBox>
            <asp:DropDownList ID="DropDownList1" runat="server" ValidationGroup="G1">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem>1</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="Button1" runat="server" Text="Button" ValidationGroup="G1" OnClick="Button1_Click" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ForeColor="Red"  ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox1" Text="TextBox1 Пустой" ValidationGroup="G1"></asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ForeColor="Red" ErrorMessage="RequiredFieldValidator" ControlToValidate="DropDownList1" Text="DropDownList1 Пустой" ValidationGroup="G1"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="TextBox2" runat="server" ValidationGroup="G2"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server" ValidationGroup="G2"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" Text="Button" ValidationGroup="G2" />
            <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="RangeValidator" ValidationGroup="G2" ControlToValidate="TextBox2" Text="Поле TextBox2 неверный диапазон (100,200)" Type="Integer" MinimumValue="100" MaximumValue="200"></asp:RangeValidator>
            <asp:RangeValidator ID="RangeValidator2" runat="server" ErrorMessage="RangeValidator" ValidationGroup="G2" ControlToValidate="TextBox3" Text="Поле TextBox3 неверный диапазон (01.01.2011, 31.12.2011)" Type="Date" MinimumValue="01.01.2011" MaximumValue="31.12.2011"></asp:RangeValidator>
            <br />
            <asp:TextBox ID="TextBox4" runat="server" ValidationGroup="G3"></asp:TextBox>
            <asp:TextBox ID="TextBox5" runat="server" ValidationGroup="G3"></asp:TextBox>
            <asp:Button ID="Button3" runat="server" Text="Button" ValidationGroup="G3" />
            <asp:CompareValidator ID="CompareValidator1" runat="server" ValidationGroup="G3" ErrorMessage="CompareValidator" Text="TextBox4 не меньше чем TextBox5" Type="Date" ControlToValidate="TextBox5" ControlToCompare="TextBox4" Operator="GreaterThan"></asp:CompareValidator>
            <br />
            <asp:TextBox ID="TextBox6" runat="server" ValidationGroup="G4"></asp:TextBox>
            <asp:Button ID="Button4" runat="server" Text="Button" ValidationGroup="G4" />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ValidationGroup="G4" ErrorMessage="Некорректный Email" ControlToValidate="TextBox6" ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"></asp:RegularExpressionValidator>
            <br />
            <asp:TextBox ID="TextBox7" runat="server" ValidationGroup="G5"></asp:TextBox>
            <asp:Button ID="Button5" runat="server" ValidationGroup="G5" Text="Button" />
            <asp:CustomValidator ID="CustomValidator1" runat="server" ValidationGroup="G5" Text="Не простое число" ErrorMessage="CustomValidator" ControlToValidate="TextBox7" ClientValidationFunction="ValidFun" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
       <img src ="1.jpg" border="5" style="position:absolute; top:100px; right:20px">
            </div>
    </form>
</body>
</html>
