using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace do_an_thuongmaidientu.user
{
    public partial class giohang : System.Web.UI.Page
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

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["tendangnhap"] != null)
                {
                    string sql2 = "select * from mathang, donhang where mathang.mahang = donhang.mahang and donhang.tendangnhap like '" + Session["tendangnhap"] + "'" + " order by mathang.dongia asc";
                    ds_donhang.DataSource = ketnoi.docdulieu(sql2);
                    ds_donhang.DataBind();
                    if (ds_donhang.Rows.Count == 0)
                    {
                        ds_donhang = null;
                        tongthanhtien.Text = "Không đơn hàng nào";
                    }
                    else
                    {
                        ds_donhang.DataBind();
                        string sql3 = "select sum(dongia * soluong) from mathang, donhang where mathang.mahang = donhang.mahang and donhang.tendangnhap like '" + Session["tendangnhap"] + "'";
                        DataTable dt = new DataTable();
                        dt = ketnoi.docdulieu(sql3);
                        var tong = dt.Rows[0][0];
                        tongthanhtien.Text = "Tổng thành tiền : " + tong;
                        string sql_count = "select count(*) from mathang, donhang where mathang.mahang = donhang.mahang and donhang.tendangnhap like '" + Session["tendangnhap"] + "'";
                        DataTable dt_count = new DataTable();
                        dt_count = ketnoi.docdulieu(sql_count);
                        var count = dt_count.Rows[0][0];
                        dem_sodon.Text = "Số đơn hàng " + count;
                    }
                }
                else
                {
                    Response.Redirect("../master/loginPage.aspx");
                }
            }
        }


    }
}