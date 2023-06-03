<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="ds_loaihang.aspx.cs" Inherits="webform_csdl.ds_loaihang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <style>

       #MainContent_DataList1 tr {
           float:left;
           margin:0px;
       }

       td input{
           height:250px;
           width:300px;
       }
       .card{
           width:285px;
           padding:15px;
           border: 3px solid white;
           border-radius: 10px 0px;
           background-color: #ee4d2d;
       }
       .card-img-top{
           width:250px;
       }

    

        .card  a{
           height: 30px;
           width: 70px;
           color:white;
           text-decoration:none;    
       }
        .lop-nut{
            text-align:center;
        }
        .ten-loai{
            color :white;
            font-size:20px;
        }
        .card-text{
            color :white;
        }

        #MainContent_DataList1{
            margin: 0px 45px;
        }
        .btn-link{
            font-size:15px;
            margin:20px;
          
        }
        .btn-link:hover{
            text-decoration:none;
            color:white;
        }
        .ma-loaihang{
            color:white;
            font-size:17px;
        }

    </style>
    <div><h1>Danh sách Loại hàng</h1></div>
  
     <asp:DataList ID="DataList1" OnItemCommand="xoa" runat="server">
        <ItemTemplate>
                <div class="card">
                    <asp:Label CssClass="ma-loaihang" ID="Label1" runat="server" Text='<%# Eval("maloai") %>'></asp:Label>
                 <div class="view overlay">
                        <asp:ImageButton ID="ImageButton1" CssClass="card-img-top" runat="server" ImageUrl='<%# Eval("hinh") %>' PostBackUrl='<%# "mat_hang.aspx?MatHang=" + Eval("maloai") %>'  />
                    <a href="#!">
                      <div class="mask rgba-white-slight"></div>
                    </a>
                  </div>
                  <div class="card-body">
                    <h4 class="card-title">
                        <asp:Label CssClass="ten-loai" runat="server" Text='<%# Eval("tenloai") %>' />
                        <asp:TextBox ID="maloai" CssClass="form-control" Visible="false" runat="server" Text='<%# Eval("maloai") %>'></asp:TextBox>
                    </h4>
                    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card'scontent.</p>
                    <div class="lop-nut">
                        <asp:LinkButton CssClass="btn-link"  runat="server" PostBackUrl='<%# "mat_hang.aspx?MatHang=" + Eval("maloai") %>' Text='Xem'>
                        </asp:LinkButton>
                         <asp:LinkButton CssClass="btn-link" runat="server" PostBackUrl='<%# "sua_loaihang.aspx?loaihang=" + Eval("maloai") %>' Text='Sửa'>
                        </asp:LinkButton>
                         <asp:LinkButton CssClass="btn-link" runat="server"  Text='Xóa' CommandName="Delete"  CommandArgument='<%# Container.ItemIndex %>'>
                        </asp:LinkButton>
                    </div>
                  </div>
                </div>
          </ItemTemplate>
    </asp:DataList>

</asp:Content>
