<%@ Page Title="" Language="C#" MasterPageFile="~/master/admin.Master" AutoEventWireup="true" CodeBehind="them.aspx.cs" Inherits="do_an_thuongmaidientu.admin.them" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <style>
        .form-control{
            width:500px;
        }
       .them-container {

            max-width:100%;
            margin:0px 30px auto;
        }
       .themthanhcong{
           color:greenyellow;
           padding-top:15px;
       }
    </style>
    
    <div class="them-container">
         <div class="form-group">
        <asp:Label ID="Label1" runat="server" Text="Mã loại" ></asp:Label>
        <asp:TextBox ID="maloai_loaihang" CssClass="form-control"  runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
          <asp:Label ID="Label2" runat="server" Text="Tên loại" ></asp:Label>
            <asp:TextBox ID="tenloai" CssClass="form-control"  runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="Button1" CssClass="btn btn-primary" OnClick="themmoi_loaihang" runat="server" Text="Thêm" />
        </div>
    </div>
    <br/>
    <br/>
     <div class="them-container">
         <div class="form-group">
        <asp:Label ID="Label4" runat="server" Text="Mã hàng" ></asp:Label>
        <asp:TextBox ID="mahang" CssClass="form-control"  runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
          <asp:Label ID="Label5" runat="server" Text="Tên hàng" ></asp:Label>
            <asp:TextBox ID="tenhang" CssClass="form-control"  runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
          <asp:Label ID="Label7" runat="server" Text="Mô tả" ></asp:Label>
            <asp:TextBox ID="mota" CssClass="form-control"  runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
          <asp:Label ID="Label8" runat="server" Text="Đơn giá" ></asp:Label>
            <asp:TextBox ID="dongia" CssClass="form-control"  runat="server"></asp:TextBox>
        </div>
         <div class="form-group">
          <asp:Label ID="Label9" runat="server" Text="maloai" ></asp:Label>
            <asp:TextBox ID="maloai_mathang" CssClass="form-control"  runat="server"></asp:TextBox>
        </div>
         <div class="form-group">
          <asp:Label ID="Label6" runat="server" Text="Hình ảnh" ></asp:Label>
            <asp:TextBox ID="hinh_mathang" CssClass="form-control" runat="server"></asp:TextBox>
             <asp:FileUpload ID="FileUpload2" runat="server" />
        </div>
        <div>
            <asp:Button ID="Button2" CssClass="btn btn-primary" OnClick="themmoi_mathang" runat="server" Text="Thêm" />
        </div>
         <div>
             <asp:Label ID="themmoi_thanhcong" CssClass="themthanhcong" runat="server" Text=""></asp:Label>
        </div>
    </div>
     

</asp:Content>
