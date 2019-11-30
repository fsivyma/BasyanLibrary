<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddAuthor.aspx.cs" Inherits="BasyanLibrary.Admin.AddAuthor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Add Author</h1>
    <div>
        <asp:Label ID="LblAddName" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="TxtAddName" runat="server"></asp:TextBox>
    </div>

    <div>
        <asp:Label ID="LblAddDOB" runat="server" Text="Date of Birth"></asp:Label>
        <asp:TextBox ID="TxtAddDOB" runat="server" TextMode="Date"></asp:TextBox>
    </div>

    <div>
        <asp:Label ID="LblAddCountry" runat="server" Text="Country"></asp:Label>
        <asp:TextBox ID="TxtAddCountry" runat="server"></asp:TextBox>
    </div>

    <asp:Button ID="BtnAddAuthor" runat="server" Text="Add Author" />
</asp:Content>
