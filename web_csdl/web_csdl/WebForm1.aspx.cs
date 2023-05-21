using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace web_csdl
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //protected void Page_Load(object sender, EventArgs e)
        //{

        //    SqlConnection cn = new SqlConnection();
        //    //cn.ConnectionString = "server=DESKTOP-9ER0ESK\\SQLEXPRESS;database=baitap1;user_ID=DESKTOP-9ER0ESK\\clearlove7;password=";

        //    cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Server.MapPath("/App_Data/ban_hang.mdf") + ";Integrated Security=True";

        //    cn.Open();
        //    cn.Close();


        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = cn;
        //    cmd.CommandText = "select * count(*) from sanpham";
        //    int ketqua = (int)cmd.ExecuteScalar();
        //    Response.Write(ketqua);

        //    //cmd.CommandText = "insert into sanpham value(3,'giay dep',15000,4,'mota','hinh3.png')";
        //    //int so = cmd.ExecuteNonQuery();

        //    //if (so > 0) Response.Write("thanh cong");
        //    //else Response.Write("khong thanh cong");

        //    //cmd.CommandText = "select * from sanpham";
        //    //SqlDataReader reader = cmd.ExecuteReader();


        //    //while (reader.Read())
        //    //{
        //    //    ddl_sanpham.Items.Add(reader["tensp"] + "");
        //    //}

        //}

        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Server.MapPath("/App_Data/ban_hang.mdf") + ";Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                cmd.CommandText = "SELECT COUNT(*) FROM sanpham";
                int ketqua = (int)cmd.ExecuteScalar();
                so_sp.Text = "Số sản phẩm : "+ketqua;

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