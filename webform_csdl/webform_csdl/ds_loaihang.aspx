﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="ds_loaihang.aspx.cs" Inherits="webform_csdl.ds_loaihang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <style>

       #MainContent_DataList1 tr {
           float:left;
           padding:10px;
           margin:15px;
       }

       td input{
           height:250px;
           width:300px;
       }
       .card{
           width:350px;
           padding:15px;
           border: 3px solid black;
           border-radius: 10px 0px;
           background-color: #ee4d2d;
       }
       .card-img-top{
           width:318px;
       }

    

        .card  a{
            height: 35px;
           width: 90px;
           color:white;
           text-decoration:none;
       }
        .lop-nut{
            text-align:center;
        }
        .ten-loai{
            color :white;
        }
        .card-text{
            color :white;
        }

    </style>
    <div><h1>Danh sách Loại hàng</h1></div>
     <div>
          <asp:Button ID="Button1" CssClass="btn btn-success" runat="server" Text="Thêm mới" OnClick="themmoi_loaihang" />   
    </div>
    
 <asp:DataList ID="DataList1" runat="server">
    <ItemTemplate>
            <div class="card">
             <div class="view overlay">
                    <asp:ImageButton ID="ImageButton1" CssClass="card-img-top" runat="server" ImageUrl='<%# "./image/"+Eval("hinh") %>' PostBackUrl='<%# "mat_hang.aspx?MatHang=" + Eval("maloai") %>'  />
                <a href="#!">
                  <div class="mask rgba-white-slight"></div>
                </a>
              </div>
              <div class="card-body">
                <h4 class="card-title">
                    <asp:Label CssClass="ten-loai" runat="server" Text='<%# Eval("tenloai") %>' />
                </h4>
                <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card'scontent.</p>
                <div class="lop-nut">
                    <asp:LinkButton CssClass="btn btn-warning" runat="server" PostBackUrl='<%# "mat_hang.aspx?MatHang=" + Eval("maloai") %>' Text='Xem'>
                    </asp:LinkButton>
                </div>
                
              </div>
            </div>
      </ItemTemplate>
</asp:DataList>



</asp:Content>
