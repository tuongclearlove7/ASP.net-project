using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace webform_csdl
{
    public partial class loaihang : System.Web.UI.Page
    {

        protected int countModel(string connectString, string query)
        {
            SqlConnection connection = new SqlConnection(connectString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            int data = (int)cmd.ExecuteScalar();
            connection.Close();

            return data;
        }

        protected string modelLink(string maloai, string tenloai)
        {
            string res = "<a style='text-decoration:none;color:white;' " + " href='" + "mat_hang.aspx?MatHang=" + maloai + "'>Loại hàng " + tenloai + "</a>";
            return res;
        }


        protected void Page_Load(object sender, EventArgs e)
        {

    
            if (!IsPostBack)
            {

                string connectionVsDB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Server.MapPath("/App_Data/ql_banhang.mdf") + ";Integrated Security=True";
                string connectionSQLServer = "server=DESKTOP-9ER0ESK\\SQLEXPRESS;database=baitap1;User ID=sa;Password=tuongyeuthao1";
                
                using (SqlConnection connection = new SqlConnection(connectionVsDB))
                {
                    connection.Open();

                    string query1 = "select count(*) from loaihang;";

                    so_loaihang.Text = "Có "+countModel(connectionVsDB, query1) + " loại hàng";

                    string sql = "SELECT * FROM loaihang";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    int index = 0;
                    //foreach (DataRow dr in dt.Rows)
                    //{
                    //    //RadioButtonList_loaihang.Items.Add(dr["tenloai"] + "");
                    //    //dropDownList_loaihang.Items.Add(dr["tenloai"] + "");
                    //    dropDownList_loaihang.Items.Add(new ListItem(dr["tenloai"]+"", dr["maloai"]+""));
                    //}

                    dropDownList_loaihang.DataSource = dt;
                    dropDownList_loaihang.DataTextField = "tenloai";
                    dropDownList_loaihang.DataValueField = "maloai";

                    

                    dropDownList_loaihang.DataBind();
                  
                    string str = dt.Rows[1][2].ToString();
                  
                    //RadioButtonList_loaihang.DataSource = dt;
                    //RadioButtonList_loaihang.DataTextField = "tenloai";
                    //RadioButtonList_loaihang.DataValueField = "maloai";
                    //RadioButtonList_loaihang.DataBind();
                    foreach (DataRow row in dt.Rows)
                    {
                        string anh = row["hinh"].ToString();
                        string maloai = row["maloai"].ToString();
                        string tenloai = row["tenloai"].ToString();
                        string img = "<img class='image-loaihang' src='./image/" + anh + "'>";
                       
                        switch (index)
                        {
                            case 0:
                                ao.Text = modelLink(maloai, tenloai);
                                Label1.Text = img;
                                break;
                            case 1:
                                quan.Text = modelLink(maloai, tenloai);
                                Label2.Text = img;
                                break;
                            case 2:
                                maytinh.Text = modelLink(maloai, tenloai);
                                Label3.Text = img;
                                break;
                            case 3:
                                tuixach.Text = modelLink(maloai, tenloai);
                                Label4.Text = img;
                                break;
                            case 4:
                                tivi.Text = modelLink(maloai, tenloai);
                                Label5.Text = img;
                                break;
                            case 5:
                                giay.Text = modelLink(maloai, tenloai);
                                Label6.Text = img;
                                break;
                            case 6:
                                dep.Text = modelLink(maloai, tenloai);
                                Label7.Text = img;
                                break;
                            case 7:
                                mu.Text = modelLink(maloai, tenloai);
                                Label8.Text = img;
                                break;
                        }
                        index++;
                    }

                    connection.Close();

                }
            }
        }

        protected void direct(object sender, EventArgs e)
        {
            string maloai = dropDownList_loaihang.SelectedValue;
            Response.Redirect("mat_hang.aspx?MatHang=" + maloai);
        }

        protected void direct_link(object sender, EventArgs e)
        {

            Response.Redirect("mat_hang.aspx?MatHang=");
        }


    }
}