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

        //BUSSINESS LAYER

        int manc=1;
        int mangc=1;
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
            DataTable dt_ad = DAL_NCDK.DAL_loadDataAdmin();
            int manv = (int)((DataRowView)APP.cb_nhanvat.SelectedItem)["manhanvat"];
           
            if (!string.IsNullOrEmpty(APP.txt_tendangnhap.Text) && !string.IsNullOrEmpty(APP.txt_matkhau.Text)
                   && !string.IsNullOrEmpty(APP.txt_hoten.Text) && !string.IsNullOrEmpty(APP.txt_sdt.Text))
            {
             
                int comfirmAD = DAL_NCDK.DAL_comfirm_admin(APP.txt_tendangnhap.Text);
                if (comfirmAD < 1)
                {
                    int comfirm = DAL_NCDK.DAL_comfirm_dk();
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            object mancValue = row["manguoichoi"];
                            if (comfirm <= (int)mancValue) manc = comfirm + 1;
                        }
                    }

                    DAL_NCDK.DAL_dangky(manc, APP.txt_tendangnhap.Text, APP.txt_matkhau.Text, APP.txt_hoten.Text, APP.txt_sdt.Text, current_date, "user1.png", manv);
                }
                else
                {
                    MessageBox.Show("Bạn đã nhập tên đăng nhập trùng với người chơi khác vui lòng nhập tên đăng nhập khác!"); 
                }

               
            }
            else
            {
                MessageBox.Show("Vui lòng nhập vào");
            }



        }
           


    }
}
