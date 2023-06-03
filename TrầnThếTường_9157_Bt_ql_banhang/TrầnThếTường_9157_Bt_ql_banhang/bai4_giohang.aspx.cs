using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrầnThếTường_9157_Bt_ql_banhang
{
    public partial class bai4_giohang : System.Web.UI.Page
    {
        lopketnoi ketnoi = new lopketnoi();

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
            string connectionVsDB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Server.MapPath("/App_Data/banhang.mdf") + ";Integrated Security=True";
            // string connectionSQLServer = "server=DESKTOP-9ER0ESK\\SQLEXPRESS;database=ban_hang;User ID=sa;Password=tuongyeuthao1";
            string sql = "select * from mathang, donhang where mathang.mahang = donhang.mahang";
            ds_donhang.DataSource = ketnoi.docdulieu(connectionVsDB, sql);
            ds_donhang.DataBind();
            string sql2 = "select sum(dongia * soluong) from mathang, donhang where mathang.mahang = donhang.mahang";
            DataTable dt = new DataTable();
            dt = ketnoi.docdulieu(connectionVsDB, sql2);
            var tong = dt.Rows[0][0];
            tongthanhtien.Text = "Tổng thành tiền : " + tong;


        }
    }
}