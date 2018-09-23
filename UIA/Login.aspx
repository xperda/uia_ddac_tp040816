<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UIA.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Login</h2>
    <p>
        <asp:Label ID="Label_Message" runat="server" Font-Size="Medium" />
    <br />

    <asp:Label ID="lblusername" runat="server" Text="Username: "/>

    <asp:TextBox ID="tbloginusername" runat="server"/>
    </p>

    <p>
    <asp:Label ID="lblpassword" runat="server" Text="Password: " />
    <asp:TextBox ID="tbloginpassword" runat="server" TextMode="Password" />
    </p>
    <p>

    <asp:Button ID="btnLogin" runat="server" onclick="btnLogin_Click" Text="Login"/>
</p>
</asp:Content>
