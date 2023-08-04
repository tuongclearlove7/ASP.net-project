using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TrầnThếTường9157_đồ_án
{
    public partial class form_quanly : Form
    {

        BLL.BLL_nguoichoi BLL_NC;
        bool c = false;
        ketnoi_database ketnoi;
        public form_quanly()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimumSize = this.Size;
            this.Resize += Form1_Resize;



            ketnoi = new ketnoi_database();
            BLL_NC = new BLL.BLL_nguoichoi(this);

            BLL_NC.BLL_loadDataNhanvat($@"SELECT * FROM NHANVAT");
            dataGridView2.DataSource = BLL_NC.BLL_loadData($@"SELECT * FROM NHANVAT");
            dataGridView1.DataSource = BLL_NC.BLL_loadData($@"SELECT * FROM NGUOICHOI");
            dataGridView1.Columns["matkhau"].Visible = false;

            DataTable dt_nc = BLL_NC.BLL_loadData($@"SELECT * FROM NGUOICHOI");
            string userImage = dt_nc.Rows[0]["hinhanh"].ToString();
            string hotenNC = dt_nc.Rows[0]["hoten"].ToString();
            img_user.ImageLocation = Application.StartupPath + $@"\\Resources\\{userImage}";
            lb_player.Text = hotenNC;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }


        private void form_ql_Closing(object sender, FormClosingEventArgs e)
        {

            if (sender is form_quanly) Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        
            try { 

                c = true;

                int manc = (int)dataGridView1.Rows[e.RowIndex].Cells["manguoichoi"].Value;
                DataTable dt_nc = BLL_NC.BLL_loadData($@"SELECT * FROM NGUOICHOI WHERE manguoichoi = {manc} ");
                string userImage = dt_nc.Rows[0]["hinhanh"].ToString();
                string hotenNC = dt_nc.Rows[0]["hoten"].ToString();
                img_user.ImageLocation = Application.StartupPath + $@"\\Resources\\{userImage}";
                lb_player.Text = hotenNC;
                
                int manv = (int)dataGridView1.Rows[e.RowIndex].Cells["manhanvat"].Value;
                BLL_NC.DLL_filterRecord(manv);

                c = false;
            }
            catch
            {
                return;
            }
     
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
            try
            {
                c = true;
                int manv = (int)dataGridView2.Rows[e.RowIndex].Cells["manhanvat"].Value;
                BLL_NC.DLL_filterRecord(manv);
                c = false;
            }
            catch
            {
                return;
            }

        }

        private void cb_nhanvat_SelectedIndexChanged(object sender, EventArgs e)
        {

         
            if (c == false)
            {
                int manv = (int)((DataRowView)cb_nhanvat.SelectedItem)["manhanvat"];
                DataTable dt = ketnoi.loadData($@"SELECT * FROM NHANVAT WHERE manhanvat = {manv}");
                string hinh_nv = dt.Rows[0]["hinhanh"].ToString();
                img_player.ImageLocation = Application.StartupPath + $@"\\Resources\\{hinh_nv}";
                dt.Rows[0]["tennhanvat"].ToString();
                lb_nv.Text = txt_tennv.Text;
                txt_maunv.Text = dt.Rows[0]["mau"].ToString();
                txt_nlnv.Text = dt.Rows[0]["nangluong"].ToString();
                txt_hinhanhnv.Text = dt.Rows[0]["hinhanh"].ToString();
                dataGridView1.DataSource = BLL_NC.BLL_loadData($@"SELECT * FROM NGUOICHOI WHERE manhanvat = {manv}");
                dataGridView2.DataSource = BLL_NC.BLL_loadData($@"SELECT * FROM NHANVAT WHERE NHANVAT.manhanvat = {manv}"); 

            }

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            BLL_NC.BLL_loadDataNhanvat($@"SELECT * FROM NHANVAT");
            dataGridView2.DataSource = BLL_NC.BLL_loadData($@"SELECT * FROM NHANVAT");
            dataGridView1.DataSource = BLL_NC.BLL_loadData($@"SELECT * FROM NGUOICHOI");

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            img_player.Image.Save(Application.StartupPath + $@"\\Resources\\{txt_hinhanhnv.Text}");
            BLL_NC.BLL_them();
            BLL_NC.BLL_loadDataNhanvat($@"SELECT * FROM NHANVAT");
            dataGridView2.DataSource = BLL_NC.BLL_loadData($@"SELECT * FROM NHANVAT");
            dataGridView1.DataSource = BLL_NC.BLL_loadData($@"SELECT * FROM NGUOICHOI");
        }

        private void btn_sua_nhanvat_Click(object sender, EventArgs e)
        {
            img_player.Image.Save(Application.StartupPath + $@"\\Resources\\{txt_hinhanhnv.Text}");
            BLL_NC.BLL_sua();
            dataGridView2.DataSource = BLL_NC.BLL_loadData($@"SELECT * FROM NHANVAT");
            
        }

        private void btn_xoa_nhanvat_Click(object sender, EventArgs e)
        {
            BLL_NC.BLL_xoa();
            dataGridView2.DataSource = BLL_NC.BLL_loadData($@"SELECT * FROM NHANVAT");
            dataGridView1.DataSource = BLL_NC.BLL_loadData($@"SELECT * FROM NGUOICHOI");
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string sql = $@"SELECT * FROM NGUOICHOI WHERE manguoichoi LIKE '%{txt_search.Text}%' OR hoten LIKE '%{txt_search.Text}%' OR tendangnhap LIKE '%{txt_search.Text}%' OR sodienthoai LIKE '%{txt_search.Text}%' ";
            dataGridView1.DataSource = BLL_NC.BLL_loadData(sql);
        }

        private void btn_sapxep_Click(object sender, EventArgs e)
        {
          
            dataGridView1.DataSource = BLL_NC.BLL_loadData($@"SELECT * FROM NGUOICHOI ORDER BY manguoichoi DESC");

        }

        private void btnDX_Click(object sender, EventArgs e)
        {
            formLogin login = new formLogin();
            this.Hide();
            login.Show();
        }

        private void img_player_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Hãy chọn ảnh";
            ofd.Filter = "Tất cả đuôi ảnh|*.*|JPG|*.jpg|PNG|*.png|JPEG|*.jpeg|GIF|*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                img_player.Image = Image.FromFile(ofd.FileName);
            }
        }

        
    }
}
