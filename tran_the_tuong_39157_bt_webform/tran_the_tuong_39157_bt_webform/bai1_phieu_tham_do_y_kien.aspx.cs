using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tran_the_tuong_39157_bt_webform
{
    public partial class bai1_phieu_tham_do_y_kien : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void hien_thi(object sender, EventArgs e)
        {
            string gender = gioitinh.SelectedValue;
            string result = "";

            foreach (ListItem item in checkbox.Items)
            {
                if (item.Selected)
                {
                    result += item.Text + ", ";
                }
            }

            if (!string.IsNullOrEmpty(result))
            {
                result = result.TrimEnd(',', ' ');
            }

            label_hienthi.Text = "Họ và tên : " + hoten.Text + "<br>" + "Giới tính : " + gender + "<br>" +
                                 "Dùng internet để : " + result;

        }
    }
}