<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Flight.aspx.cs" Inherits="UIA.Flight" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<asp:GridView 
    ID="flightView" 
    runat="server"
    AutoGenerateColumns="True" 
    OnSelectedIndexChanged="grdView_SelectedIndexChanged">
</asp:GridView>



</asp:Content>

