<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Reservation.aspx.cs" Inherits="UIA.Reservation" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<div class="jumbotron">
<p>
<asp:Label id="labelFlights" runat="server" Text ="Available Flights to Reserve" ForeColor ="Red" Font-Size="Medium" /> 
</p>
<asp:GridView ID="reservationGrid" runat="server" AutoGenerateColumns="True" OnSelectedIndexChanged="reservationGrid_SelectedIndexChanged">
    <Columns> 
            <asp:CommandField HeaderText="Reserve" ShowSelectButton="True" />          
    </Columns>    
</asp:GridView>

<asp:Label runat="server" ID="labeldisplay" Visible="false" ForeColor="Red" />
<p>
    <asp:Button runat="server" ID="btnBack" Text="Back" OnClick="btnBack_Click" />
</p>

</div>


</asp:Content>

