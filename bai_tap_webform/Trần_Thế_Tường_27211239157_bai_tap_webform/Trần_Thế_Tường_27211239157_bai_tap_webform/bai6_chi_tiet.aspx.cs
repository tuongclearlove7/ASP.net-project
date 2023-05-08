using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trần_Thế_Tường_27211239157_bai_tap_webform
{
    public partial class bai6_chi_tiet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["GianHang"] != null)
                {
                    string GianHang = Request.QueryString["GianHang"];
                    string image_ao_quan = "<img src='./Content/image/quan_ao.jpg'/>";
                    string image_giay_dep = "<img src='./Content/image/giay_dep.jpg'/>";
                    string image_tui_xach = "<img src='./Content/image/tui_xach.jpg'/>";

                    switch (GianHang)
                    {
                        case "Aoquan":
                            lblAoquan.Text = "<h1>Áo quần</h1><br>" + image_ao_quan;
                            break;
                        case "Giaydep":
                            lblGiaydep.Text = "<h1>Giày dép</h1>" + image_giay_dep;
                            break;
                        case "Tuixach":
                            lblTuixach.Text = "<h1>Túi xách</h1>" + image_tui_xach;
                            break;
                        default:
                            Response.Redirect("bai6_gian_hang.aspx");
                            break;
                    }
                }
                else
                {
                    Response.Redirect("bai6_gian_hang.aspx");
                }
            }

        }

    }
}