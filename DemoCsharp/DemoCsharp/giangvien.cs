using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCsharp
{
    class giangvien : nguoi
    {

        private int maGiangVien;

        public giangvien(string hoten, DateTime ngaysinh, int gioitinh, string dienthoai, int maGiangVien) : base(hoten, ngaysinh, gioitinh, dienthoai)
        {

            this.maGiangVien = maGiangVien;

        }



        public giangvien() : base()
        {

        }


        ~giangvien()
        {

        }

        public override void nhap()
        {
            base.nhap();
            Console.Write("Nhap ma giang vien: ");
            maGiangVien = int.Parse(Console.ReadLine());
        }

        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Ma giang vien: " + maGiangVien);
        }
    }
}
