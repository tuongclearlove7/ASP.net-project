﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tran_the_tuong_39157_bt_webform
{
    public partial class bai6_gian_hang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void click_ao_quan(object sender, EventArgs e)
        {
            Response.Redirect("bai6_chi_tiet.aspx?GianHang=Aoquan");
        }

        protected void click_giay_dep(object sender, EventArgs e)
        {
            Response.Redirect("bai6_chi_tiet.aspx?GianHang=Giaydep");
        }

        protected void click_tui_xach(object sender, EventArgs e)
        {
            Response.Redirect("bai6_chi_tiet.aspx?GianHang=Tuixach");
        }

    }
}