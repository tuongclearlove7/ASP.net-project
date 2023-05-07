<%@ Page Title="Trang chủ" Language="C#" MasterPageFile="~/Site.Master"  AutoEventWireup="true" CodeBehind="trang_chu.aspx.cs" Inherits="WebForm.trang_chu" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
  
 
   <script type="text/javascript">
       function ham() {

       }

   </script>

    <script runat="server">
        void capnhat() {

        }

    </script>
       <div> 

       </div>
      <%-- <form id="form1" runat="server">--%>
             <div>  
                 <asp:Label ID="label_username" runat="server">User Name</asp:Label>  
                 <asp:TextBox ID="username" runat="server" ToolTip="UserName"></asp:TextBox> 
             </div>
                 
             <div>  
                 <asp:Label ID="label1" runat="server">Password</asp:Label>  
                 <asp:TextBox ID="password" runat="server" TextMode='Password'></asp:TextBox>  
             </div>
            <div>  
                 <asp:Label ID="label2" runat="server">SingleLine</asp:Label>  
                 <asp:TextBox ID="singleLine" runat="server" TextMode="SingleLine"></asp:TextBox> 
             </div>
            <div>
                 <asp:Label ID="label3" runat="server">MultiLine</asp:Label> 
                 <asp:TextBox ID="multiLine" runat="server" TextMode="MultiLine"></asp:TextBox>  
            </div>
            <div>
                <asp:Label ID="label4" runat="server">Date</asp:Label> 
                <asp:TextBox ID="date" runat="server" TextMode="Date"></asp:TextBox> 
            </div>
            <div> 
                <asp:ImageButton ID="img_1" runat="server" />   
             </div>
       
            <div>
                <asp:CheckBoxList ID="checkboxlist1" AutoPostBack="True" CellPadding="5" 
                    RepeatColumns="2" RepeatDirection="Vertical"
                    RepeatLayout="Flow"
                    TextAlign="Right"
                    runat="server">
                    <asp:ListItem>Item 1</asp:ListItem>
                    <asp:ListItem>Item 2</asp:ListItem>
                    <asp:ListItem>Item 3</asp:ListItem>
                    <asp:ListItem>Item 4</asp:ListItem>
                    <asp:ListItem>Item 5</asp:ListItem>
                    <asp:ListItem>Item 6</asp:ListItem>
                </asp:CheckBoxList>
            </div>
            <div>  
                <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />  
            </div>  
     
             <asp:Label ID="userInput" runat="server"></asp:Label>   
      <%-- </form>--%>

</asp:Content>
