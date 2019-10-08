<%@ Page Language="C#" AutoEventWireup="true" Inherits="_Default" Codebehind="Default.aspx.cs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" OnAsyncPostBackError="ScriptManager1_AsyncPostBackError" runat="server" ></asp:ScriptManager>
     <script type="text/javascript">
   function pageLoad() {
                    var pageManager = Sys.WebForms.PageRequestManager.getInstance();
                    pageManager.add_endRequest(endRequest);
                }

                function endRequest(sender, args) {
                    if (args.get_error() != null) {
                        alert(args.get_error().message);
                        args.set_errorHandled(true);
                    }
                }
        function AbortPostBack() {
            alert("AbortPostBack");
           
            if (prm.get_isInAsyncPostBack()) {
                prm.abortPostBack();
            }
         }
       </script>
        <asp:UpdatePanel ID="UpdatePanel"  runat="server">
            <ContentTemplate>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="+" OnClick="Button1_Click"/>
                <asp:Timer ID="Timer1" runat="server" Interval="10000" ontick="Timer1_Tick"/>
                 
            </ContentTemplate>
           
         
        </asp:UpdatePanel><br />
        <asp:UpdatePanel ID="UpdatePanel1"  runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                <asp:Button ID="Button2" runat="server" Text="*" OnClick="Button2_Click" />
                   
                 <asp:CheckBox ID="CheckBox1" runat="server" />
        <asp:RadioButton ID="RadioButton1" runat="server" />
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </ContentTemplate>
             <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Button3" EventName="Click" />
            </Triggers>
          
        </asp:UpdatePanel>
        <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
            <ProgressTemplate>
                Servers Call ...
   <img src="1.gif  ">
                <input type="button" id="Button4" onclick="AbortPostBack()" value="Cancel" /> 
            </ProgressTemplate>
        </asp:UpdateProgress>
       <asp:Button ID="Button3" runat="server" Text="Button" OnClick="Button3_Click"/>
         
          <hr />
            <br />
            <h3>Таймер</h3>
            <asp:Timer ID="Timer2" runat="server" Interval="1000" OnTick="Timer2_Tick" />
            <asp:Timer ID="Timer3" runat="server" Interval="3000" OnTick="Timer3_Tick" />
            <asp:UpdatePanel ID="UpdatePanel5" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    Counter 1:
                    <asp:Label ID="Counter1Label" runat="server" Text="0" />
                    <br />
                    Counter 2:
                    <asp:Label ID="Counter2Label" runat="server" Text="0" />
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="Timer2" EventName="Tick" />
                    <asp:AsyncPostBackTrigger ControlID="Timer3" EventName="Tick" />
                </Triggers>
            </asp:UpdatePanel>
            <hr />
            <br />
    </form>
</body>
</html>
