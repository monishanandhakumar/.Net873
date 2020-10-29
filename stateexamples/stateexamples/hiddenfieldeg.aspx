<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hiddenfieldeg.aspx.cs" Inherits="stateexamples.hiddenfieldeg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="Label1" runat="server" Text="Country"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <div>
                <br />
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="Nationality"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

                <asp:HiddenField ID="HiddenField2" runat="server" />

                <br />

            </div>
            
            <div>
         <asp:Button ID="Button1" runat="server" Text="Store" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Load" OnClick="Button2_Click" />

            </div>
           
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>

        </div>
    </form>
</body>
</html>
