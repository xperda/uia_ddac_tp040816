<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Login.aspx.cs" Inherits="UIA.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">   
    <div class ="jumbotron">
    <h2>Login</h2>
    <br/>
    <p>
    <asp:Label id="lblusername" runat="server" Text="Username: "/>
    <asp:TextBox id="tbloginusername" runat="server"/>
    </p>
    <p>
    <asp:Label runat="server" id ="lblvalidusername" Text="No such username exist." Visible="False" ForeColor="Red" />
    </p>
    <p>
    <asp:Label id="lblpassword" runat="server" Text="Password: " />
    <asp:TextBox id="tbloginpassword" runat="server" TextMode="Password" />
    </p>

    <p>
         <asp:Label runat="server" id ="lblvalidpassword" Text="Wrong password." Visible="False" ForeColor="Red" />
    </p>
    <p>
    <asp:Button runat="server" id="btnLogin" Text="Login" OnClick="btnLogin_Click" />
    </p>
    <p>
        <asp:Label runat="server" id ="loginvalid" Text="Wrong Credentials. Try again." Visible="False" ForeColor="Red" />
    </p>
    
    <p>
    <asp:Label runat="server" id ="lblregister" Text="No account? Register now." />
    </p>
    <p>
    <asp:Button runat="server" id="btnRegister" Text="Register" OnClick="btnRegister_Click" />
    </p>
    </div>
</asp:Content>
