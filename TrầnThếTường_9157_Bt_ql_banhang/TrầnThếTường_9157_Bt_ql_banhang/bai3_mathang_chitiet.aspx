<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="bai3_mathang_chitiet.aspx.cs" Inherits="TrầnThếTường_9157_Bt_ql_banhang.bai3_mathang_chitiet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div>
        <h1>Chi tiết mặt hàng</h1>
    </div>
     <asp:DataList ID="ds_mathang" runat="server">
        <ItemTemplate>
            <asp:ImageButton ID="ImageButton1" PostBackUrl="bai3_mathang_chitiet.aspx" CssClass="card-img-top" runat="server" ImageUrl='<%# Eval("hinh") %>' />
            <div>
                <asp:Label ID="Label1" runat="server" Text='<%# "Tên hàng : "+Eval("tenhang") %>'></asp:Label>
            </div>
            <div>
                <asp:Label ID="Label2" runat="server" Text='<%# "Mô tả : "+Eval("mota") %>'></asp:Label>
            </div>
              <div>
                <asp:Label ID="Label3" runat="server" Text='<%# "Đơn giá : "+Eval("dongia") %>'></asp:Label>
            </div>
             <div>
                 <asp:Label ID="Label4" runat="server" >Số lượng</asp:Label>
                 <asp:TextBox ID="soluong" runat="server" >
                 </asp:TextBox>
            </div>
            <div>
                <asp:Button ID="Button1" runat="server" Text="Mua" OnClick="mua" CommandArgument='<%# Container.ItemIndex %>' />
            </div>
        </ItemTemplate>
    </asp:DataList>
        <asp:Label ID="hienthi" runat="server" Text=""></asp:Label>

</asp:Content>
