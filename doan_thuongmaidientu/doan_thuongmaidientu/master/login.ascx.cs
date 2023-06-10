using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace doan_thuongmaidientu.master
{
    public partial class login1 : System.Web.UI.UserControl
    {
        Models.ketnoi_database ketnoi = new Models.ketnoi_database();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected bool kiemtra(string tendangnhap, string matkhau)
        {
            string sql = "select * from khachhang";
            ketnoi.docdulieu(sql);
            DataTable dt = ketnoi.docdulieu(sql);

            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["tendangnhap"].ToString() == tendangnhap &&
                        dt.Rows[i]["matkhau"].ToString() == matkhau)
                        return true;
                }
            }
            if (dt.Rows.Count == 0)
            {
                dt = null;
                Thread.Sleep(1000);
            }

            return false;
        }

        protected void kiemtra_dangnhap(object sender, EventArgs e)
        {
            if (kiemtra(tendangnhap.Text, matkhau.Text))
            {

                Session["tendangnhap"] = tendangnhap.Text;
                Session["matkhau"] = matkhau.Text;
                HttpCookie cookie_tendangnhap = new HttpCookie("tendangnhap");
                cookie_tendangnhap.Value = tendangnhap.Text;
                cookie_tendangnhap.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(cookie_tendangnhap);
                string valueCookie = cookie_tendangnhap.Value;
                //Response.Redirect("bai2_mathang.aspx");
                Server.Transfer("./view/home/home.aspx");
                //dangnhap_thanhcong.Text = "Đăng nhập thành công tên đăng nhập đã đc lưu vào session và cookie<br>"
                //+ "Session tên đăng nhập : " + Session["tendangnhap"] + "<br>Cookie tên đăng nhập : " + valueCookie;
            }
            else
            {
                dangnhap_thanhcong.Text = "dang nhap that bai";
                Session.Clear();
                HttpCookie cookie_tendangnhap = Request.Cookies["tendangnhap"];
                if (cookie_tendangnhap != null)
                {
                    cookie_tendangnhap.Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies.Add(cookie_tendangnhap);
                }
            }

        }



    }
}