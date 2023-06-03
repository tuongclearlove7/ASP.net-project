using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webform_csdl
{
    public partial class them_loaihang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void themmoi_loaihang(object sender, EventArgs e)
        {
            string connectionVsDB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Server.MapPath("/App_Data/ql_banhang.mdf") + ";Integrated Security=True";
            string connectionSQLServer = "server=DESKTOP-9ER0ESK\\SQLEXPRESS;database=ban_hang;User ID=sa;Password=tuongyeuthao1";
            lopketnoi kn = new lopketnoi();
            string sql1 = "INSERT INTO loaihang(maloai, tenloai, hinh) " +
             "VALUES(" + maloai_loaihang.Text + ", N'" + tenloai.Text + "', N'" + hinh_loaihang.Text + "')";
            DataTable dt = kn.docdulieu(connectionVsDB, sql1);
            kn.docdulieu(connectionSQLServer, sql1);
            Response.Redirect("ds_loaihang.aspx");
        }


        protected void themmoi_mathang(object sender, EventArgs e)
        {
            string connectionVsDB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Server.MapPath("/App_Data/ql_banhang.mdf") + ";Integrated Security=True";
            string connectionSQLServer = "server=DESKTOP-9ER0ESK\\SQLEXPRESS;database=ban_hang;User ID=sa;Password=tuongyeuthao1";
            lopketnoi kn = new lopketnoi();
            string sql1 = "INSERT INTO mathang(mahang, tenhang, mota, dongia, maloai, hinh)" +
              "VALUES('" + mahang.Text + "', '" + tenhang.Text + "', '" + mota.Text + "', '" + dongia.Text + "', '" + maloai_mathang.Text + "', '" + hinh_mathang.Text + "')";
            DataTable dt = kn.docdulieu(connectionVsDB, sql1);
            kn.docdulieu(connectionSQLServer, sql1);

            Response.Redirect("danhsachsp.aspx");
        }
    }
}