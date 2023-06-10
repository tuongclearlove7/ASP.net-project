using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace do_an_thuongmaidientu.admin
{
    public partial class timkiem : System.Web.UI.Page
    {
        Models.ketnoi_database ketnoi = new Models.ketnoi_database();

        protected void ds_donhang_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                int soluong = Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "soluong"));
                double dongia = Convert.ToDouble(DataBinder.Eval(e.Row.DataItem, "dongia"));
                double thanhTien = soluong * dongia;
                Label thanhTienLabel = (Label)e.Row.FindControl("thanhtien");
                thanhTienLabel.Text = thanhTien.ToString();
            }
        }

        protected void xoa(object sender, EventArgs e)
        {

            Button btnXoa = (Button)sender;
            string mahang = btnXoa.CommandArgument;
            string sql1 = "DELETE FROM donhang WHERE donhang.mahang = " + mahang;
            ketnoi.capnhat(sql1);
            Response.Redirect("timkiem.aspx?donhang=" + Request.QueryString["donhang"]);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["tendangnhap"] != null)
            {
                if (Session["tendangnhap"].ToString() == "admin")
                {

                    if (Request.QueryString["donhang"] != null)
                    {
                        string tendangnhap = Request.QueryString["donhang"];
                        string sql = "SELECT * FROM mathang, donhang WHERE mathang.mahang = donhang.mahang and donhang.tendangnhap = '" + tendangnhap + "' order by mathang.dongia asc";
                        ds_donhang.DataSource = ketnoi.docdulieu(sql);
                        ds_donhang.DataBind();

                        ds_donhang.DataBind();
                        string sql3 = "select sum(dongia * soluong) from mathang, donhang where mathang.mahang = donhang.mahang and donhang.tendangnhap = '" + tendangnhap + "'";
                        DataTable dt = new DataTable();
                        dt = ketnoi.docdulieu(sql3);
                        var tong = dt.Rows[0][0];
                      
                        string sql_count = "select count(*) from mathang, donhang where mathang.mahang = donhang.mahang and donhang.tendangnhap = '" + tendangnhap + "'";
                        DataTable dt_count = new DataTable();
                        dt_count = ketnoi.docdulieu(sql_count);
                        var count = dt_count.Rows[0][0];
                        dem_sodon.Text = "Số đơn hàng " + count;
                        tongthanhtien.Text = "Tổng thành tiền : " + tong;
                       
                    }
                    else
                    {
                        Response.Redirect("../admin/homeAdmin.aspx");
                    } 
                }
                else
                {
                    Response.Redirect("../user/homeUser.aspx");
                }
            }
            else
            {
                Response.Redirect("../master/loginPage.aspx");
            }

        }
    }
}