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

        public DataTable ExecuteQuery(string connectionString, string query)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                    connection.Close();
                }
            }
            return dataTable;
        }


        protected string connectDB(string connectString, string query)
        {
            
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                cmd.CommandText = query;
                SqlDataReader r1 = cmd.ExecuteReader();
                string res = "";
                int index = 0;

                while (r1.Read())
                {
                    string ten = r1["tenhang"].ToString();

                    foreach (var item in ten)
                    {
                        res += item;
                    }
                    res += "<br>";
                    string anh = r1["hinh"].ToString();
                    string img = "<img class='image-mathang' src='./image/" + anh + "'>";
                    switch (index)
                    {
                        case 0:
                            Label1.Text = img;
                            break;
                        case 1:
                            Label2.Text = img;
                            break;
                        case 2:
                            Label3.Text = img;
                            break;
                        case 3:

                            break;
                        case 4:

                            break;
                    }

                    
                    index++;
                }
                r1.Close();
                connection.Close();

                return res;
            }           
        }

        protected int countModel(string connectString,string query)
        {
            SqlConnection connection = new SqlConnection(connectString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            int data = (int)cmd.ExecuteScalar();
            connection.Close();
     
            return data;
        }
        protected string getModel(string connectString, string query)
        {
            SqlConnection connection = new SqlConnection(connectString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            string data = (string)cmd.ExecuteScalar();
            connection.Close();

            return data;
        }

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
               
                        connectDB(connectionVsDB, query);
                        mathang.Text = connectDB(connectionVsDB, query);
                        lbl_hienthi.Text = "Có " + countModel(connectionVsDB, query2) + " mặt hàng " + getModel(connectionVsDB, query6);
                        DataTable table = ExecuteQuery(connectionVsDB, query);
                        GridView1.DataSource = table;
                        GridView1.DataBind();

                        // lbl_hienthi.Text =  getModel(connectionSQLServer, query3);
                    }
                }
                else
                {
                    Response.Redirect("loaihang.aspx");
                }
            }
          

         
        }


    }
}