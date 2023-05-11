using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace baitap_webform
{
    public partial class bai1_event : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void hienthi(object sender, EventArgs e)
        {

            lbl_hienthi.Text = chon.Text;
        }

        protected void capnhat(object sender, EventArgs e)
        {

            Button btt = (Button)sender;
            if (btt.ID == "btn_them")
            {
                lbl_hienthi.Text = "<h1>them moi</h1>";
            }
            else if (btt.ID == "btn_sua")
            {
                lbl_hienthi.Text = "<h1>chỉnh sửa</h1>";
            }
            else
            {
                lbl_hienthi.Text = "<h1>xóa</h1>";
            }

        }


        protected void capnhat_update(object sender, EventArgs e)
        {

            Button btt = (Button)sender;
            if (btt.ID == "btn_ten")
            {
                hienthi_ten.Text = "Chào bạn tên là : " + txtName.Text;
            }
            else if (btt.ID == "btn_lop")
            {
                hienthi_lop.Text = "lớp : " + txtLop.Text;
            }


        }




    }
}