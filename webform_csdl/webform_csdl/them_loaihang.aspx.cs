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

        protected void them(object sender, EventArgs e)
        {
            string connectionVsDB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Server.MapPath("/App_Data/ql_banhang.mdf") + ";Integrated Security=True";
            lopketnoi kn = new lopketnoi();
            string sql1 = "INSERT INTO loaihang(maloai, tenloai, hinh)" +
               "VALUES(" + maloai.Text + ", '" + tenloai.Text + "', '" + hinhanh.Text + "'" +
               ")";
            DataTable dt = kn.docdulieu(connectionVsDB, sql1);
            Response.Redirect("ds_loaihang.aspx");
        }
    }
}