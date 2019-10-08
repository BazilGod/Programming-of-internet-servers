<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="WebApplication1.WebUserControl1" %>
 <div>
             <asp:Label runat="server">Фамилия</asp:Label>
             <asp:TextBox runat="server" ID="surname" /><br />
             <asp:Label runat="server">Имя</asp:Label>
             <asp:TextBox runat="server" ID="name" /><br />
             <asp:Label runat="server">Отчество</asp:Label>
             <asp:TextBox runat="server" ID="father_name" /><br />
             <asp:Label runat="server">День рождения</asp:Label>
             <asp:TextBox runat="server" ID="birthday" /><br />
             <asp:Label runat="server">Пол</asp:Label>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem Value="1" Text="мужской" />
                  <asp:ListItem Value="0" Text="Женский" />
            </asp:RadioButtonList>
            <br/ />
            <asp:Label runat="server">Факультет</asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>ФИТ</asp:ListItem>
                <asp:ListItem>ХТиТ</asp:ListItem>
                <asp:ListItem>ИЭФ</asp:ListItem>
            </asp:DropDownList><br/ /><br/ />
               <asp:Label runat="server">Группа</asp:Label>
            <asp:TextBox runat="server" ID="group" />
            <br />
            <asp:Label runat="server">Год поступления</asp:Label>
            <asp:TextBox runat="server" ID="year" />
            <asp:Button ID="input" runat="server" ValidationGroup="one" UseSubmitBehavior="False" /><br />
           <asp:Button ID="Button2" runat="server" Text="Отказаться" />

            <asp:RequiredFieldValidator ID="qqq" runat="server" enableclientscript="False" ErrorMessage="Введите фамилию" ControlToValidate="surname" ValidationGroup="one" Display="None" />
            <asp:RangeValidator ID="www" runat="server" enableclientscript="False" ErrorMessage="Номер группы должен быть 1-100" ControlToValidate="group" MinimumValue="1" MaximumValue="100" ValidationGroup="one" Type="Integer" Display="None" />

            <asp:ValidationSummary ValidationGroup="one" DisplayMode="BulletList" EnableClientScript="true" HeaderText="Ошиби обнаружены:" runat="server" />

        </div>