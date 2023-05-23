using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webform2_csdl
{
    public partial class loaihang_radiobuttonlist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionVsDB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Server.MapPath("/App_Data/ban_hang.mdf") + ";Integrated Security=True";
            string connectionSQLServer = "server=DESKTOP-9ER0ESK\\SQLEXPRESS;database=ban_hang;User ID=sa;Password=tuongyeuthao1";

            using (SqlConnection connection = new SqlConnection(connectionSQLServer))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                cmd.CommandText = "SELECT tenloai FROM loaihang WHERE maloai IN (1,2,3)";
                SqlDataReader r1 = cmd.ExecuteReader();
                int index = 0;

                while (r1.Read())
                {
                    string ten = r1["tenloai"].ToString();

                    switch (index)
                    {
                        case 0:
                            Label1.Text = ten;

                            break;
                        case 1:
                            Label2.Text = ten;
                            break;
                        case 2:
                            Label3.Text = ten;
                            break;
                        case 3:

                            break;
                        case 4:

                            break;
                    }

                    index++;
                }

                r1.Close();

                cmd.CommandText = "select * from loaihang";
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    RadioButtonList_loaihang.Items.Add(reader["tenloai"] + "");
                }
                reader.Close();

                connection.Close();
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

        protected void direct(object sender, EventArgs e)
        {

            string mat_hang = RadioButtonList_loaihang.Text;
            Response.Redirect("mathang.aspx?MatHang=" + mat_hang);
            //Response.Redirect("mathang.aspx");
            Session.Clear();



        }


        protected void xoa(object sender, EventArgs e)
        {



        }



    }
}