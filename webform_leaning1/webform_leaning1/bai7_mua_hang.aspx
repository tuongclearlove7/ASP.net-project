<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bai7_mua_hang.aspx.cs" Inherits="webform_leaning1.mua_hang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <div>
                <asp:Label ID="label1" runat="server">Tên hàng</asp:Label>
                <asp:DropDownList ID="chon_hang" runat="server" >  
                    <asp:ListItem >Áo sơ mi tay dài</asp:ListItem>  
                    <asp:ListItem>áo sơ mi trắng</asp:ListItem>  
                    <asp:ListItem>áo sơ mi đen</asp:ListItem> 
                    <asp:ListItem>áo ngắn tay</asp:ListItem>   
                </asp:DropDownList>  
       
            </div>
             <div>
                 <asp:Label ID="label2" runat="server">Đơn giá</asp:Label>
                 <asp:TextBox ID="don_gia" runat="server" Text="" Height="16px" Width="179px"></asp:TextBox> 
            </div>
               <div>
                 <asp:Label ID="label3" runat="server">Số lượng</asp:Label>
                 <asp:TextBox ID="so_luong" runat="server" Text="" Height="16px" Width="179px"></asp:TextBox> 
            </div>
            <div>
                 <asp:Label ID="label4" runat="server">Đối tượng</asp:Label>
                  <asp:RadioButtonList ID="doi_tuong" runat="server" >
                          <asp:ListItem>Bình thường</asp:ListItem>
                          <asp:ListItem>Giảm giá</asp:ListItem>
                 </asp:RadioButtonList>
            </div>
            <div>
                 <asp:Button style='width:70px;height:20px; margin:2px;' ID="Button1" runat="server" Text="Mua" OnClick="mua" />
                  <asp:Button style='width:70px;height:20px; margin:2px;' ID="Button2" runat="server" Text="Xóa" OnClick="xoa" />
            </div>
              <div>
                <asp:Label ID="lbl_hienthi" runat="server" ></asp:Label>
            </div>

            
        </div>
    </form>
</body>
</html>
