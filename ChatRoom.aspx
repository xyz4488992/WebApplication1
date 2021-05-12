<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChatRoom.aspx.cs" Inherits="WebApplication1.ChatRoom" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="number" runat="server" Text="目前線上人數"></asp:Label>
    <br />
    <asp:Label ID="name" runat="server" Text="你的名稱: "></asp:Label>
    <br />
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Label ID="Label3" runat="server" Text="顯示聊天內容"></asp:Label>
            <br />
            <asp:Label ID="chatResult" runat="server" BorderColor="Black" BorderStyle="Double" BorderWidth="2px"></asp:Label>
            <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="countTimer_Tick">
            </asp:Timer>
        </ContentTemplate>
    </asp:UpdatePanel>
    輸入<asp:Label ID="Label2" runat="server" Text="聊天內容"></asp:Label>
    <br />
    <asp:TextBox ID="inputText" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" BorderStyle="None" OnClick="sendBtn_Click" Text="送出" />
    <br />
    </asp:Content>
