<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="bai5_giaodien.aspx.cs" Inherits="baitap_WebForm1.bai5_giaodien" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div>
        <div style='padding-top:20px;'>  
            <asp:Label ID="label1" runat="server">Số chẵn</asp:Label>  
            <asp:TextBox ID="so_chan" runat="server" ToolTip="sochan"></asp:TextBox> 
            <asp:CustomValidator id="CustomValidator1" ControlToValidate="so_chan" ClientValidationFunction="ClientValidate" OnServerValidate="serverValidate" Display="Static" ErrorMessage="Vui lòng nhập số chẵn" runat="server"/>
        </div>
         <div style='padding-top:20px;'>  
            <asp:Label ID="label2" runat="server">Mã bảo mật</asp:Label>  
            <asp:TextBox ID="ma_baomat" TextMode="Password" runat="server" ToolTip="mabaomat"></asp:TextBox> 
            <asp:Label style="color:red;" ID="lblMaBM" runat="server"></asp:Label>  
            <asp:CustomValidator ID="CustomValidator2" runat="server" ControlToValidate="ma_baomat" Display="Dynamic" OnServerValidate="CustomValidator2_ServerValidate">
            </asp:CustomValidator>
         </div>
        <div style='padding-top:10px;'>  
            <asp:Button style='width:70px;height:20px;' ID="btn_kiemtra" runat="server" Text="Kiểm lỗi" OnClick="kiemtra_mabaomat" />  
        </div>
    </div>
     <script type="text/javascript">
         function ClientValidate(source, arguments) {
             var input = document.getElementById('<%= so_chan.ClientID %>').value;
             arguments.IsValid = sochan(input);
         }

         function sochan(input) {
             return parseInt(input) % 2 === 0;
         }
     </script>
     <br/>
    <br/>
     <br/>
    <br/>
     <br/>
    <br/>
</asp:Content>
