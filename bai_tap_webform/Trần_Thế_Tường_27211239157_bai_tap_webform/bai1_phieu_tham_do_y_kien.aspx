﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="bai1_phieu_tham_do_y_kien.aspx.cs" Inherits="Trần_Thế_Tường_27211239157_bai_tap_webform.bai1_phieu_tham_do_y_kien" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


      <div>
            <div style='width:85%; margin-top:20px;padding:20px; height: 403px;'>
               <h1>Thăm Dò Ý Kiến</h1>
                <div>  
                    <asp:Label ID="label1" runat="server">Họ và tên</asp:Label>  
                    <asp:TextBox ID="hoten" runat="server" Text="" Height="16px" Width="179px"></asp:TextBox> 
                     <asp:RadioButtonList ID="gioitinh" runat="server" >
                          <asp:ListItem>Nam</asp:ListItem>
                          <asp:ListItem>Nữ</asp:ListItem>
                     </asp:RadioButtonList>
                </div>
      
                <p>Bạn dùng internet để làm gì?</p>
                 <div>
                     <asp:CheckBoxList ID="checkbox" runat="server" Width="279px">
                          <asp:ListItem>Tin tức</asp:ListItem>
                          <asp:ListItem>Giải trí</asp:ListItem>
                          <asp:ListItem>Học tập</asp:ListItem>
                          <asp:ListItem>Mục đích khác</asp:ListItem>
                    </asp:CheckBoxList> 
                 </div>
                <div style='padding-top:10px;'>  
                    <asp:Button style='width:100px;height:30px;' ID="Button1" runat="server" Text="Chọn" OnClick="hien_thi"/>  
                    <asp:Button style='width:100px;height:30px;' ID="Button2" runat="server" Text="Hủy" />  
                </div> 
                <div style="padding-top:20px;">  
                   <asp:Label ID="label_hienthi" runat="server" ></asp:Label>  
                </div>
            </div>
        </div>
        <br/>
     <br/>
     <br/>
     <br/>

</asp:Content>
