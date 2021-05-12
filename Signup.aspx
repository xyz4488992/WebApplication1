<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="WebApplication1.Signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <br /><br />
    <asp:Label ID="Label1" runat="server" style="font-size: large; font-weight: 700" Text="帳號:"></asp:Label>
    &nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    &nbsp;<asp:Label ID="Label3" runat="server" style="font-size: medium"></asp:Label>
    <br /><br />
    <asp:Label ID="Label2" runat="server" style="font-size: large; font-weight: 700" Text="密碼:"></asp:Label>
    &nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    &nbsp;<asp:Label ID="Label4" runat="server" style="font-size: medium"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label5" runat="server" style="font-size: large; font-weight: 700" Text="名稱:"></asp:Label>
    &nbsp;<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <br />
    <br />
    
    <asp:Button ID="Button1" runat="server" Text="送出" OnClick="Button1_Click" />
    &nbsp;
    <asp:Button ID="Button2" runat="server" Text="清除" OnClick="Button2_Click" />
    &nbsp;
    <asp:Button ID="Button3" runat="server" Text="去聊天室" OnClick="Button3_Click" />
    
    
    
    
</asp:Content>
