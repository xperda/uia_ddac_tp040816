﻿<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="View.aspx.cs" Inherits="UIA.View" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<div class ="jumbotron">
<asp:GridView ID="viewGrid" runat="server" AutoGenerateColumns="True" 
    OnRowDeleting="reservation_RowDeleting" >
    <Columns> 
        <asp:CommandField HeaderText="Cancel" ShowDeleteButton="True"/>
    </Columns>   
</asp:GridView>
</div>


</asp:Content>

