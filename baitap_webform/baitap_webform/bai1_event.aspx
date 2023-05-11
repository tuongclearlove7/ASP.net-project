<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="bai1_event.aspx.cs" Inherits="baitap_webform.bai1_event" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
    <div style="color:red;"><h1>Thành Phố</h1></div>
   
       <div>
           <asp:Label ID="label1" runat="server">Thành phố</asp:Label>
           <asp:DropDownList ID="chon" runat="server" >  
               <asp:ListItem >Đà Nẵng</asp:ListItem>  
               <asp:ListItem>Tp Hồ Chí Minh</asp:ListItem>  
           
           </asp:DropDownList>  
  
       </div>
      
      
       <div>
            <asp:Button style='width:70px;height:20px; margin:2px;' ID="Button1" runat="server" Text="button" OnClick="hienthi" />
       </div>

       <div>
            <asp:Button style='width:70px;height:20px; margin:2px;' ID="btn_them" runat="server" Text="thêm mới" OnClick="capnhat" />
       </div>

       <div>
            <asp:Button style='width:70px;height:20px; margin:2px;' ID="btn_sua" runat="server" Text="chỉnh sửa" OnClick="capnhat" />
       </div>
       <div>
            <asp:Button style='width:70px;height:20px; margin:2px;' ID="Button2" runat="server" Text="xóa" OnClick="capnhat" />
       </div>
        <div>
           <asp:Label ID="lbl_hienthi" runat="server" ></asp:Label>
       </div>
       
   <div>
       <div>  
       <asp:Label ID="label_username" runat="server"><h1>Kiểm Tra Sự Kiện</h1></asp:Label>  
       </div>
           <hr/>
       <div style='padding-top:20px;'>  
               <asp:Label ID="label4" runat="server">Tên của bạn</asp:Label>  
               <asp:TextBox ID="txtName" runat="server" ToolTip="UserName"></asp:TextBox> 
           </div>
       <div style='padding-top:20px;'>  
               <asp:Label ID="label5" runat="server" style='margin-right:58px;' >lớp</asp:Label>  
               <asp:TextBox ID="txtLop" runat="server" ToolTip="UserName"></asp:TextBox> 
           </div>

       <div  style='padding-top:10px;'>  
           <asp:Button style='width:70px;height:20px;' ID="btn_ten" runat="server" Text="tên" OnClick="capnhat_update" />  
       </div> 
       <div  style='padding-top:10px;'>  
           <asp:Button style='width:70px;height:20px;' ID="btn_lop" runat="server" Text="lớp" OnClick="capnhat_update" />  
       </div> 
      
           <div>  
           <asp:Label ID="hienthi_ten" runat="server" ></asp:Label>  
       </div>
        <div>  
           <asp:Label ID="hienthi_lop" runat="server" ></asp:Label>  
       </div>
   </div>

       
   </div>
 <br/>
<br/>
 <br/>
<br/>
 <br/>
<br/>
</asp:Content>
