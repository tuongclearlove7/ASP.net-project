using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace doan_thuongmaidientu.Controller
{
    public partial class homeController : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string action = HttpContext.Current.Request.Form["action"];
            if (string.IsNullOrEmpty(action))
            {
                action = HttpContext.Current.Request.QueryString["action"];
                if (string.IsNullOrEmpty(action))
                {
                    action = "show_admin_menu";
                }
            }

            switch (action) {
                case "show_admin_menu":
                    Response.Redirect("./view/home/home.aspx");
                    break;

            }


        }



    }
}