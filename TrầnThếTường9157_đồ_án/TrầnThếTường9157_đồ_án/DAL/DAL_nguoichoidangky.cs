using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrầnThếTường9157_đồ_án.DAL
{
    class DAL_nguoichoidangky
    {

        ketnoi_database ketnoi;
        public DAL_nguoichoidangky()
        {

            ketnoi = new ketnoi_database();
        }

        public DataTable DAL_loadData()
        {

            string sql = $@"SELECT * FROM NGUOICHOI";

            return ketnoi.loadData(sql);
        }

        public DataTable DAL_loadDataNhanvat()
        {

            string sql = $@"SELECT * FROM NHANVAT";

            return ketnoi.loadData(sql);
        }


        public void DAL_dangky(int manguoichoi, string tendangnhap, string matkhau, string hoten, string sodienthoai, DateTime ngaydangky, string hinhanh, int manhanvat)
        {
            string sql = $@"insert into NGUOICHOI values ({manguoichoi}, '{tendangnhap}', '{matkhau}', N'{hoten}', '{sodienthoai}', '{ngaydangky}', '{hinhanh}', {manhanvat})";
            ketnoi.changeDB(sql);
        }





    }
}
