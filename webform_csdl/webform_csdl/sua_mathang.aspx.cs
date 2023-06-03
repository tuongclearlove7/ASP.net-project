using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webform_csdl
{
    public partial class sua_mathang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionVsDB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Server.MapPath("/App_Data/ql_banhang.mdf") + ";Integrated Security=True";
            string connectionSQLServer = "server=DESKTOP-9ER0ESK\\SQLEXPRESS;database=ban_hang;User ID=sa;Password=tuongyeuthao1";
            if (!IsPostBack)
            {
                if (Request.QueryString["mat_hang"] != null)
                {
                    string mahang = Request.QueryString["mat_hang"];

                    lopketnoi kn = new lopketnoi();
                    string sql1 = "select * from mathang where mahang = '" + mahang + "'";
                    DataTable dt = kn.docdulieu(connectionVsDB, sql1);
                    DataList1.DataSource = dt;
                    DataList1.DataBind();
                }
                else
                {
                    Response.Redirect("danhsachsp.aspx");
                }
            }

        }
        protected void sua(object sender, EventArgs e)
        {
            string connectionVsDB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Server.MapPath("/App_Data/ql_banhang.mdf") + ";Integrated Security=True";
            string connectionSQLServer = "server=DESKTOP-9ER0ESK\\SQLEXPRESS;database=ban_hang;User ID=sa;Password=tuongyeuthao1";
            Button button = (Button)sender;
            DataListItem item = (DataListItem)button.NamingContainer;
            TextBox mahang = (TextBox)item.FindControl("mahang");
            TextBox tenhang = (TextBox)item.FindControl("tenhang");
            TextBox mota = (TextBox)item.FindControl("mota");
            TextBox dongia = (TextBox)item.FindControl("dongia");
            TextBox maloai = (TextBox)item.FindControl("maloai");
            TextBox hinh = (TextBox)item.FindControl("hinh");

            string mahangValue = mahang.Text;
            string tenhangValue = tenhang.Text;
            string motaValue = mota.Text;
            string dongiaValue = dongia.Text;
            string maloaiValue = maloai.Text;
            string hinhValue = hinh.Text;

            lopketnoi kn = new lopketnoi();
            string sql1 = "UPDATE mathang SET tenhang = '" + tenhangValue + "', mota = '" + motaValue + "', dongia = " + dongiaValue + ", maloai = " + maloaiValue + ", hinh = '" + hinhValue + "' WHERE mahang = '" + mahangValue + "'";
            DataTable dt = kn.docdulieu(connectionVsDB, sql1);
            DataList1.DataSource = dt;
            DataList1.DataBind();

            Response.Redirect("danhsachsp.aspx");
        }

    }
}