<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Member.aspx.cs" Inherits="P5.Member" %>

<%@ Register src="WebUserControl1.ascx" tagname="WebUserControl1" tagprefix="uc1" %>

<%@ Register src="WebUserControl2.ascx" tagname="WebUserControl2" tagprefix="uc2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
    <body>
        <form id="form1" runat="server">
            <h1 align="center">
                <asp:Label ID="Label20" runat="server"></asp:Label>
            </h1>
            <div align="center">
                <uc1:WebUserControl1 ID="WebUserControl11" runat="server" />
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" Text="Home Page" OnClick="Button1_Click" />
               
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               
                <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Log out" />
                <br />
                <br />
                <hr />
                <strong>
                <asp:Label ID="lbl_weatherTitle" runat="server" Text="5-Day Weather Forecast!" Font-Size="X-Large"></asp:Label>
                </strong>
                <br />
                <br />
                Enter Zip Code:&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                <br />
                <asp:Button ID="Button2" runat="server" Text="Get Weather Forecast" OnClick="Button2_Click" />
                <br />
                <br />
                <strong>Today&#39;s Weather</strong><br />
                <br />
                <asp:Label ID="Label5" runat="server"></asp:Label>
                <br />
                <br />
                <strong>Day 1 Forecast</strong><br />
                <br />
                <asp:Label ID="Label6" runat="server"></asp:Label>
                <br />
                <br />
                <strong>Day 2 Forecast</strong><br />
                <br />
                <asp:Label ID="Label7" runat="server"></asp:Label>
                <br />
                <br />
                <strong>Day 3 Forecast</strong><br />
                <br />
                <asp:Label ID="Label8" runat="server"></asp:Label>
                <br />
                <br />
                <strong>Day 4 Forecast</strong><br />
                <br />
                <asp:Label ID="Label9" runat="server"></asp:Label>
                <br />
                <br />
                <strong>Day 5 Forecast</strong><br />
                <br />
                <asp:Label ID="Label10" runat="server"></asp:Label>
                <br />
                <br />
            <br />
            </div>
            <hr />
            <div align="center">
                <strong>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Find Nearest Store" Font-Size="X-Large"></asp:Label>
                </strong>
                <br />
                <br />
                Enter Zip Code:&nbsp;
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                Enter Store Name:&nbsp
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <br />
                <asp:Button ID="Button3" runat="server" Text="Find Nearest Store" Width="142px" OnClick="Button3_Click" />
                <br />
                <br />
                <asp:Label ID="Label11" runat="server"></asp:Label>
                <br />
                <br />
                <br />
            </div>
            <hr />
            <div align="center">
                <strong>
                <asp:Label ID="Label3" runat="server" Text="Currency Converter" Font-Size="X-Large"></asp:Label>

                </strong>

                <br />
                <br />
                Please enter the amount to convert<br />
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                <br />
                <br />
                Please enter the Currency Codes<br />
                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp; -&gt;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button6" runat="server" OnClick="Button6_Click1" Text="Convert" />
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label21" runat="server"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <br />

            </div>
            <hr />
            <div style="font-weight: 700" align="center">
                
                <asp:Label ID="Label1" runat="server" Text="Encryption / Decryption" Font-Size="X-Large"></asp:Label>
                <br />
                <br />
                    Please enter a string to encrypt&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button7" runat="server" Text="Encrypt" Width="95px" OnClick="Button7_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                Encrypted String:
                <asp:Label ID="Label22" runat="server"></asp:Label>
                <br />
                <br />
                Please enter a string to decrypt&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button8" runat="server" Text="Decrypt" Width="95px" OnClick="Button8_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                Decrypted String:
                <asp:Label ID="Label23" runat="server"></asp:Label>
                <br />
                <br />
            </div>
            <hr />
            <div style="font-weight: 700" align="center">
                <asp:Label ID="Label4" runat="server" Text="Image Captcha Verifier" Font-Size="X-Large"></asp:Label>
                <br />
                <uc2:WebUserControl2 ID="WebUserControl21" runat="server" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" style="font-weight: 700" Text="Verify" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label24" runat="server" ForeColor="Red"></asp:Label>
&nbsp;</div>

            </form>

    </body>
</html>
