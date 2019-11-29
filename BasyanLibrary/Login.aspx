<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BasyanLibrary.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Login Page</h1>
    <div>
        <asp:Label ID="LblUserName" runat="server" Text="User Name"></asp:Label>
        <asp:TextBox ID="TxtUserName" runat="server"></asp:TextBox>
    </div>

    <div>
        <asp:Label ID="LblPassword" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="TxtPassword" runat="server" TextMode="Password"></asp:TextBox>
    </div>
    
    <div>
        <asp:Button ID="BtnLogin" runat="server" Text="Login" />
    </div>
</asp:Content>
