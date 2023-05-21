using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tran_the_tuong_39157_bt_webform
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




        //private bool isValidEmail(string email)
        //{
        //    try
        //    {
        //        var address = new System.Net.Mail.MailAddress(email);
        //        return address.Address == email;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        //protected void kiemtra_loi(object sender, EventArgs e)
        //{

        //    try
        //    {
        //        double point = Convert.ToDouble(diem.Text);
        //        DateTime ngaySinh;

        //        if (isValidEmail(email.Text))
        //            hienthi.Text = "";
        //        else
        //            hienthi.Text = "<h3>Vui lòng khắc phục các lỗi sau</h3><br>"
        //                                + "<li>Email không đúng định dạng</li>";

        //        if (xac_thuc_email.Text != email.Text)
        //            hienthi_xacthuc.Text = "<li>Xác nhận không giống email</li>";
        //        else
        //            hienthi_xacthuc.Text = "";

        //        if (DateTime.TryParseExact(ngaysinh.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaySinh))
        //        {
        //            DateTime ngayHienTai = DateTime.Now;
        //            int tuoi = ngayHienTai.Year - ngaySinh.Year;

        //            if (ngayHienTai < ngaySinh.AddYears(tuoi))
        //                tuoi--;

        //            if (tuoi < 16)
        //                hienthi_tuoi.Text = "<li>Ngày sinh phải trên 16 tuổi</li>";
        //        }
        //        else
        //        {
        //            hienthi_tuoi.Text = "<li>Ngày tháng năm sinh không hợp lệ!</li>";
        //        }

        //        if (point > 10)
        //            hienthi_diem.Text = "<li>Điểm phải từ 0 đến 10</li>";

        //    }
        //    catch (Exception error)
        //    {
        //        hienthi.Text = "Vui lòng nhập vào!";
        //    }



        //}


    }


    }