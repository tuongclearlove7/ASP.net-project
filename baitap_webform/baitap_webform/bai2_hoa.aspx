<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="bai2_hoa.aspx.cs" Inherits="baitap_webform.bai2_hoa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div style="padding-top: 20px;">

    <asp:CheckBoxList ID="checkboxList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="tinh_tien">
       <asp:ListItem Text="Hoa hồng" Value="hong"></asp:ListItem>
       <asp:ListItem Text="Hoa tulip" Value="tulip"></asp:ListItem>
       <asp:ListItem Text="Hoa Thủy tiên" Value="thuy_tien"></asp:ListItem>
   </asp:CheckBoxList>

</div>

<div>  
   <asp:Label ID="don_gia" runat="server" ></asp:Label>  
</div>

 <br/>
<br/>
 <br/>
<br/>
 <br/>
<br/>
</asp:Content>
