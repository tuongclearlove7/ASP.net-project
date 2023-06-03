using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace webform_csdl
{
    public partial class danhsachsp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string connectionVsDB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Server.MapPath("/App_Data/ql_banhang.mdf") + ";Integrated Security=True";

            if (!IsPostBack)
            {
                lopketnoi kn = new lopketnoi();
                string sql1 = "select * from mathang, loaihang where mathang.maloai = loaihang.maloai";
                DataTable dt = kn.docdulieu(connectionVsDB, sql1);
                bang_mathang.DataSource = dt;
                bang_mathang.DataBind();
                data_list1.DataSource = dt;
                data_list1.DataBind();
            }

        }

        protected void xoa(object sender, EventArgs e)
        {

            string connectionVsDB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Server.MapPath("/App_Data/ql_banhang.mdf") + ";Integrated Security=True";
            string connectionSQLServer = "server=DESKTOP-9ER0ESK\\SQLEXPRESS;database=ban_hang;User ID=sa;Password=tuongyeuthao1";
            Button btnXoa = (Button)sender;
            string mahang = btnXoa.CommandArgument;
            string sql1 = "DELETE FROM mathang WHERE mahang = '" + mahang + "'";
            lopketnoi kn = new lopketnoi();
            DataTable dt = kn.docdulieu(connectionVsDB, sql1);
            kn.docdulieu(connectionSQLServer, sql1);
            bang_mathang.DataSource = dt;
            bang_mathang.DataBind();
            Response.Redirect("danhsachsp.aspx?");
            
        }

    }


}