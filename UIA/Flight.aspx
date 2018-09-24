<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Flight.aspx.cs" Inherits="UIA.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
<asp:Content ID="flightTables" ContentPlaceHolderID="MainContent" runat="server"> 
    <!---Reference from https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions-1/models-data/displaying-a-table-of-database-data-cs --->
    <h2>Flights</h2>
    <table>
        <tr>
        <th></th>
        <!---Table Column descriptions--->
        <th>
            FlightID
        </th>
         <th>
           TimeofDepature
        </th>
         <th>
           TimeofArrival
        </th>
         <th>
            Destination
        </th>
        <th>
            Status
        </th>
    </table>

</asp:Content>
