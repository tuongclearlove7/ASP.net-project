using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_dahinh
{
    class BENHNHAN_BHYT : BENHNHAN, Itienan
    {
        string maBhyt;
        int soNgayNamVien;
        string bhyt;

        public BENHNHAN_BHYT(string ten, string mabn, string maBhyt, int soNgayNamVien, string bhyt) : base(ten, mabn)
        {

            this.maBhyt = maBhyt;
            this.soNgayNamVien = soNgayNamVien;
            this.bhyt = bhyt;


        }

        public BENHNHAN_BHYT()
        {
           
        }

        public string Bhyt { get => bhyt; set => bhyt = value; }
        public int SoNgayNamVien { get => soNgayNamVien; set => soNgayNamVien = value; }
        public string MaBhyt { get => maBhyt; set => maBhyt = value; }

        public double tinhTienAn()
        {
            return 25000 * SoNgayNamVien;
        }

        public override double tinhvienphi()
        {
            return (SoNgayNamVien * 50000) + tinhTienAn();
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
            Console.Write("Nhap vao ma bhyt : ");
            MaBhyt = Console.ReadLine();
            Console.Write("Nhap vao bhyt : ");
            Bhyt = Console.ReadLine();
            Console.Write("Nhap vao so ngay nam vien : ");
            SoNgayNamVien = Convert.ToInt32(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("ma bhyt : " + MaBhyt);
            Console.WriteLine("BHYT : " + Bhyt);
            Console.WriteLine("So ngay nam vien : " + SoNgayNamVien);
        }
    }
}
