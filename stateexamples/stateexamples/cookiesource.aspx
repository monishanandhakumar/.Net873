<%@ Page Language="C#" AutoEventWireup="true"  CodeBehind="cookiesource.aspx.cs" Inherits="stateexamples.cookiesource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Employee Id">
                </asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
          </div>
        <div>
            <br/>
            <asp:Label ID="Label2" runat="server" Text="Employee Department"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:HiddenField ID="HiddenField1" runat="server" Value="3000" />
        </div>
        <div>
            <br/>
            <asp:Button ID="Button1" runat="server" Text="Redirect" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
