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

        connectDB ketnoi;
        BLL.BLL_sinhvien BLL_SV;

        public app_quanly_sinhvien()
        {
            InitializeComponent();
            ketnoi = new connectDB();
            BLL_SV = new BLL.BLL_sinhvien(this);
            BLL_SV.BLL_loadDataKhoa();
            BLL_SV.BLL_loadData();
        }


        private void frm_sinhvien_Load(object sender, EventArgs e)
        {
           
        }

    

        private void btnThem_Click(object sender, EventArgs e)
        {
            image_sv.Image.Save(Application.StartupPath + $@"\\Resources\\{txt_hinhanh.Text}");
            BLL_SV.BLL_them();
            BLL_SV.BLL_loadData();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            File.Delete(Application.StartupPath + $@"\\Resources\\{txt_hinhanh.Text}");
            BLL_SV.BLL_xoa();
            BLL_SV.BLL_loadData();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            image_sv.Image.Save(Application.StartupPath + $@"\\Resources\\{txt_hinhanh.Text}");
            BLL_SV.BLL_sua();
            BLL_SV.BLL_loadData();
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
                BLL_SV.BLL_loadData();
            }


        }

     
        private void button_load_Click(object sender, EventArgs e)
        {
            BLL_SV.BLL_loadDataKhoa();
            BLL_SV.BLL_loadData();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string sql = $@"SELECT * FROM SINHVIEN WHERE masv like '%{txt_search.Text}%' OR hoten like N'%{txt_search.Text}%' OR hinhanh like '%{txt_search.Text}%'";
            dataGridView1.DataSource = ketnoi.loadData(sql);
        }

        private void add_image(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Hãy chọn ảnh";
            ofd.Filter = "Tất cả đuôi ảnh|*.*|JPG|*.jpg|PNG|*.png|JPEG|*.jpeg|GIF|*.gif";
            if (ofd.ShowDialog() == DialogResult.OK) {
                image_sv.Image = Image.FromFile(ofd.FileName);
            }
        }



    }
}
