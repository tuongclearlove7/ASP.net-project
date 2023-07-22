using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class Program
    {
        static void Main(string[] args)
        {
            QLSinhVien DanhSach = new QLSinhVien();
            DanhSach.Nhap();
            DanhSach.Xuat();
            Console.ReadLine();
        }
    }
}
