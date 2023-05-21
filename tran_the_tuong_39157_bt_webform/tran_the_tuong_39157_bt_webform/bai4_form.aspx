<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="bai4_form.aspx.cs" Inherits="tran_the_tuong_39157_bt_webform.bai4_form" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
      <div style='padding-top:20px;'>  
    
            <div>
                 <asp:Label ID="label1" runat="server">Email</asp:Label>  
                 <asp:TextBox ID="email" runat="server" ToolTip="Email"></asp:TextBox> 
                 <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="email" Display="Dynamic" ErrorMessage="email định dạng không đúng" ValidationExpression="^(\w+@\w+\.\w+)$">@
	             </asp:RegularExpressionValidator>
            </div>

             <div style='padding-top:20px;'>  
                <asp:Label ID="label2" runat="server">Xác thực Email</asp:Label>  
                <asp:TextBox ID="xac_thuc_email" runat="server" ToolTip="Email"></asp:TextBox> 
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="email" ControlToValidate="xac_thuc_email" Display="Dynamic" ErrorMessage="Xác thực không giống email" ForeColor="Red" Operator="Equal"   Type="String">#
                </asp:CompareValidator>
            </div>

            <div style='padding-top:20px;'>  
                <asp:Label ID="label3" runat="server">Điểm</asp:Label>  
                <asp:TextBox ID="diem" runat="server" ToolTip="Email"></asp:TextBox> 
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="diem" Display="Dynamic" ErrorMessage="Điểm phải từ 0 đến 10" MinimumValue ="1" MaximumValue ="10" Type="Integer">0...10
                </asp:RangeValidator>
            </div>

             <div style='padding-top:20px;'>  
                <asp:Label ID="label4" runat="server">Ngày sinh</asp:Label>  
                <asp:TextBox ID="ngaysinh" runat="server" ToolTip="text"></asp:TextBox> 
                <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="ngaysinh" Display="Dynamic" ErrorMessage="Ngày sinh phải trên 16 tuổi" ClientValidationFunction="kiemtra_tuoi">>16
                </asp:CustomValidator>
             </div>

            <div style='padding-top:10px;'>  
                <asp:ValidationSummary ID="ValidationSummary2" runat="server" HeaderText="Vui lòng khắc phục các lỗi sau" ShowMessageBox="True" ShowSummary="False" />
                <asp:Button ID="Button2" runat="server" Text="Kiểm lỗi" OnClick="kiem_loi"/>
                    <asp:Label ID="hienthi" runat="server"></asp:Label> 
                    <asp:Label ID="hienthi_xacthuc" runat="server"></asp:Label> 
                    <asp:Label ID="hienthi_diem" runat="server"></asp:Label> 
                    <asp:Label ID="hienthi_tuoi" runat="server"></asp:Label>
            </div>

        </div>
     <script type="text/javascript">
         function kiemtra_tuoi(source, arguments) {
             var ngaysinh = document.getElementById('<%= ngaysinh.ClientID %>').value;
             var today = new Date();
             var ns = new Date(ngaysinh);
             var tuoi = today.getFullYear() - ns.getFullYear();
             if (tuoi < 16) {
                 arguments.IsValid = false;
             } else {
                 arguments.IsValid = true;
             }
         }
     </script>

      <script type="text/javascript">
          function kiemtra_nhapvao() {
              var isValid = Page_ClientValidate();
              if (!isValid) {
                  var errorMessage = document.getElementById('<%= ValidationSummary2.ClientID %>').innerText;
              }
          }
      </script>
          
     <br/>
    <br/>
     <br/>
    <br/>
     <br/>
    <br/>
</asp:Content>
