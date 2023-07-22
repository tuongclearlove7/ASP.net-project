using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_dahinh
{
    class NHANVIEN_HOPDONG : NHANVIEN, Iphucap
    {

        double mucluong;

        public NHANVIEN_HOPDONG()
        {
        }

        public NHANVIEN_HOPDONG(string ten, string namsinh, string gioitinh, string cmnd, string manv, double mucluong) : base(ten, namsinh, gioitinh, cmnd, manv)
        {


            this.mucluong = mucluong;
        }

        public double Mucluong { get => mucluong; set => mucluong = value; }


        public double phucap()
        {
            return Mucluong / 10;
        }

        public override double thuclinh()
        {
            return Mucluong + phucap();
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap muc luong : ");
            Mucluong = double.Parse(Console.ReadLine());
            
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("muc luong la : " + Mucluong);
           

        }
    }
}
