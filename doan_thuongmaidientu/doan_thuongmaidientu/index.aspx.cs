using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace doan_thuongmaidientu
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string controller = HttpContext.Current.Request.Form["controller"];
            if (string.IsNullOrEmpty(controller))
            {
                controller = HttpContext.Current.Request.QueryString["controller"];
                if (string.IsNullOrEmpty(controller))
                {
                    controller = "homeController";
                }
            }


            switch (controller) {
   
            case "homeController":
                    Server.Transfer("./controller/homeController.aspx");
                break;
            //case "homeController":
            //    Server.Transfer("./controller/homeController.aspx");
            //    break;

            }


        }
    }
}