using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webform_csdl
{
    public partial class Site : System.Web.UI.MasterPage
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

                    }

                    index++;
                }

                r1.Close();

                connection.Close();
            }

        }


    }
}