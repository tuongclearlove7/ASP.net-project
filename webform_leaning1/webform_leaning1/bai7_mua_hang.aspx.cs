using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webform_leaning1
{
    public partial class mua_hang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void mua(object sender, EventArgs e) 
        {

            //Response.Redirect("bai7_gio_hang.aspx?Hang=" + chon_hang.Text + don_gia.Text + so_luong.Text + doi_tuong.Text);
            Session["tenhang"] = chon_hang.Text;
            Session["dongia"] = don_gia.Text;
            Session["soluong"] = so_luong.Text;
            Session["doituong"] = doi_tuong.Text;

            Response.Redirect("bai7_gio_hang.aspx");

        }


        protected void xoa(object sender, EventArgs e)
        {
         
            chon_hang.SelectedIndex = 0;
            don_gia.Text = "";
            so_luong.Text = "";
            doi_tuong.SelectedIndex = 0;
        }


    }
}