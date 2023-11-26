<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="P5.login" %>

<%@ Register src="WebUserControl1.ascx" tagname="WebUserControl1" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
       p.staffLogin {
           line-height: 2.0;
       }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div text-align: left align="center">
            <uc1:WebUserControl1 ID="WebUserControl11" runat="server" />
            <br />
            <p class="staffLogin" align="center">
                Welcome Staff Members!<br />
                <asp:Label ID="userNameLabel" runat="server" Text="Username: "></asp:Label> &nbsp
                <asp:TextBox ID="staffUsername" runat="server" Width="181px" BorderColor="Black" BorderWidth="1px" style="margin-left: 6px"></asp:TextBox>
                <br />
                <asp:Label ID="passwordLabel" runat="server" Text="Password: "></asp:Label> &nbsp
                <asp:TextBox ID="staffPassword" runat="server" Width="181px" BorderColor="Black" BorderWidth="1px" style="margin-left: 8px" TextMode="Password"></asp:TextBox>
                <br />                
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;                
                <asp:Button ID="loginButton" runat="server" Text="Log In" OnClick="bttn_Login_Click" />
                <br />
            </p>
            <asp:Label ID="errorLabelDisplay" runat="server" BorderColor="White" BorderWidth="4px"></asp:Label>
        </div>
    </form>
</body>
</html>