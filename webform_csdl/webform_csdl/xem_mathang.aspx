<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="xem_mathang.aspx.cs" Inherits="webform_csdl.xem_mathang" %>
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
        .container-mathang{
            max-width:100%;
            margin:20px 50px auto;
        }
      
    </style>
    <div class="container-mathang">
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
                <asp:BoundField DataField="dongia" HeaderText="Đơn giá" />
                <asp:BoundField DataField="maloai" HeaderText="Mã loại" />
                 <asp:TemplateField  HeaderText="Hình ảnh">
                    <ItemTemplate>
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("hinh") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="tenloai" HeaderText="Tên loại" />
            </Columns>
        </asp:GridView>

        
        </aside>
    </div>

   

</asp:Content>
