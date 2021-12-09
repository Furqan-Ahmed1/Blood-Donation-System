<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="appointment.aspx.cs" Inherits="Donation_Managment_System.appointment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 165px;
        }
        .auto-style2 {
            height: 1190px;
            width: 1189px;
        }
        .auto-style4 {
            width: 408px;
        }
        .auto-style5 {
            width: 398px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-image: url('https://nhsbtdbe.blob.core.windows.net/umbraco-assets-corp/14007/1819-427-winter-stock-build-2018-facebook-1200x630px3.jpg');" class="auto-style2">
        <br /><br /><br /><br /><br /><br />
        <div class="auto-style1">

            <table style="width:100%;">
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style4">
                        <asp:Label ID="appHeader" runat="server" Text="Appointment"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>

        </div>
        </div>
    </form>
</body>
</html>
