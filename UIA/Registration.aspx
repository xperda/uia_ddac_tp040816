<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Registration.aspx.cs" Inherits="UIA.Registration" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Register A New User Account</h2>
    <p>
    <asp:Label ID="Label1" runat="server" Text="Username: "/>
    <asp:TextBox ID="tbusername" runat="server" />
    </p>
    <p>
    <asp:Label ID="Label2" runat="server" Text="Password: "/>
    <asp:TextBox ID="tbpassword" runat="server" TextMode="Password" />
    </p>
    <p>
    <asp:Label ID="Label3" runat="server" Text="FullName: "/>
    <asp:TextBox ID="tbfullname" runat="server" />
    </p>
    <p>
    <asp:Label ID="Label4" runat="server" Text="Passport: "/>
    <asp:TextBox ID="tbpassport" runat="server" />
    </p>
  
    <p>
        <asp:Button ID="btnRegister" runat="server" onclick="btnRegister_Click" Text="Register" />
    </p>
    <p>
        <asp:Label ID="Label5" runat="server" Visible= "False" ForeColor="Red" Text="Some fields are empty.Please input your details."/>
    </p>
</asp:Content>
