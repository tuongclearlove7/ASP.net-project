<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gian_hang.aspx.cs" Inherits="WebForm.gian_hang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>      
            
            <div>
                <asp:LinkButton ID="link1" runat="server" OnClick="click_ao_quan">áo quần </asp:LinkButton>
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
