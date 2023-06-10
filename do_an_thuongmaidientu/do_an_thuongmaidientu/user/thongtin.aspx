<%@ Page Title="" Language="C#" MasterPageFile="~/master/page.Master" AutoEventWireup="true" CodeBehind="thongtin.aspx.cs" Inherits="do_an_thuongmaidientu.user.thongtin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <style>

   
       .card{
           width: 285px;
            padding: 15px;
            border: 3px solid black;
            border-radius: 10px 0px;
            background-color: #d8d8d8;
       }
       .card-img-top{
           width:250px;
       }
        .card  a{
           height: 30px;
           width: 70px;
           color: black;
           text-decoration:none;    
       }
     
        .ten-taikhoan{
            font-size:20px;
            text-align:center;
            color: black;
        }
        .card-text{
            color: black;
        }
        .card-title{
            text-align:center;
        }

    
    </style>

     <div class="card">
            <div class="view overlay">
                <asp:ImageButton ID="ImageButton1" CssClass="card-img-top" runat="server" ImageUrl='https://cdn-icons-png.flaticon.com/512/1946/1946429.png'/>
            <a href="#!">
                <div class="mask rgba-white-slight"></div>
            </a>
            </div>
            <div class="card-body">
            <h4 class="card-title">
                <asp:Label ID="tentaikhoan" CssClass="ten-taikhoan" runat="server" Text='' />
            </h4>
            <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card'scontent.</p>
            </div>
        </div>


</asp:Content>
