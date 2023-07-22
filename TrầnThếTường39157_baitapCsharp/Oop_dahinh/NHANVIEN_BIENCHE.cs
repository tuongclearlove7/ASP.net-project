using System;

namespace Oop_dahinh
{
    class NHANVIEN_BIENCHE : NHANVIEN, Iphucap
    {

        private double luongcoban;
        private double hesoluong;

        public NHANVIEN_BIENCHE()
        {
        }

        public NHANVIEN_BIENCHE(string ten, string namsinh, string gioitinh, string cmnd, string manv, double luongcoban, double hesoluong) : base(ten, namsinh, gioitinh, cmnd, manv)
        {

            this.luongcoban = luongcoban;
            this.hesoluong = hesoluong;

        }

        public double Luongcoban { get => luongcoban; set => luongcoban = value; }
        public double Hesoluong { get => hesoluong; set => hesoluong = value; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

       

        public double phucap()
        {
            return Luongcoban /10;
        }

        public override double thuclinh()
        {
            return Luongcoban * Hesoluong + phucap();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap vao he so luong : ");
            Hesoluong = double.Parse(Console.ReadLine());
            Console.Write("Nhap luong co ban : ");
            Luongcoban = double.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("he so luong la : " + Hesoluong);
            Console.WriteLine("luong co ban la : " + Luongcoban);

        }
    }
}
