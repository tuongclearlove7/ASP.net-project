<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="bai7_mua_hang.aspx.cs" Inherits="tran_the_tuong_39157_bt_webform.bai7_mua_hang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <div>
         <div style="color:red;"><h1>Mua Hàng</h1></div>
        
            <div>
                <asp:Label ID="label1" runat="server">Tên hàng</asp:Label>
                <asp:DropDownList ID="chon_hang" runat="server" >  
                    <asp:ListItem >Áo sơ mi tay dài</asp:ListItem>  
                    <asp:ListItem>áo sơ mi trắng</asp:ListItem>  
                    <asp:ListItem>áo sơ mi đen</asp:ListItem> 
                    <asp:ListItem>áo ngắn tay</asp:ListItem>   
                </asp:DropDownList>  
       
            </div>
             <div>
                 <asp:Label ID="label2" runat="server">Đơn giá</asp:Label>
                 <asp:TextBox ID="don_gia" runat="server" Text="" Height="16px" Width="179px"></asp:TextBox> 
            </div>
               <div>
                 <asp:Label ID="label3" runat="server">Số lượng</asp:Label>
                 <asp:TextBox ID="so_luong" runat="server" Text="" Height="16px" Width="179px"></asp:TextBox> 
            </div>
            <div>
                 <asp:Label ID="label4" runat="server">Đối tượng</asp:Label>
                  <asp:RadioButtonList ID="doi_tuong" runat="server" >
                          <asp:ListItem>Bình thường</asp:ListItem>
                          <asp:ListItem>Giảm giá</asp:ListItem>
                 </asp:RadioButtonList>
            </div>
            <div>
                 <asp:Button style='width:70px;height:20px; margin:2px;' ID="Button1" runat="server" Text="Mua" OnClick="mua" />
                  <asp:Button style='width:70px;height:20px; margin:2px;' ID="Button2" runat="server" Text="Xóa" OnClick="xoa" />
                <%-- <asp:Button style='width:70px;height:20px; margin:2px;' ID="Button3" runat="server" Text="Show" OnClick="show_object" />--%>
            </div>
             <div>
                <asp:Label ID="lbl_hienthi" runat="server" ></asp:Label>
            </div>

            
        </div>
      <br/>
    <br/>
      <br/>
    <br/>
      <br/>
    <br/>
</asp:Content>
