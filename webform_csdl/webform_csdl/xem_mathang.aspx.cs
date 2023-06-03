using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webform_csdl
{
    public partial class xem_mathang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionVsDB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Server.MapPath("/App_Data/ql_banhang.mdf") + ";Integrated Security=True";
            string connectionSQLServer = "server=DESKTOP-9ER0ESK\\SQLEXPRESS;database=ban_hang;User ID=sa;Password=tuongyeuthao1";

            if (!IsPostBack)
            {
                if (Request.QueryString["MatHang"] != null)
                {
                    string mahang = Request.QueryString["MatHang"];
                    string query = "SELECT * FROM mathang, loaihang " +
                                 "WHERE mathang.maloai = loaihang.maloai " +
                                 "AND mathang.mahang = '" + mahang + "'";

                    if (mahang == Request.QueryString["MatHang"])
                    {
                        lopketnoi ketnoi = new lopketnoi();
                        DataTable table = ketnoi.hienthi_bang(connectionVsDB, query);
                        GridView1.DataSource = table;
                        GridView1.DataBind();

                        // lbl_hienthi.Text =  getModel(connectionSQLServer, query3);
                    }
                }
                else
                {
                    Response.Redirect("danhsachsp.aspx");
                }
            }

        }
    }
}