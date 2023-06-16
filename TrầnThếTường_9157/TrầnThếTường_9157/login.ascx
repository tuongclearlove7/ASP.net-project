<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="login.ascx.cs" Inherits="TrầnThếTường_9157.login" %>
<div><h1>Đăng nhập</h1></div>
 <div class="form-group">
    <div><asp:Label ID="Label1" runat="server" Text="Tên đăng nhập"></asp:Label></div>
    <div><asp:TextBox class="form-control" ID="tendangnhap" runat="server"></asp:TextBox></div>
    
    <div><asp:Label ID="Label2" runat="server" Text="Mật khẩu" ></asp:Label></div>
    <div><asp:TextBox class="form-control" ID="matkhau"  TextMode="Password" runat="server"></asp:TextBox></div>
    
    <br/>
    <div style="text-align:start;">
        <div><asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Đăng nhập"  /></div>
    </div>
     <div>
         <asp:Label ID="dangnhap_thanhcong" runat="server" Text=""></asp:Label>
     </div>
</div>