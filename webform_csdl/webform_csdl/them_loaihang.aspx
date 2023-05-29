<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="them_loaihang.aspx.cs" Inherits="webform_csdl.them_loaihang" %>
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
         <div class="form-group">
        <asp:Label ID="Label1" runat="server" Text="Mã loại" ></asp:Label>
        <asp:TextBox ID="maloai" CssClass="form-control"  runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
          <asp:Label ID="Label2" runat="server" Text="Tên loại" ></asp:Label>
            <asp:TextBox ID="tenloai" CssClass="form-control"  runat="server"></asp:TextBox>
        </div>
         <div class="form-group">
          <asp:Label ID="Label3" runat="server" Text="Hình ảnh" ></asp:Label>
            <asp:TextBox ID="hinhanh" CssClass="form-control" runat="server"></asp:TextBox>
             <asp:FileUpload ID="FileUpload1" runat="server" />
        </div>
        <div>
            <asp:Button ID="Button1" CssClass="btn btn-primary" OnClick="them" runat="server" Text="Thêm" />
        </div>
    </div>
   

</asp:Content>
