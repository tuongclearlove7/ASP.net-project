using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webform2_csdl
{
    public partial class mat_hang : System.Web.UI.Page
    {

        protected void connectDB(string connectionSQLServer, string dk)
        {

            using (SqlConnection connection = new SqlConnection(connectionSQLServer))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                cmd.CommandText = "SELECT * FROM mathang, loaihang " +
                                  "WHERE mathang.maloai = loaihang.maloai " +
                                  "AND loaihang.tenloai = '" + dk + "'";
                SqlDataReader r1 = cmd.ExecuteReader();
                int index = 0;
                string res = "";

                while (r1.Read())
                {
                    string ten = r1["tenhang"].ToString();

                    foreach (var item in ten)
                    {
                        res += item;
                    }

                    res += "<br>";

                    mathang.Text = res;

                    string anh = r1["hinh"].ToString();
                    string imagePath = "~/image/" + anh;

                    hinh_anh.ImageUrl = imagePath;
                }

                r1.Close();

                connection.Close();

            }

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionVsDB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Server.MapPath("/App_Data/ban_hang.mdf") + ";Integrated Security=True";
            string connectionSQLServer = "server=DESKTOP-9ER0ESK\\SQLEXPRESS;database=ban_hang;User ID=sa;Password=tuongyeuthao1";

            if (!IsPostBack)
            {
                if (Request.QueryString["MatHang"] != null)
                {
                    string matHang = Request.QueryString["MatHang"];

                    if (matHang == Request.QueryString["MatHang"])
                    {
                        connectDB(connectionSQLServer, matHang);
                    }
                   
                }
                else
                {
                    Response.Redirect("loaihang_radiobuttonlist.aspx");
                }
            }


            using (SqlConnection connection = new SqlConnection(connectionVsDB))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                cmd.CommandText = "SELECT hinh_anh FROM sanpham WHERE masp IN (1, 2, 3, 4, 5)";
                SqlDataReader r1 = cmd.ExecuteReader();
                int index = 0;

                while (r1.Read())
                {
                    string anh = r1["hinh_anh"].ToString();
                    string imagePath = "~/image/" + anh;

                    switch (index)
                    {
                        case 0:
                            Image0.ImageUrl = imagePath;
                            break;
                        case 1:

                            break;
                        case 2:

                            break;
                        case 3:

                            break;
                        case 4:

                            break;
                    }

                    index++;
                }

                r1.Close();

                string sql = "SELECT * FROM sanpham";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                adapter.Update(ds);

                connection.Close();
            }



        }
    }
}