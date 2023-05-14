<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="bai4_form.aspx.cs" Inherits="tran_the_tuong_39157_bt_webform.bai4_form" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>

         <div style='padding-top:20px;'>  
            <asp:Label ID="label1" runat="server">Email</asp:Label>  
            <asp:TextBox ID="email" runat="server" ToolTip="Email"></asp:TextBox> 

               <asp:RequiredFieldValidator ID="reqemail" ControlToValidate="email" 
                Display="Dynamic" runat="server"
                 ErrorMessage="email không được để trống">
                   <%--email không được để trống--%>
               </asp:RequiredFieldValidator>
        <div>
        </div>
         <div style='padding-top:20px;'>  
            <asp:Label ID="label2" runat="server">Xác thực Email</asp:Label>  
            <asp:TextBox ID="xac_thuc_email" runat="server" ToolTip="Email"></asp:TextBox> 
              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="xac_thuc_email" 
                Display="Dynamic" runat="server"
                 ErrorMessage="email không được để trống">
                   <%--email không được để trống--%>
               </asp:RequiredFieldValidator>
        </div>
        <div style='padding-top:20px;'>  
            <asp:Label ID="label3" runat="server">Điểm</asp:Label>  
            <asp:TextBox ID="diem" runat="server" ToolTip="Email"></asp:TextBox> 
        </div>
         <div style='padding-top:20px;'>  
            <asp:Label ID="label4" runat="server">Ngày sinh</asp:Label>  
            <asp:TextBox ID="ngaysinh" runat="server" ToolTip="Email"></asp:TextBox> 
        </div>
        
        <div  style='padding-top:10px;'>  
            <asp:Button style='width:70px;height:20px;' ID="btn_kiemtra" runat="server" Text="Kiểm lỗi" OnClick="kiemtra_loi" />  
        </div> 

         <div style='padding-top:20px;'>  
            <asp:Label ID="hienthi" runat="server"></asp:Label>  
        </div>
         <div style='padding-top:5px;'>  
            <asp:Label ID="hienthi_xacthuc" runat="server"></asp:Label>  
        </div>
        <div style='padding-top:5px;'>  
            <asp:Label ID="hienthi_diem" runat="server"></asp:Label>  
        </div>
         <div style='padding-top:5px;'>  
            <asp:Label ID="hienthi_tuoi" runat="server"></asp:Label>  
        </div>

    </div>
   
     <br/>
    <br/>
     <br/>
    <br/>
     <br/>
    <br/>
</asp:Content>
