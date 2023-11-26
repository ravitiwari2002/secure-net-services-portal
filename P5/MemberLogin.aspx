<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberLogin.aspx.cs" Inherits="P5.MemberLogin" %>

<%@ Register src="WebUserControl1.ascx" tagname="WebUserControl1" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            height: 198px;
            width: 491px;
        }
        .auto-style8 {
            width: 457px;
        }
        .auto-style11 {
            width: 318px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center">
            <uc1:WebUserControl1 ID="WebUserControl11" runat="server" />
            <br />
        </div>
        <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate" Height="210px" Width="500px" align="center">
            <LayoutTemplate>
                <table cellpadding="1" cellspacing="0" style="border-collapse:collapse;" align="center">
                    <tr>
                        <td>
                            <table cellpadding="0" class="auto-style2">
                                <tr>
                                    <td align="center" colspan="2"><strong>
                                        <br />
                                        Please enter your login details below</strong></td>
                                </tr>
                                <tr align="center">
                                    <td align="right" class="auto-style11">
                                        <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">User Name:</asp:Label>
                                    </td>
                                    <td class="auto-style8">
                                        <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="User Name is required." ToolTip="User Name is required." ValidationGroup="Login1">*Invalid Username</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr align="center">
                                    <td align="right" class="auto-style11">
                                        <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Password:</asp:Label>
                                    </td>
                                    <td class="auto-style8">
                                        <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="Password is required." ToolTip="Password is required." ValidationGroup="Login1">*Invalid Password</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2" align="center">
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Log In" ValidationGroup="Login1" />
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
                                        &nbsp;&nbsp;
                                    </td>
                                </tr>
                                
                                
                            </table>
                        </td>
                    </tr>
                </table>
            </LayoutTemplate>
        </asp:Login>
        <p align="center">
            Not a member yet?</p>
        <p align="center">
            <asp:Button ID="Button1" runat="server" OnClick="memberSignup" Text="Become A Member" />
        </p>
    </form>
</body>
</html>
