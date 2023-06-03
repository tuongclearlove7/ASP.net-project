<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="sua_mathang.aspx.cs" Inherits="webform_csdl.sua_mathang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <style>
        .form-control{
            width:500px;
        }
       .them-container {
            margin: 0 auto;
            max-width: 1280px;
            padding: 35px 20px;
        }
       
    </style>

<div class="them-container">
    <asp:DataList ID="DataList1"  runat="server">
        <ItemTemplate>
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="Mã hàng"></asp:Label>
                <asp:TextBox ID="mahang" CssClass="form-control" ReadOnly="true" runat="server" Text='<%# Eval("mahang") %>'></asp:TextBox>
            </div>
            <div class="form-group">
              <asp:Label ID="Label2" runat="server" Text="Tên loại"></asp:Label>
                <asp:TextBox ID="tenhang" CssClass="form-control" runat="server" Text='<%# Eval("tenhang") %>'></asp:TextBox>
            </div>
             <div class="form-group">
              <asp:Label ID="Label4" runat="server" Text="Mô tả"></asp:Label>
                <asp:TextBox ID="mota" CssClass="form-control" runat="server" Text='<%# Eval("mota") %>'></asp:TextBox>
             </div>
              <div class="form-group">
              <asp:Label ID="Label5" runat="server" Text="Đơn giá"></asp:Label>
                <asp:TextBox ID="dongia" CssClass="form-control" runat="server" Text='<%# Eval("dongia") %>'></asp:TextBox>
             </div>
            <div class="form-group">
              <asp:Label ID="Label6" runat="server" Text="Mã loại"></asp:Label>
                <asp:TextBox ID="maloai" CssClass="form-control" runat="server" Text='<%# Eval("maloai") %>'></asp:TextBox>
             </div>
             <div class="form-group">
              <asp:Label ID="Label3" runat="server" Text="Hình ảnh"></asp:Label>
                <asp:TextBox ID="hinh" CssClass="form-control" runat="server" Text='<%# Eval("hinh") %>'></asp:TextBox>
                <asp:FileUpload ID="FileUpload2" runat="server" />
             </div>
            <div>
                <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="Sửa" OnClick="sua" CommandArgument='<%# Container.ItemIndex %>' />
            </div>
        </ItemTemplate>
    </asp:DataList>
 </div>

































</asp:Content>
