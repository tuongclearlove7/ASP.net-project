<%@ Page Title="" Language="C#" MasterPageFile="~/master/page.Master" AutoEventWireup="true" CodeBehind="giohang.aspx.cs" Inherits="do_an_thuongmaidientu.user.giohang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        th{
            padding:5px;
        }
        td{
            padding:10px;
        }

         table {
          font-family: arial, sans-serif;
          border-collapse: collapse;
          width: 100%;
        }

        td, th {
          border: 1px solid #dddddd;
          text-align: left;
          padding: 8px;
        }

        tr:nth-child(even) {
          background-color: #dddddd;
        }
    </style>
     <div style="padding-top:0px;">
        <div>
             <h1>Giỏ hàng</h1>
        </div>
        <div>
            <br/>
            <asp:Button ID="Button1" runat="server" Text="Xóa sửa" PostBackUrl="sua_xoa.aspx" /> 
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
