using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace do_an_thuongmaidientu.user
{
    public partial class thongtin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Session["tendangnhap"] != null)
                {

                    tentaikhoan.Text = "Tên đăng nhập : " + Session["tendangnhap"].ToString().Trim();
                }
                else
                {
                    Response.Redirect("../master/loginPage.aspx");
                }
            }

        }
    }
}