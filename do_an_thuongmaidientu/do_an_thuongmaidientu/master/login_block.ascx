<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="login_block.ascx.cs" Inherits="do_an_thuongmaidientu.master.login_block" %>
<div><h1>Đăng nhập</h1></div>
 <div class="form-group">
    <div><asp:Label ID="Label1" runat="server" Text="Tên đăng nhập"></asp:Label></div>
    <div><asp:TextBox class="form-control" ID="tendangnhap" runat="server"></asp:TextBox></div>
     <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tendangnhap"
      ForeColor="Red"  ValidationExpression="^.{0,12}$" ErrorMessage="Vui lòng nhập không quá 12 ký tự !">
     </asp:RegularExpressionValidator>
    <div><asp:Label ID="Label2" runat="server" Text="Mật khẩu" ></asp:Label></div>
    <div><asp:TextBox class="form-control" ID="matkhau"  TextMode="Password" runat="server"></asp:TextBox></div>
     <asp:RegularExpressionValidator ID="revInput" runat="server" ControlToValidate="matkhau"
      ForeColor="Red"  ValidationExpression="^.{0,12}$" ErrorMessage="Vui lòng nhập không quá 12 ký tự !">
     </asp:RegularExpressionValidator>
    <br/>
    <div style="text-align:start;">
        <div><asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Đăng nhập" OnClick="kiemtra_dangnhap" /></div>
    </div>
     <div>
         <asp:Label ID="dangnhap_thanhcong" runat="server" Text=""></asp:Label>
     </div>
</div>