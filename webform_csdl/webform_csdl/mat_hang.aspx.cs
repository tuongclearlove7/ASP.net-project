using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webform_csdl
{
    public partial class mat_hang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionVsDB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Server.MapPath("/App_Data/ql_banhang.mdf") + ";Integrated Security=True";
            string connectionSQLServer = "server=DESKTOP-9ER0ESK\\SQLEXPRESS;database=ban_hang;User ID=sa;Password=tuongyeuthao1";
           
            if (!IsPostBack)
            {
                if (Request.QueryString["MatHang"] != null)
                {
                    string maloai = Request.QueryString["MatHang"];
                    string query = "SELECT * FROM mathang, loaihang " +
                                 "WHERE mathang.maloai = loaihang.maloai " +
                                 "AND mathang.maloai = '" + maloai + "'";
                    string query2 = "SELECT count(*) FROM mathang, loaihang " +
                                "WHERE mathang.maloai = loaihang.maloai " +
                                "AND mathang.maloai = '" + maloai + "'";
                    string query3 = "SELECT mathang.tenhang FROM mathang, loaihang " +
                                "WHERE mathang.maloai = loaihang.maloai " +
                                "AND mathang.maloai = '" + maloai + "'";
                    string query4 = "select count(*) from loaihang";
                    string query5 = "select count(*) from mathang";
                    string query6 = "select tenloai from loaihang " +
                                     "where loaihang.maloai = '"+maloai+"'";

                    if (maloai == Request.QueryString["MatHang"])
                    {
                        lopketnoi kn = new lopketnoi();
                        DataTable dt = kn.docdulieu(connectionVsDB, query);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();

                    }
     
                }
                else
                {
                    Response.Redirect("ds_loaihang.aspx");
                }
            }
          
        }


    }
}