<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="danhsachsp.aspx.cs" Inherits="webform_csdl.danhsachsp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style>

        .container-bang{
            padding-top:20px;
        }
        td img{
            width:200px;
            height:150px;
        }

        td input{
             width:200px;
            height:150px;
        }
        #MainContent_data_list1 tr{
            float: left;
        }

     

    </style>
    <div><h1>Danh sách mặt hàng</h1></div>
    <div>
        <asp:DataList ID="data_list1" runat="server">
            <ItemTemplate>
                <div>
                    <asp:LinkButton ID="LinkButton1" runat="server" Text='<%# Eval("tenhang") %>' CommandName="Select" CommandArgument='<%#Eval("maloai") %>' />
                </div>
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl='<%# "./image/"+Eval("hinh") %>' />
            </ItemTemplate>
        </asp:DataList>
    </div>
    

    <div class="container-bang">

         <asp:GridView ID="bang_mathang" CssClass="table table-hover" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="mahang" HeaderText="Mã hàng" />
                <asp:BoundField DataField="tenhang" HeaderText="Tên hàng" />
                <asp:BoundField DataField="tenhang" HeaderText="Mô tả" />
                 <asp:TemplateField  HeaderText="Hình ảnh">
                    <ItemTemplate>
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# "./image/"+Eval("hinh") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="tenloai" HeaderText="Tên loại" />
            </Columns>
        </asp:GridView>

    </div>































</asp:Content>
