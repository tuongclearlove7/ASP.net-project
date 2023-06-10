using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TrầnThếTường_9157
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

        public DataTable docdulieu(string sql)
        {
            string connectionVsDB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + 
                   Server.MapPath("/App_Data/ten_database.mdf") + ";Integrated Security=True";

            DataTable dt = new DataTable();
            try
            {
                lay_ketnoi(connectionVsDB);
                SqlDataAdapter da = new SqlDataAdapter(sql, connection);
                da.Fill(dt);
            }
            catch
            {
                dt = null;

            }
            finally
            {
                dong_ketnoi();
            }
            return dt;
        }

        public void capnhat(string sql)
        {
            string connectionVsDB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + 
                   Server.MapPath("/App_Data/ten_database.mdf") + ";Integrated Security=True";
            try
            {
                lay_ketnoi(connectionVsDB);
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return;
            }
            finally
            {
                dong_ketnoi();
            }
        }

    }
}