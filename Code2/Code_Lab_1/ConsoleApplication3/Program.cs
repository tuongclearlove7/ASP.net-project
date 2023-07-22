using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; //hiển thị Tiếng Việt
            //Console.OutputEncoding = Encoding.Unicode;
            //Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Nhập họ tên");
            string hoTen = Console.ReadLine();
            DateTime ngaySinh;
            Console.WriteLine("Nhập ngày sinh");
            do
            {
                try
                {
                    ngaySinh = DateTime.Parse(Console.ReadLine()); break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Nhập sai định dạng, nhập lại");
                }
            }
            while (true);
            int tuoi = DateTime.Today.Year - ngaySinh.Year;
            Console.Write("Họ tên là: " + hoTen);
            if (ngaySinh.Day == DateTime.Today.Day && ngaySinh.Month == DateTime.Today.Month)  //Today hoac Now
                Console.WriteLine("\nChúc mừng sinh nhật lần thứ {0}", tuoi);
            Console.WriteLine("\nKết thúc chương trình");
            Console.ReadLine();
           
        }
    }
}
