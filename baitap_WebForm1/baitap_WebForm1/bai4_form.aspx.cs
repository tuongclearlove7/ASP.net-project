using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace baitap_WebForm1
{
    public partial class bai4_form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void customValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
         

            
        }
        protected void kiem_loi(object sender, EventArgs e)
        {
            Page.Validate();

            if (Page.IsValid)
            {
                hienthi.Text = "";
                hienthi_xacthuc.Text = "";
                hienthi_diem.Text = "";
                hienthi_tuoi.Text = "";

            }
            else
            {
                hienthi.Text = HienthiLoi(RegularExpressionValidator1);
                hienthi_xacthuc.Text = HienthiLoi(CompareValidator1);
                hienthi_diem.Text = HienthiLoi(RangeValidator1);
                //hienthi_tuoi.Text = HienthiLoi(CustomValidator1);

            }
        }

        private string HienthiLoi(BaseValidator validator)
        {
            if (!validator.IsValid)
            {
                return "<li>" + validator.ErrorMessage + "</li>";
            }

            return "";
        }




    }
}