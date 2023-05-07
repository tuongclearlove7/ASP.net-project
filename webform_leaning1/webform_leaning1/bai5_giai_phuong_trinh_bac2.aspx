<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bai5_giai_phuong_trinh_bac2.aspx.cs" Inherits="webform_leaning1.bai5_giai_phuong_trinh_bac2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h1>Giải Phương Trình Bậc Hai (AX^2 + BX + C = 0)</h1>
            <hr/>
            <div>
                 <asp:Label ID="label1" runat="server" style="margin-right:8px;">Hệ số A</asp:Label>  
                 <asp:TextBox ID="he_so_a" runat="server" ToolTip="UserName"></asp:TextBox> 
             </div>
            <div style='padding-top:20px;'>  
                 <asp:Label ID="label2" runat="server" style='margin-right:8px;' >Hệ số B</asp:Label>  
                 <asp:TextBox ID="he_so_b" runat="server" ToolTip="UserName"></asp:TextBox> 
             </div>
            <div style='padding-top:20px;'>  
                 <asp:Label ID="label3" runat="server" style='margin-right:8px;' >Hệ số C</asp:Label>  
                 <asp:TextBox ID="he_so_c" runat="server" ToolTip="UserName"></asp:TextBox> 
                 <asp:Button style='width:70px;height:20px; margin:2px;' ID="Button1" runat="server" Text="Giải" OnClick="giaiPhuongtrinh" /> 
             </div>
       
             <div style="padding-top: 20px;">  
                <asp:Label ID="label_hienthi" runat="server" ></asp:Label>  
            </div>

        </div>
    </form>
</body>
</html>
