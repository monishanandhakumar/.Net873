<%@ Page Language="C#" trace="true" AutoEventWireup="true" CodeBehind="sessioneg.aspx.cs" Inherits="stateexamples.sessioneg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

        </div>
        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Logout" OnClick="Button2_Click" />
        <asp:Button ID="Button3" runat="server" Text="Increment" OnClick="Button3_Click" />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
    </form>
</body>
</html>
