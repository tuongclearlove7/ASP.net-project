using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrầnThếTường9157_đồ_án.BLL
{
    class BLL_nguoichoidangky
    {
        int manc;
        string tendn;
        DAL.DAL_nguoichoidangky DAL_NCDK;
        form_register APP;
        
        public BLL_nguoichoidangky(form_register app)
        {
            DAL_NCDK = new DAL.DAL_nguoichoidangky();
            APP = app;
        }

        public void BLL_loadDataNhanvat()
        {
            APP.cb_nhanvat.DataSource = DAL_NCDK.DAL_loadDataNhanvat();
            APP.cb_nhanvat.DisplayMember = "tennhanvat";
            APP.cb_nhanvat.ValueMember = "manhanvat";
            string hinh_nv = APP.cb_nhanvat.ValueMember = "hinhanh";
       
        }
        
        public void BLL_dangky()
        {
            DateTime current_date = DateTime.Now;
            DataTable dt = DAL_NCDK.DAL_loadData();
            manc++;

          // if (checkIsvalid(APP.txt_tendangnhap.Text, APP.txt_matkhau.Text, APP.txt_hoten.Text, APP.txt_sdt.Text))
            if (!string.IsNullOrEmpty(APP.txt_tendangnhap.Text) && !string.IsNullOrEmpty(APP.txt_matkhau.Text)
                   && !string.IsNullOrEmpty(APP.txt_hoten.Text) && !string.IsNullOrEmpty(APP.txt_sdt.Text)){

                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        object mancValue = row["manguoichoi"];

                        object tendangnhapValue = row["tendangnhap"];

                        if ((int)mancValue == manc) manc++;

                        if (APP.txt_tendangnhap.Text == tendangnhapValue.ToString())
                        {
                            int maxManc = 0;
                            foreach (DataRow id in dt.Rows)
                            {
                                if ((int)id["manguoichoi"] > maxManc) maxManc = (int)id["manguoichoi"];
                            }

                            tendn = APP.txt_tendangnhap.Text + (maxManc + 1).ToString();
                            MessageBox.Show($@"Bạn nhập tên đăng nhập trùng với người chơi khác nên chúng tôi thêm id sau tên đăng nhập của bạn {tendn}");

                        }
                    }
                }

                int manv = (int)((DataRowView)APP.cb_nhanvat.SelectedItem)["manhanvat"];

                if (tendn == null)
                {
                    tendn = APP.txt_tendangnhap.Text;
                }
             
                DAL_NCDK.DAL_dangky(manc, tendn, APP.txt_matkhau.Text, APP.txt_hoten.Text, APP.txt_sdt.Text, current_date, "user1.png", manv);


            }
            else
            {
                MessageBox.Show("Vui lòng nhập vào");



            }



        }


    }
}
