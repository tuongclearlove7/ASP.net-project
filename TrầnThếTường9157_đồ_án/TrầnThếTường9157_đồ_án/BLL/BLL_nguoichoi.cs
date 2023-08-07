using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrầnThếTường9157_đồ_án.BLL
{
    class BLL_nguoichoi
    {
        //BUSSINESS LAYER

        DAL.DAL_nguoichoi DAL_NC;
        form_quanly APP;
        form_nguoichoi APP_NC;
        form_register APP_RG;
        formGame APP_GE;
        int manv;
        
        public BLL_nguoichoi(form_quanly app)
        {
            DAL_NC = new DAL.DAL_nguoichoi();
            APP = app;
        }

        public BLL_nguoichoi(form_nguoichoi app_nc)
        {
            DAL_NC = new DAL.DAL_nguoichoi();
            APP_NC = app_nc;
        }

        public BLL_nguoichoi(form_register app_rg)
        {
            DAL_NC = new DAL.DAL_nguoichoi();
            APP_RG = app_rg;
        }

        public BLL_nguoichoi(formGame app_ge)
        {
            DAL_NC = new DAL.DAL_nguoichoi();
            APP_GE = app_ge;
        }

        public DataTable BLL_loadData(string sql)
        {

            return DAL_NC.DAL_loadData(sql);
        }

        public DataTable BLL_loadDataQuery(string sql)
        {

            return DAL_NC.DAL_query(sql);
        }

        public void BLL_them() {

            string sql = $@"SELECT * FROM NHANVAT";
            DataTable dt = DAL_NC.DAL_loadData(sql);
            manv++; 

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    object manvValue = row["manhanvat"];

                    if ((int)manvValue == manv) manv++;
                }
            }

            DAL_NC.DAL_them(manv, APP.txt_tennv.Text, APP.txt_maunv.Text, APP.txt_nlnv.Text, APP.txt_hinhanhnv.Text);
        }

        public void BLL_xoa()
        {
            int manhanvat = (int)((DataRowView)APP.chon_nhanvat.SelectedItem)["manhanvat"];
            DAL_NC.DAL_xoa(manhanvat);
        }

        public void BLL_xoa_nc(int manc)
        { 
            DAL_NC.DAL_xoa_nc(manc);
        }

        public void BLL_sua(int manhanvat)
        {           
            
            DAL_NC.DAL_sua(manhanvat, APP.txt_tennv.Text, APP.txt_maunv.Text, APP.txt_nlnv.Text, APP.txt_hinhanhnv.Text);

        }

        public void BLL_sua_nv_nc(int manhanvat, string tendangnhap)
        {
            DialogResult res = MessageBox.Show("Bạn chắc chắn muốn đổi nhân vật chứ ?", "Xác nhận", MessageBoxButtons.OKCancel);
           
            if (res == DialogResult.OK)
            {
                DAL_NC.DAL_sua_nv(manhanvat, tendangnhap);
            }
            else if(res == DialogResult.Cancel)
            {
                return;
            }

        }


        private bool checkIsvalid(DataTable dt)
        {
            if (dt.Rows[0]["hinhanh"].ToString() != "user1.png")
            {
                return true;
            }
            return false;
        }

        public void BLL_sua_anhdaidien(string anhdaidien, string tendangnhap)
        {
            DialogResult res = MessageBox.Show("Bạn chắc chắn muốn đổi ảnh đại diện chứ ?", "Xác nhận", MessageBoxButtons.OKCancel);

            if (res == DialogResult.OK)
            {

                DAL_NC.DAL_loadData($@"SELECT * FROM NGUOICHOI WHERE tendangnhap = '{APP_NC.lb_nc.Text}'");
                DAL_NC.DAL_loadData($@"SELECT * FROM NGUOICHOI");
                try
                {
                    APP_NC.img_nc.Image.Save(Application.StartupPath + $@"\\Resources\\{APP_NC.txt_filename.Text}");
                    DAL_NC.DAL_sua_anhdaidien(anhdaidien, tendangnhap);
                }
                catch
                {
                    return;
                }
            }
            else if (res == DialogResult.Cancel)
            {
                return;
            }


        }


        public void DLL_filterRecord(int manv)
        {
            try
            {
                DAL_NC.DAL_FilterRecord(manv);
                DataTable dt = DAL_NC.DAL_FilterRecord(manv);
                string hinh_nv = dt.Rows[0]["hinhanh"].ToString();
                APP.img_player.ImageLocation = Application.StartupPath + $@"\\Resources\\{hinh_nv}";
                APP.txt_tennv.Text = dt.Rows[0]["tennhanvat"].ToString();
                APP.lb_nv.Text = APP.txt_tennv.Text;
                APP.txt_maunv.Text = dt.Rows[0]["mau"].ToString();
                APP.txt_nlnv.Text = dt.Rows[0]["nangluong"].ToString();
                APP.txt_hinhanhnv.Text = dt.Rows[0]["hinhanh"].ToString();
                APP.chon_nhanvat.SelectedValue = manv;
            }
            catch
            {
                return;
            }


        }





    }
}
