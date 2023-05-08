<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="bai3_form_nhap_va_hienthi.aspx.cs" Inherits="tran_the_tuong_39157_bt_webform.bai3_form_nhap_va_hienthi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
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
            <asp:Button style='width:70px;height:20px;' ID="Button3" runat="server" Text="OK" OnClick="hien_thi" />  
        </div> 
            <div>  
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
