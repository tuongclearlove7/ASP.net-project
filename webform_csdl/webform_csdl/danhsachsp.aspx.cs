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
                DataTable dt = kn.docdulieu(connectionVsDB,sql1);
                bang_mathang.DataSource = dt;
                bang_mathang.DataBind();
                data_list1.DataSource = dt;
                data_list1.DataBind();
            }


            //using (SqlConnection connection = new SqlConnection(connectionVsDB))
            //{
            //    connection.Open();
            //    string sql = "select * from mathang";
            //    SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            //    DataSet ds = new DataSet();
            //    da.Fill(ds);
            //    DataTable dt = ds.Tables[0];
            //    bang_mathang.DataSource = dt;
            //    bang_mathang.DataBind();
            //    data_list1.DataSource = dt;
            //    data_list1.DataBind();
            //    connection.Close();
            //}


        }
    }
}