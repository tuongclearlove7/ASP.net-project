<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="capnhat.aspx.cs" Inherits="Trần_Thế_Tường_9157.capnhat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="label1" runat="server">Tên sản phẩm</asp:Label>  
            <asp:TextBox ID="tensp" runat="server" Text="" Height="16px" Width="179px"></asp:TextBox> 
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="tensp" Display="Dynamic" runat="server" ErrorMessage="Tên sản phẩm bắt buộc phải nhập"></asp:RequiredFieldValidator>
        </div>
         <div>
            <asp:Label ID="label2" runat="server">Đơn giá</asp:Label>  
            <asp:TextBox ID="don_gia" runat="server" Text="" Height="16px" Width="179px"></asp:TextBox> 
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="don_gia" Display="Dynamic" runat="server" ErrorMessage="đơn giá bắt buộc phải nhập và khác 0"></asp:RequiredFieldValidator>
        </div>
          <div style='padding-top:20px;'>  
                <asp:Label ID="label3" runat="server">số lượng</asp:Label>  
                <asp:TextBox ID="so_luong" runat="server" ToolTip="Email"></asp:TextBox> 
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="diem" Display="Dynamic" ErrorMessage="Số lượng là số nguyên dương trong khoảng từ 1 đến 10" MinimumValue ="1" MaximumValue ="10" Type="Integer">
                </asp:RangeValidator>
         </div>
          <asp:Button style='width:70px;height:20px;' ID="btn_tinhluong" runat="server" Text="cập nhật" OnClick="capnhat" />  
        <asp:Label ID="hienthi" runat="server"></asp:Label>  


    </form>
</body>
</html>
