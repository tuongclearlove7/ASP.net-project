<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bai3_form_nhap_va_hienthi.aspx.cs" Inherits="webform_leaning1.form_nhap_va_hienthi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
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
                <asp:Button style='width:100px;height:30px;' ID="Button3" runat="server" Text="OK" OnClick="hien_thi" />  
            </div> 
             <div>  
                <asp:Label ID="label_hienthi" runat="server" ></asp:Label>  
            </div>
        </div>
    </form>
</body>
</html>
