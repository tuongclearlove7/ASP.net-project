<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="validation.aspx.cs" Inherits="tran_the_tuong_39157_bt_webform.validation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <br/>
    <br/>
      <br/>
    <div>

 <asp:TextBox ID="txtTen" runat="server" Text="" Height="16px" Width="179px"></asp:TextBox> 
  
        <asp:RequiredFieldValidator ID="reqTen" ControlToValidate="txtTen" 
            Display="Dynamic" runat="server"
            ErrorMessage="Bạn phải nhập tên">Bạn phải nhập tên</asp:RequiredFieldValidator>
        <div>
        Nhập mk : <asp:TextBox ID="txtMatkhau1" runat="server" Text="" Height="16px" Width="179px" TextMode="Password"></asp:TextBox> 
            <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="txtMatkhau1" 
             Display="Dynamic" ErrorMessage="mk phai khac 123" ForeColor="Red" ValueToComapre="123"   
            Operator="NotEqual" Type="String"></asp:CompareValidator>

            <asp:CompareValidator ControlToValidate="txtMatkhau1"  ValueToCompare="123" runat="server"
                Operator="NotEqual" SetFocusOnError="True" Type="Integer">
                mật khẩu phải khác 123
            </asp:CompareValidator>

     </div>
         
 
    <div>
            Nhập lại mk : <asp:TextBox ID="txtMatkhau2" runat="server" Text="" Height="16px" Width="179px" TextMode="Password"></asp:TextBox> 
    </div>
    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtMatkhau1"   
        ControlToValidate="txtMatkhau2" Display="Dynamic" ErrorMessage="2 mk không giống nhau" ForeColor="Red"   
        Operator="Equal"   Type="String">
    </asp:CompareValidator>
    
    </div>

    <div  style='padding-top:10px;'>  
        <asp:Button style='width:70px;height:20px;' ID="btn1" runat="server" Text="Cập nhật" />  
    </div> 
   



</asp:Content>
