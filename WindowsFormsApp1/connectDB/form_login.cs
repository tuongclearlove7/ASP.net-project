using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace connectDB
{
    public partial class form_login : Form
    {
        connectDB ketnoi = new connectDB();

        public form_login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string sql = $@"SELECT COUNT(*) FROM TAIKHOAN WHERE tendangnhap = N'{txt_tendangnhap.Text}' AND matkhau = N'{txt_matkhau.Text}'";


            int count = (int)ketnoi.countRecord(sql);

           

            if (count >= 1)
            {
                //app_quanly_sinhvien app = new app_quanly_sinhvien();

                res.Text = count.ToString();
                //app.Show();
            }
            else
            {
                res.Text = "Sai tên đăng nhập hoặc mật khẩu";
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
        }

       

     
    }
}
