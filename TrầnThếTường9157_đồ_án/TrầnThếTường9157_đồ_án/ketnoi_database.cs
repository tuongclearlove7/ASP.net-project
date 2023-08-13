using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrầnThếTường9157_đồ_án
{
    class ketnoi_database
    {

        static string dbName = "db.mdf";
        SqlConnection connection;
        string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\clearlove7\Documents\GitHub\ASP.net-project\TrầnThếTường9157_đồ_án\TrầnThếTường9157_đồ_án\{dbName};Integrated Security=True";
        public ketnoi_database()
        {
            connection = new SqlConnection(connectionString);
        }

        public DataTable loadData(string sql)
        {
            DataTable dt = new DataTable();

            try
            {
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                
                da.Fill(dt);
                
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng cú pháp!");
            }
            return dt;
        }


        public void changeDB(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            try
            {
                int res = cmd.ExecuteNonQuery();
                if (res >= 1) MessageBox.Show("successfully");
                else MessageBox.Show("Vui lòng nhập vào mã!");
            }
            catch (Exception error)
            {
               MessageBox.Show("Bạn đã nhập tên đăng nhập trùng với người chơi khác vui lòng nhập tên đăng nhập khác!");
            }

            connection.Close();
        }

        public object countRecord(string sql)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            int count = (int)cmd.ExecuteScalar();
            connection.Close();

            return count;
        }


    }
}
