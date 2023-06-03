<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="mat_hang.aspx.cs" Inherits="webform_csdl.mat_hang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        th, td{
            padding:20px;
        }
        #GridView1{
            margin:20px;
        }
        .image-mathang{
            width:290px;
            height:250px;
        }
        td img{
            height:150px;
            width:200px;
        }
      
    </style>

     <section>
         <h1>Mặt hàng</h1>
        <div>
            <asp:Label ID="lbl_hienthi" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="mathang" runat="server" Text=""></asp:Label>
        </div>

        <div>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
        </div>
                       
    </section>
    <aside>
                       
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="mahang" HeaderText="Mã hàng" />
            <asp:BoundField DataField="tenhang" HeaderText="Tên hàng" />
            <asp:BoundField DataField="mota" HeaderText="Mô tả" />
             <asp:TemplateField  HeaderText="Hình ảnh">
                <ItemTemplate>
                    <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("hinh") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="tenloai" HeaderText="Tên loại" />
             <asp:BoundField DataField="maloai" HeaderText="Mã loại" />
        </Columns>
    </asp:GridView>

        
    </aside>
</asp:Content>
