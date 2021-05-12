<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="logintest.aspx.cs" Inherits="WebApplication1.logintest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </br>
            <asp:Label ID="Label1" runat="server" style="font-size: large" Text="帳號: (左:form 右:TextBox) "></asp:Label>
            <input type="text" id="user" name="user2"/>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </br>
            
            <asp:Label ID="Label2" runat="server" style="font-size: large" Text="密碼: (左:form 右:TextBox) "></asp:Label>
            <input type="text" id="passwd" name="passwd2"/>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </br>
            
            <input type="submit" value="Submit"/>
        </div>
    </form>
</body>
</html>
