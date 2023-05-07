<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="thuc_hien_phep_tinh.aspx.cs" Inherits="WebForm.thuc_hien_phep_tinh" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>


             <div>  
                <asp:Label ID="label_username" runat="server"><h1>Thực hiện phép tính</h1></asp:Label>  
            </div>
            <hr>

            <div style='padding-top:20px;'>  
                 <asp:Label ID="label4" runat="server">Số thứ nhất</asp:Label>  
                 <asp:TextBox ID="so_thu1" runat="server" ToolTip="UserName"></asp:TextBox> 
             </div>
            <div style='padding-top:20px;'>  
                 <asp:Label ID="label5" runat="server" style='margin-right:8px;' >Số thứ hai</asp:Label>  
                 <asp:TextBox ID="so_thu2" runat="server" ToolTip="UserName"></asp:TextBox> 
             </div>
             <div  style='padding-top:10px;'>  
                 <asp:Button  ID="button1" runat="server" Text="+" style="padding-right:20px;" OnClick="cong" />  
                 <asp:Button  ID="button2" runat="server" Text="-" style="padding-right:20px;" OnClick="tru"/> 
                 <asp:Button  ID="button3" runat="server" Text="*" style="padding-right:20px;" OnClick="nhan"/> 
                 <asp:Button  ID="button4" runat="server" Text="/" style="padding-right:20px;" OnClick="chia"/> 
            </div> 
             <div>  
                <asp:Label ID="label_hienthi" runat="server" ></asp:Label>  
            </div>



        </div>
    </form>
</body>
</html>
