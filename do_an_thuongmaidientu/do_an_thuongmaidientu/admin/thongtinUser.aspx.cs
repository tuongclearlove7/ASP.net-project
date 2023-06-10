using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace do_an_thuongmaidientu.admin
{
    public partial class thongtinUser : System.Web.UI.Page
    {
        Models.ketnoi_database ketnoi = new Models.ketnoi_database();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["tendangnhap"] != null)
            {
                if (Session["tendangnhap"].ToString() == "admin")
                {
                    string sql = "select * from khachhang";
                    ds_user.DataSource = ketnoi.docdulieu(sql);
                    ds_user.DataBind();
                }
                else {
                    Response.Redirect("../user/homeUser.aspx");
                }
            }
            else
            {
                Response.Redirect("../master/loginPage.aspx");
            }

        }
    }
}