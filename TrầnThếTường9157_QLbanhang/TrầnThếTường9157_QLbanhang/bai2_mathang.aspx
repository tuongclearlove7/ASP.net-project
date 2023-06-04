<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" EnableEventValidation="false"  AutoEventWireup="true" CodeBehind="bai2_mathang.aspx.cs" Inherits="TrầnThếTường9157_QLbanhang.bai2_mathang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <style>
        .img-sp{
            height:270px;
            width:250px;
        }

    </style>
    <div>
         <h1>Các mặt hàng</h1>
    </div>
    <div><p>Ý tưởng của em là bấm vào các mặt hàng sau đó sẽ chuyển hướng đến trang của mặt hàng đó</p></div>
    <asp:DataList ID="ds_mathang" runat="server">
        <ItemTemplate>
            <asp:ImageButton  ID="ImageButton1" CssClass="img-sp" runat="server" PostBackUrl='<%# "bai3_mathang_chitiet.aspx?MatHang=" + Eval("mahang") %>' ImageUrl='<%# Eval("hinh") %>' />
            <div>
                <asp:LinkButton ID="LinkButton1" PostBackUrl='<%# "bai3_mathang_chitiet.aspx?MatHang=" + Eval("mahang") %>' runat="server">
                    <%# Eval("tenhang") %>
                </asp:LinkButton>
            </div>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>




