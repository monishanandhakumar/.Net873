<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewstateeg.aspx.cs" Inherits="stateexamples.viewstateeg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <div>
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

            </div>
            
            <div>
                <asp:Button ID="Button1" runat="server" Text="Store" OnClick="Button1_Click" />
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <asp:Button ID="Button2" runat="server" Text="Load" OnClick="Button2_Click" />
            </div>
            <div>
                  <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            </div>
          

        </div>
    </form>
</body>
</html>
