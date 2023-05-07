using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webform_leaning1
{
    public partial class bai7_gio_hang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["tenhang"] != null && Session["dongia"] != null && 
                    Session["soluong"] != null && Session["doituong"] != null)
                {
                    string tenhang = Session["tenhang"].ToString();
                    int dongia = Convert.ToInt32(Session["dongia"]);
                    int soluong = Convert.ToInt32(Session["soluong"]);
                    string doituong = Session["doituong"].ToString();

                    lbl_tenhang.Text = tenhang;
                    lbl_dongia.Text = dongia + "";
                    lbl_soluong.Text = soluong + "";
                    lbl_soluong.Text = doituong;

                }
                else
                {
                    Response.Redirect("bai7_mua_hang.aspx");
                }
            }

        }
    }
}