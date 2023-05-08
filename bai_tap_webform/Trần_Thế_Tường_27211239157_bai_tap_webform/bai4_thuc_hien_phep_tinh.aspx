<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="bai4_thuc_hien_phep_tinh.aspx.cs" Inherits="Trần_Thế_Tường_27211239157_bai_tap_webform.bai4_thuc_hien_phep_tinh" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

      <div>

             <div>  
                <asp:Label ID="label_username" runat="server"><h1>Thực Hiện Phép Tính</h1></asp:Label>  
            </div>
            <hr/>

            <div style='padding-top:20px;'>  
                 <asp:Label ID="label4" runat="server">Số thứ nhất</asp:Label>  
                 <asp:TextBox ID="so_thu1" runat="server" ToolTip="UserName"></asp:TextBox> 
             </div>
            <div style='padding-top:20px;'>  
                 <asp:Label ID="label5" runat="server" style='margin-right:8px;' >Số thứ hai</asp:Label>  
                 <asp:TextBox ID="so_thu2" runat="server" ToolTip="UserName"></asp:TextBox> 
             </div>
             <div  style='padding-top:10px;'>  
                 <asp:Button  ID="button1" runat="server" Text="+" style="padding-right:20px;" OnClick="cong" />  
                 <asp:Button  ID="button2" runat="server" Text="-" style="padding-right:20px;" OnClick="tru"/> 
                 <asp:Button  ID="button3" runat="server" Text="*" style="padding-right:20px;" OnClick="nhan"/> 
                 <asp:Button  ID="button4" runat="server" Text="/" style="padding-right:20px;" OnClick="chia"/> 
            </div> 
             <div style="padding:20px 0px 20px;">  
                <asp:Label ID="label_hienthi" runat="server" ></asp:Label>  
            </div>

        </div>
      <br/>
    <br/>
      <br/>
    <br/>
      <br/>
    <br/>
</asp:Content>
