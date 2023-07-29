<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="webform_leaning1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

               <asp:TableRow runat="server" Height="100px" ID="TableRow1">
                    <asp:TableCell runat="server">
                        <asp:Label ID="lbUserID" runat="server" Text="User ID"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="tbInputUserId" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="myTextBox" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator
                            ID="RequiredFieldValidator1" 
                            runat="server" ControlToValidate="myTextBox" 
                            ErrorMessage="Please enter a value">
                        </asp:RequiredFieldValidator>
                    </asp:TableCell>
                    </asp:TableRow>

        </div>
        <p>

               <asp:TableRow runat="server" Height="100px" ID="TableRow2">
                    <asp:TableCell runat="server">
                        <asp:Label ID="lbUserID0" runat="server" Text="User ID"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="tbInputUserId0" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="myTextBox0" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator
                            ID="RequiredFieldValidator2" 
                            runat="server" ControlToValidate="myTextBox" 
                            ErrorMessage="Please enter a value">
                        </asp:RequiredFieldValidator>
                    </asp:TableCell>
                    </asp:TableRow>

        </p>
        <p>

               <asp:TableRow runat="server" Height="100px" ID="TableRow3">
                    <asp:TableCell runat="server">
                        <asp:Label ID="lbUserID1" runat="server" Text="User name"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="tbInputUserId1" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="myTextBox1" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator
                            ID="RequiredFieldValidator3" 
                            runat="server" ControlToValidate="myTextBox" 
                            ErrorMessage="Please enter a value">
                        </asp:RequiredFieldValidator>
                    </asp:TableCell>
                    </asp:TableRow>

        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="click" />
        </p>
    </form>
</body>
</html>
