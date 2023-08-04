using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrầnThếTường9157_đồ_án.BLL
{
    class BLL_nguoichoi
    {

        DAL.DAL_nguoichoi DAL_NC;
        form_quanly APP;
        int manv;

        public BLL_nguoichoi(form_quanly app)
        {
            DAL_NC = new DAL.DAL_nguoichoi();
            APP = app;
        }

        public void BLL_loadDataNhanvat(string sql)
        {
            
            APP.cb_nhanvat.DataSource = DAL_NC.DAL_loadDataNhanvat(sql);
            APP.cb_nhanvat.DisplayMember = "tennhanvat";
            APP.cb_nhanvat.ValueMember = "manhanvat";

        }

        public DataTable BLL_loadData(string sql)
        {
           // APP.dataGridView1.DataSource = DAL_NC.DAL_loadData(sql);
            DataTable dt = DAL_NC.DAL_loadData(sql);

            return dt;
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
            int manhanvat = (int)((DataRowView)APP.cb_nhanvat.SelectedItem)["manhanvat"];
            DAL_NC.DAL_xoa(manhanvat);
        }

        public void BLL_sua()
        {           
            int manhanvat = (int)((DataRowView)APP.cb_nhanvat.SelectedItem)["manhanvat"];
            DAL_NC.DAL_sua(manhanvat, APP.txt_tennv.Text, APP.txt_maunv.Text, APP.txt_nlnv.Text, APP.txt_hinhanhnv.Text);

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
                APP.cb_nhanvat.SelectedValue = manv;
            }
            catch
            {
                return;
            }


        }





    }
}
