<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UIA._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Ukraine International Airlines</h1>
        <p class="lead">Ukraine International Airlines is the flagship carrier of Ukraine. We provide domestic and international flights and cargo services to Europe, Middle East and Asia.</p>
       <p>Join us now to start flying!</p>
        <p>
            
            <asp:Button runat="server" id="btnFlight" Text="Login" OnClick="btnLogin_Click" />
            <asp:Button runat="server" id="btnRegister" Text="Register" OnClick="btnRegister_Click" />

        </p>
    </div>


</asp:Content>
