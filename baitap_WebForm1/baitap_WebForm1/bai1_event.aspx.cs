using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace baitap_WebForm1
{
    public partial class bai1_event : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void capnhat_update(object sender, EventArgs e)
        {

            Button btt = (Button)sender;

            switch (btt.ID)
            {
                case "btn_ten":
                    hienthi_ten.Text = "Chào bạn tên là : " + txtName.Text;
                    break;
                case "btn_lop":
                    hienthi_lop.Text = "lớp : " + txtLop.Text;
                    break;
            }


        }


    }
}