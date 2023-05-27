<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="loaihang.aspx.cs" Inherits="webform_csdl.loaihang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <style>
        .container-loaihang{

            padding-top: 120px;
            padding-bottom:500px;
            max-width: 100%;
            margin:0 auto;
        }
        
        #MainContent_dropDownList_loaihang{
            width:300px;
            height:30px;
            margin: 10px 50px 30px;
        
        }
        .chon-hang{
            margin-left:50px;
        }
        #MainContent_Button1{
            width:80px;
            height: 25px;
            border-radius:5px;
            border:1px solid white; 
            font-size:15px;
            background-color: black;
            color:white;
        }
        .btn-1{
            margin-left:50px;
        }
        .image-loaihang{
            width: 280px;
            height: 250px;
            border-radius:20px;
    
        }

        .loaihang{
            padding-top: 20px;
            font-size: 20px;
            margin: 20px 0px 10px 50px;
            height: 280px;
            width: 280px;
            padding:20px;
            border-radius: 20% 0px;
            font-family: sans-serif;
            border: 1px solid black;
            background-color:#2b2c34;
            color:white;
            float: left;
        }
        .sohang{
            margin: 20px 0px 10px 50px;
        }
        .block-loaihang{
            float:left;
            height: 100%;
            padding:10px 0px 200px 0px;
        }

    </style>

    <div class="container-loaihang">
        <div class="chon-hang"><h2>Chọn loại hàng</h2></div>

        <div >
            <asp:RadioButtonList ID="RadioButtonList_loaihang" runat="server">
            </asp:RadioButtonList>
        </div>
        <div>        
            <asp:DropDownList ID="dropDownList_loaihang" runat="server"></asp:DropDownList>
        </div>

        <div class="btn-1">
            <asp:Button ID="Button1" runat="server" Text="Chọn" OnClick="direct" />
        </div>

        <div class="sohang">
            <h3><asp:Label ID="so_loaihang" runat="server" Text="Label"></asp:Label>
            </h3>
        </div>

        <div class="block-loaihang">
            <div class="loaihang">
                <div>
                    <asp:Label ID="ao" runat="server" Text="">
                    </asp:Label>
                </div>
                 <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            </div>

             <div class="loaihang">
                <div>
                    <asp:Label ID="quan" runat="server" Text="">
                    </asp:Label>
                </div>
                 <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
            </div>

             <div class="loaihang">
                <div>
                    <asp:Label ID="maytinh" runat="server" Text="">
                    </asp:Label>
                </div>
                 <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
            </div>

            <div class="loaihang">
                <div>
                    <asp:Label ID="tuixach" runat="server" Text="">
                    </asp:Label>
                </div>
                 <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
            </div>

             <div class="loaihang">
                <div>
                    <asp:Label ID="tivi" runat="server" Text=""></asp:Label>
                </div>
                 <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
            </div>

             <div class="loaihang">
                <div>
                    <asp:Label ID="giay" runat="server" Text=""></asp:Label>
                </div>
                 <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
            </div>

             <div class="loaihang">
                <div>
                    <asp:Label ID="dep" runat="server" Text=""></asp:Label>
                </div>
                 <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
            </div>

             <div class="loaihang">
                <div>
                    <asp:Label ID="mu" runat="server" Text=""></asp:Label>
                </div>
                 <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
            </div>
            
        </div>
    </div>



   

</asp:Content>
