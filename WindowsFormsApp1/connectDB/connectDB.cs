using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace connectDB
{
    class connectDB
    {

        static string dbName = "DBsinhvien.mdf";
        SqlConnection connection;
        string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\clearlove7\Documents\GitHub\ASP.net-project\WindowsFormsApp1\connectDB\{dbName};Integrated Security=True";
        public connectDB()
        {
            connection = new SqlConnection(connectionString);
        }

        public DataTable loadData(string sql)
        {

            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public void changeDB(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            try
            {
                int res = cmd.ExecuteNonQuery();
                if (res >= 1)
                    MessageBox.Show("successfully");
                else MessageBox.Show("Vui lòng nhập vào mã!");
            }
            catch (Exception error)
            {
                MessageBox.Show("Lỗi trùng mã!");
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
