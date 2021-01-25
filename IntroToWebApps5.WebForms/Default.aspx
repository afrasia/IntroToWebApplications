<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="IntroToWebApps5.WebForms.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>
    </head>
    <body>
        <h1>Hello World!</h1>
        This is a test of the emergency broadcast system.
        <form id="form1" runat="server">
            <h3>Simple Web Form</h3>
            <table>
                <tr>
                    <td>
                        First Name:
                    </td>
                    <td>
                        <asp:TextBox ID="firstNameTextBox" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        Last Name:
                    </td>
                    <td>
                        <asp:TextBox ID="lastNameTextBox" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>

                    </td>
                    <td>
                        <asp:Button ID="processDataButton" runat="server" Text="Process" OnClick="ProcessDataButton_Click" />
                    </td>
                </tr>
            </table>
            <h3>Output of Web Form</h3>
            <asp:Literal ID="outputLiteral" runat="server" />
        </form>
    </body>
</html>
