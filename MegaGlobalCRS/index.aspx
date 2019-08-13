<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MegaGlobalCRS.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Global Media Customer Registeration</title>
    
</head>
<body style="text-align:center">
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" ImageUrl="/Resources/Company_Logo.png" runat="server" />
            <br />
            <br />
            <asp:Label runat="server" ID="nameLabel" AssociatedControlID="nameInput">First Name:</asp:Label>
            <asp:TextBox ID="nameInput" runat="server" />
            <br />
            <br />
            <asp:Label runat="server" ID="idLabel" AssociatedControlID="idInput">User ID:</asp:Label>
            <asp:TextBox ID="idInput" runat="server"/>
            <br />
            <br />
            <asp:Label runat="server" ID="passwordLabel" AssociatedControlID="passwordInput">Password:</asp:Label>
            <asp:TextBox ID="passwordInput" runat="server" TextMode="Password"/>
            <br />
            <br />
            <asp:Label runat="server" ID="confirmLabel" AssociatedControlID="confirmPassInput">Confirm Password:</asp:Label>
            <asp:TextBox ID="confirmPassInput" runat="server" TextMode="Password"/>
            <br />
            <br />
            <asp:Button ID="submitButton" Text="Register" runat="server" OnClick="registerButton_Click"/>
            <br />
            <asp:Label ID="registerStatus" runat="server" />
        </div>
    </form>
</body>
</html>
