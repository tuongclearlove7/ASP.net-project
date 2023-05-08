<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bai6_gian_hang.aspx.cs" Inherits="webform_leaning1.gian_hang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Gian Hàng</h1>
            <div>
                <asp:LinkButton style="text-decoration:;" ID="link1" runat="server" OnClick="click_ao_quan">áo quần </asp:LinkButton>
            </div>

              <div>
                <asp:LinkButton ID="link2" runat="server"  OnClick="click_giay_dep">giày dép </asp:LinkButton>
            </div>

              <div>
                <asp:LinkButton ID="link3" runat="server" OnClick="click_tui_xach">túi_xách </asp:LinkButton>
            </div>

             <div>  
                <asp:Label ID="label_hienthi" runat="server" ></asp:Label>  
            </div>

        </div>
    </form>
</body>
</html>
