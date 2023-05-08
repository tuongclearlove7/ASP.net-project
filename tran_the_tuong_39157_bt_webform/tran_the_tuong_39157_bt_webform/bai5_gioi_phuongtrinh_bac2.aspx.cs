using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tran_the_tuong_39157_bt_webform
{
    public partial class bai5_gioi_phuongtrinh_bac2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void giaiPhuongtrinh(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(he_so_a.Text);
                int b = Convert.ToInt32(he_so_b.Text);
                int c = Convert.ToInt32(he_so_c.Text);

                if (a == 0)
                {
                    if (b == 0)
                    {
                        if (c == 0)
                        {
                            label_hienthi.Text = "Phương trình vô nghiệm";
                        }
                        else
                        {
                            label_hienthi.Text = "Phương trình vô nghiệm";
                        }
                    }
                    else
                    {
                        double X = -c / b;
                        label_hienthi.Text = "Phương trình có một nghiệm: x = " + X;
                    }
                }
                else
                {
                    double delta = b * b - 4 * a * c;

                    if (delta > 0)
                    {
                        double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                        double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                        label_hienthi.Text = "Phương trình có hai nghiệm" + " x = " + x1 + " và " + "x = " + x2;
                    }
                    else if (delta == 0)
                    {

                        label_hienthi.Text = "Phương trình có một nghiệm";
                    }
                    else
                    {
                        label_hienthi.Text = "Phương trình vô nghiệm";
                    }
                }

            }
            catch (Exception Error)
            {
                label_hienthi.Text = "Vui lòng nhập vào 1 số nguyên!";
            }



        }
    }
}