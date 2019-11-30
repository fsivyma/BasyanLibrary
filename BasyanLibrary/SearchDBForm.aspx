<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SearchDBForm.aspx.cs" Inherits="BasyanLibrary.SearchDBForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Search your book</h1>
    <div>
        <asp:Label ID="LblTitle" runat="server" Text="Book Title"></asp:Label>
        <asp:TextBox ID="TxtTitle" runat="server"></asp:TextBox>
    </div>

    <div>
        <asp:Label ID="LblName" runat="server" Text="Author Name"></asp:Label>
        <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
    </div>

    <div>
        <asp:Label ID="LblGenre" runat="server" Text="Genre"></asp:Label>
        <asp:TextBox ID="TxtGenre" runat="server"></asp:TextBox>
    </div>

    <asp:Button ID="BtnSearch" runat="server" Text="Search" />
</asp:Content>
