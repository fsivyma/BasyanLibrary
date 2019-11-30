<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Author.aspx.cs" Inherits="BasyanLibrary.Author" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Author information</h1>
    <div>
        <asp:Label ID="LblAuthorName" runat="server" Text="Name"></asp:Label>
        <asp:Label ID="LblShowAuthorName" runat="server" Text=".."></asp:Label>
    </div>

    <div>
        <asp:Label ID="LblDOB" runat="server" Text="Date of Birth"></asp:Label>
        <asp:Label ID="LblShowDOB" runat="server" Text=".."></asp:Label>
    </div>

    <div>
        <asp:Label ID="LblCountry" runat="server" Text="Country of Origin"></asp:Label>
        <asp:Label ID="LblShowCountry" runat="server" Text=".."></asp:Label>
    </div>

    <div>
        <asp:Label ID="LblBookList" runat="server" Text="List of Books"></asp:Label>
        <asp:ListBox ID="LstBooks" runat="server"></asp:ListBox>
    </div>
</asp:Content>
