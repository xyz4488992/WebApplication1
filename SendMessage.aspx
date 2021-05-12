<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SendMessage.aspx.cs" Inherits="WebApplication1.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:TextBox ID="TxtName" runat="server" name="TxtName"></asp:TextBox>
    <br />
    <asp:TextBox ID="TxtEmail" runat="server" name="TxtEMail"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Button"  value ="submit" OnClick="Button1_Click"/>
</asp:Content>
