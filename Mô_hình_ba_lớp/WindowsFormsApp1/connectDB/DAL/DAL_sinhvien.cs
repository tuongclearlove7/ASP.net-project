using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace connectDB.DAL
{
    class DAL_sinhvien
    {


        connectDB ketnoi;
        public DAL_sinhvien()
        {

            ketnoi = new connectDB();
        }


        public DataTable DAL_loadData()
        {

            string sql = $@"SELECT * FROM SINHVIEN";

            return ketnoi.loadData(sql);
        }

        public DataTable DAL_loadDatakhoa()
        {

            string sql = $@"SELECT * FROM KHOA";

            return ketnoi.loadData(sql);
        }


        public void DAL_them(string masv, string hoten, DateTime ngaynhaphoc, string makhoa, string hinhanh)
        {
            string sql = $@"insert into SINHVIEN values ('{masv}', N'{hoten}', '{ngaynhaphoc}', '{makhoa}', '{hinhanh}')";
            ketnoi.changeDB(sql);
        }
        

        public void DAL_xoa(string masv)
        {
            string sql = $@"DELETE FROM SINHVIEN WHERE masv = '{masv}'";
            ketnoi.changeDB(sql);
        }

        public void DAL_sua(string masv, string hoten, DateTime ngaynhaphoc, string makhoa, string hinhanh)
        {
            string sql = $@"UPDATE SINHVIEN SET hoten = N'{hoten}', ngaynhaphoc = '{ngaynhaphoc}', makhoa = '{makhoa}', hinhanh = '{hinhanh}' WHERE masv = '{masv}'";
            ketnoi.changeDB(sql);
        }

    }
}
