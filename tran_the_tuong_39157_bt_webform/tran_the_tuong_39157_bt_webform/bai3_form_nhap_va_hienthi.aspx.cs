﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tran_the_tuong_39157_bt_webform
{
    public partial class bai3_form_nhap_va_hienthi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void hien_thi(object sender, EventArgs e)
        {

            label_hienthi.Text = "<h1>Chào bạn : " + txtName.Text + " học lớp : " + txtLop.Text + "</h1>";

        }
    }
}