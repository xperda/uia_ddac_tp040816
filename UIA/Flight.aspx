<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Flight.aspx.cs" Inherits="UIA.Flight" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<div class="jumbotron">
<p>
<asp:Label id="labelFlights" runat="server" Text ="Flights" ForeColor ="Red" Font-Size="Large" /> 
</p>
<asp:GridView ID="flightGrid" runat="server">
    <Columns> 
        <asp:BoundField ItemStyle-Width="150px" DataField="flightID" HeaderText="Flight ID" />
        <asp:BoundField ItemStyle-Width="150px" DataField="timeofDepature" HeaderText="Depature" />
        <asp:BoundField ItemStyle-Width="150px" DataField="timeofArrival" HeaderText="Arrival" />
        <asp:BoundField ItemStyle-Width="150px" DataField="destination" HeaderText="Destination" />
        <asp:BoundField ItemStyle-Width="150px" DataField="status" HeaderText="Status" />
    </Columns>    
</asp:GridView>
<asp:Button runat="server" ID="btnBack" Text="Back" OnClick="btnBack_Click" />
</div>


</asp:Content>

