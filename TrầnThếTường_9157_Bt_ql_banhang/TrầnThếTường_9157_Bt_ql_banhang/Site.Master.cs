using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrầnThếTường_9157_Bt_ql_banhang
{
    public partial class Site : System.Web.UI.MasterPage
    {
        lopketnoi ketnoi = new lopketnoi();

        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionVsDB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Server.MapPath("/App_Data/banhang.mdf") + ";Integrated Security=True";
           // string connectionSQLServer = "server=DESKTOP-9ER0ESK\\SQLEXPRESS;database=ban_hang;User ID=sa;Password=tuongyeuthao1";
            string sql = "select * from loaihang";
            ds_loaihang.DataSource = ketnoi.docdulieu(connectionVsDB,sql);
            ds_loaihang.DataBind();
        }
    }
}