<%@ Page Title="" Language="C#" MasterPageFile="~/master/admin.Master" AutoEventWireup="true" CodeBehind="homeAdmin.aspx.cs" Inherits="do_an_thuongmaidientu.admin.homeAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div><h2>Home Admin</h2></div>

     <style>

           #ContentPlaceHolder1_ds_mathang tr {
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

        .img-sp{
            height:270px;
            width:250px;
        }

    </style>

       <div><h1>Danh sách mặt hàng</h1></div>
     <asp:DataList ID="ds_mathang"  runat="server">
        <ItemTemplate>
                <div class="card">
                    <asp:Label CssClass="ma-loaihang" ID="Label1" runat="server" Text='<%# Eval("mahang") %>'></asp:Label>
                 <div class="view overlay">
                        <asp:ImageButton ID="ImageButton1" CssClass="card-img-top" runat="server" ImageUrl='<%# Eval("hinh") %>'  />
                    <a href="#!">
                      <div class="mask rgba-white-slight"></div>
                    </a>
                  </div>
                  <div class="card-body">
                    <h4 class="card-title">
                        <asp:Label CssClass="ten-loai" runat="server" Text='<%# Eval("tenloai") %>' />
                        <asp:TextBox ID="maloai" CssClass="form-control" Visible="false" runat="server" Text='<%# Eval("mahang") %>'></asp:TextBox>
                    </h4>
                    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card'scontent.</p>
                    <div class="lop-nut">
                        <asp:Button Width="100px" Height="30px"  ID="Button1" CssClass="btn btn-warning" runat="server" Text="Sửa" PostBackUrl='<%# "sua.aspx?MatHang="+Eval("mahang") %>' />

                         <asp:Button Width="100px" Height="30px"  ID="btnXoa" CssClass="btn btn-warning" runat="server" Text="Xóa" OnClick="xoa" CommandArgument='<%# Eval("mahang") %>' />
                    </div>
                  </div>
                </div>
          </ItemTemplate>
    </asp:DataList>


</asp:Content>
