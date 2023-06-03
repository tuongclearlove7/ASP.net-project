using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrầnThếTường_9157_Bt_ql_banhang
{
    public partial class bai1_login : System.Web.UI.UserControl
    {
        lopketnoi ketnoi = new lopketnoi();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected bool kiemtra(string tendangnhap, string matkhau)
        {
            // string connectionSQLServer = "server=DESKTOP-9ER0ESK\\SQLEXPRESS;database=ban_hang;User ID=sa;Password=tuongyeuthao1";
            string connectionVsDB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Server.MapPath("/App_Data/banhang.mdf") + ";Integrated Security=True";
            string sql = "select * from khachhang";
            ketnoi.docdulieu(connectionVsDB, sql);
            DataTable dt = ketnoi.docdulieu(connectionVsDB, sql);

            if (dt.Rows[0]["tendangnhap"].ToString() == tendangnhap &&
                dt.Rows[0]["matkhau"].ToString() == matkhau)
                return true;
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

                dangnhap_thanhcong.Text = "Đăng nhập thành công tên đăng nhập đã đc lưu vào session và cookie<br>"
                + "Session : " + Session["tendangnhap"] + "<br>Cookie : " + valueCookie;
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