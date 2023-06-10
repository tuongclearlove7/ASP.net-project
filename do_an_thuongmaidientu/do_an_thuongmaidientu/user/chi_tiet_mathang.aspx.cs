using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace do_an_thuongmaidientu.user
{
    public partial class chi_tiet_mathang : System.Web.UI.Page
    {
        Models.ketnoi_database ketnoi = new Models.ketnoi_database();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["tendangnhap"] != null)
                {

                    if (Request.QueryString["MatHang"] != null)
                    {
                        string mahang = Request.QueryString["MatHang"];
                        if (mahang == Request.QueryString["MatHang"])
                        {
                            string sql = "SELECT * FROM mathang WHERE " +
                                         "mathang.mahang = " + mahang;
                            ds_mathang.DataSource = ketnoi.docdulieu(sql);
                            DataTable dt = ketnoi.docdulieu(sql);
                            ds_mathang.DataBind();
                        }
                    }
                    else
                    {
                        Response.Redirect("homeUser.aspx");
                    }
                }
                else
                {
                    Response.Redirect("../master/loginPage.aspx");
                }
            }

        }



        protected void mua(object sender, EventArgs e)
        {
            string mahang = Request.QueryString["MatHang"];
            Button btn = (Button)sender;
            DataListItem item = (DataListItem)btn.NamingContainer;
            TextBox txtSoLuong = (TextBox)item.FindControl("soluong");
            string soluong = txtSoLuong.Text;
            string sql = "select * from donhang";
            ketnoi.docdulieu(sql);
            DataTable dt = ketnoi.docdulieu(sql);

            if (dt != null && dt.Rows.Count > 0)
            {
                // Truy cập vào DataTable 
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["mahang"].ToString() == mahang)
                    {
                        string sql3 = "UPDATE donhang SET soluong = " + soluong + " where donhang.mahang = " + mahang + "and donhang.tendangnhap = '" + Session["tendangnhap"] + "'";
                        ketnoi.capnhat(sql3);
                    }
                    else
                    {
                        string sql2 = "INSERT INTO donhang(tendangnhap, mahang, soluong) " +
                                        "VALUES ('" + Session["tendangnhap"] + "', " + mahang + ", " + soluong + ")";
                        ketnoi.capnhat(sql2);

                    }
                }
            }
            else
            {
                // DataTable không có dữ liệu
                string sql2 = "INSERT INTO donhang(tendangnhap, mahang, soluong) " +
                                "VALUES ('" + Session["tendangnhap"] + "', " + mahang + ", " + soluong + ")";
                ketnoi.capnhat(sql2);

            }
            Thread.Sleep(1000);
            Response.Redirect("giohang.aspx");

        }


    }
}