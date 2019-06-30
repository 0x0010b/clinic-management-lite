<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Views_Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="lblMessageUser" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:Button ID="btnLogout" runat="server" Text="Button" OnClick="btnLogout_Click" />
</asp:Content>

