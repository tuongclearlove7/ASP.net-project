using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCsharp
{
    class sinhvien:nguoi
    {

       
        private int masv;
       
        private int Masv { get => masv; set => masv = value; }

        public sinhvien(string hoten, DateTime ngaysinh, int gioitinh, string dienthoai, int masv):base(hoten, ngaysinh, gioitinh, dienthoai)
        {
            
            this.Masv = masv;
            
        }



        public sinhvien() : base()
        {

        }


        ~sinhvien()
        {

        }

       

        public override void nhap()
        {
            base.nhap();
            Console.Write("Nhap ma sinh vien: ");
            Masv = int.Parse(Console.ReadLine());
        }

        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Ma sinh vien: " + Masv);
        }

    }
}
