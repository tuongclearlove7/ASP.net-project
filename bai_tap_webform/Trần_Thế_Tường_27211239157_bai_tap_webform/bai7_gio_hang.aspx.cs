using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace Trần_Thế_Tường_27211239157_bai_tap_webform
{
    public partial class bai7_gio_hang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["tenhang"] != null && Session["dongia"] != null &&
                    Session["soluong"] != null && Session["doituong"] != null)
                {
                    try
                    {
                        string tenhang = Session["tenhang"].ToString();
                        int dongia = Convert.ToInt32(Session["dongia"]);
                        int soluong = Convert.ToInt32(Session["soluong"]);
                        string doituong = Session["doituong"].ToString();
                        double thanh_tien;
                        lbl_tenhang.Text = tenhang;
                        lbl_dongia.Text = dongia.ToString();
                        lbl_soluong.Text = soluong.ToString();

                        if (doituong == "Giảm giá")
                        {
                            double giam_gia = dongia * 0.1;
                            thanh_tien = (dongia - giam_gia) * soluong;
                            doituong = "10%";
                            lbl_doituong.Text = doituong;
                            lbl_thanhtien.Text = thanh_tien.ToString();
                        }
                        else
                        {
                            thanh_tien = dongia * soluong;
                            lbl_doituong.Text = doituong;
                            lbl_thanhtien.Text = thanh_tien.ToString();
                        }

                    }
                    catch (Exception error)
                    {

                        Response.Redirect("bai7_mua_hang.aspx");
                    }


                }
                else
                {
                    Response.Redirect("bai7_mua_hang.aspx");
                }
            }

        }
    }
}