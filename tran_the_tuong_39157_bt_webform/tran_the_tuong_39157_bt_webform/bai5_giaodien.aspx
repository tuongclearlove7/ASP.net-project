<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="bai5_giaodien.aspx.cs" Inherits="tran_the_tuong_39157_bt_webform.bai5_giaodien" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div style='padding-top:20px;'>  
            <asp:Label ID="label1" runat="server">Số chẵn</asp:Label>  
            <asp:TextBox ID="so_chan" runat="server" ToolTip="sochan"></asp:TextBox> 
        </div>
        <div style='padding-top:20px;'>  
            <asp:Label ID="label2" runat="server">Mã bảo mật</asp:Label>  
            <asp:TextBox ID="ma_baomat" runat="server" ToolTip="mabaomat"></asp:TextBox> 
        </div>
       
         <script type="text/javascript">

             function kiemtra_sochan() {
                 var inputVal = document.getElementById("<%= so_chan.ClientID %>").value
                 console.log(inputVal);

                 if (inputVal % 2 === 0) {
                     return true;
                 } else {
                     var hienthisochan = document.getElementById('<%= hienthi_sochan.ClientID %>');
                     hienthisochan.innerHTML = "Vui lòng nhập số chẵn!";
                 }

                 return false;
             }
         </script>
         <div  style='padding-top:10px;'>  
            <asp:Button style='width:70px;height:20px;' ID="btn_kiemtra" runat="server" Text="Kiểm lỗi" OnClick="kiemtra" OnClientClick="return kiemtra_sochan();" />  
         </div> 

          <div style='padding-top:20px;'>  
            <asp:Label ID="hienthi_sochan" runat="server"></asp:Label>  
        </div>
           <div style='padding-top:5px;'>  
            <asp:Label ID="lblMaBM" runat="server"></asp:Label>  
        </div>
         <div style='padding-top:5px;'>  
            <asp:Label ID="kiemtra_mabaomat" runat="server"></asp:Label>  
        </div>
      
    </div>

  

     <br/>
    <br/>
     <br/>
    <br/>
     <br/>
    <br/>
</asp:Content>
