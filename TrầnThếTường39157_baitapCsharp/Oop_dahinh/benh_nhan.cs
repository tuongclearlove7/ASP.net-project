using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_dahinh
{


    interface Ivienphi
    {

        double tinhHoaDonVienPhi();
        double dongiaPhong { get; set; }
     
    }


    abstract class benh_nhan
    {
        string ten;
        string mabn;
        DateTime ngaynamvien;
        bool phongtheoyeucau;


        protected benh_nhan()
        {
        }

        protected benh_nhan(string ten, string mabn, DateTime ngaynamvien, bool phongtheoyeucau)
        {
            this.ten = ten;
            this.mabn = mabn;
            this.ngaynamvien = ngaynamvien;
            this.phongtheoyeucau = phongtheoyeucau;

        }

        public string Mabn { get => mabn; set => mabn = value; }
        public string Ten { get => ten; set => ten = value; }
        public DateTime Ngaynamvien { get => ngaynamvien; set => ngaynamvien = value; }
        public bool Phongtheoyeucau { get => phongtheoyeucau; set => phongtheoyeucau = value; }

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

        string yeucau;
        public virtual void Nhap()
        {
            Console.Write("Nhap vao ma benh nhan : ");
            Mabn = Console.ReadLine();
            Console.Write("Nhap vao Ten : ");
            Ten = Console.ReadLine();
            Console.Write("Nhap vao ngay nam vien : ");
            Ngaynamvien = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Nhap vao phong theo yeu cau : ");
            Phongtheoyeucau = Convert.ToBoolean(Console.ReadLine());


            Console.Write("Nhap vao Y la co yeu cau ve phong, N la k co yeu cau ve phong : ");
            yeucau = Console.ReadLine().ToUpper();

            if(yeucau == "Y")
            {
                phongtheoyeucau = true;
                Console.WriteLine("co yeu cau ve phong");
            }else if (yeucau == "N")
            {
                phongtheoyeucau = false;
                Console.WriteLine("k co yeu cau ve phong");
            }

        }
        public virtual void Xuat()
        {
            Console.WriteLine("_____________________________ Thông tin Benh nhan {0}________________________", Ten);
            Console.WriteLine("ma nhan vien la : " + Mabn);
            Console.WriteLine("Ten nhan vien la : " + Ten);
            Console.WriteLine("Ngay nam vien la : " + Ngaynamvien);
            Console.WriteLine("Phong theo yeu cau : " + Phongtheoyeucau);

            switch (Phongtheoyeucau)
            {
                case true: Console.WriteLine("co yeu cau ve phong"); break;
                case false: Console.WriteLine("k co yeu cau ve phong"); break;
                default:break;
            }

        }

        public int tinhSongayNhapVien() {


            return DateTime.Today.Day - Ngaynamvien.Day;
        
        }
        abstract public string toString();




    }
}
