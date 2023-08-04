using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace connectDB.DAL
{
    class DAL_dangnhap
    {

        connectDB ketnoi;


        public DAL_dangnhap()
        {
            ketnoi = new connectDB();
        }

        public int dal_Dangnhap(string tendangnhap, string matkhau)
        {
            string sql = $@"SELECT COUNT(*) FROM TAIKHOAN WHERE tendangnhap = '{tendangnhap}' AND matkhau = '{matkhau}'";
            return (int) ketnoi.countRecord(sql);
        }


    }
}
