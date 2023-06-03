<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="bai4_giohang.aspx.cs" Inherits="TrầnThếTường_9157_Bt_ql_banhang.bai4_giohang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div style="padding-top:70px;">
        <div>
             <h1>Giỏ hàng</h1>
        </div>
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
            <asp:Label ID="tongthanhtien" runat="server" Text="Label"></asp:Label>
        </div>
    </div>
</asp:Content>
