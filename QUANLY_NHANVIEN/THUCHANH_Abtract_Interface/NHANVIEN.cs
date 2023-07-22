using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THUCHANH_Abtract_Interface
{
    abstract class NHANVIEN
    {
        string hoten;

        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
        DateTime namsinh;

        public DateTime Namsinh
        {
            get { return namsinh; }
            set { namsinh = value; }
        }
        string gioitinh;

        public string Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        string socm;

        public string Socm
        {
            get { return socm; }
            set { socm = value; }
        }
        string manhanvien;

        public string Manhanvien
        {
            get { return manhanvien; }
            set { manhanvien = value; }
        }

        public virtual void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;            
            Console.Write("Nhập mã nhân viên: "); Manhanvien = Console.ReadLine();
            Console.Write("Nhập họ tên: "); Hoten = Console.ReadLine();
            Console.Write("Nhập năm sinh: "); Namsinh = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhập giới tính: "); Gioitinh = Console.ReadLine();
            Console.Write("Nhập số CM: "); Socm = Console.ReadLine();
            
        }
        public virtual void Xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;           
            Console.WriteLine("Mã nhân viên là: {0}", Manhanvien);
            Console.WriteLine("Họ tên là: {0}",Hoten);
            Console.WriteLine("Năm sinh là: {0}", Namsinh);
            Console.WriteLine("Giới tính là: {0}", Gioitinh);
            Console.WriteLine("Số chứng minh là: {0}", Socm);           
        }
        public abstract double ThucLinh();
    }
}
