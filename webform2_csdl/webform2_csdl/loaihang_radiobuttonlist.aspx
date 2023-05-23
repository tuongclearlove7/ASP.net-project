<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loaihang_radiobuttonlist.aspx.cs" Inherits="webform2_csdl.loaihang_radiobuttonlist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="~/css/style1.css"/>
</head>
<body>
    <form id="form1" runat="server">
         <div class="container">

            <div class="header-1">
                <nav>
                    <div class="navbar">
                        <div class="logo">
                          <asp:Image ID="Image0" runat="server" />
                        </div>
                        <div class="text1">
                            <h3>
                                <asp:LinkButton ID="LinkButton0" runat="server">Web-form</asp:LinkButton>
                            </h3>
                        </div>
                        <ul>
                            <li>
                                <asp:LinkButton ID="LinkButton1" runat="server">Home</asp:LinkButton>
                            </li>
                             <li>
                                 <asp:LinkButton ID="LinkButton2" runat="server">About</asp:LinkButton>
                             </li>
                              <li>
                                 <asp:LinkButton ID="LinkButton3" runat="server">Contact</asp:LinkButton>
                             </li>
                             <li>
                                 <asp:LinkButton ID="LinkButton4" runat="server">Other</asp:LinkButton>
                             </li>
                             <li>
                                 <asp:LinkButton ID="LinkButton5" runat="server">Profile</asp:LinkButton>
                             </li>
                        </ul>
                    </div>
                 </nav>

            </div>
           
            <main>
                <div class="main-content">
                    <section>
                        <div>
                             <asp:Label ID="Label1" runat="server" ></asp:Label>
                        </div>
                        <div>
                            <asp:Label ID="Label2" runat="server" ></asp:Label>
                        </div>
                        <div>
                            <asp:Label ID="Label3" runat="server" ></asp:Label>
                        </div>
                       
                    </section>
                   <aside>
                       <div> 
                           <asp:RadioButtonList ID="RadioButtonList_loaihang" runat="server">
                            </asp:RadioButtonList>
                       </div>            
                        <div>
                            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="direct"/>
                        </div>   
                       
                   </aside>
                </div>
            </main>
            <hr/>
            <footer>
                <div class="footer-top">
                    <h2>FOOTER</h2>
                </div>
                <div class="footer-bottom">
                </div>
            </footer>

        </div>
    </form>
</body>
</html>
