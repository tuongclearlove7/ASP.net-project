using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm
{
    public partial class chi_tiet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["GianHang"] != null)
                {
                    string hangHoa = Request.QueryString["GianHang"];

                    switch (hangHoa)
                    {
                        case "Aoquan":
                            lblAoquan.Text = "Áo quần";
                            break;
                        case "Giaydep":
                            lblAoquan.Text = "Giày dép";
                            break;
                        case "Tuixach":
                            lblTuixach.Text = "Túi xách";
                            break;
                        default:
                            Response.Redirect("gian_hang.aspx");
                            break;
                    }
                }
                else
                {
                    Response.Redirect("gian_hang.aspx");
                }
            }


        }
    }
}