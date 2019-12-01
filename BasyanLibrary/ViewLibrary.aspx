<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ViewLibrary.aspx.cs" Inherits="BasyanLibrary.ViewLibrary" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Welcome back</h1>
    <div>
        <h3>Book</h3>
    </div>

    <div>

        <asp:GridView ID="GridViewBookList" runat="server"></asp:GridView>
    </div>
</asp:Content>
