<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="View.aspx.cs" Inherits="UIA.View" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<div class ="jumbotron">
<asp:GridView ID="viewGrid" runat="server" DataKeyNames ="reservationID"
    OnRowDeleting="reservation_RowDeleting" >
    <Columns> 
        <asp:CommandField HeaderText="Cancel" ShowDeleteButton="True"/>
    </Columns>   
</asp:GridView>
    
<asp:Label runat="server" ID="labeldisplay" Visible="false" ForeColor="Red" />
<p>  
<asp:Button runat="server" ID="btnBack" Text="Back" OnClick="btnBack_Click" />
</p>     
</div>


</asp:Content>

