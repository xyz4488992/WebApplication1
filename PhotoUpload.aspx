<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PhotoUpload.aspx.cs" Inherits="WebApplication1.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:FileUpload ID="FileUpload1" runat="server" />

        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" UseSubmitBehavior="False" />
        <asp:Label ID="Message" runat="server" Text="______"></asp:Label>
        <br />
        <asp:Image ID="Image1" runat="server" />
    </div>
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" style="font-size: large"></asp:Label>
    <br />
    <br />
    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
    <br />
    <br />
    <asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton>

 
</asp:Content>


