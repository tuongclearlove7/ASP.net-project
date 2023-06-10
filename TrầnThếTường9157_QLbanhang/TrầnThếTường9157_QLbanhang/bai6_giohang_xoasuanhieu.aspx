<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="bai6_giohang_xoasuanhieu.aspx.cs" Inherits="TrầnThếTường9157_QLbanhang.bai6_giohang_xoasuanhieu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div style="padding-top:70px;">
        <div>
             <h1>Sửa xóa nhiều mặt hàng trong giỏ hàng</h1>
        </div>
            <div>
               <asp:Button ID="Button2" PostBackUrl="~/bai2_mathang.aspx" runat="server" Text="Trang chủ" />
              <asp:Button ID="Button1" PostBackUrl="~/bai4_giohang.aspx" runat="server" Text="Giỏ hàng" />
          </div>
            <br/>
        <asp:GridView ID="ds_donhang" runat="server" AutoGenerateColumns="false" RowCommand="ds_donhang_RowCommand" OnRowDataBound="ds_donhang_RowDataBound" >
            <Columns>
                <asp:TemplateField HeaderText="Xóa">
                    <ItemTemplate>
                        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                        </asp:CheckBoxList>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="mahang" HeaderText="Mã hàng" />
                <asp:BoundField DataField="tenhang" HeaderText="Tên hàng" />
                <asp:BoundField DataField="mota" HeaderText="Mô tả" />
                <asp:BoundField DataField="dongia" HeaderText="Đơn giá" />
                 <asp:TemplateField  HeaderText="Số lượng">
                    <ItemTemplate>
                        <asp:TextBox ID="textbox_soluong" Text=' <%# Eval("soluong") %>'  runat="server"></asp:TextBox>
                        <asp:TextBox ID="textbox_mahang" Visible="false" Text='<%# Eval("mahang") %>' runat="server"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField  HeaderText="Thành tiền">
                    <ItemTemplate>
                        <asp:Label ID="thanhtien" runat="server" Text=""></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <div>
            <asp:Label ID="tongthanhtien" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="label_xoa" runat="server" Text=""></asp:Label>
        </div>
    </div>
    <div>
        <asp:Button  ID="btnXoa" CssClass="btn btn-warning" runat="server" Text="Xóa" OnClick="xoa" CommandArgument='<%# Eval("mahang") %>' />
        <asp:Button ID="btnsua" runat="server" Text="Sửa" OnClick="sua" />
    </div>
</asp:Content>
