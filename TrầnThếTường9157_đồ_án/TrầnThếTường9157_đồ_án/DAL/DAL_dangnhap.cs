using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrầnThếTường9157_đồ_án.DAL
{
    class DAL_dangnhap
    {
        //DATA LAYER

        ketnoi_database ketnoi;

        public DAL_dangnhap()
        {
            ketnoi = new ketnoi_database();
        }

        public int dal_Dangnhap(string tendangnhap, string matkhau)
        {
            string sql = $@"SELECT COUNT(*) FROM NGUOICHOI WHERE tendangnhap = '{tendangnhap}' AND matkhau = '{matkhau}'";
            return (int) ketnoi.countRecord(sql);
        }

        public int dal_Dangnhap_Admin(string tendangnhap, string matkhau)
        {
            string sql = $@"SELECT COUNT(*) FROM ADMIN WHERE tendangnhap = '{tendangnhap}' AND matkhau = '{matkhau}'";
            return (int)ketnoi.countRecord(sql);
        }


    }
}
