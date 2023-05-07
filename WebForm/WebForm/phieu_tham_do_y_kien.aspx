<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="phieu_tham_do_y_kien.aspx.cs" Inherits="WebForm.phieu_tham_do_y_kien" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      

        <div style='float:left;width:85%; margin-top:20px;padding:20px; height: 403px;'>
           <h1>Thăm dò ý kiến</h1>
            <div>  
                <asp:Label ID="label1" runat="server">Họ và tên</asp:Label>  
                <asp:TextBox ID="TextBox1" runat="server" Text="tên sinh viên" Height="16px" Width="179px"></asp:TextBox> 
                 <asp:RadioButtonList ID="RadioButtonList" runat="server" >
                      <asp:ListItem>Nam</asp:ListItem>
                      <asp:ListItem>Nữ</asp:ListItem>
                 </asp:RadioButtonList>
            </div>
           
            <p>Bạn dùng internet để làm gì?</p>
             <div>

                 <asp:CheckBoxList ID="CheckBoxList1" runat="server" Width="279px">
                      <asp:ListItem>Tin tức</asp:ListItem>
                      <asp:ListItem>Giải trí</asp:ListItem>
                      <asp:ListItem>Học tập</asp:ListItem>
                      <asp:ListItem>Mục đích khác</asp:ListItem>
                </asp:CheckBoxList> 

             </div>
            <div  style='padding-top:10px;'>  
                <asp:Button style='width:100px;height:30px;' ID="Button1" runat="server" Text="Chọn" />  
                <asp:Button style='width:100px;height:30px;' ID="Button2" runat="server" Text="Hủy" />  

            </div> 
    
        </div>




    </form>
</body>
</html>
