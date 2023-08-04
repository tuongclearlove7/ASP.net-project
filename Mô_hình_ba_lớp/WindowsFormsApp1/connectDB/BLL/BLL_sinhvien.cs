using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace connectDB.BLL
{
    class BLL_sinhvien
    {

        DAL.DAL_sinhvien DAL_SV;
        app_quanly_sinhvien APP;

        public BLL_sinhvien(app_quanly_sinhvien app_ql_sv)
        {
            DAL_SV = new DAL.DAL_sinhvien();
            APP = app_ql_sv;
        }

        public void BLL_loadData()
        {
            APP.dataGridView1.DataSource = DAL_SV.DAL_loadData();   
        }

        public void BLL_loadDataKhoa()
        {
            APP.combox_khoa.DataSource = DAL_SV.DAL_loadDatakhoa();
            APP.combox_khoa.DisplayMember = "tenkhoa";
            APP.combox_khoa.ValueMember = "makhoa";
        }

        public void BLL_them()
        {

            string makhoa = ((DataRowView)APP.combox_khoa.SelectedItem)["makhoa"].ToString();
            DAL_SV.DAL_them(APP.txt_masv.Text, APP.txt_hoten.Text, APP.dateTimePicker1.Value,makhoa, APP.txt_hinhanh.Text);

        }

        public void BLL_xoa()
        {
            DAL_SV.DAL_xoa(APP.txt_masv.Text);

        }

        public void BLL_sua()
        {
            string makhoa = ((DataRowView)APP.combox_khoa.SelectedItem)["makhoa"].ToString();
            DAL_SV.DAL_sua(APP.txt_masv.Text, APP.txt_hoten.Text, APP.dateTimePicker1.Value, makhoa, APP.txt_hinhanh.Text);

        }

       

    }
}
