<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Book.aspx.cs" Inherits="BasyanLibrary.Book" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Book detail</h1>
    <div>
        <asp:Label ID="LblBookTitle" runat="server" Text="Title:"></asp:Label>
        <asp:Label ID="LblShowTitle" runat="server" Text="..."></asp:Label>
    </div>

    <div>
        <asp:Label ID="LblAuthor" runat="server" Text="Author:"></asp:Label>
        <asp:Label ID="LblShowAuthor" runat="server" Text="..."></asp:Label>
    </div>

    <div>
        <asp:Label ID="LblGenre" runat="server" Text="Genre:"></asp:Label>
        <asp:Label ID="LblShowGenre" runat="server" Text="..."></asp:Label>
    </div>

    <div>
        <asp:Label ID="LblYear" runat="server" Text="Year Publised:"></asp:Label>
        <asp:Label ID="LblShowYear" runat="server" Text="..."></asp:Label>
    </div>

    <div>
        <asp:Label ID="LblPageCount" runat="server" Text="Current Page count:"></asp:Label>
        <asp:Label ID="LblShowPageCount" runat="server" Text="..."></asp:Label>
    </div>
</asp:Content>
