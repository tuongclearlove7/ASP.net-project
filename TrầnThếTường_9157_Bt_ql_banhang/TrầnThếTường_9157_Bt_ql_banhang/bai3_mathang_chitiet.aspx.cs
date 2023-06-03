using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrầnThếTường_9157_Bt_ql_banhang
{
    public partial class bai3_mathang_chitiet : System.Web.UI.Page
    {

        lopketnoi ketnoi = new lopketnoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionVsDB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Server.MapPath("/App_Data/banhang.mdf") + ";Integrated Security=True";
            // string connectionSQLServer = "server=DESKTOP-9ER0ESK\\SQLEXPRESS;database=ban_hang;User ID=sa;Password=tuongyeuthao1";

            if (!IsPostBack)
            {
                if (Request.QueryString["MatHang"] != null)
                {
                    string mahang = Request.QueryString["MatHang"];
                    if (mahang == Request.QueryString["MatHang"])
                    {
                        string sql = "SELECT * FROM mathang WHERE " +
                                     "mathang.mahang = " + mahang;
                        ds_mathang.DataSource = ketnoi.docdulieu(connectionVsDB, sql);
                        DataTable dt = ketnoi.docdulieu(connectionVsDB, sql);

                        ds_mathang.DataBind();
                    }
                }
                else
                {
                    Response.Redirect("bai2_mathang.aspx");
                }
            }

        }


        protected void mua(object sender, EventArgs e)
        {

            string connectionVsDB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Server.MapPath("/App_Data/banhang.mdf") + ";Integrated Security=True";
            // string connectionSQLServer = "server=DESKTOP-9ER0ESK\\SQLEXPRESS;database=ban_hang;User ID=sa;Password=tuongyeuthao1";
            string mahang = Request.QueryString["MatHang"];
            Button btn = (Button)sender;
            DataListItem item = (DataListItem)btn.NamingContainer;
            TextBox txtSoLuong = (TextBox)item.FindControl("soluong");
            string soluong = txtSoLuong.Text;
            string sql = "select * from donhang";
            ketnoi.docdulieu(connectionVsDB, sql);
            DataTable dt = ketnoi.docdulieu(connectionVsDB, sql);


            if (dt != null && dt.Rows.Count > 0)
            {
                // Truy cập vào DataTable 
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["mahang"].ToString() == mahang)
                    {
                        string sql3 = "UPDATE donhang SET soluong = " + soluong + " where donhang.mahang = " + mahang;
                        ketnoi.docdulieu(connectionVsDB, sql3);
                        hienthi.Text = "Cập nhật số lượng thành công";

                    }
                    else
                    {
                        hienthi.Text = "Lưu mã hàng và số lượng thành công!!!";
                        string sql2 = "INSERT INTO donhang(tendangnhap, mahang, soluong) " +
                                        "VALUES ('" + "admin" + "', " + mahang + ", " + soluong + ")";
                        ketnoi.docdulieu(connectionVsDB, sql2);

                    }
                }
            }
            else
            {
                // DataTable không có dữ liệu
                hienthi.Text = "Lưu mã hàng và số lượng thành công";
                string sql2 = "INSERT INTO donhang(tendangnhap, mahang, soluong) " +
                                "VALUES ('" + "admin" + "', " + mahang + ", " + soluong + ")";
                ketnoi.docdulieu(connectionVsDB, sql2);

            }
            Thread.Sleep(1000);
            Response.Redirect("bai4_giohang.aspx");

        }

    }
}