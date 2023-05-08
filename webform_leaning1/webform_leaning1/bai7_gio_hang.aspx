<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bai7_gio_hang.aspx.cs" Inherits="webform_leaning1.bai7_gio_hang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
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
    <form id="form1" runat="server">
        <div>
             <div style="padding-top:20px;">  

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

            </div>

        </div>
    </form>
</body>
</html>
