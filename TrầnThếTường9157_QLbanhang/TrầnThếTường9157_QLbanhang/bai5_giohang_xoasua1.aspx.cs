using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrầnThếTường9157_QLbanhang
{
    public partial class bai5_giohang_xoasua1 : System.Web.UI.Page
    {
        lopketnoi ketnoi = new lopketnoi();

        protected void ds_donhang_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                int soluong = Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "soluong"));
                double dongia = Convert.ToDouble(DataBinder.Eval(e.Row.DataItem, "dongia"));
                double thanhTien = soluong * dongia;
                Label thanhTienLabel = (Label)e.Row.FindControl("thanhtien");
                thanhTienLabel.Text = thanhTien.ToString();
            }

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["tendangnhap"] != null)
                {
                    string sql = "select * from mathang, donhang where mathang.mahang = donhang.mahang and donhang.tendangnhap like '" + Session["tendangnhap"] + "'";
                    ds_donhang.DataSource = ketnoi.docdulieu(sql);
                    ds_donhang.DataBind();
                    if (ds_donhang.Rows.Count == 0)
                    {
                        ds_donhang = null;
                        Response.Redirect("bai4_giohang.aspx");
                    }
                    else
                    {
                        ds_donhang.DataBind();
                        string sql2 = "select sum(dongia * soluong) from mathang, donhang where mathang.mahang = donhang.mahang and donhang.tendangnhap like '" + Session["tendangnhap"] + "'";
                        DataTable dt = new DataTable();
                        dt = ketnoi.docdulieu(sql2);
                        var tong = dt.Rows[0][0];
                        tongthanhtien.Text = "Tổng thành tiền : " + tong;
                    }
                }
                else
                {
                    Response.Redirect("login.aspx");
                }
            }
        }

        protected void xoa(object sender, EventArgs e)
        {
            Button btnXoa = (Button)sender;
            string mahang = btnXoa.CommandArgument;
            string sql1 = "DELETE FROM donhang WHERE donhang.mahang = " + mahang + " and donhang.tendangnhap like '" + Session["tendangnhap"] + "'";
            ketnoi.capnhat(sql1);
            Response.Redirect("bai5_giohang_xoasua1.aspx");

        }

        protected void sua(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            TextBox textbox_soluong = (TextBox)row.FindControl("textbox_soluong");
            TextBox textbox_mahang = (TextBox)row.FindControl("textbox_mahang");

            if (textbox_soluong != null && textbox_mahang != null)
            {
                string soluong = textbox_soluong.Text;
                string mahang = textbox_mahang.Text;

                string sql3 = "UPDATE donhang SET soluong = " + soluong + " WHERE donhang.mahang = " + mahang + " and donhang.tendangnhap like '" + Session["tendangnhap"] + "'";
                ketnoi.capnhat(sql3);
                //Thread.Sleep(1000);
                Response.Redirect("bai4_giohang.aspx");
            }
        }
    }
}