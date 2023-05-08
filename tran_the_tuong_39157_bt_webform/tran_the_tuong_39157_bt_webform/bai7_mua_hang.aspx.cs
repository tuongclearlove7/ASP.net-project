using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace tran_the_tuong_39157_bt_webform
{
    public partial class bai7_mua_hang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void show_object(object sender, EventArgs e)
        {

            Session["tenhang"] = chon_hang.Text;
            Session["dongia"] = don_gia.Text;
            Session["soluong"] = so_luong.Text;
            Session["doituong"] = doi_tuong.Text;

            ArrayList lists = new ArrayList();
            lists.Add(Session["tenhang"]);
            lists.Add(Session["dongia"]);
            lists.Add(Session["soluong"]);
            lists.Add(Session["doituong"]);
            Session["lists"] = lists;
            string hienThi = "";
            ArrayList sessionLists = Session["lists"] as ArrayList;
            if (sessionLists != null)
            {
                foreach (var item in sessionLists)
                {
                    hienThi += item.ToString() + " ";
                }
            }


            //lbl_hienthi.Text = hienThi;
        }

        protected void mua(object sender, EventArgs e)
        {
            Session["tenhang"] = chon_hang.Text;
            Session["dongia"] = don_gia.Text;
            Session["soluong"] = so_luong.Text;
            Session["doituong"] = doi_tuong.Text;

            ArrayList lists = new ArrayList();
            lists.Add(Session["tenhang"]);
            lists.Add(Session["dongia"]);
            lists.Add(Session["soluong"]);
            lists.Add(Session["doituong"]);
            //Session["lists"] = lists;


            Response.Redirect("bai7_gio_hang.aspx");

        }


        protected void xoa(object sender, EventArgs e)
        {

            Session.Clear();
        }

    }
}