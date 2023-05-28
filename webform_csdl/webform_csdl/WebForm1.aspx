<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="webform_csdl.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <section>
            <div>
                <asp:Label ID="so_sp" runat="server" Text="Label"></asp:Label>
            </div>
            <div>
                <asp:DropDownList style="width:300px;height:30px;" ID="ddl_sanpham" runat="server">
                </asp:DropDownList>
            </div>
        </section>
        <aside>
            <div>
                <asp:Image style="width:400px;" ID="Image1" runat="server" />
                <asp:Image style="width:400px;" ID="Image2" runat="server" />
                <asp:Image style="width:400px;" ID="Image3" runat="server" />
                <asp:Image style="width:400px;" ID="Image4" runat="server" />

                <asp:GridView ID="GridView1" runat="server"></asp:GridView>


            </div>
        </aside>
</asp:Content>
