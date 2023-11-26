<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberSignUp.aspx.cs" Inherits="P5.MemberSignUp" %>

<%@ Register src="WebUserControl1.ascx" tagname="WebUserControl1" tagprefix="uc1" %>
<%@ Register src="WebUserControl2.ascx" tagname="WebUserControl2" tagprefix="uc2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 346px;
        }
        .auto-style2 {
            width: 168px;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">
        <div align="center">
            <uc1:WebUserControl1 ID="WebUserControl11" runat="server" />
&nbsp;<table align="center">
                                <tr>
                                    <td align="center" colspan="2"><strong>Sign up to become a member and gain access to our Road Trip Planner!<br />
                                        <br />
                                        </strong></td>
                                </tr>
                                <tr>
                                    <td align="right" class="auto-style2">
                                        <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Create User Name:</asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="User Name is required." ToolTip="User Name is required." ValidationGroup="CreateUserWizard1">*Please Enter Username</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" class="auto-style2">
                                        <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Create Password:</asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="Password is required." ToolTip="Password is required." ValidationGroup="CreateUserWizard1">*Please Enter Password</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" class="auto-style2">
                                        <asp:Label ID="ConfirmPasswordLabel" runat="server" AssociatedControlID="ConfirmPassword">Confirm Password:</asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="ConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="ConfirmPasswordRequired" runat="server" ControlToValidate="ConfirmPassword" ErrorMessage="Confirm Password is required." ToolTip="Confirm Password is required." ValidationGroup="CreateUserWizard1">*Please Enter Password</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center">
                                        &nbsp;<br />
                                        Enter captcha to validate<uc2:WebUserControl2 ID="WebUserControl21" runat="server" />
                                        <br />
                                    </td>
                                </tr>
                            </table>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Create Account" />
            <br />
            <asp:Label ID="error" runat="server" ForeColor="#CC0000" Visible="False"></asp:Label>
            <br />
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
