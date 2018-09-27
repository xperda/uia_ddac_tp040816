<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Members.aspx.cs" Inherits="UIA.Members" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Ukraine International Airlines</h1>
        <p class="lead">Ukraine International Airlines is the flagship carrier of Ukraine. We provide domestic and international flights and cargo services to Europe, Middle East and Asia.</p>
        <asp:Label runat="server" ID ="lblusernamedisplay" Text=""/>
        <asp:Button runat="server" id="btnLogout" Text="Logout" OnClick="btnLogout_Click" />
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Make Flight Reservations</h2>
             <p>
                Make a flight reservation here.
            </p>
            <p>
                <asp:Button runat="server" id="btnReserve" Text="Reserve" OnClick="btnReserve_Click" />
            </p>
          
        </div>
        <div class="col-md-4">
            <h2>Manage Reservations</h2>
            <p>
                View and cancel your flight reservations.
            </p>
            <p>
                <asp:Button runat="server" id="btnView" Text="View" OnClick="btnView_Click" />
            </p>
           
        </div>
        <div class="col-md-4">
            <h2>Flight Schedule</h2>
             <p>
                Keep up to date on our flight schedules here.
            </p>
            <p>
                <asp:Button runat="server" id="btnFlight" Text="View" OnClick="btnFlight_Click" />
            </p>
        </div>
    </div>

</asp:Content>
