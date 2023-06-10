using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace do_an_thuongmaidientu.admin
{
    public partial class them : System.Web.UI.Page
    {
        Models.ketnoi_database ketnoi = new Models.ketnoi_database();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["tendangnhap"] != null)
            {
                if (Session["tendangnhap"].ToString() == "admin")
                    return;
                else Response.Redirect("../user/homeUser.aspx");
            }
            else
            {
                Response.Redirect("../master/loginPage.aspx");
            }
        }

        protected void themmoi_loaihang(object sender, EventArgs e)
        {
           
            
            string sql1 = "INSERT INTO loaihang(maloai, tenloai) " +
             "VALUES(" + maloai_loaihang.Text + ", '" + tenloai.Text + "')";
            ketnoi.capnhat(sql1);
            themmoi_thanhcong.Text = "<p style='color:green;'>Thêm mới thành công</p>";
           // Response.Redirect("homeAdmin.aspx");
        }


        protected void themmoi_mathang(object sender, EventArgs e)
        {
           
            string sql1 = "INSERT INTO mathang(mahang, tenhang, mota, dongia, hinh, maloai)" +
              "VALUES(" + mahang.Text + ", '" + tenhang.Text + "', '" + mota.Text + "' ," + dongia.Text + ", '"+ hinh_mathang.Text +"' ," + maloai_mathang.Text + ")";
            ketnoi.capnhat(sql1);
            Response.Redirect("homeAdmin.aspx");
        }
    }
}