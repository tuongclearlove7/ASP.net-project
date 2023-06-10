using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace do_an_thuongmaidientu.master
{
    public partial class admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["tendangnhap"] != null)
            {
                if (Session["tendangnhap"].ToString() == "admin")
                    account.Text = Session["tendangnhap"].ToString();
                else account.Text = "User " + Session["tendangnhap"].ToString();
            }
        }

        protected void dangxuat(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Session.Clear();
            HttpCookie cookie_tendangnhap = Request.Cookies["tendangnhap"];
            cookie_tendangnhap.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(cookie_tendangnhap);
            Response.Redirect("../master/loginPage.aspx");
        }
        protected void chuyen_trang(object sender, EventArgs e)
        {
            Response.Redirect("../admin/donhang.aspx");
        }

        protected void res_homepage(object sender, EventArgs e)
        {
            if (Session["tendangnhap"].ToString() == "admin")
            {
                Response.Redirect("../admin/homeAdmin.aspx");
            }
            else
            {
                Response.Redirect("../user/homeUser.aspx");
            }
        }


    }
}