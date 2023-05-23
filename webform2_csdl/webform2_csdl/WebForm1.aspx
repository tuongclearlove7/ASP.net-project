<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="webform2_csdl.WebForm1" %>

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
                            <asp:Label ID="so_sp" runat="server" Text="Label"></asp:Label>
                        </div>
                        <div>
                            <asp:DropDownList ID="ddl_sanpham" runat="server">
                            </asp:DropDownList>
                        </div>
                    </section>
                   <aside>
                        <div>
                            <asp:Image style="width:400px;" ID="Image1" runat="server" />
                            <asp:Image style="width:400px;" ID="Image2" runat="server" />
                            <asp:Image style="width:400px;" ID="Image3" runat="server" />
                            <asp:Image style="width:400px;" ID="Image4" runat="server" />
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
