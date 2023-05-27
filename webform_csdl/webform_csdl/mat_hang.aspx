<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="mat_hang.aspx.cs" Inherits="webform_csdl.mat_hang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        th, td{
            padding:20px;
        }
        #GridView1{
            margin:20px;
        }
        .image-mathang{
            width:290px;
            height:250px;
        }
      
    </style>

     <section>
        <div>
            <asp:Label ID="lbl_hienthi" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="mathang" runat="server" Text=""></asp:Label>
        </div>

        <div>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </div>
                       
    </section>
    <aside>
                       
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true"></asp:GridView>
        
    </aside>
</asp:Content>
