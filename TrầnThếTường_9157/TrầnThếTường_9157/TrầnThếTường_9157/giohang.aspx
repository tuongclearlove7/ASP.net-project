<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="giohang.aspx.cs" Inherits="TrầnThếTường_9157.giohang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

       <asp:GridView ID="ds_dathang" runat="server" AutoGenerateColumns="false" >
            <Columns>
              
                 <asp:BoundField DataField="mathietbi" HeaderText="Mã thiết bị" />
                <asp:BoundField DataField="tenthietbi" HeaderText="Tên thiết bị" />
                <asp:BoundField DataField="dongia" HeaderText="Đơn giá" />
               <asp:BoundField DataField="soluong" HeaderText="Số lượng" />
                  <asp:TemplateField HeaderText="Xóa">
                      <ItemTemplate>
                          <asp:Label ID="Label1" runat="server" Text="Xóa"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>


</asp:Content>
