using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace connectDB
{
    public partial class app_quanly_sinhvien : Form
    {

        int c = 0;

        connectDB ketnoi = new connectDB();

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
            dataGridView1.DataSource = ketnoi.loadData(sql);

            return 0;
        }

        public int loadDataKhoa(string sql)
        {
            combox_khoa.DataSource = ketnoi.loadData(sql);
            combox_khoa.DisplayMember = "tenkhoa";
            combox_khoa.ValueMember = "makhoa";

            return 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = $@"insert into SINHVIEN values ('{txt_masv.Text}', N'{txt_hoten.Text}', '{dateTimePicker1.Value}', '{((DataRowView)combox_khoa.SelectedItem)["makhoa"]}', '{txt_hinhanh.Text}')";
            image_sv.Image.Save(Application.StartupPath + $@"\\Resources\\{txt_hinhanh.Text}");
            ketnoi.changeDB(sql);
            loadData("SELECT * FROM SINHVIEN");

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            string sql = $@"DELETE FROM SINHVIEN WHERE masv = '{txt_masv.Text}'";
            File.Delete(Application.StartupPath + $@"\\Resources\\{txt_hinhanh.Text}");
            ketnoi.changeDB(sql);
            loadData("SELECT * FROM SINHVIEN");

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
       
            string sql = $@"UPDATE SINHVIEN SET hoten = N'{txt_hoten.Text}', ngaynhaphoc = '{dateTimePicker1.Value}', makhoa = '{((DataRowView)combox_khoa.SelectedItem)["makhoa"]}', hinhanh = '{txt_hinhanh.Text}' WHERE masv = '{txt_masv.Text}'";
            image_sv.Image.Save(Application.StartupPath + $@"\\Resources\\{txt_hinhanh.Text}");
            ketnoi.changeDB(sql);
            loadData("SELECT * FROM SINHVIEN");
        }
        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            combox_khoa.ValueMember = "makhoa";
            combox_khoa.DisplayMember = "tenkhoa";
            txt_masv.Text = dataGridView1.CurrentRow.Cells["masv"].Value.ToString();
            txt_hoten.Text = dataGridView1.CurrentRow.Cells["hoten"].Value.ToString();
            txt_search.Text = dataGridView1.CurrentRow.Cells["hoten"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["ngaynhaphoc"].Value.ToString();
            txt_hinhanh.Text = dataGridView1.CurrentRow.Cells["hinhanh"].Value.ToString();
            image_sv.ImageLocation = Application.StartupPath + $@"\\Resources\\{txt_hinhanh.Text}";
            c = 1;
            combox_khoa.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells["makhoa"].Value.ToString();
            c = 0;

        }



        private void btnCount_Click(object sender, EventArgs e)
        {
            //loadData("SELECT count(*) FROM SINHVIEN");
            int count = (int)ketnoi.countRecord("SELECT count(*) FROM SINHVIEN");
            lbCount.Text = "Số sinh viên : " + count.ToString();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (c == 0)
            {
                string sql = $@"SELECT * FROM SINHVIEN WHERE makhoa = '{((DataRowView)combox_khoa.SelectedItem)["makhoa"]}'";
                dataGridView1.DataSource = ketnoi.loadData(sql);
            }

            if (((DataRowView)combox_khoa.SelectedItem)["makhoa"].ToString() == "XTC")
            {
                loadData("SELECT * FROM SINHVIEN");
            }


        }

     
        private void button_load_Click(object sender, EventArgs e)
        {
            loadDataKhoa("SELECT * FROM KHOA");
            loadData("SELECT * FROM SINHVIEN");
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string sql = $@"SELECT * FROM SINHVIEN WHERE masv like '%{txt_search.Text}%' OR hoten like N'%{txt_search.Text}%' OR hinhanh like '%{txt_search.Text}%'";
            loadData(sql);
        }

        private void add_image(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Hãy chọn ảnh";
            ofd.Filter = "Tất cả đuôi ảnh|*.*|JPG|*.jpg|PNG|*.png|JEPG|*.jpeg|GIF|*.gif";
            if (ofd.ShowDialog() == DialogResult.OK) {
                image_sv.Image = Image.FromFile(ofd.FileName);
            }
        }



    }
}
