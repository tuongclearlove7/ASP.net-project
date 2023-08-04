using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrầnThếTường9157_đồ_án.BLL
{
    class BLL_dangnhap
    {

        DAL.DAL_dangnhap DAL_DN;
        formLogin LOGIN;

        public BLL_dangnhap(formLogin login)
        {
            DAL_DN = new DAL.DAL_dangnhap();
            LOGIN = login;
        }


        public void blldangnhap()
        {

            if (LOGIN.txt_tendangnhap.Text == "admin" && LOGIN.txt_matkhau.Text == "123")
            {
                LOGIN.Hide();
                form_quanly ql = new form_quanly();
                ql.Show();
            }
            else
            {
                int res = DAL_DN.dal_Dangnhap(LOGIN.txt_tendangnhap.Text, LOGIN.txt_matkhau.Text);

                if (res >= 1)
                {
                    LOGIN.Hide();
                    formUser nguoichoi = new formUser();
                    nguoichoi.Show();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu " + res.ToString());
                }
            }


           
        }




    }
}
