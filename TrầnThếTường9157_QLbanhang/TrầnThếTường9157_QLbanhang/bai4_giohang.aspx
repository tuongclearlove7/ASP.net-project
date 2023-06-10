<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="bai4_giohang.aspx.cs" Inherits="TrầnThếTường9157_QLbanhang.bai4_giohang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div style="padding-top:70px;">
        <div>
             <h1>Giỏ hàng</h1>
        </div>
        <div>
            <br/>
            <asp:Button ID="Button3" runat="server" Text="Trang chủ" PostBackUrl="bai2_mathang.aspx" />   
            <asp:Button ID="Button1" runat="server" Text="Xóa sửa" PostBackUrl="bai5_giohang_xoasua1.aspx" /> 
            <asp:Button ID="Button2" runat="server" Text="Xóa sửa nhiều" PostBackUrl="bai6_giohang_xoasuanhieu.aspx" /> 

        </div>
        <br/>
         <asp:GridView ID="ds_donhang" runat="server" AutoGenerateColumns="false" OnRowDataBound="ds_donhang_RowDataBound">
            <Columns>
                <asp:BoundField DataField="mahang" HeaderText="Mã hàng" />
                <asp:BoundField DataField="tenhang" HeaderText="Tên hàng" />
                <asp:BoundField DataField="mota" HeaderText="Mô tả" />
                <asp:BoundField DataField="dongia" HeaderText="Đơn giá" />
                <asp:BoundField DataField="soluong" HeaderText="Số lượng" />
                <asp:TemplateField  HeaderText="Thành tiền">
                    <ItemTemplate>
                        <asp:Label ID="thanhtien" runat="server" Text=""></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <div>
            <asp:Label ID="tongthanhtien" runat="server" Text=""></asp:Label>
        </div>
          <div>
            <asp:Label ID="dem_sodon" runat="server" Text=""></asp:Label>
        </div>
    </div>
</asp:Content>
