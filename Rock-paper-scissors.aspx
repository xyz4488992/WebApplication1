<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Rock-paper-scissors.aspx.cs" Inherits="WebApplication1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    
    <asp:Label ID="Label1" runat="server" Text="Label" style="font-size: xx-large"></asp:Label>
    <br />
    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Picture/paper.png" OnClick="button_click" />
    &nbsp;&nbsp;
    <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Picture/scissors.png" OnClick="button_click" />
    &nbsp;&nbsp;
    <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/Picture/stone.png" OnClick="button_click"  Enabled="True" />
    <br/>
    <asp:Label ID="Player" runat="server" Text="" style="font-size: x-large " ></asp:Label>
    <br/>
    <br/>
    <asp:Label ID="Result" runat="server" Text="" ForeColor="#FF3300" style="font-size: x-large"></asp:Label>
    <br/>
    <br />
    <asp:Label ID="Computer" runat="server" Text="" style="font-size: x-large"></asp:Label>
    <br/>
    <asp:Image ID="ComputerImage" runat="server" ImageUrl="~/Picture/paper.png" />
    
    
    <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick">
    </asp:Timer>
    
    
    
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
        </Triggers>
    </asp:UpdatePanel>
</asp:Content>
