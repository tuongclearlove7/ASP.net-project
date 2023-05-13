<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="bai3_tinhluong.aspx.cs" Inherits="baitap_WebForm1.bai3_tinhluong" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <div>
       <div>  
       <asp:Label ID="label_username" runat="server"><h1>Bảng tính lương</h1></asp:Label>  
       </div>
           <hr/>

             <div>
           <asp:Label ID="label1" runat="server">Tháng</asp:Label>
           <asp:DropDownList style="width:100px;" ID="chon" runat="server" >  
               <asp:ListItem >1</asp:ListItem>  
                <asp:ListItem >2</asp:ListItem>  
                <asp:ListItem >3</asp:ListItem>  
                <asp:ListItem >4</asp:ListItem>  
                <asp:ListItem >5</asp:ListItem>  
               <asp:ListItem>6</asp:ListItem>  
           </asp:DropDownList>  
  
       </div>

       <div style='padding-top:20px;'>  
               <asp:Label ID="label2" runat="server">Hệ số lương</asp:Label>  
               <asp:TextBox ID="he_soluong" runat="server" ToolTip="text"></asp:TextBox> 
        </div>
        <div>  
            <asp:Label ID="label3" runat="server"><h1>Các chi phí bảo hiểm</h1></asp:Label>  
       </div>
         <div style="padding-top: 20px;">

            <asp:CheckBoxList ID="checkbox" runat="server" AutoPostBack="True">
               <asp:ListItem value="bhxh">Bảo hiểm xã hội</asp:ListItem>
               <asp:ListItem value="bhyt">bảo hiểm y tế</asp:ListItem>
           </asp:CheckBoxList>

        </div>

        <div>  
            <asp:Label ID="label4" runat="server"><h1>Loại tiền tệ</h1></asp:Label>  
       </div>

          <div>  
             <asp:Radiobuttonlist ID="radiobuttonlist" runat="server" AutoPostBack="True" >
                <asp:ListItem Text="VNĐ" Value="vnd"></asp:ListItem>
                <asp:ListItem Text="USD" Value="usd"></asp:ListItem>
            </asp:Radiobuttonlist>
       </div>
         
       <div>
            <asp:Label ID="tien_usd" runat="server"></asp:Label>  
            <asp:TextBox ID="tien_luong" runat="server" ToolTip="text"></asp:TextBox> 
           <asp:Label ID="label6" runat="server">VNĐ</asp:Label>  
       </div>

        <div  style='padding-top:10px;'>  
           <asp:Button style='width:70px;height:20px;' ID="btn_tinhluong" runat="server" Text="Tính" OnClick="tinh_luong" />  
       </div> 


        <div style="padding-top: 20px;">  
           <asp:Label ID="hienthi" runat="server" ></asp:Label>  
       </div>
        <div style="padding-top: 20px;">  
           <asp:Label ID="hienthi_luong" runat="server" ></asp:Label>  
       </div>
           <div style="padding-top: 20px;">  
           <asp:Label ID="hienthi_luong_bhxh" runat="server" ></asp:Label>  
       </div>
        <div style="padding-top: 20px;">  
           <asp:Label ID="hienthi_luong_bhyt" runat="server" ></asp:Label>  
       </div>
         <div>  
           <asp:Label ID="thuc_nhan" runat="server" ></asp:Label>  
       </div>
   </div>

 <br/>
<br/>
 <br/>
<br/>
 <br/>
<br/>

</asp:Content>
