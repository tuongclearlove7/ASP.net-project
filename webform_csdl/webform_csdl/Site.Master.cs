using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace webform_csdl
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionVsDB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Server.MapPath("/App_Data/ban_hang.mdf") + ";Integrated Security=True";
            string connectionSQLServer = "server=DESKTOP-9ER0ESK\\SQLEXPRESS;database=baitap1;User ID=sa;Password=tuongyeuthao1";

            lopketnoi ketnoi = new lopketnoi();
            string sql1 = "select * from sanpham";
            ketnoi.docdulieu(connectionVsDB, sql1);
            DataTable dt = ketnoi.docdulieu(connectionVsDB, sql1);
            //data1.DataSource = dt;
            //data1.DataBind();
        }


    }
}