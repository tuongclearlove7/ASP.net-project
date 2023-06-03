<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="danhsachsp.aspx.cs" Inherits="webform_csdl.danhsachsp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style>

        .container-bang{
            padding-top:20px;
            margin:0px 45px;
        }
        td img{
            width:100px;
            height:90px;
        }

        td input{
            width:160px;
            height:140px;
        }
        #MainContent_data_list1 tr{
            float: left;
        }
        .nut-sua{
            width:100px;
            height:35px;
        }
        .btn-danger{
            width:100px;
            height:35px;
        }
        .btn-link{
            width:70px;
            height:30px;
        }
        .btn{
            width:100px;
            height:30px;
            box-shadow: 0 2px 2px #ccc;
            min-width: auto;
        }
        .btn-warning{
            width:70px;
        }
       
     

    </style>
   
    

    <div class="container-bang">

         <div><h1>Danh sách mặt hàng</h1></div>
            <div>
                <asp:DataList ID="data_list1" runat="server">
                    <ItemTemplate>
                        <div>
                            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl='<%# "xem_mathang.aspx?MatHang=" + Eval("mahang") %>' Text='<%# Eval("tenhang") %>' CommandName="Select" CommandArgument='<%#Eval("maloai") %>' />
                        </div>
                        <asp:ImageButton ID="ImageButton1" runat="server" PostBackUrl='<%# "xem_mathang.aspx?MatHang=" + Eval("mahang") %>' ImageUrl='<%# Eval("hinh") %>' />
                    </ItemTemplate>
                </asp:DataList>
            </div>
    
         <asp:GridView ID="bang_mathang" CssClass="table table-hover" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="mahang" HeaderText="Mã hàng" />
                <asp:BoundField DataField="tenhang" HeaderText="Tên hàng" />
                <asp:BoundField DataField="mota" HeaderText="Mô tả" />
                <asp:BoundField DataField="dongia" HeaderText="Đơn giá" />
                <asp:BoundField DataField="maloai" HeaderText="Mã loại" />

                 <asp:TemplateField  HeaderText="Hình ảnh">
                    <ItemTemplate>
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("hinh") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="tenloai" HeaderText="Tên loại" />

                <asp:TemplateField HeaderText="Sửa">
                    <ItemTemplate>
                         <asp:LinkButton  CssClass="btn btn-warning" runat="server" PostBackUrl='<%# "sua_mathang.aspx?mat_hang=" + Eval("mahang") %>' Text='Sửa'>
                        </asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>

                 <asp:TemplateField HeaderText="Xem">
                    <ItemTemplate>
                        <asp:LinkButton  CssClass="btn btn-warning" runat="server" PostBackUrl='<%# "xem_mathang.aspx?MatHang=" + Eval("mahang") %>' Text='Xem'>
                        </asp:LinkButton>                    
                    </ItemTemplate>
                </asp:TemplateField>

                 <asp:TemplateField HeaderText="Xóa">
                    <ItemTemplate>
                        <asp:Button  ID="btnXoa" CssClass="btn btn-warning" runat="server" Text="Xóa" OnClick="xoa" CommandArgument='<%# Eval("mahang") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

                  <asp:TemplateField HeaderText="Mua">
                    <ItemTemplate>
                        <asp:Button  ID="btnMua" CssClass="btn btn-warning" runat="server" Text="Mua"  CommandArgument='<%# Eval("mahang") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>
        </asp:GridView>

    </div>



</asp:Content>
