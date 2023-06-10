using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrầnThếTường9157_QLbanhang
{
    public partial class bai2_mathang : System.Web.UI.Page
    {
        lopketnoi ketnoi = new lopketnoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["tendangnhap"] != null)
                {
                    account.Text = "Hello " + Session["tendangnhap"] + " Welcome to Shop page!!!";
                    string sql = "select * from mathang";
                    ds_mathang.DataSource = ketnoi.docdulieu(sql);
                    ds_mathang.DataBind();
                }
                else
                {
                    Response.Redirect("login.aspx");
                }
            }
        }
    
        protected void dangxuat(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Session.Clear();
            HttpCookie cookie_tendangnhap = Request.Cookies["tendangnhap"];
            cookie_tendangnhap.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(cookie_tendangnhap);
            Response.Redirect("login.aspx");
        }

    }
}