<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SearchResult.aspx.cs" Inherits="BasyanLibrary.SearchResult" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Here are the result of your search</h1>
    <div>
        <asp:GridView ID="GridViewSearchResult" runat="server"></asp:GridView>
    </div>
</asp:Content>
