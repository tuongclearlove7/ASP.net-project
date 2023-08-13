using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrầnThếTường9157_đồ_án.Properties;


namespace TrầnThếTường9157_đồ_án.BLL
{
    class BLL_dangnhap
    {
        //BUSSINESS LAYER

        DAL.DAL_dangnhap DAL_DN;
        formLogin LOGIN;
        int close = 0;
        private static BLL_dangnhap session;
        public string tendangnhap { get; set; }

        private BLL_dangnhap() {

        }

        public static BLL_dangnhap SESSION
        {
            get
            {
                if (session == null)
                {
                    session = new BLL_dangnhap();
                }
                return session;
            }
        }

        public BLL_dangnhap(formLogin login)
        {
            DAL_DN = new DAL.DAL_dangnhap();
            LOGIN = login;
        }

   
        public void blldangnhap()
        {
            if (!string.IsNullOrEmpty(LOGIN.txt_tendangnhap.Text) && 
                  !string.IsNullOrEmpty(LOGIN.txt_matkhau.Text))
            {
                int res_admin = DAL_DN.dal_Dangnhap_Admin(LOGIN.txt_tendangnhap.Text, LOGIN.txt_matkhau.Text);
                if (res_admin >=1)
                {
                    close = 0;
                    LOGIN.Hide();
                    form_quanly ql = new form_quanly();
                    ql.Show();
                }
                else
                {
                    int res = DAL_DN.dal_Dangnhap(LOGIN.txt_tendangnhap.Text, LOGIN.txt_matkhau.Text);
                    if (res >= 1)
                    {
                        SESSION.tendangnhap = LOGIN.txt_tendangnhap.Text;
                        close = 0;
                        LOGIN.Hide();
                        form_nguoichoi nguoichoi = new form_nguoichoi();
                        nguoichoi.Show();
                    }
                    else
                    {
                        close++;
                        MessageBox.Show($@"Bạn đã nhập sai tên đăng nhập hoặc mật khẩu lần {close} !");
                    }
                }

                if (close > 3)
                {
                    MessageBox.Show($@"Bạn đã nhập sai quá {close-1} lần chương trình phải thoát");
                    Application.Exit();
                }

            }
            else
            {
                MessageBox.Show("Vui lòng nhập vào");
            }
          

        }




    }
}
