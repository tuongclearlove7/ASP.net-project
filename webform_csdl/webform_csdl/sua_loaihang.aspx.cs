using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webform_csdl
{
    public partial class sua_loaihang : System.Web.UI.Page

   
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionVsDB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Server.MapPath("/App_Data/ql_banhang.mdf") + ";Integrated Security=True";
            string connectionSQLServer = "server=DESKTOP-9ER0ESK\\SQLEXPRESS;database=ban_hang;User ID=sa;Password=tuongyeuthao1";

            if (!IsPostBack)
            {
                if (Request.QueryString["loaihang"] != null)
                {
                    string maloai = Request.QueryString["loaihang"];

                    lopketnoi kn = new lopketnoi();
                    string sql1 = "select * from loaihang where maloai = " + maloai;
                    DataTable dt = kn.docdulieu(connectionVsDB, sql1);
                    DataList1.DataSource = dt;
                    DataList1.DataBind();
                }
                else
                {
                    Response.Redirect("ds_loaihang.aspx");
                }
            }

        }
        protected void sua(object sender, EventArgs e)
        {
            string connectionVsDB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Server.MapPath("/App_Data/ql_banhang.mdf") + ";Integrated Security=True";
            Button button = (Button)sender;
            DataListItem item = (DataListItem)button.NamingContainer;
            TextBox maloai = (TextBox)item.FindControl("maloai");
            TextBox tenloai = (TextBox)item.FindControl("tenloai");
            TextBox hinh = (TextBox)item.FindControl("hinh");

            string maloaiValue = maloai.Text;
            string tenloaiValue = tenloai.Text;
            string hinhValue = hinh.Text;

            lopketnoi kn = new lopketnoi();
            string sql1 = "update loaihang " +
                          "set tenloai = '" + tenloaiValue + "', " +
                          "hinh = '" + hinhValue + "' " +
                          "where maloai = '" + maloaiValue + "'";
            DataTable dt = kn.docdulieu(connectionVsDB, sql1);
            DataList1.DataSource = dt;
            DataList1.DataBind();

            Response.Redirect("ds_loaihang.aspx");
        }


    }
}