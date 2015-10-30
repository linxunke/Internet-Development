<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Translator.aspx.cs" Inherits="Translator.Translator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 103px;
        }
    </style>
</head>
<body style="height: 508px">
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Universal Translator:)" Font-Bold="True" Font-Size="Large" ForeColor="Black"></asp:Label>
        <p style="width: 1096px; height: 18px">
            <asp:TextBox ID="TextBox1" runat="server" Height="34px" TextMode="MultiLine" Width="105px"></asp:TextBox>
        </p>
        <p style="width: 1096px; height: 22px">
            <asp:Button ID="Button1" runat="server" style="margin-bottom: 0px" Text="Translate:)" />
        </p>
    </form>
</body>
</html>
