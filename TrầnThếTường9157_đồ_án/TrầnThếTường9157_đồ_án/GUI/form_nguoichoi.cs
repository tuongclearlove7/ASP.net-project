using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrầnThếTường9157_đồ_án
{
    public partial class form_nguoichoi : Form
    {
        ketnoi_database ketnoi = new ketnoi_database();
        BLL.BLL_nguoichoi BLL_NC;
        string tendangnhap = BLL.BLL_dangnhap.SESSION.tendangnhap;
        bool c = false; 


        public form_nguoichoi()
        {
            InitializeComponent();

            BLL_NC = new BLL.BLL_nguoichoi(this);

            chon_nhanvat.DataSource = BLL_NC.BLL_loadData($@"SELECT * FROM NHANVAT");
            chon_nhanvat.DisplayMember = "tennhanvat";
            chon_nhanvat.ValueMember = "manhanvat";

            DataTable dt_nc = BLL_NC.BLL_loadData($@"SELECT * FROM NGUOICHOI WHERE tendangnhap = '{tendangnhap}'");
            lb_nc.Text = BLL.BLL_dangnhap.SESSION.tendangnhap;
            lb_ten_nc.Text = $@"Họ tên : {dt_nc.Rows[0]["hoten"].ToString()}";
            lb_sdt.Text = $@"Số điện thoại : {dt_nc.Rows[0]["sodienthoai"].ToString()}";
            lb_ngdk.Text = $@"Ngày đăng ký : {dt_nc.Rows[0]["ngaydangky"].ToString()}";

            string anhdaidien = dt_nc.Rows[0]["hinhanh"].ToString();
            img_nc.ImageLocation = Application.StartupPath + $@"\\Resources\\{anhdaidien}";

            int manhanvat = (int)dt_nc.Rows[0]["manhanvat"];
            DataTable dt_nv = BLL_NC.BLL_loadData($@"SELECT * FROM NHANVAT WHERE manhanvat = {manhanvat}");
            string anhnhanvat = dt_nv.Rows[0]["hinhanh"].ToString();
            img_nv.ImageLocation = Application.StartupPath + $@"\\Resources\\{anhnhanvat}";



        }

        private void chon_nhanvat_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (c)
            {
                case false:
                    int manv = (int)((DataRowView)chon_nhanvat.SelectedItem)["manhanvat"];
                    DataTable dt = BLL_NC.BLL_loadData($@"SELECT * FROM NHANVAT WHERE manhanvat = {manv}");
                    string hinh_nv = dt.Rows[0]["hinhanh"].ToString();
                    img_nv.ImageLocation = Application.StartupPath + $@"\\Resources\\{hinh_nv}";

                break;
            }

           
        }

        private void btn_doi_Click(object sender, EventArgs e)
        {
            int manhanvat = (int)((DataRowView)chon_nhanvat.SelectedItem)["manhanvat"];
            string tendangnhap = BLL.BLL_dangnhap.SESSION.tendangnhap;
            BLL_NC.BLL_sua_nv_nc(manhanvat, tendangnhap);
           
            DataTable dt_nv = BLL_NC.BLL_loadData($@"SELECT * FROM NHANVAT WHERE manhanvat = {manhanvat}");
            string anhnhanvat = dt_nv.Rows[0]["hinhanh"].ToString();
            img_nv.ImageLocation = Application.StartupPath + $@"\\Resources\\{anhnhanvat}";

        }

        private void form_nc_Closing(object sender, FormClosingEventArgs e)
        {

            if (sender is form_nguoichoi)
            {
                Application.Exit();
            }
        }

        private void btn_doianh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Hãy chọn ảnh";
            ofd.Filter = "Tất cả đuôi ảnh|*.*|JPG|*.jpg|PNG|*.png|JPEG|*.jpeg|GIF|*.gif";

            switch (ofd.ShowDialog())
            {
                case DialogResult.OK:
                    img_nc.Image = Image.FromFile(ofd.FileName);
                    string fileName = Path.GetFileName(ofd.FileName);
                    txt_filename.Text = fileName;
                    BLL_NC.BLL_sua_anhdaidien(fileName, tendangnhap);

                break;
            }

          
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            formLogin login = new formLogin();
            this.Hide();
            login.Show();
        }

        private void btn_playgame_Click(object sender, EventArgs e)
        {
            formGame game = new formGame();
            this.Hide();
            game.Show();
        }
    }
}
