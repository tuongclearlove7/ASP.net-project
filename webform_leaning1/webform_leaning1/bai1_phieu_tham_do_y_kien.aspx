<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bai1_phieu_tham_do_y_kien.aspx.cs" Inherits="webform_leaning1.phieu_tham_do_y_kien" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <div style='float:left;width:85%; margin-top:20px;padding:20px; height: 403px;'>
               <h1>Thăm Dò Ý Kiến</h1>
                <div>  
                    <asp:Label ID="label1" runat="server">Họ và tên</asp:Label>  
                    <asp:TextBox ID="hoten" runat="server" Text="" Height="16px" Width="179px"></asp:TextBox> 
                     <asp:RadioButtonList ID="gioitinh" runat="server" >
                          <asp:ListItem>Nam</asp:ListItem>
                          <asp:ListItem>Nữ</asp:ListItem>
                     </asp:RadioButtonList>
                </div>
      
                <p>Bạn dùng internet để làm gì?</p>
                 <div>
                     <asp:CheckBoxList ID="checkbox" runat="server" Width="279px">
                          <asp:ListItem>Tin tức</asp:ListItem>
                          <asp:ListItem>Giải trí</asp:ListItem>
                          <asp:ListItem>Học tập</asp:ListItem>
                          <asp:ListItem>Mục đích khác</asp:ListItem>
                    </asp:CheckBoxList> 
                 </div>
                <div style='padding-top:10px;'>  
                    <asp:Button style='width:100px;height:30px;' ID="Button1" runat="server" Text="Chọn" OnClick="hien_thi"/>  
                    <asp:Button style='width:100px;height:30px;' ID="Button2" runat="server" Text="Hủy" OnClick="huy" />  
                </div> 
                <div style="padding-top:20px;">  
                   <asp:Label ID="label_hienthi" runat="server" ></asp:Label>  
                </div>
            </div>
        </div>
    </form>
</body>
</html>
