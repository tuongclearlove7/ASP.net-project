using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace baitap_WebForm1
{
    public partial class bai3_tinhluong : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tinh_luong(object sender, EventArgs e)
        {
            try
            {

                double luong = Convert.ToDouble(tien_luong.Text);
                double luong_thuclinh = 0;
                double luong_heso;
                double tien_bhxh;
                double tien_bhyt;
                double heso = Convert.ToDouble(he_soluong.Text);
                foreach (ListItem item in radiobuttonlist.Items)
                {

                    if (item.Selected)
                    {
                        switch (item.Value)
                        {
                            case "vnd":

                                luong_heso = heso * 840000;
                                hienthi.Text = "<h1>Bảng tính lương tháng " + chon.Text + "</h1>";
                                hienthi_luong.Text = "Lương theo hệ số : " + luong_heso.ToString();

                                foreach (ListItem item_checkbox in checkbox.Items)
                                {

                                    if (item_checkbox.Selected)
                                    {
                                        switch (item_checkbox.Value)
                                        {
                                            case "bhxh":
                                                tien_bhxh = luong_heso * 0.05;
                                                luong_thuclinh = luong_heso - tien_bhxh;
                                                hienthi_luong_bhxh.Text = "Trừ bảo hiểm xã hội : " + tien_bhxh;

                                                break;
                                            case "bhyt":
                                                tien_bhxh = luong_heso * 0.05;
                                                tien_bhyt = luong_heso * 0.01;
                                                luong_thuclinh = luong_heso - tien_bhxh - tien_bhyt;
                                                hienthi_luong_bhyt.Text = "Trừ bảo hiểm y tế : " + tien_bhyt;

                                                break;

                                        }
                                    }
                                }

                                thuc_nhan.Text = "<h3 style='color:red;'>Thực nhận : " + luong_thuclinh + " USD </h3>";

                                break;
                            case "usd":

                                double usd = luong / 20000;
                                luong_heso = usd * heso * (840000 / 20000);

                                tien_usd.Text = "USD " + usd.ToString() + " = ";
                                hienthi.Text = "<h1>Bảng tính lương tháng " + chon.Text + "</h1>";
                                hienthi_luong.Text = "Lương theo hệ số : " + luong_heso.ToString();

                                foreach (ListItem item_checkbox in checkbox.Items)
                                {

                                    if (item_checkbox.Selected)
                                    {
                                        switch (item_checkbox.Value)
                                        {
                                            case "bhxh":
                                                tien_bhxh = luong_heso * 0.05;
                                                luong_thuclinh = luong_heso - tien_bhxh;
                                                hienthi_luong_bhxh.Text = "Trừ bảo hiểm xã hội : " + tien_bhxh;

                                                break;
                                            case "bhyt":
                                                tien_bhxh = luong_heso * 0.05;
                                                tien_bhyt = luong_heso * 0.01;
                                                luong_thuclinh = luong_heso - tien_bhxh - tien_bhyt;
                                                hienthi_luong_bhyt.Text = "Trừ bảo hiểm y tế : " + tien_bhyt;

                                                break;

                                        }
                                    }
                                }

                                thuc_nhan.Text = "<h3 style='color:red;'>Thực nhận : " + luong_thuclinh + " USD </h3>";
                                break;
                        }
                    }
                }

            }
            catch (Exception error)
            {
                hienthi.Text = "Vui lòng thao tác và nhập vào số!";

            }


        }



    }
}