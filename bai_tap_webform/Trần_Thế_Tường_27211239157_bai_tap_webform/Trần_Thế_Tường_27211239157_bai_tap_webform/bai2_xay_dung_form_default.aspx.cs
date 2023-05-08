using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trần_Thế_Tường_27211239157_bai_tap_webform
{
    public partial class bai2_xay_dung_form_default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void next(object sender, EventArgs e)
        {

            label1.Text = "<h1>Trang tiếp</h1>";

        }
        protected void previous(object sender, EventArgs e)
        {

            label1.Text = "<h1>Trang trước</h1>";

        }
        protected void home(object sender, EventArgs e)
        {

            label1.Text = "<h1>Trang chủ</h1>";

        }
    }
}