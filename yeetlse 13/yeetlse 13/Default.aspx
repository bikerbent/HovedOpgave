    <%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="yeetlse_13._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td colspan="3">
                <asp:Label ID="UserNameLabel" runat="server">Brugernavn: </asp:Label>
            </td>
            <td colspan="3">
                <asp:TextBox runat="server" ID="UserNameTextBox"></asp:TextBox>
            </td>

        </tr>
        <tr>
            <td colspan="3">
                <asp:Label runat="server" ID="PasswordLabel">Password: </asp:Label>
            </td>
            <td colspan="3">
                <asp:TextBox runat="server" TextMode="Password" ID="PasswordTextBox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button runat="server" Text="Login" ID="LoginButton" OnClick="LoginButton_Click" />
            </td>
        </tr>
    </table>

</asp:Content>
