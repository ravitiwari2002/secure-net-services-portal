<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="P5.Default" %>

<%@ Register src="WebUserControl1.ascx" tagname="WebUserControl1" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    <form id="form1" runat="server" align="center">
        <uc1:WebUserControl1 ID="WebUserControl11" runat="server" />
        <div align="center">
            <h1>Road Trip Planner</h1>
        </div>
        <div align="center">
            <p>This Road Trip Planner helps you gather the necesssary information to help plan the perfect road trip. </p>
            <p>With the help of this road trip planner, you will be able to find the next 5 day weather forecast for any location, the nearest store for any location, and&nbsp; currency exchange rates.</p>
            <p>&nbsp;</p>
            <hr />
            <p>&nbsp;</p>
            <h1>Member Exclusive Services</h1>
        </div>
        <div align="center">
            <table style="width:50%">
                <tr style='font-size:150%'>
                    <th>Weather Service</th>
                    <th>Nearest Store</th>
                    <th>Currency Converter</th>
                </tr>
                <tr>
                    <td>This service returns the 5 day weather report of the entered zip code.</td>
                    <td>This service shows the nearest store for the entered zip code and store name by the user.</td>
                    <td>This service returns converted currency for the entered currency amount and currency codes.</td>
                </tr>
</table>
            <p>&nbsp;</p>
            <hr />
            <p>&nbsp;</p>
            <p>Already a member or want to sign up? Click here -&gt;
        <asp:Button ID="Button1" runat="server" OnClick="memberButtonClick" Text="Member Page" />
            </p>
            <p>&nbsp;Are you a staff member? Click here -&gt;
        <asp:Button ID="Button2" runat="server" OnClick="staffButtonClick" Text="Staff Page" Width="89px" />
            </p>
            <p>&nbsp;</p>
        </div>
        <div align="center">
            <p><a href="http://webstrar17.fulton.asu.edu/SummaryTable.html"> Application and Components Summary Table </a></p>
            <p>&nbsp;</p>
            <p>Created by: Ravi Tiwari, Thinh Pham, Nash Carlow</p>
        </div>
    </form>
</body>
</html>

