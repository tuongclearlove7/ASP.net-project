<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForm._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <div>  
            <asp:Label ID="label_username" runat="server"><h1>Kiểm tra sự kiện</h1></asp:Label>  
        </div>
        <hr>

            <div style='padding-top:20px;'>  
                 <asp:Label ID="label4" runat="server">Tên của bạn</asp:Label>  
                 <asp:TextBox ID="txtName" runat="server" ToolTip="UserName"></asp:TextBox> 
             </div>
            <div style='padding-top:20px;'>  
                 <asp:Label ID="label5" runat="server" style='margin-right:58px;' >lớp</asp:Label>  
                 <asp:TextBox ID="txtLop" runat="server" ToolTip="UserName"></asp:TextBox> 
             </div>
             <div  style='padding-top:10px;'>  
                <asp:Button style='width:100px;height:30px;' ID="Button3" runat="server" Text="OK" OnClick="hien_thi" />  
            </div> 
             <div>  
                <asp:Label ID="label_hienthi" runat="server" ></asp:Label>  
            </div>

</asp:Content>
