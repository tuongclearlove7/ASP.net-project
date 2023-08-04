using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace connectDB.BLL
{
    class BLL_dangnhap
    {

        DAL.DAL_dangnhap DAL_DN;
        form_login LOGIN;

        public BLL_dangnhap(form_login login)
        {
            DAL_DN = new DAL.DAL_dangnhap();
            LOGIN = login;
        }


        public void blldangnhap()
        {

            int res = DAL_DN.dal_Dangnhap(LOGIN.txt_tendangnhap.Text, LOGIN.txt_matkhau.Text);

            if (res >= 1)
            {
                app_quanly_sinhvien app_ql_sv = new app_quanly_sinhvien();
                app_ql_sv.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu " + res.ToString());
            }
        }

    }
}
