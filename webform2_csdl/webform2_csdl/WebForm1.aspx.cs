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
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionVsDB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Server.MapPath("/App_Data/ban_hang.mdf") + ";Integrated Security=True";
            string connectionSQLServer = "server=DESKTOP-9ER0ESK\\SQLEXPRESS;database=baitap1;User ID=sa;Password=tuongyeuthao1";

            using (SqlConnection connection = new SqlConnection(connectionVsDB))
            {
                connection.Open();




                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                cmd.CommandText = "SELECT COUNT(*) FROM sanpham";
                int ketqua = (int)cmd.ExecuteScalar();
                so_sp.Text = "Số sản phẩm : " + ketqua;

                cmd.CommandText = "select * from sanpham";
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ddl_sanpham.Items.Add(reader["tensp"] + "");
                }
                reader.Close();

                //cmd.CommandText = "INSERT INTO sanpham(masp, tensp, dongia, soluong, mota, hinh_anh)" +
                //                        "VALUES (4,'giay',300000, 2,'mota','hinh4.png')";

                //int so = cmd.ExecuteNonQuery();
                //if (so > 0)
                //    Response.Write("thanh cong");
                //else
                //    Response.Write("khong thanh cong");

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
                            Image1.ImageUrl = imagePath;
                            break;
                        case 2:
                            Image2.ImageUrl = imagePath;
                            break;
                        case 3:
                            Image3.ImageUrl = imagePath;
                            break;
                        case 4:
                            Image4.ImageUrl = imagePath;
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