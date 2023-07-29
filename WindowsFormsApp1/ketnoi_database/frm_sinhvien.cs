using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ketnoi_database
{
    public partial class frm_sinhvien : Form
    {

        static string databaseFileName = "DBsinhvien.mdf";

        public string DatabaseFileName { get => databaseFileName; set => databaseFileName = value; }

        string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\clearlove7\Documents\GitHub\ASP.net-project\WindowsFormsApp1\ketnoi_database\{databaseFileName};Integrated Security=True";


        public frm_sinhvien()
        {
            InitializeComponent();
            loadData();
        }


        public void loadData()
        {
            //string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\{databaseFileName};Integrated Security=True";
            //string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\{databaseFileName};Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);
            string sql = "SELECT * FROM SINHVIEN";
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
           // string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\{databaseFileName};Integrated Security=True";
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\clearlove7\Documents\GitHub\ASP.net-project\WindowsFormsApp1\ketnoi_database\DBsinhvien.mdf;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);
            string sql = $@"insert into SINHVIEN values ('{txt_masv.Text}',N'{txt_hoten.Text}')";
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            int res = cmd.ExecuteNonQuery();
            if (res >= 1)
                MessageBox.Show("successfully");
            else MessageBox.Show("failed");
            connection.Close();
            loadData();


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\clearlove7\Documents\GitHub\ASP.net-project\WindowsFormsApp1\ketnoi_database\DBsinhvien.mdf;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);
            string sql = $@"DELETE FROM SINHVIEN WHERE masv = '{txt_masv.Text}'";
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            int res = cmd.ExecuteNonQuery();
            if (res >= 1)
                MessageBox.Show("successfully");
            else MessageBox.Show("failed");
            connection.Close();
            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\clearlove7\Documents\GitHub\ASP.net-project\WindowsFormsApp1\ketnoi_database\DBsinhvien.mdf;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);
            string sql = $@"UPDATE SINHVIEN SET hoten = '{txt_hoten.Text}' WHERE masv = '{txt_masv.Text}'";
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            int res = cmd.ExecuteNonQuery();
            if (res >= 1)
                MessageBox.Show("successfully");
            else MessageBox.Show("failed");
            connection.Close();
            loadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_masv.Text = dataGridView1.CurrentRow.Cells["masv"].Value.ToString();
            txt_hoten.Text = dataGridView1.CurrentRow.Cells["hoten"].Value.ToString();

        }

        private void frm_sinhvien_Load(object sender, EventArgs e)
        {

        }

       

       
    }
}
