<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Flight.aspx.cs" Inherits="UIA.Flight" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<asp:Label id="labelFlights" runat="server" Text ="Flights" Font-Color ="Red" Font-Size="Medium" /> 
<asp:GridView ID="flightView" runat="server" AutoGenerateColumns="false" AllowPaging="true"
    OnPageIndexChanging="flightView_PageIndexChanging">
    <Columns> 
        <asp:BoundField ItemStyle-Width="150px" DataField="flightID" HeaderText="Flight ID" />
        <asp:BoundField ItemStyle-Width="150px" DataField="timeofDepature" HeaderText="Depature" />
        <asp:BoundField ItemStyle-Width="150px" DataField="timeofArrival" HeaderText="Arrival" />
        <asp:BoundField ItemStyle-Width="150px" DataField="destination" HeaderText="Destination" />
        <asp:BoundField ItemStyle-Width="150px" DataField="status" HeaderText="Status" />
    </Columns>    
</asp:GridView>


</asp:Content>

