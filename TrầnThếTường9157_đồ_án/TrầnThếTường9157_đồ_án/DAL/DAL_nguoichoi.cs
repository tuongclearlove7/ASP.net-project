using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrầnThếTường9157_đồ_án.DAL
{
    class DAL_nguoichoi
    {
        //DATA LAYER

        ketnoi_database ketnoi;

        public DAL_nguoichoi()
        {
            ketnoi = new ketnoi_database();
        }

        public DataTable DAL_loadDataNhanvat(string sql)
        {
        
            return ketnoi.loadData(sql);
        }


        public DataTable DAL_loadData(string sql)
        {
            
            return ketnoi.loadData(sql);
        }


        public void DAL_them(int manhanvat, string tennhanvat, string mau, string nangluong, string hinhanh)
        {
            string sql = $@"insert into NHANVAT values ({manhanvat}, N'{tennhanvat}', {mau}, {nangluong}, '{hinhanh}')";
            ketnoi.changeDB(sql);
        }

        public DataTable DAL_FilterRecord(int manhanvat)
        {
            DataTable dt = ketnoi.loadData($@"SELECT * FROM NHANVAT WHERE NHANVAT.manhanvat = {manhanvat}");

            return dt;
        }

        public DataTable DAL_query(string sql)
        {

            return ketnoi.loadData(sql);
        }


        public void DAL_xoa(int manhanvat)
        {
            string sql = $@"DELETE FROM NHANVAT WHERE manhanvat = {manhanvat}";
            ketnoi.changeDB(sql);
        }

        public void DAL_xoa_nc(int manc)
        {
            string sql = $@"DELETE FROM NGUOICHOI WHERE manguoichoi = {manc}";
            ketnoi.changeDB(sql);
        }

        public void DAL_sua(int manhanvat, string tennhanvat, string mau, string nangluong, string hinhanh)
        {
            string sql = $@"UPDATE NHANVAT SET tennhanvat = N'{tennhanvat}', mau = {mau}, nangluong = {nangluong}, hinhanh = '{hinhanh}' WHERE manhanvat = {manhanvat}";
            ketnoi.changeDB(sql);
        }

        public void DAL_sua_nv(int manhanvat, string tendangnhap)
        {
            string sql = $@"UPDATE NGUOICHOI SET manhanvat = {manhanvat} WHERE tendangnhap = '{tendangnhap}'";
            ketnoi.changeDB(sql);
        }

        public void DAL_sua_anhdaidien(string anhdaidien, string tendangnhap)
        {
            string sql = $@"UPDATE NGUOICHOI SET hinhanh = '{anhdaidien}' WHERE tendangnhap = '{tendangnhap}'";
            ketnoi.changeDB(sql);
        }

        

    }
}
