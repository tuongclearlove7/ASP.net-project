<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="bai6_gian_hang.aspx.cs" Inherits="tran_the_tuong_39157_bt_webform.bai6_gian_hang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div style="text-align:center;">
            <h1>Gian Hàng</h1>
            <div>
                <asp:LinkButton style="text-decoration: underline;" ID="link1" runat="server" OnClick="click_ao_quan">áo quần </asp:LinkButton>
            </div>

              <div>
                <asp:LinkButton style="text-decoration: underline;" ID="link2" runat="server"  OnClick="click_giay_dep">giày dép </asp:LinkButton>
            </div>

              <div>
                <asp:LinkButton style="text-decoration: underline;" ID="link3" runat="server" OnClick="click_tui_xach">túi_xách </asp:LinkButton>
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
