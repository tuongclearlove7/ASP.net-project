<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sinhvien.aspx.cs" Inherits="WebForm.sinhvien" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div style='float:left; width:30%;'>
            <asp:Image style="width:100%; height:350px;" ID ="image1" runat="server" ImageUrl="~/Content/image/hoa_hong.jpg" /> 
        </div>

        <div style='float:left;width:50%;margin-top:20px;padding:20px;'>
            <div>  
                <asp:Label ID="label_username" runat="server">Mã sinh viên</asp:Label>  
                <asp:TextBox ID="masv" runat="server" Text="masv"></asp:TextBox> 
            </div>
            <div>  
                <asp:Label ID="label1" runat="server">tên sinh viên</asp:Label>  
                <asp:TextBox ID="TextBox1" runat="server" Text="tên sinh viên"></asp:TextBox> 
            </div>
            <div>
                <asp:Label ID="label4" runat="server">Ngày sinh</asp:Label> 
                <asp:TextBox ID="date" runat="server" TextMode="Date"></asp:TextBox> 
            </div>

             <div>
                  <asp:RadioButtonList ID="RadioButtonList1" runat="server" Width="279px">
                  <asp:ListItem>C. Ronaldo</asp:ListItem>
                  <asp:ListItem>Kaka</asp:ListItem>
                  <asp:ListItem>T. Henry</asp:ListItem>
                  <asp:ListItem>S.Etoo’</asp:ListItem>
                </asp:RadioButtonList> 
            </div>
            <div  style='padding-top:10px;'>  
                <asp:Button style='width:100px;height:30px;' ID="Button3" runat="server" Text="Chọn" />  
                <asp:Button style='width:100px;height:30px;' ID="Button1" runat="server" Text="Hủy" />  
            </div> 
    
        </div>

    </form>
</body>
</html>
