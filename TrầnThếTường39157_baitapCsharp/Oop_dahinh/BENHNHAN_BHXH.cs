using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_dahinh
{
    class BENHNHAN_BHXH : BENHNHAN, Itienan
    {

        string maBhxh;
        int soNgayNamVien;
        string bhxh;


        public BENHNHAN_BHXH(string ten, string mabn, string maBhxh, int soNgayNamVien, string bhxh) : base(ten, mabn)
        {

            this.maBhxh = maBhxh;
            this.soNgayNamVien = soNgayNamVien;
            this.bhxh = bhxh;


        }

        public BENHNHAN_BHXH()
        {

        }

        public string Bhxh { get => bhxh; set => bhxh = value; }
        public int SoNgayNamVien { get => soNgayNamVien; set => soNgayNamVien = value; }
        public string MaBhxh { get => maBhxh; set => maBhxh = value; }

        public double tinhTienAn()
        {
            return 30000 * SoNgayNamVien;
        }

        public override double tinhvienphi()
        {
            return (SoNgayNamVien * 70000) + tinhTienAn();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap vao ma bhxh : ");
            MaBhxh = Console.ReadLine();
            Console.Write("Nhap vao bhxh : ");
            Bhxh = Console.ReadLine();
            Console.Write("Nhap vao so ngay nam vien : ");
            SoNgayNamVien = Convert.ToInt32(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("ma bhxh : " + MaBhxh);
            Console.WriteLine("BHXH : " + Bhxh);
            Console.WriteLine("So ngay nam vien : " + SoNgayNamVien);
        }


    }
}
