<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="login.ascx.cs" Inherits="webform_csdl.login1" %>
<br/>
<br/>

<div style="max-width:900px;margin:0 auto;">
    <div><h1>Đăng nhập</h1></div>
    <div class="form-group">
        <div><asp:Label ID="Label1" runat="server" Text="User name"></asp:Label></div>
        <div><asp:TextBox class="form-control" ID="TextBox1" runat="server"></asp:TextBox></div>
        <div><asp:Label ID="Label2" runat="server" Text="Password"></asp:Label></div>
        <div><asp:TextBox class="form-control" ID="TextBox2" runat="server"></asp:TextBox></div>
        <br/>
        <div style="text-align:start;">
             <div><asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Đăng nhập" /></div>
        </div>
      
    </div>
</div>






























