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

namespace connectDB
{
    public partial class app_quanly_sinhvien : Form
    {
        static string databaseFileName = "DBsinhvien.mdf";

        public string DatabaseFileName { get => databaseFileName; set => databaseFileName = value; }

        string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\clearlove7\Documents\GitHub\ASP.net-project\WindowsFormsApp1\connectDB\{databaseFileName};Integrated Security=True";


        public app_quanly_sinhvien()
        {
            InitializeComponent();
            loadDataKhoa("SELECT * FROM KHOA");
            loadData("SELECT * FROM SINHVIEN");

        }


        private void frm_sinhvien_Load(object sender, EventArgs e)
        {
           
        }


        public int loadData(string sql)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            return 0;
        }

        public int loadDataKhoa(string sql)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            combox_khoa.DataSource = dt;
            combox_khoa.DisplayMember = "tenkhoa";

            return 0;
        }

        public int changeDB(string sql)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            int res = cmd.ExecuteNonQuery();
            if (res >= 1)
                MessageBox.Show("successfully");
            else MessageBox.Show("failed");
            connection.Close();
            loadData("SELECT * FROM SINHVIEN");

            return 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = $@"insert into SINHVIEN values ('{txt_masv.Text}', N'{txt_hoten.Text}', '{dateTimePicker1.Value}', '{((DataRowView)combox_khoa.SelectedItem)["makhoa"]}')";
            changeDB(sql);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            string sql = $@"DELETE FROM SINHVIEN WHERE masv = '{txt_masv.Text}'";
            changeDB(sql);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            string sql = $@"UPDATE SINHVIEN SET hoten = N'{txt_hoten.Text}', ngaynhaphoc = '{dateTimePicker1.Value}', makhoa = '{((DataRowView)combox_khoa.SelectedItem)["makhoa"]}' WHERE masv = '{txt_masv.Text}'";
            changeDB(sql);
        }
        int c = 0;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            combox_khoa.ValueMember = "makhoa";
            combox_khoa.DisplayMember = "tenkhoa";

            txt_masv.Text = dataGridView1.CurrentRow.Cells["masv"].Value.ToString();
            txt_hoten.Text = dataGridView1.CurrentRow.Cells["hoten"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["ngaynhaphoc"].Value.ToString();
            c = 1;
            combox_khoa.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells["makhoa"].Value.ToString();
            c = 0;


        }



        private void btnCount_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT count(*) FROM SINHVIEN", connection);
            connection.Open();
            int count = (int)cmd.ExecuteScalar();
            connection.Close();
            lbCount.Text = "Số sinh viên : " + count.ToString();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (c == 0)
            {
                SqlConnection connection = new SqlConnection(connectionString);

                string sql = $@"SELECT * FROM SINHVIEN WHERE makhoa = '{((DataRowView)combox_khoa.SelectedItem)["makhoa"]}'";
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            if (((DataRowView)combox_khoa.SelectedItem)["makhoa"].ToString() == "XTC")
            {
                loadData("SELECT * FROM SINHVIEN");
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            loadDataKhoa("SELECT * FROM KHOA");
            loadData("SELECT * FROM SINHVIEN");
        }



    }
}
