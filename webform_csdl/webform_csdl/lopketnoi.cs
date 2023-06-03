using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace webform_csdl
{

    public class lopketnoi : System.Web.UI.Page
    {
        SqlConnection connection;
        private void lay_ketnoi(string connectString)
        {
            connection = new SqlConnection(connectString);
            connection.Open();
        }
        private void dong_ketnoi()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public DataTable docdulieu(string connectString, string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                lay_ketnoi(connectString);
                SqlDataAdapter da = new SqlDataAdapter(sql, connection);
                da.Fill(dt);
            }
            catch
            {
                dt = null;
                //Response.SubStatusCode = 404;

            }
            finally
            {
                dong_ketnoi();
            }
            return dt;
        }

        public DataTable hienthi_bang(string connectionString, string query)
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


        public int countModel(string connectString, string query)
        {
            SqlConnection connection = new SqlConnection(connectString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            int data = (int)cmd.ExecuteScalar();
            connection.Close();

            return data;
        }

        public string getModel(string connectString, string query)
        {
            SqlConnection connection = new SqlConnection(connectString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            string data = (string)cmd.ExecuteScalar();
            connection.Close();

            return data;
        }



    }
}