using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace do_an_thuongmaidientu.admin
{
    public partial class homeAdmin : System.Web.UI.Page
    {
        Models.ketnoi_database ketnoi = new Models.ketnoi_database();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["tendangnhap"] != null)
                {
                    string sql = "select * from loaihang, mathang where loaihang.maloai = mathang.maloai";
                    ds_mathang.DataSource = ketnoi.docdulieu(sql);
                    ds_mathang.DataBind();
                }
                else
                {
                    Response.Redirect("../master/loginPage.aspx");
                }
            }
        }

        protected void xoa(object sender, EventArgs e)
        {
            Button btnXoa = (Button)sender;
            string mahang = btnXoa.CommandArgument;
            string sql1 = "DELETE FROM mathang WHERE mathang.mahang = " + mahang;
            ketnoi.capnhat(sql1);
            Response.Redirect("homeAdmin.aspx");

        }

    }
}