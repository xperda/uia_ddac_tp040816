<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Reservation.aspx.cs" Inherits="UIA.Reservation" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<div class="jumbotron">
<p>
<asp:Label id="labelFlights" runat="server" Text ="Flights" Font-Color ="Red" Font-Size="Medium" /> 
</p>
<asp:GridView ID="reservationGrid" runat="server" DataKeyNames="RID"    
OnRowDeleting="reservationGrid_RowDeleting">
    <Columns> 
        <asp:TemplateField>
        <ItemTemplate>
            <asp:LinkButton runat = "server" id="lnkReserve" text ="Reserve"  OnClick="lnkReserve_Click" />
             </ItemTemplate>
        </asp:TemplateField>
        <asp:BoundField ItemStyle-Width="150px" DataField="flightID" HeaderText="Flight ID" />
        <asp:BoundField ItemStyle-Width="150px" DataField="timeofDepature" HeaderText="Depature" />
        <asp:BoundField ItemStyle-Width="150px" DataField="timeofArrival" HeaderText="Arrival" />
        <asp:BoundField ItemStyle-Width="150px" DataField="destination" HeaderText="Destination" />
        <asp:BoundField ItemStyle-Width="150px" DataField="status" HeaderText="Status" />     
    </Columns>    
</asp:GridView>
</div>


</asp:Content>

