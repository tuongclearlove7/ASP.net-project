<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menu.aspx.cs" Inherits="WebForm.menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

                <div>  
                    <asp:Label ID="label1" runat="server" ><h1>Trang chủ</h1></asp:Label>  
                </div>
                 <div>  
                    <asp:Label ID="label2" runat="server"></asp:Label>  
                </div>
                <div>  
                    <asp:Label ID="label3" runat="server"></asp:Label>  
                </div>
            
                <div>  
                    <asp:Button ID="SubmitButton" runat="server" Text="Next" OnClick="next" />  
                    <asp:Button ID="Button1" runat="server" Text="Previous" OnClick="previous" />  
                    <asp:Button ID="Button2" runat="server" Text="Home" OnClick="home" />  
                </div> 
        </div>
    </form>
</body>
</html>
