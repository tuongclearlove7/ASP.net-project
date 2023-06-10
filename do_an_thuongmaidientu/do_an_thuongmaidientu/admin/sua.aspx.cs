using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace do_an_thuongmaidientu.admin
{
    public partial class sua : System.Web.UI.Page
    {
        Models.ketnoi_database ketnoi = new Models.ketnoi_database();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["tendangnhap"] != null)
            {
                if (Session["tendangnhap"].ToString() == "admin")
                {
                    if (!IsPostBack)
                    {
                        if (Request.QueryString["MatHang"] != null)
                        {
                            string mahang = Request.QueryString["MatHang"];
                            string sql1 = "select * from mathang where mahang = " + mahang + "";
                            DataTable dt = ketnoi.docdulieu(sql1);
                            ds_mathang.DataSource = dt;
                            ds_mathang.DataBind();

                            string sql2 = "select * from loaihang where maloai = " + Request.QueryString["MatHang"] + "";
                            DataTable dt2 = ketnoi.docdulieu(sql2);
                            ds_loaihang.DataSource = dt2;
                            ds_loaihang.DataBind();
                        }
                        else
                        {
                            Response.Redirect("homeAdmin.aspx");
                        }
                    }
                }
                else {
                    Response.Redirect("../user/homeUser.aspx");
                };
            }
            else
            {
                Response.Redirect("../master/loginPage.aspx");
            }
        }



        protected void sua_mathang(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            DataListItem item = (DataListItem)button.NamingContainer;
            TextBox mahang = (TextBox)item.FindControl("mahang");
            TextBox tenhang = (TextBox)item.FindControl("tenhang");
            TextBox mota = (TextBox)item.FindControl("mota");
            TextBox dongia = (TextBox)item.FindControl("dongia");
            TextBox maloai = (TextBox)item.FindControl("mathang_maloai");
            TextBox hinh = (TextBox)item.FindControl("hinh");

            string mahangValue = mahang.Text;
            string tenhangValue = tenhang.Text;
            string motaValue = mota.Text;
            string dongiaValue = dongia.Text;
            string maloaiValue = maloai.Text;
            string hinhValue = hinh.Text;
        }

        protected void sua_loaihang(object sender, EventArgs e)
        {
            foreach (DataList item in ds_loaihang.Items)
            {
                TextBox txt_maloai = item.FindControl("loaihang_maloai") as TextBox;
                TextBox txt_tenloai = item.FindControl("tenloai") as TextBox;
                string maloai = txt_maloai.Text;
                string tenloai = txt_tenloai.Text;
               
            }

        }

    }
}