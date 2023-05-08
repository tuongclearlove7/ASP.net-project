<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="bai7_gio_hang.aspx.cs" Inherits="tran_the_tuong_39157_bt_webform.bai7_gio_hang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <style>
            table {
              font-family: arial, sans-serif;
              border-collapse: collapse;
              width: 100%;
            }
            td, th {
              border: 1px solid #dddddd;
              text-align: left;
              padding: 8px;
            }
            tr:nth-child(even) {
              background-color: #dddddd;
            }
    </style>
      <div>
            <div style="padding-top:20px;">  
                <div style="color:darkred;"><h1>Giỏ Hàng</h1></div>
                <table>
                    <tr>
                    <th>Tên hàng</th>
                    <th>Đơn giá</th>
                    <th>Số lượng</th>
                    <th>Giảm giá</th>
                    <th>Thành tiền</th>
                    </tr>
                    <tr>
                        <td><asp:Label ID="lbl_tenhang" runat="server" ></asp:Label></td>
                        <td><asp:Label ID="lbl_dongia" runat="server" ></asp:Label></td>
                        <td><asp:Label ID="lbl_soluong" runat="server" ></asp:Label></td>
                        <td><asp:Label ID="lbl_doituong" runat="server" ></asp:Label> </td>
                        <td><asp:Label ID="lbl_thanhtien" runat="server" ></asp:Label> </td>
                    </tr>
                </table>
                <div style="margin-top:20px;"><asp:Label ID="lbl_hienthi" runat="server" ></asp:Label></div>

            </div>

        </div>
      <br/>
    <br/>
      <br/>
    <br/>
      <br/>
    <br/>
</asp:Content>
