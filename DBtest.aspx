<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DBtest.aspx.cs" Inherits="WebApplication1.DBtest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
<br />
<br />
<asp:Label ID="Label1" runat="server" style="font-size: x-large" Text="Label"></asp:Label>
    <br />
    帳號<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    密碼<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
</asp:Content>
