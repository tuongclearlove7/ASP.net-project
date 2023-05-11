using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace baitap_webform
{
    public partial class bai2_hoa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tinh_tien(object sender, EventArgs e)
        {
            int sum = 0;

            foreach (ListItem item in checkboxList.Items)
            {
                if (item.Selected)
                {
                    switch (item.Value)
                    {
                        case "hong":
                            sum += 15000;
                            break;
                        case "tulip":
                            sum += 30000;
                            break;
                        case "thuy_tien":
                            sum += 25000;
                            break;
                    }
                }
            }

            don_gia.Text = "Phải trả " + sum.ToString();


        }


    }
}