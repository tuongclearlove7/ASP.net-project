<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="sanpham.aspx.cs" Inherits="TrầnThếTường_9157.sanpham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <asp:DataList ID="ds_sanpham"  runat="server">
        <ItemTemplate>
                    <div>
                        <h3>
                             <%# Eval("tenthietbi") %>
                        </h3>
                        
                    </div>
                    <div>
                        <p> <%# Eval("mota") %></p>
                    </div>
                      <div>
                        <p> <%# Eval("dongia") %></p>
                    </div>
                     <div>
                         <asp:Image style="width:300px;height:250px;" ID="Image1" ImageUrl='<%# Eval("hinhanh") %>' runat="server" />
                    </div>
                        <div>
                            <asp:TextBox ID="txt_soluong" Text='<%# Eval("soluong") %>' runat="server"></asp:TextBox>
                        </div>
                    <div>
                        <asp:Button ID="Button1" runat="server" Text="Mua" PostBackUrl='<%# "giohang.aspx?sanpham="+Eval("mathietbi") %>' />
                         <asp:Button ID="Button2" runat="server" Text="xem giỏ hàng" PostBackUrl='giohang.aspx' />
                    </div>
            </ItemTemplate>
    </asp:DataList>




</asp:Content>
